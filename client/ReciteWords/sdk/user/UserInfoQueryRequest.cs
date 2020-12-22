using sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReciteWords
{
    public class UserInfoQueryRequest : NoodleRequest<UserInfoQueryDto>
    {
        public override string ApiMethodName { get => "user.query"; }

        public override void Validate() { }
    }
}
