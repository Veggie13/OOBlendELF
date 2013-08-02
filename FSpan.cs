using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOBlendELF
{
    public struct FSpan
    {
        public FSpan (float min, float max)
        {
            Min = min;
            Max = max;
        }

        public float Min;
        public float Max;

        public static FSpan New(float min, float max)
        {
            return new FSpan(min, max);
        }
    }
}
