using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk
{
    public class NoodleResponse<T>
    {
        public string ClientRequestNo { get; set; }
        public long ServerRequestNo { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; }
        public T Data { get; set; }
    }
}
