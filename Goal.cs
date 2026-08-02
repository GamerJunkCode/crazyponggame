using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crazyponggame
{
    public enum GoalSide
    {
        Left,
        Right
    }
    /// <summary>
    /// Introduced a configurable Goal class that replaces the duplicated LeftGoal and RightGoal classes.
    /// The goal side is now configured via an exported GoalSide property, 
    /// removing duplicate logic while keeping the behavior identical.
    /// </summary>
    public partial class Goal : Area2D
    {
        [Export]
        public GoalSide Side { get; set; } // Define the Side per Goal in the editor
        public int LeftScore { get; private set; } = 0;
        public int RightScore { get; private set; } = 0;
        public override void _Ready()
        {
            BodyEntered += OnBodyEntered;
        }


        private void OnBodyEntered(Node2D body)
        {
            if (body is not Ball ball)
                return;

            if (Side == GoalSide.Left)
                LeftScore++;

            if (Side == GoalSide.Right)
                RightScore++;

            // I would write it to a method in the ui and have BodyEntered subscribed to it.
            //GD.Print(Main.LeftPlayerScore);
        }

        /// <summary>
        /// Resets both player scores back to zero.
        /// </summary>
        public void ResetScoreBoard()
        {
            LeftScore = 0; 
            RightScore = 0;
        }
    }
}
