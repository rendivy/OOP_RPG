using WindowsFormsApp1.GlobalEffectItem;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects
{
    internal class Vendor : NPC
    {
        public Vendor(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            ((Creature)this).HealthPoint = 20;
            speed = 20;
            xSpeed = speed;
            ySpeed = speed;
            damage = 5;
            ID = ObjectEnum.VendorAssetId;
            
            inventory.Items.Add(new EnemyKiller(200, "smert vragov"));
            inventory.Items.Add(new DistanceDecreaser(200, "vragi atakyut tolki blizko"));
            inventory.Items.Add(new SpeedDecreaser(200, "vragi atakyut tolki blizko"));
            inventory.Items.Add(new Note(2, "zapiska"));
        }
    }
}