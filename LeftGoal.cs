using Godot;
using System;

public partial class LeftGoal : Area2D
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
            Main.LeftPlayerScore += 1;
            ball.Reset();
        }

        GD.Print(Main.LeftPlayerScore);
    }
}
