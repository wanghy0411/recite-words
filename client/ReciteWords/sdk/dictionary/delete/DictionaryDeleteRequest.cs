using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.delete
{
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
