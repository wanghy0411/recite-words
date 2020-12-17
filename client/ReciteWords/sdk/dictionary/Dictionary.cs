using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.list
{
    /// <summary>
    /// 字典类
    /// </summary>
    public class Dictionary
    {
        /// <summary>
        /// id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 字典名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// 有效标志
        /// </summary>
        public String ValidFlag { get; set; }

        /// <summary>
        /// 共有标志
        /// </summary>
        public string PublicFlag { get; set; }
    }
}
