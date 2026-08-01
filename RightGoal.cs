using Godot;
using System;

public partial class RightGoal : Area2D
{
    public override void _Ready()
    {
        BodyEntered += OnBodyEntered;
    }


    private void OnBodyEntered(Node2D body)
    {
        // defensive check. Body should always be type Ball, but ...
        if (body is Ball ball)
        {
            Main.RightPlayerScore += 1;
            ball.ResetBall();
        }

        GD.Print(Main.RightPlayerScore);
    }
}
