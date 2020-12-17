using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.list
{
    public class DictionaryListRequest : NoodleRequest<List<Dictionary>>
    {

        public override string ApiMethodName => "dictionary.list";

        public override void Validate() { }
    }
}
