using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;

namespace OOBlendELF
{
    public class Particles : Actor
    {
        public Particles() { }
        public Particles(string name, int maxCount)
        {
            Create(name, maxCount);
        }

        public void Create(string name, int maxCount)
        {
            InitializeHandle(BlendELF.CreateParticles(name, maxCount));
        }

        public Texture Texture
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesTexture(Handle, value.Handle);
            }
        }

        public FColor4 ColorMin
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesColorMin(Handle, value.R, value.G, value.B, value.A);
            }
        }

        public FColor4 ColorMax
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesColorMax(Handle, value.R, value.G, value.B, value.A);
            }
        }

        public FSpan Size
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesSize(Handle, value.Min, value.Max);
            }
        }

        public FVector3 VelocityMin
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesVelocityMin(Handle, value.X, value.Y, value.Z);
            }
        }

        public FVector3 VelocityMax
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesVelocityMax(Handle, value.X, value.Y, value.Z);
            }
        }

        public FVector3 Gravity
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesGravity(Handle, value.X, value.Y, value.Z);
            }
        }

        public float SpawnDelay
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesSpawnDelay(Handle, value);
            }
        }

        public FSpan LifeSpan
        {
            set
            {
                CheckInit();
                BlendELF.SetParticlesLifeSpan(Handle, value.Min, value.Max);
            }
        }

    }
}
