using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.review.list
{
    /// <summary>
    /// 个人指定时间后的背诵记录列表获取服务
    /// </summary>
    public class ReviewListRequest : NoodleRequest<List<Review>>
    {
        /// <summary>
        /// 开始时间, 不输入缺省取30日内的记录
        /// </summary>
        public long StartTimestamp { get; set; }

        public override string ApiMethodName => "review.list";

        public override void Validate() { }
    }
}
