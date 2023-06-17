using System;
using WindowsFormsApp1.Objects;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1
{
    public class Potion : Item
    {
        private PotionEnum PotionSize { get; set; }
        private PotionType PotionType { get; set; }

        public Potion(int price, string description, PotionEnum potionSize, PotionType potionType, ObjectEnum id) :
            base(price, description, id)
        {
            PotionType = potionType;
            PotionSize = potionSize;
        }

        public override void UseItem()
        {
            switch (PotionSize)
            {
                case PotionEnum.Small:
                    GameEngine.MainCharacter.DrinkPotion(10, PotionType);
                    break;
                case PotionEnum.Medium:
                    GameEngine.MainCharacter.DrinkPotion(15, PotionType);
                    break;
                case PotionEnum.Large:
                    GameEngine.MainCharacter.DrinkPotion(35, PotionType);
                    break;
            }
        }
    }
}