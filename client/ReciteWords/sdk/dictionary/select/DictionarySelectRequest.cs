using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.select
{
    /// <summary>
    /// 用户选定公共字典作为需背诵的字典
    /// </summary>
    public class DictionarySelectRequest : NoodleRequest<object>
    {
        /// <summary>
        /// 待选定的字典id
        /// </summary>
        public long DictionaryId { get; set; }

        public override string ApiMethodName => "dictionary.select";

        public override void Validate() { }
    }
}
