using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.review.words
{
    /// <summary>
    /// 复习记录中的单词
    /// </summary>
    public class ReviewWordsDto
    {
        public long Id { get; set; }

        /// <summary>
        /// 复习reviewId
        /// </summary>
        public long ReviewId { get; set; }

        /// <summary>
        /// 单词wordId
        /// </summary>
        public long WordsId { get; set; }

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
