using System;
using crazyponggame;
using Godot;

public partial class Ball : CharacterBody2D
{
    public Vector2 Direction = new Vector2(-1, 0.5f).Normalized();
    public int Speed { get; set; } = GameConstants.InitialSpeed;

    private Vector2 _startPosition;

    public override void _PhysicsProcess(double delta)
    {
        Velocity = Direction * Speed;
        MoveAndSlide();

        if (GetSlideCollisionCount() > 0)
        {
            KinematicCollision2D Collision = GetSlideCollision(0);

            Direction = Direction.Bounce(Collision.GetNormal());
        }
    }

    public override void _Ready()
    {
        _startPosition = Position;
    }

    /// <summary>
    /// On call it will return the ball to his original point.
    /// </summary>
    public void Reset()
    {
        Position = _startPosition;
    }
}
