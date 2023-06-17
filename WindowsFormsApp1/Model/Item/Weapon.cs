using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1
{
    public abstract class Weapon: Item
    {
        private int AttackSpeed { get; set; }
        private int WeaponAttackRange { get; set; }
        private int WeaponDamage { get; set; }

        protected Weapon(int price, string description, int attackSpeed, int weaponAttackRange, int weaponDamage, ObjectEnum id) : base(price, description, id)
        {
            this.AttackSpeed = attackSpeed;
            WeaponAttackRange = weaponAttackRange;
            WeaponDamage = weaponDamage;
        }

        public override void UseItem()
        { }
    }
}