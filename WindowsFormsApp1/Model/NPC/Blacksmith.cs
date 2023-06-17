using System;
using WindowsFormsApp1.ArmorType;
using WindowsFormsApp1.Objects.Assets;
using WindowsFormsApp1.WeaponType;

namespace WindowsFormsApp1.Objects
{
    internal class Blacksmith : NPC
    {
        public Blacksmith(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            (this).HealthPoint = 20;
            speed = 20;
            xSpeed = speed;
            ySpeed = speed;
            damage = 5;
            ID = ObjectEnum.BlacksmithAssetId;

            inventory.Items.Add(new Axe(50, "topor", 10, 20, 20));
            inventory.Items.Add(new Boots(50, "botinki", 10, ArmorEnum.Foot, 10));
            inventory.Items.Add(new Helmet(60, "shlem", 25, ArmorEnum.Head, 5));
            inventory.Items.Add(new Plate(60, "bronya", 20, ArmorEnum.Plate, 10));
            inventory.Items.Add(new Sword(100, "mech", 10, 20, 30));
            inventory.Items.Add(new Spear(100, "kopie", 10, 20, 30));
        }
    }
}