using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;
using System.Diagnostics;

namespace OOBlendELF
{
    public class Obj
    {
        private ObjectHandle _handle = null;
        internal ObjectHandle Handle
        {
            get { return _handle; }
        }

        protected void InitializeHandle(ObjectHandle h)
        {
            if (_handle != null)
                throw new ObjectReinitializationException();

            _handle = h;
            Debug.Assert(IsValid);
        }

        public bool IsInitialized
        {
            get { return (_handle != null); }
        }

        public bool IsValid
        {
            get
            {
                CheckInit();
                return _handle.IsValid();
            }
        }

        public override bool Equals(object obj)
        {
            Obj other = obj as Obj;
            if (other == null)
                return false;
            return Handle.Equals(other.Handle);
        }

        protected void CheckInit()
        {
            if (_handle == null)
                throw new ObjectUninitializedException();
        }
    }

}
