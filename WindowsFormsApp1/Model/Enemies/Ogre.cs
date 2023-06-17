using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects.Enemies
{
    internal class Ogre: Enemy
    {
        public Ogre(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            ((Creature)this).HealthPoint = 150;
            speed = 10;
            xSpeed = speed;
            ySpeed = speed;
            damage = 5;
            attackRange = 50;
            attackSpeed = 12;
            ID = ObjectEnum.OgreAssetId;
        }
        
        protected override void UniqueAction()
        {
            if (CalculateDistance(GameEngine.MainCharacter) <= attackRange)
                GameEngine.MainCharacter.Speed = 0;
            else
                GameEngine.MainCharacter.Speed = 20;
        }
    }
}