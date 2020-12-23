using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.exercise
{
    /// <summary>
    /// 个人指定时间后的测验记录列表获取服务
    /// </summary>
    public class ExerciseListRequest : NoodleRequest<List<Exercise>>
    {
        /// <summary>
        /// 开始时间, 不输入缺省取6年内的记录
        /// </summary>
        public long StartTimestamp { get; set; }

        public override string ApiMethodName => "exercise.list";

        public override void Validate() { }
    }
}
