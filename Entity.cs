using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;

namespace OOBlendELF
{
    public class Entity : Actor
    {
        private class SoundSource : Sound.Source
        {
            public SoundSource(ObjectHandle h)
            {
                InitializeHandle(h);
            }
        }
        public Sound.Source PlaySound(Sound snd, float volume)
        {
            CheckInit();
            return new SoundSource(BlendELF.PlayEntitySound(Handle, snd.Handle, volume));
        }

        public Sound.Source LoopSound(Sound snd, float volume)
        {
            CheckInit();
            return new SoundSource(BlendELF.LoopEntitySound(Handle, snd.Handle, volume));
        }
    }
}
