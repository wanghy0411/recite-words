using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.list
{
    /// <summary>
    /// 字典列表服务
    /// </summary>
    public class DictionaryListRequest : NoodleRequest<List<Dictionary>>
    {

        public override string ApiMethodName => "dictionary.list";

        public override void Validate() { }
    }
}
