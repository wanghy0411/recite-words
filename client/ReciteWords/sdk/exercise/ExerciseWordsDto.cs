using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.exercise
{
    /// <summary>
    /// 测验记录中的单词
    /// </summary>
    public class ExerciseWordsDto
    {
        public long Id { get; set; }

        /**
         * 复习reviewId
         */
        public long ExerciseId { get; set; }

        /**
         * 行号
         */
        public int LineNumber { get; set; }

        /**
         * 单词wordId
         */
        public long WordsId { get; set; }

        /**
         * 拼写
         */
        public string Spelling { get; set; }

        /**
         * 发音
         */
        public string Pronunciation { get; set; }

        /**
         * 释义
         */
        public string Explanation { get; set; }

        /**
         * 练习对错(1正确0错误)
         */
        public int? Correct { get; set; }
    }
}
