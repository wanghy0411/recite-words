using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sdk
{
    public abstract class NoodlePagedRequest<T> : NoodleRequest<T>
    {
        public int PageSize { get; set; }
        public int PageNum { get; set; }
    }
}
