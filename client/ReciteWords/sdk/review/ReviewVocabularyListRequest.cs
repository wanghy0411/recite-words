using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.review
{
    /// <summary>
    /// 个人应复习词汇查询服务
    /// </summary>
    public class ReviewVocabularyListRequest : NoodlePagedRequest<List<ReviewVocabularyDto>>
    {
        public override string ApiMethodName => "review.vocabulary";

        public override void Validate() { }
    }
}
