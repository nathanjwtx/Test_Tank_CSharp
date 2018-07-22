using Godot;
using System;

public class TestMap : Node2D
{
    public TileMap Ground;

    public override void _Ready()
    {
    }

	public void _on_TestTankEnemy_Shoot(PackedScene bullet, Vector2 _position, Vector2 _direction)
	{
	    GD.Print("boom boom");
		TestBullet b = (TestBullet) bullet.Instance();
		AddChild(b);
		b.Start(_position, _direction);
	}
}
