using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.exercise
{
    /// <summary>
    /// 个人应测验词汇查询服务
    /// </summary>
    public class ExerciseVocabularyListRequest : NoodlePagedRequest<List<ExerciseVocabularyDto>>
    {
        public override string ApiMethodName => "exercise.vocabulary";

        public override void Validate() { }
    }
}
