using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.exercise
{
    /// <summary>
    /// 测验记录
    /// </summary>
    public class Exercise
    {
        /// <summary>
        /// 测验id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 测验时间ms
        /// </summary>
        public long ExerciseTime { get; set; }

        /// <summary>
        /// 测验时间
        /// </summary>
        public DateTime ExerciseDateTime { get; set; }

        /// <summary>
        /// 测验成绩
        /// </summary>
        public int? Score { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comment { get; set; }
    }
}
