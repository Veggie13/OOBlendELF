using ManagedBlendELF;

namespace OOBlendELF
{
    public enum PhysicsShape
    {
        Mesh = CollisionShape.Mesh,
        Sphere = CollisionShape.Sphere,
        Box = CollisionShape.Box
    }
    
    public enum KeyState
    {
        Pressed = ManagedBlendELF.KeyState.Pressed,
        Down = ManagedBlendELF.KeyState.Down
    }

    public enum KeyCode
    {
        Space = ManagedBlendELF.KeyCode.Space,
        W = ManagedBlendELF.KeyCode.W,
        S = ManagedBlendELF.KeyCode.S,
        A = ManagedBlendELF.KeyCode.A,
        D = ManagedBlendELF.KeyCode.D,
        Escape = ManagedBlendELF.KeyCode.ESC
    }
}