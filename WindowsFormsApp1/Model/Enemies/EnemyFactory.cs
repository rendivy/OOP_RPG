using System.Collections.Generic;
using WindowsFormsApp1.Objects.Enemies;

namespace WindowsFormsApp1.Objects
{
    public class EnemyFactory
    {
        private List<Enemy> enemies = new List<Enemy>();
        
        public EnemyFactory(float width, float height)
        {
            enemies.Add(new Archer(GameEngine.GetRandomCoordinates(width, height)));
            enemies.Add(new GeneralRadahn(GameEngine.GetRandomCoordinates(width, height)));
            enemies.Add(new Mage(GameEngine.GetRandomCoordinates(width, height)));
            enemies.Add(new Mosquito(GameEngine.GetRandomCoordinates(width, height)));
            enemies.Add(new Ogre(GameEngine.GetRandomCoordinates(width, height)));
            enemies.Add(new Warrior(GameEngine.GetRandomCoordinates(width, height)));
        }
        
        public List<Enemy> Enemies
        {
            get
            {
                return enemies;
            }
        }
    }
}