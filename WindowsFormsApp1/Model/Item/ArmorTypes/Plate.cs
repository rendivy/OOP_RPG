using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.ArmorType
{
    public class Plate : Armor
    {
        public Plate(int price, string description, int defense, ArmorEnum armorType, int speedDecrease) 
            :base(price, description, defense, armorType, ObjectEnum.PlateAssetId, speedDecrease) 
        {
        }
        
        public override void UseItem()
        {
            GameEngine.MainCharacter.PutArmor(ArmorType, Defense, SpeedDecrease);
        }
    }
    
    
    
}