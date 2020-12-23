using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.exercise
{
    /// <summary>
    /// 测验中的词汇记录
    /// </summary>
    public class ExerciseWords
    {
        /// <summary>
        /// 测验中行记录id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 测验id
        /// </summary>
        public long ExerciseId { get; set; }

        /// <summary>
        /// 词汇id
        /// </summary>
        public long VocabularyId { get; set; }

        /// <summary>
        /// 行号
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// 是否正确 1正确/0错误
        /// </summary>
        public int? Correct { get; set; }
    }
}
