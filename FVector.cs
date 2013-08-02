using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOBlendELF
{
    public struct FVector2
    {
        public FVector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X;
        public float Y;

        public static FVector2 New(float x, float y)
        {
            return new FVector2(x, y);
        }
    }

    public struct FVector3
    {
        public FVector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float X;
        public float Y;
        public float Z;

        public static FVector3 New(float x, float y, float z)
        {
            return new FVector3(x, y, z);
        }
    }
}
