using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.exercise
{
    /// <summary>
    /// 测验打分服务
    /// </summary>
    public class ExerciseScoreRequest : NoodleRequest<object>
    {
        /// <summary>
        /// 测验id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 测验单词打分记录, 只需要传入id和correct即可
        /// </summary>
        public List<ExerciseWords> ExerciseWords { get; set; }

        public override string ApiMethodName => "exercise.score";

        public override void Validate()
        {
            if (ExerciseWords==null || ExerciseWords.Count==0)
            {
                throw new ArgumentException("测验打分列表不能为空");
            }
        }
    }
}
