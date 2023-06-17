using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.GlobalEffectItem
{
    public class DistanceDecreaser : Item
    {
        public DistanceDecreaser(int price, string description) : base(price, description, ObjectEnum.DistanceDecreaserAssetId)
        { }

        public override void UseItem()
        {
            foreach (var t in GameEngine.Enemies)
            {
                t.AttackRange = 20;
            }
        }
    }
}