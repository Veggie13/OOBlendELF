using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOBlendELF
{
    public class ObjectUninitializedException : ApplicationException
    {
        public ObjectUninitializedException() : base() { }
        public ObjectUninitializedException(string msg) : base(msg) { }
        public ObjectUninitializedException(string msg, Exception inner)
            : base(msg, inner)
        {
        }
    }
}
