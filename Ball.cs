using System;
using Godot;

public partial class Ball : CharacterBody2D
{
    public Vector2 Direction = new Vector2(-1, 0.5f).Normalized();
    public int Speed { get; set; } = 400;
    public Vector2 StartPos {get; private set;}

    public override void _PhysicsProcess(double delta)
    {
        Velocity = Direction * Speed;
        MoveAndSlide();

        if (GetSlideCollisionCount() > 0)
        {
            var Collision = GetSlideCollision(0);

            Direction = Direction.Bounce(Collision.GetNormal());
        }
    }

    public override void _Ready()
    {
        StartPos = Position;
    }

    /// <summary>
    /// On call it will return the ball to his original point.
    /// </summary>
    public void ResetBall()
    {
        Position = StartPos;
    }
}
