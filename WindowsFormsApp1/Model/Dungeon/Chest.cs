using System;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.Objects.Dungeon
{
    public class Chest : GameObject
    {
        private int Rarity { get; set; }
        private Item item;

        public Chest(Item item, int rarity, Coordinates coordinates)
        {
            ID = ObjectEnum.ChestAssetId;
            Rarity = rarity;
            this.item = item;

            Coordinates = coordinates;
        }

        public Item OpenChest(string key)
        {
            return item;
        }

        public Item ChestItem => item;
    }
}