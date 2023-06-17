using WindowsFormsApp1.Objects;
using WindowsFormsApp1.Objects.Assets;
using WindowsFormsApp1.Objects.Dungeon;

namespace WindowsFormsApp1
{
    public class ChestKey: Item
    {
        private RarityEnum Rarity { get; set; }
        public ChestKey(int price, string description, RarityEnum rarity) : base(price, description, ObjectEnum.KeyAssetId)
        {
            this.Rarity = rarity;
        }

        public override void UseItem()
        {
            GameEngine.MainCharacter.OpenChest();
        }
    }
} 