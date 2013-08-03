using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOBlendELF;

namespace BlendELFTest
{
    class Program
    {
        static void Main()
        {
            Sys.Init(1280, 720, "Test", 16, false, "elf.log");

            Mouse.Hide(true);

            var scn = new Scene("level1.pak");

            var snd = new Sound("resources/track5_mono.ogg");

            var ent1 = scn.GetEntityByName("Plane");
            var ent2 = scn.GetEntityByName("Cube.002");
            var ent3 = scn.GetEntityByName("Cube.001");
            var src = ent2.LoopSound(snd, 1.0f);

            ent1.SetPhysics(PhysicsShape.Mesh, 0.0f);
            //ent2.SetPhysics(PhysicsShape.Sphere, 1.0f);
            //ent3.SetPhysics(PhysicsShape.Sphere, 1.0f);

            var partex = new Texture("resources/particle.png");
            var par = new Particles("MyParticles", 1000);
            par.Texture = partex;
            par.ColorMin = FColor4.New(0.5f, 0.5f, 0.5f, 1.0f);
            par.ColorMax = FColor4.New(1.0f, 1.0f, 1.0f, 1.0f);
            par.Size = FSpan.New(0.25f, 1.0f);
            par.VelocityMin = FVector3.New(-3f, -3f, 7.0f);
            par.VelocityMax = FVector3.New(3f, 3f, 7.0f);
            par.Gravity = FVector3.New(0f, 0f, -20f);
            par.SpawnDelay = 0.01f;
            par.LifeSpan = FSpan.New(1.5f, 2.0f);
            par.Position = FVector3.New(0f, 0f, 3f);
            scn.AddParticles(par);

            var cam = scn.GetActiveCamera();
            while (Sys.Run())
            {
                if (Keys.State[KeyCode.Space] == KeyState.Pressed)
                    src.Stop();

                if (Keys.State[KeyCode.W] == KeyState.Down)
                    cam.MoveLocal(FVector3.New(0f, 0f, -12f));

                if (Keys.State[KeyCode.S] == KeyState.Down)
                    cam.MoveLocal(FVector3.New(0f, 0f, 12f));

                if (Keys.State[KeyCode.A] == KeyState.Down)
                    cam.MoveLocal(FVector3.New(-12f, 0f, 0f));

                if (Keys.State[KeyCode.D] == KeyState.Down)
                    cam.MoveLocal(FVector3.New(12f, 0f, 0f));

                var mf = Mouse.Force;
                cam.Rotate(FVector3.New(0f, 0f, -mf.X * 10f));
                cam.RotateLocal(FVector3.New(-mf.Y * 10f, 0f, 0f));

                if (Keys.State[KeyCode.Escape] == KeyState.Pressed)
                    Sys.Quit();
            }

            Sys.Deinit();
        }
    }
}
