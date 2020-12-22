using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.recite.words
{
    /// <summary>
    /// 单词背诵记录中的单词列表获取服务
    /// </summary>
    public class ReciteWordsRequest : NoodleRequest<List<ReciteWordsDto>>
    {
        public long ReciteId { get; set; }

        public override string ApiMethodName => "recite.words";

        public override void Validate() { }
    }
}
