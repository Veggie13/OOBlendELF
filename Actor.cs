using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;

namespace OOBlendELF
{
    public abstract class Actor : Obj
    {
        public void SetPhysics(PhysicsShape shape, float mass)
        {
            CheckInit();
            BlendELF.SetActorPhysics(Handle, (int)shape, mass);
        }

        public void MoveLocal(FVector3 pos)
        {
            CheckInit();
            BlendELF.MoveActorLocal(Handle, pos.X, pos.Y, pos.Z);
        }

        public FVector3 Position
        {
            set
            {
                CheckInit();
                BlendELF.SetActorPosition(Handle, value.X, value.Y, value.Z);
            }
        }

        public void Rotate(FVector3 dir)
        {
            CheckInit();
            BlendELF.RotateActor(Handle, dir.X, dir.Y, dir.Z);
        }

        public void RotateLocal(FVector3 dir)
        {
            CheckInit();
            BlendELF.RotateActorLocal(Handle, dir.X, dir.Y, dir.Z);
        }
    }
}
