using Godot;

public partial class CPU : CharacterBody2D
{
    [Export]
    public Ball _ball;
    public float Speed {get; private set;} = 400;

    public override void _PhysicsProcess(double delta)
    {
        float targetY = _ball.Position.Y;
        float newY = Mathf.MoveToward(Position.Y, targetY, Speed * (float)delta);
        Position = new Vector2(Position.X, newY);
    }
}
