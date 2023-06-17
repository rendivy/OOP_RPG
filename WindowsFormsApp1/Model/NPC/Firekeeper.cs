using System.Runtime.CompilerServices;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects
{
    internal class Firekeeper : NPC
    {
        public Firekeeper(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            ((Creature)this).HealthPoint = 20;
            speed = 20;
            xSpeed = speed;
            ySpeed = speed;
            damage = 5;
            ID = ObjectEnum.FirekeeperAssetId;
            
            inventory.Items.Add(new Potion(10, "malenkoe zel`e", PotionEnum.Large, PotionType.HealthPotion, ObjectEnum.HealthPotionAssetId));
            inventory.Items.Add(new Potion(50, "srednee zel`e", PotionEnum.Medium, PotionType.DefensePotion, ObjectEnum.DefensePotionAssetId));
            inventory.Items.Add(new Potion(100, "bolshoe zel`e", PotionEnum.Small, PotionType.SpeedPotion, ObjectEnum.SpeedPotionAssetId));
            inventory.Items.Add(new ChestKey(250, "kluch", RarityEnum.Common));
        }
    }
}