using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.id
{
    public class NoodleIdGeneratorRequest : NoodleRequest<List<long>>
    {
        /// <summary>
        /// 需要生成的id个数, 不填值时为1个
        /// </summary>
        public int Number { get; set; }
        public override string ApiMethodName => "id.generate";

        public override void Validate() { }
    }
}
