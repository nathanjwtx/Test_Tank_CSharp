using Godot;

public class InstanceKinematicBody2D : KinematicBody2D
{
    public override void _Ready()
    {
        base._Ready();
        GD.Print(Speed);
    }
}