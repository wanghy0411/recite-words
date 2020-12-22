using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.review
{
    /// <summary>
    /// 复习记录
    /// </summary>
    public class Review
    {
        public long Id { get; set; }

        /// <summary>
        /// 复习时间戳(毫秒)
        /// </summary>
        public long ReviewTime { get; set; }

        /// <summary>
        /// 复习时间, 客户端根据ReviewTime生成
        /// </summary>
        public DateTime ReviewDateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comment { get; set; }
    }
}
