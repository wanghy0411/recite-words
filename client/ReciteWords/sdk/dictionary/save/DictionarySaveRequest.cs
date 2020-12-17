using sdk.dictionary.list;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.dictionary.save
{
    public class DictionarySaveRequest : NoodleRequest<object>
    {
        /// <summary>
        /// 待保存的字典对象
        /// </summary>
        public Dictionary Dictionary { get; set; }

        public override string ApiMethodName => "dictionary.save";

        public override void Validate()
        {
            if (Dictionary==null)
            {
                throw new ArgumentException("字典对象不能为空");
            }
            if (string.IsNullOrEmpty(Dictionary.Name))
            {
                throw new ArgumentException("字典名称不能为空");
            }
            if (string.IsNullOrEmpty(Dictionary.ValidFlag))
            {
                throw new ArgumentException("有效标志不能为空");
            }
            if (!"YN".Contains(Dictionary.ValidFlag))
            {
                throw new ArgumentException("有效标志只能为Y/N");
            }
            if (string.IsNullOrEmpty(Dictionary.PublicFlag))
            {
                throw new ArgumentException("公用标志不能为空");
            }
            if (!"YN".Contains(Dictionary.PublicFlag))
            {
                throw new ArgumentException("公用标志只能为Y/N");
            }
        }
    }
}
