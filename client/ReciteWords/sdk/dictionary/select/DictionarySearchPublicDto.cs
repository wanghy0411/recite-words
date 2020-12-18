using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.select
{
    /// <summary>
    /// 公用字典搜索服务返回信息
    /// </summary>
    public class DictionarySearchPublicDto
    {
        public long Id { get; set; }

        /// <summary>
        /// 字典名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// 已选定
        /// </summary>
        public bool Selected { get; set; }
    }
}
