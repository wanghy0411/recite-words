using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.words.delete
{
    /// <summary>
    /// 单词删除服务
    /// </summary>
    public class WordsDeleteRequest : NoodleRequest<object>
    {
        /// <summary>
        /// 单词id
        /// </summary>
        public long WordsId { get; set; }
        public override string ApiMethodName => "words.delete";

        public override void Validate() { }
    }
}
