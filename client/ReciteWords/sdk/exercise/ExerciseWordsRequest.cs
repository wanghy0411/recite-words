using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.exercise
{
    /// <summary>
    /// 单词测验记录中的单词列表获取服务
    /// </summary>
    public class ExerciseWordsRequest : NoodleRequest<List<ExerciseWordsDto>>
    {
        /// <summary>
        /// 测验id
        /// </summary>
        public long ExerciseId { get; set; }

        public override string ApiMethodName => "exercise.words";

        public override void Validate() { }
    }
}
