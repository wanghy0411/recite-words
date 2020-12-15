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
        private readonly int Timeout;
        private readonly int ReadWriteTimeout;

        /// <summary>
        /// token方式调用noodle框架服务
        /// </summary>
        /// <param name="Url">noodle框架服务地址</param>
        /// <param name="AccessToken">token</param>
        /// <param name="Timeout">等待响应的超时设置ms</param>
        /// <param name="ReadWriteTimeout">读写数据的超时设置</param>
        public NoodleTokenClient(String Url, String AccessToken, int Timeout=3000, int ReadWriteTimeout=5000)
        {
            this.Url = Url;
            this.AccessToken = AccessToken;
            this.Timeout = Timeout;
            this.ReadWriteTimeout = ReadWriteTimeout;
        }

        public NoodleResponse<T> DoPost<T>(NoodleRequest<T> request)
        {
            if (string.IsNullOrEmpty(request.ApiMethodName))
            {
                throw new ArgumentException("ApiMethodName不能为空");
            }

            //业务参数校验
            request.Validate();

            NoodleApiParam noodlePostParams = new NoodleApiParam();
            noodlePostParams.ApiMethodName = request.ApiMethodName;
            noodlePostParams.AccessToken = AccessToken;
            noodlePostParams.Timestamp = Convert.ToInt64((DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalMilliseconds);
            noodlePostParams.RequestData = request;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            req.ServicePoint.Expect100Continue = false;
            req.Method = "POST";
            req.KeepAlive = true;
            req.Timeout = Timeout;
            req.ReadWriteTimeout = ReadWriteTimeout;
            req.ContentType = "application/json";

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
            };
            string postJson = JsonConvert.SerializeObject(noodlePostParams, Formatting.Indented, settings);
            byte[] postData = Encoding.UTF8.GetBytes(postJson);
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            Encoding encoding = Encoding.GetEncoding("utf-8");
            string responseString = GetResponseAsString(rsp, encoding);

            return JsonConvert.DeserializeObject<NoodleResponse<T>>(responseString, settings);
        }

        private String GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            Stream stream = null;
            StreamReader reader = null;

            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }
    }
}
