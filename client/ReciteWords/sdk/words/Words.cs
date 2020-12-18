using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.words
{
    public class Words
    {
        /// <summary>
        /// 单词id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 所在字典的id
        /// </summary>
        public long DictionaryId { get; set; }

        /// <summary>
        /// 拼写
        /// </summary>
        public string Spelling { get; set; }

        /// <summary>
        /// 发音
        /// </summary>
        public string Pronunciation { get; set; }

        /// <summary>
        /// 释义
        /// </summary>
        public string Explanation { get; set; }
    }
}
