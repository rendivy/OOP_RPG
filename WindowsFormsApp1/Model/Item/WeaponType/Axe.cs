using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1.WeaponType
{
    public class Axe : Weapon
    {
        public Axe(int price, string description, int attackSpeed, int weaponAttackRange, int weaponDamage) : base(
            price, description, attackSpeed, weaponAttackRange, weaponDamage, ObjectEnum.AxeAssetId)
        { }


        public override void UseItem()
        {
            GameEngine.MainCharacter.Damage += 50;
            GameEngine.MainCharacter.AttackRange -= 15;
        }
    }
}