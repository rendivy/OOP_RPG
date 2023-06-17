using System;
using System.Diagnostics;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects
{
    public abstract class NPC : Creature
    {
        public NPC()
        {
            inventory = new Inventory(10);
        }
        
        public override void Move(float formWidth, float formHeight)
        {
            double speedCoefficient = 0.7;

            xSpeed = xSpeed * speedCoefficient + (GameEngine.Rnd.NextDouble() * 60 - 30);
            ySpeed = ySpeed * speedCoefficient + (GameEngine.Rnd.NextDouble() * 60 - 30);

            if (Coordinates.X + (float)xSpeed > 0 && Coordinates.X + (float)xSpeed < formWidth)
                Coordinates.X += (float)xSpeed;

            if (Coordinates.Y + (float)ySpeed > 0 && Coordinates.Y + (float)ySpeed < formHeight)
                Coordinates.Y += (float)ySpeed;
        }
        
        public override void OnDie()
        {
            Coordinates = new Coordinates(-999, -999);
        }
    }
}