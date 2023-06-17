using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.WeaponType
{
    public class Spear : Weapon
    {
        public Spear(int price, string description, int attackSpeed, int weaponAttackRange, int weaponDamage) : base(
            price, description, attackSpeed, weaponAttackRange, weaponDamage, ObjectEnum.SpearAssetId)
        { }
        
        
        public override void UseItem()
        {
            GameEngine.MainCharacter.Damage += 20;
            GameEngine.MainCharacter.AttackRange += 100;
        }
    }
}