using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOBlendELF
{
    public class ObjectReinitializationException : ApplicationException
    {
        public ObjectReinitializationException() : base() { }
        public ObjectReinitializationException(string msg) : base(msg) { }
        public ObjectReinitializationException(string msg, Exception inner)
            : base(msg, inner)
        {
        }
    }
}
