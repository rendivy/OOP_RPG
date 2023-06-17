using WindowsFormsApp1.Objects;
using WindowsFormsApp1.Objects.Assets;
using WindowsFormsApp1.Objects.Enemies;

namespace WindowsFormsApp1.GlobalEffectItem
{
    public class EnemyKiller : Item
    {
        public EnemyKiller(int price, string description) : base(price, description, ObjectEnum.EnemyKillerAssetId)
        { }

        public override void UseItem()
        {
            foreach (var t in GameEngine.Enemies)
            {
                t.OnDie();
            }
        }
    }
}