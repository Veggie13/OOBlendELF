using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOBlendELF
{
    public struct FColor4
    {
        public FColor4 (float r, float g, float b, float a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public float R;
        public float G;
        public float B;
        public float A;

        public static FColor4 New(float r, float g, float b, float a)
        {
            return new FColor4(r, g, b, a);
        }
    }
}
