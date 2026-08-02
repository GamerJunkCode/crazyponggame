using crazyponggame;
using Godot;

public partial class Player : CharacterBody2D
{
    [Export] // Why [Export] if its defined here?
    public int Speed { get; set; } = GameConstants.InitialSpeed;

    /// <summary>
    /// Turn Input to Velocity times Speed.
    /// </summary>
    public void InputToVelocity()
    {
        Velocity = new Vector2(0, Input.GetAxis("ui_up", "ui_down")) * Speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        InputToVelocity();
        MoveAndSlide();
    }

}
