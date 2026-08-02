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
        if (body is Ball ball)
        {
            Main.RightPlayerScore += 1;
            ball.Reset();
        }

        GD.Print(Main.RightPlayerScore);
    }
}
