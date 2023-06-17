using System;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects.Enemies
{
    internal class Archer : Enemy
    {
        public Archer(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            ((Creature)this).HealthPoint = 10;
            speed = 20;
            xSpeed = speed;
            ySpeed = speed;
            damage = 3;
            attackRange = 300;
            attackSpeed = 10;
            ID = ObjectEnum.ArcherAssetId;
        }

        protected override void UniqueAction()
        {
            if (CalculateDistance(GameEngine.MainCharacter) > GameEngine.MainCharacter.AttackRange)
                return;
            
            xSpeed = (GameEngine.MainCharacter.Coordinates.X - Coordinates.X);
            ySpeed = (GameEngine.MainCharacter.Coordinates.Y - Coordinates.Y);
            
            double currentSpeed = Math.Sqrt(xSpeed * xSpeed + ySpeed * ySpeed);

            xSpeed *= speed / currentSpeed;
            ySpeed *= speed / currentSpeed;

            Coordinates.X -= (float)xSpeed;
            Coordinates.Y -= (float)ySpeed;
        }
    }
}