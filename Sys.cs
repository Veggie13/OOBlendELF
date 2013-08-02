using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedBlendELF;

namespace OOBlendELF
{
    public static class Sys
    {
        public static void Init(int width, int height, string title, int multi, bool fullscreen, string log)
        {
            BlendELF.Init(width, height, title, multi, fullscreen, log);
        }

        public static void Deinit()
        {
            try
            {
                BlendELF.Deinit();
            }
            catch (AccessViolationException)
            {
                // whatever, I don't care
            }
        }

        public static bool Run()
        {
            return BlendELF.Run();
        }

        public static void Quit()
        {
            BlendELF.Quit();
        }
    }
}
