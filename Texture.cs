using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;

namespace OOBlendELF
{
    public class Texture : Obj
    {
        public Texture() { }
        public Texture(string file)
        {
            CreateFromFile(file);
        }

        public void CreateFromFile(string file)
        {
            InitializeHandle(BlendELF.CreateTextureFromFile(file));
        }
    }
}
