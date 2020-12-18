using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.delete
{
    /// <summary>
    /// 字典删除服务
    /// </summary>
    public class DictionaryDeleteRequest : NoodleRequest<object>
    {
        /// <summary>
        /// 待删除的字典id
        /// </summary>
        public long DictionaryId { get; set; }

        public override string ApiMethodName => "dictionary.delete";

        public override void Validate() { }
    }
}
