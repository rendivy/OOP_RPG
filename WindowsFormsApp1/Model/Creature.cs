using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace WindowsFormsApp1.Objects
{
    public abstract class Creature : GameObject
    {
        protected int healthPoint;
        protected int damage;
        protected int attackRange;
        protected float speed;
        protected double xSpeed;
        protected double ySpeed;
        protected double detectionRange;
        
        protected int attackSpeed;
        private int attackTimer = 0;

        private float formWidth;
        private float formHeight;
        
        public abstract void Move(float formWidth, float formHeight);
        
        public void Stop()
        {
            xSpeed = 0;
            ySpeed = 0;
        }
        
        protected double CalculateDistance(GameObject creature)
        {
            return Math.Sqrt((creature.Coordinates.X - Coordinates.X) * (creature.Coordinates.X - Coordinates.X) +
                             (creature.Coordinates.Y - Coordinates.Y) *(creature.Coordinates.Y - Coordinates.Y));
        }
        
        public Creature Attack(Creature attackedCharacter)
        {
            if (CalculateDistance(attackedCharacter) > attackRange)
                return attackedCharacter;

            if (attackTimer == 0)
            {
                attackedCharacter.TakeDamage(damage);
                attackTimer = attackSpeed;
            }
            else
                attackTimer--;

            return attackedCharacter;
        }
        
        private void TakeDamage(int damage)
        {
            healthPoint -= damage;
            
            if (healthPoint <= 0)
                OnDie();
        }
        
        public abstract void OnDie();
        
        private void ChangePosition(float deltaX, float deltaY)
        {
            float newX = Coordinates.X + deltaX;
            float newY = Coordinates.Y + deltaY;

            if (newX >= 0 && newX <= 1942 && newY >= 0 && newY <= 1102)
            {
                Coordinates.X = newX;
                Coordinates.Y = newY;
            }
        }

        public void GetItems(List<Item> items)
        {
            foreach (var item in items)
                inventory.Items.Add(item);
        }
        
        public void MoveUp()
        {
            ChangePosition(0, -speed);
        }

        public void MoveDown()
        {
            ChangePosition(0, speed);
        }

        public void MoveRight()
        {
            ChangePosition(speed, 0);
        }

        public void MoveLeft()
        {
            ChangePosition(-speed, 0);
        }

        public void MoveUpLeft()
        {
            ChangePosition(-speed, -speed);
        }

        public void MoveUpRight()
        {
            ChangePosition(speed, -speed);
        }

        public void MoveDownLeft()
        {
            ChangePosition(-speed, speed);
        }

        public void MoveDownRight()
        {
            ChangePosition(speed, speed);
        }

        public int HealthPoint
        {
            get => healthPoint;
            set => healthPoint = value;
        }

        public double DetectionRange
        {
            get => detectionRange;
            set => detectionRange = value;
        }

        public int Damage
        {
            get => damage;
            set => damage = value;
        }

        public float Speed
        {
            get => speed;
            set => speed = value;
        }

        public int AttackRange
        {
            get => attackRange;
            set => attackRange = value;
        }
    }
}