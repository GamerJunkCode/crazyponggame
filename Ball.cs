using Godot;

public partial class Ball : CharacterBody2D
{
    public Vector2 Direction = new Vector2(-1, 0.5f).Normalized();
    public int Speed { get; set; } = 400;

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

    public void ResetBall()
    {
        
    }
}
