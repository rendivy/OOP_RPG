using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Inventory
    {
        public List<Item> Items { get; set; }

        private int InventorySize { get; set; }
        private Item head;
        private Item body;
        private Item legs;
        private Item weapon;

        public Inventory(int inventorySize)
        {
            Items = new List<Item>();
            InventorySize = inventorySize;
        }
        
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void DropItem(int itemIndex)
        {
            Items[itemIndex] = null;
        }

        public Item Head
        {
            get => head;
            set => head = value;
        }

        public Item Body
        {
            get => body;
            set => body = value;
        }

        public Item Legs
        {
            get => legs;
            set => legs = value;
        }

        public Item Weapon
        {
            get => weapon;
            set => weapon = value;
        }
    }
}