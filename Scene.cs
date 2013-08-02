using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManagedBlendELF;

namespace OOBlendELF
{
    public class Scene : Obj
    {
        public Scene() { }
        public Scene(string name)
        {
            Load(name);
        }

        public void Load(string name)
        {
            InitializeHandle(BlendELF.LoadScene(name));
        }

        private class _Entity : Entity
        {
            public _Entity(ObjectHandle h)
            {
                InitializeHandle(h);
            }
        }
        public Entity GetEntityByName(string name)
        {
            CheckInit();
            return new _Entity(BlendELF.GetEntityByName(Handle, name));
        }

        public void AddParticles(Particles par)
        {
            CheckInit();
            BlendELF.AddParticlesToScene(Handle, par.Handle);
        }

        private class _Camera : Camera
        {
            public _Camera(ObjectHandle h)
            {
                InitializeHandle(h);
            }
        }
        public Camera GetActiveCamera()
        {
            CheckInit();
            return new _Camera(BlendELF.GetSceneActiveCamera(Handle));
        }
    }
}
