using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;

namespace OOBlendELF
{
    public class Sound : Obj
    {
        public Sound() { }
        public Sound(string resName)
        {
            Load(resName);
        }

        public void Load(string resName)
        {
            InitializeHandle(BlendELF.LoadSound(resName));
        }

        public abstract class Source : Obj
        {
            public void Stop()
            {
                CheckInit();
                BlendELF.StopSound(Handle);
            }
        }
        private class _Source : Source
        {
            public _Source(ObjectHandle h)
            {
                InitializeHandle(h);
            }
        }
        
        public Source Loop(float volume)
        {
            CheckInit();
            return new _Source(BlendELF.LoopSound(Handle, volume));
        }

        public Source Play(float volume)
        {
            CheckInit();
            return new _Source(BlendELF.PlaySound(Handle, volume));
        }
    }
}
