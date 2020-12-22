using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.words.list
{
    /// <summary>
    /// 单词列表查询服务
    /// </summary>
    public class WordsListRequest : NoodlePagedRequest<List<Words>>
    {
        /// <summary>
        /// 字典id
        /// </summary>
        public long DictionaryId { get; set; }
        public override string ApiMethodName => "words.list";

        public override void Validate()
        {
            if (DictionaryId<=0)
            {
                throw new ArgumentException("无效的字典id");
            }
        }
    }
}
