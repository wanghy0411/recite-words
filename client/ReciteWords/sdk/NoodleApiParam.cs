using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk
{
    /// <summary>
    /// post调用
    /// </summary>
    class NoodleApiParam
    {
        /// <summary>
        /// 调用的api接口服务方法名
        /// </summary>
        public string ApiMethodName { get; set; }

        /// <summary>
        /// 接口调用用户id, 完善后应该是不用传
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 客户端时间戳
        /// </summary>
        public long Timestamp { get; set; }

        /// <summary>
        /// 传入的数据信息
        /// </summary>
        public object RequestData { get; set; }
    }
}
