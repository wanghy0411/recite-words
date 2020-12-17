using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk.user.password
{
    public class UserPasswordCheckRequest : NoodleRequest<long>
    {
        public string Nick { get; set; }
        /**
         * 用户密码
         */
        public string Password { get; set; }
        public override string ApiMethodName => "user.password.check";

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nick))
            {
                throw new ArgumentException("用户不能为空");
            }
            if (string.IsNullOrEmpty(Password))
            {
                throw new ArgumentException("用户密码不能为空");
            }
        }
    }
}
