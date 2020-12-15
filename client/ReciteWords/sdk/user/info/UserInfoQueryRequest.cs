using sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReciteWords
{
    public class UserInfoQueryRequest : NoodleRequest<UserInfoQueryDto>
    {
        public string Nick { get; set; }
        public override string ApiMethodName { get => "user.info.query"; }
        public override string ClientRequestNo { get ; set; }
        public override string ApiVersion { get => "1.0"; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nick))
            {
                throw new ArgumentException("用户昵称不能为空");
            }
        }
    }
}
