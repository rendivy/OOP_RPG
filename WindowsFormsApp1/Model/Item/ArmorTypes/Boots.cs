using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.ArmorType
{
    public class Boots : Armor
    {
        public Boots(int price, string description, int defense, ArmorEnum armorType, int speedDecrease) 
            :base(price, description, defense, armorType, ObjectEnum.BootsAssetId, speedDecrease) 
        {
        }

        public override void UseItem()
        {
            GameEngine.MainCharacter.PutArmor(ArmorType, Defense, SpeedDecrease);
        }
    }
}