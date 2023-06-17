using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects.Enemies
{
    internal class GeneralRadahn : Enemy
    {
        public GeneralRadahn(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            ((Creature)this).HealthPoint = 100;
            speed = 3;
            xSpeed = speed;
            ySpeed = speed;
            damage = 2000;
            attackRange = 50;
            attackSpeed = 10;
            ID = ObjectEnum.GeneralRadahnAssetId;
        }

        protected override void UniqueAction()
        { }
    }
}