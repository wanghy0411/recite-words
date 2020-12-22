using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.recite.list
{
    /// <summary>
    /// 个人指定时间后的背诵记录列表获取服务
    /// </summary>
    public class ReciteListRequest : NoodleRequest<List<Recite>>
    {
        /// <summary>
        /// 开始时间, 不输入缺省取30日内的记录
        /// </summary>
        public long StartTimestamp { get; set; }

        public override string ApiMethodName => "recite.list";

        public override void Validate() { }
    }
}
