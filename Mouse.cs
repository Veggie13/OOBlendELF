using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;

namespace OOBlendELF
{
    public static class Mouse
    {
        public static void Hide(bool hide)
        {
            BlendELF.HideMouse(hide);
        }

        public static FVector2 Force
        {
            get
            {
                Vector2i v = BlendELF.GetMouseForce();
                return FVector2.New(v.X, v.Y);
            }
        }
    }
}
