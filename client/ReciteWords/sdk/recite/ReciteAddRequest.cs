using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.recite.add
{
    /// <summary>
    /// 背诵记录增加服务
    /// </summary>
    public class ReciteAddRequest : NoodleRequest<object>
    {
        public long Id { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 记忆曲线(第1次复习时间, 天数, 缺省为1)
        /// </summary>
        public int Schedule1 { get; set; }

        /// <summary>
        /// 记忆曲线(第2次复习时间, 天数, 缺省为7)
        /// </summary>
        public int Schedule2 { get; set; }

        /// <summary>
        /// 记忆曲线(第3次复习时间, 天数, 缺省为30)
        /// </summary>
        public int Schedule3 { get; set; }

        /// <summary>
        /// 记忆曲线(第4次复习时间, 天数, 缺省为90)
        /// </summary>
        public int Schedule4 { get; set; }

        /// <summary>
        /// 计划背诵的单词数量, 缺省为20个
        /// </summary>
        public int WordsNumber { get; set; }
        
        public override string ApiMethodName => "recite.add";

        public override void Validate()
        {
            if (Id==0)
            {
                throw new ArgumentException("背诵id不能为空");
            }
        }
    }
}
