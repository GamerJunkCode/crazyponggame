using Godot;
using System;
using System.Security.Principal;

public partial class LeftGoal : Area2D
{
    public override void _Ready()
    {
        BodyEntered += OnBodyEntered;
    }

    private void OnBodyEntered(Node2D body)
    {
        // defensive check. Body should always be type Ball, but ...
        if (body is Ball)
        {
            Main.LeftPlayerScore += 1;
            Ball.ResetBall();
        }

        GD.Print(Main.LeftPlayerScore);
    }
}