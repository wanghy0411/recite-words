using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.select
{
    /// <summary>
    /// 公用字典搜索服务
    /// </summary>
    public class DictionarySearchPublicRequest : NoodleRequest<List<DictionarySearchPublicDto>>
    {
        /// <summary>
        /// 待选定的字典id
        /// </summary>
        public string NameCondition { get; set; }

        public override string ApiMethodName => "dictionary.search";

        public override void Validate()
        {
            if (NameCondition == null || NameCondition.Length==0)
            {
                throw new ArgumentException("字典搜索条件不能为空");
            }
        }
    }
}
