using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.words.save
{
    /// <summary>
    /// 单词保存服务
    /// </summary>
    public class WordsSaveRequest : NoodleRequest<object>
    {
        /// <summary>
        /// 单词对象
        /// </summary>
        public Words Words { get; set; }

        public override string ApiMethodName => "words.save";

        public override void Validate()
        {
            if (Words == null)
            {
                throw new ArgumentException("单词对象不能为空");
            }
            if (string.IsNullOrEmpty(Words.Spelling))
            {
                throw new ArgumentException("单词拼写不能为空");
            }
            if (string.IsNullOrEmpty(Words.Explanation))
            {
                throw new ArgumentException("单词释义不能为空");
            }
        }
    }
}
