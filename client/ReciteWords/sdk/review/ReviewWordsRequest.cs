using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.review.words
{
    /// <summary>
    /// 单词背诵记录中的单词列表获取服务
    /// </summary>
    public class ReviewWordsRequest : NoodleRequest<List<ReviewWordsDto>>
    {
        public long ReviewId { get; set; }

        public override string ApiMethodName => "review.words";

        public override void Validate() { }
    }
}
