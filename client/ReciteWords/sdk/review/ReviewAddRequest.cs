using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.review
{
    /// <summary>
    /// 复习记录增加服务
    /// </summary>
    public class ReviewAddRequest : NoodleRequest<object>
    {
        /// <summary>
        /// 本次复习记录的id
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

        public override string ApiMethodName => "review.add";

        public override void Validate()
        {
            if (Id == 0)
            {
                throw new ArgumentException("复习id不能为空");
            }
            if (VocabularyIds.Count==0)
            {
                throw new ArgumentException("词汇id列表不能为空");
            }
        }
    }
}
