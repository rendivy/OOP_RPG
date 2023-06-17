using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects.Enemies
{
    internal class Mosquito : Enemy
    {
        public Mosquito(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            ((Creature)this).HealthPoint = 1;
            speed = 7;
            xSpeed = speed;
            ySpeed = speed;
            damage = 4;
            attackRange = 20;
            attackSpeed = 5;
            ID = ObjectEnum.MosquitoAssetId;
        }
        
        protected override void UniqueAction()
        {
            if (CalculateDistance(GameEngine.MainCharacter) < attackRange)
                GameEngine.MainCharacter.IsBleeding = true;
        }
    }
}