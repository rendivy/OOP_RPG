using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects.Enemies
{
    internal class Warrior : Enemy
    {
        public Warrior(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            ((Creature)this).HealthPoint = 40;
            speed = 20;
            xSpeed = speed;
            ySpeed = speed;
            damage = 2;
            attackRange = 20;
            attackSpeed = 10;
            ID = ObjectEnum.WarriorAssetId;
        }
        
        protected override void UniqueAction()
        {
            if (isApproaching && speed < 30)
                speed++;
            else if (!isApproaching && speed > 20)
                speed--;
        }
    }
}