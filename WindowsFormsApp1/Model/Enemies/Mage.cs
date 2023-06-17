using System.Diagnostics;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects.Enemies
{
    internal class Mage: Enemy
    {
        public Mage(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            ((Creature)this).HealthPoint = 11;
            speed = 18;
            xSpeed = speed;
            ySpeed = speed;
            damage = 2;
            attackRange = 300;
            attackSpeed = 10;
            ID = ObjectEnum.MageAssetId;
        }
        
        protected override void UniqueAction()
        {
            if (HealthPoint < 11)
                HealthPoint++;
        }
    }
}