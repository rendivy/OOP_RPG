using System;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.Objects;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1
{
    public abstract class Item : IActionable
    {
        private ObjectEnum id;
        
        protected Item(int price, string description, ObjectEnum id)
        {
            this.price = price;
            Description = description;
            this.id = id;
        }

        private int price;
        private string Description { get; set; }

        public abstract void UseItem();
        
        
        public int Price => price;
        public ObjectEnum Id => id;
    }
}