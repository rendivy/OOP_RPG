using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.ArmorType
{
    public class Helmet : Armor
    {
        public Helmet(int price, string description, int defense, ArmorEnum armorType, int speedDecrease) 
            :base(price, description, defense, armorType, ObjectEnum.HelmetAssetId, speedDecrease) 
        {
        }

        public override void UseItem()
        {
            GameEngine.MainCharacter.PutArmor(ArmorType, Defense, SpeedDecrease);
        }
    }
}