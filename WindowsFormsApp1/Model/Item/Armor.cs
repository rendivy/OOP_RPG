using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1
{
    public abstract class Armor : Item
    {
        protected int Defense { get; set; }
        protected ArmorEnum ArmorType { get; set; }
        
        protected int SpeedDecrease { get; set; }
        protected Armor(int price, string description, int defense, ArmorEnum armorType, ObjectEnum id, int speedDecrease) : base(price, description, id)
        {
            Defense = defense;
            ArmorType = armorType;
            SpeedDecrease = speedDecrease;
        }

        public override void UseItem()
        { }
    }
}