using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.review
{
    /// <summary>
    /// 个人应复习词汇
    /// </summary>
    public class ReviewVocabularyDto
    {
        /// <summary>
        /// 词汇id
        /// </summary>
        public long VocabularyId { get; set; }
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
