using System;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.Objects.Enemies
{
    public abstract class Enemy : Creature
    {
        private double xSpeed;
        private double ySpeed;
        protected bool isApproaching = false;
        private DateTime deathTime;

        protected abstract void UniqueAction();
        
        private void ApproachMainCharacter(Creature mainCharacter)
        {
            xSpeed = (mainCharacter.Coordinates.X - Coordinates.X);
            ySpeed = (mainCharacter.Coordinates.Y - Coordinates.Y);
            
            double currentSpeed = Math.Sqrt(xSpeed * xSpeed + ySpeed * ySpeed);

            xSpeed *= speed / currentSpeed;
            ySpeed *= speed / currentSpeed;

            Coordinates.X += (float)xSpeed;
            Coordinates.Y += (float)ySpeed;
        }
        
        public Creature UseAction(Creature creature)
        {
            if (Coordinates.X == -999 && Coordinates.Y == -999 && DateTime.Now.AddSeconds(-8) < deathTime)
                Coordinates = new Coordinates(
                    GameEngine.Dungeon.tableLayoutPanel1.Location.X + GameEngine.Dungeon.tableLayoutPanel1.Width / 2,
                    GameEngine.Dungeon.tableLayoutPanel1.Location.Y + GameEngine.Dungeon.tableLayoutPanel1.Height / 2);
            
            UniqueAction();
            
            if (creature.ID == 0 && CalculateDistance(creature) < attackRange)
            {
                isApproaching = true;
                creature = Attack((MainCharacter)creature);
            }
            else if (creature.ID == 0 && CalculateDistance(creature) < creature.DetectionRange)
            {
                isApproaching = true;
                ApproachMainCharacter(creature);
            }
            else
            {
                isApproaching = false;
            }

            return creature;
        }
        
        public override void OnDie()
        {
            Coordinates = new Coordinates(-999, -999);
            deathTime = DateTime.Now;
            GameEngine.MainCharacter.Spend(-15);
        }
        
        public override void Move(float formWidth, float formHeight)
        {
            if (isApproaching)
                return;
            
            double speedCoefficient = 0.7;

            xSpeed = xSpeed * speedCoefficient + (GameEngine.Rnd.NextDouble() * 60 - 30);
            ySpeed = ySpeed * speedCoefficient + (GameEngine.Rnd.NextDouble() * 60 - 30);

            double currentSpeed = Math.Sqrt(xSpeed * xSpeed + ySpeed * ySpeed);

            xSpeed *= speed / currentSpeed;
            ySpeed *= speed / currentSpeed;
            
            if (Coordinates.X + (float)xSpeed > 0 && Coordinates.X + (float)xSpeed < formWidth)
                Coordinates.X += (float)xSpeed;

            if (Coordinates.Y + (float)ySpeed > 0 && Coordinates.Y + (float)ySpeed < formHeight)
                Coordinates.Y += (float)ySpeed;
        }
    }
}