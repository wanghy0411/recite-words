using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.exercise
{
    /// <summary>
    /// 测验记录增加服务
    /// </summary>
    public class ExerciseAddRequest : NoodleRequest<object>
    {
        /// <summary>
        /// 本次测验记录的id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 本次复习的词汇id列表
        /// </summary>
        public List<long> VocabularyIds { get; set; }

        public override string ApiMethodName => "exercise.add";

        public override void Validate()
        {
            if (Id == 0)
            {
                throw new ArgumentException("测验id不能为空");
            }
            if (VocabularyIds.Count == 0)
            {
                throw new ArgumentException("词汇id列表不能为空");
            }
        }
    }
}
