using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.GlobalEffectItem
{
    public class SpeedDecreaser: Item
    {
        public SpeedDecreaser(int price, string description) : base(price, description, ObjectEnum.TimeDilatorAssetId)
        { }

        public override void UseItem()
        {
            foreach (var t in GameEngine.Enemies)
            {
                t.Speed = 0;
            }
        }
    }
}