using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace sdk
{
    public class NoodleTokenClient
    {
        private readonly String Url;
        private readonly String AccessToken;
        private readonly long UserId;
        private readonly int Timeout;
        private readonly int ReadWriteTimeout;

        /// <summary>
        /// token方式调用noodle框架服务
        /// </summary>
        /// <param name="Url">noodle框架服务地址</param>
        /// <param name="AccessToken">token</param>
        /// <param name="UserId">登录用户id, 完善后可不再需要</param>
        /// <param name="Timeout">等待响应的超时设置ms</param>
        /// <param name="ReadWriteTimeout">读写数据的超时设置</param>
        public NoodleTokenClient(String Url, String AccessToken, long UserId, int Timeout=3000, int ReadWriteTimeout=5000)
        {
            this.Url = Url;
            this.AccessToken = AccessToken;
            this.UserId = UserId;
            this.Timeout = Timeout;
            this.ReadWriteTimeout = ReadWriteTimeout;
        }

        public T DoPost<T>(NoodleRequest<T> request)
        {
            if (string.IsNullOrEmpty(request.ApiMethodName))
            {
                throw new ArgumentException("ApiMethodName不能为空");
            }

            //业务参数校验
            request.Validate();

            NoodleApiParam noodlePostParams = new NoodleApiParam();
            noodlePostParams.ApiMethodName = request.ApiMethodName;
            noodlePostParams.UserId = UserId;
            noodlePostParams.Timestamp = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds);
            noodlePostParams.RequestData = request;

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
            };
            string postJson = JsonConvert.SerializeObject(noodlePostParams, Formatting.Indented, settings);

            NoodleResponse<T> response;
            string responseString = DoPost(postJson);

            response = JsonConvert.DeserializeObject<NoodleResponse<T>>(responseString, settings);

            return response.Data;
        }

        private String DoPost(string postJson)
        {
            Stream requestStream = null;
            Stream responseStream = null;
            StreamReader reader = null;
            HttpWebResponse response = null;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            req.ServicePoint.Expect100Continue = false;
            req.Method = "POST";
            req.KeepAlive = true;
            req.Timeout = Timeout;
            req.ReadWriteTimeout = ReadWriteTimeout;
            req.ContentType = "application/json";

            try
            {
                byte[] postData = Encoding.UTF8.GetBytes(postJson);
                requestStream = req.GetRequestStream();
                requestStream.Write(postData, 0, postData.Length);
                requestStream.Close();

                response = (HttpWebResponse)req.GetResponse();
                Encoding encoding = Encoding.GetEncoding("utf-8");

                // 以字符流的方式读取HTTP响应
                responseStream = response.GetResponseStream();
                reader = new StreamReader(responseStream, encoding);
                return reader.ReadToEnd();
            }
            finally
            {
                // 释放资源
                if (requestStream != null) requestStream.Close();
                if (reader != null) reader.Close();
                if (responseStream != null) responseStream.Close();
                if (response != null) response.Close();
            }
        }
    }
}
