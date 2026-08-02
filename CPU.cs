using crazyponggame;
using Godot;

public partial class CPU : CharacterBody2D
{
    [Export]
    public Ball Ball { get; set; }
    public float Speed { get; private set; } = GameConstants.InitialSpeed;

    public override void _PhysicsProcess(double delta)
    {
        float targetY = Ball.Position.Y;
        float newY = Mathf.MoveToward(Position.Y, targetY, Speed * (float)delta);
        Position = new Vector2(Position.X, newY);
    }
}