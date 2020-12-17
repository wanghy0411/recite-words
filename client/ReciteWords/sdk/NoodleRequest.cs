using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk
{
    public abstract class NoodleRequest<T>
    {
        /// <summary>
        /// 输入参数的验证
        /// </summary>
        public abstract void Validate();

        /// <summary>
        /// 调用的方法名
        /// </summary>
        public abstract string ApiMethodName { get; }

        /// <summary>
        /// 客户端调用的唯一标识号, 如未指定, sdk会自动设置一个guid作为唯一标识号
        /// 此唯一标识号可作为服务段进行幂等判断的依据
        /// </summary>
        public virtual string ClientRequestNo { get; set; }

        /// <summary>
        /// 调用服务端的
        /// </summary>
        public virtual string ApiVersion { get => "1.0"; }
    }
}
