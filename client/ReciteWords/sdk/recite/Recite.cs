using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.recite
{
    /// <summary>
    /// 背诵记录
    /// </summary>
    public class Recite
    {
        public long Id { get; set; }

        /// <summary>
        /// 背诵时间戳(毫秒)
        /// </summary>
        public long ReciteTime { get; set; }

        /// <summary>
        /// 背诵时间, 客户端根据ReciteTime生成
        /// </summary>
        public DateTime ReciteDateTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comment { get; set; }
    }
}
