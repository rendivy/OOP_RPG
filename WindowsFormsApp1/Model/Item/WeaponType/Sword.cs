using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.WeaponType
{
    public class Sword : Weapon
    {
        public Sword(int price, string description, int attackSpeed, int weaponAttackRange, int weaponDamage) : base(
            price, description, attackSpeed, weaponAttackRange, weaponDamage, ObjectEnum.SwordAssetId)
        { }
        
        
        public override void UseItem()
        {
            GameEngine.MainCharacter.Damage += 30;
            GameEngine.MainCharacter.AttackRange += 40;
        }
    }
}