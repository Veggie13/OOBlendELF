using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;

namespace OOBlendELF
{
    public class Keys
    {
        private static Keys _instance = new Keys();
        public static Keys State
        {
            get { return _instance; }
        }

        public KeyState this[KeyCode code]
        {
            get
            {
                return (KeyState)BlendELF.GetKeyState((ManagedBlendELF.KeyCode)code);
            }
        }
    }
}
