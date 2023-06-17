using System;
using System.Collections.Generic;
using System.Drawing;
using WindowsFormsApp1.Objects.Assets;
using WindowsFormsApp1.WeaponType;

namespace WindowsFormsApp1
{
    public class ItemAssetsFactory
    {
        public Dictionary<Enum, ItemAsset> assets;
        
        public ItemAssetsFactory()
        {
            assets = new Dictionary<Enum, ItemAsset>()
            {
                { ObjectEnum.AxeAssetId, new ItemAsset(Image.FromFile("GameAsset\\axe.png")) },
                { ObjectEnum.BootsAssetId, new ItemAsset(Image.FromFile("GameAsset\\boots_01d.png")) },
                { ObjectEnum.HelmetAssetId, new ItemAsset(Image.FromFile("GameAsset\\helmet_02a.png")) },
                { ObjectEnum.PlateAssetId, new ItemAsset(Image.FromFile("GameAsset\\armor_01d.png")) },
                { ObjectEnum.SpearAssetId, new ItemAsset(Image.FromFile("GameAsset\\staff_01d.png")) },
                { ObjectEnum.SwordAssetId, new ItemAsset(Image.FromFile("GameAsset\\sword_03c.png")) },
                { ObjectEnum.DefensePotionAssetId, new ItemAsset(Image.FromFile("GameAsset\\potion_03h.png")) },
                { ObjectEnum.DistanceDecreaserAssetId, new ItemAsset(Image.FromFile("GameAsset\\spellbook_01c.png")) },
                { ObjectEnum.EnemyKillerAssetId, new ItemAsset(Image.FromFile("GameAsset\\skull_01a.png")) },
                { ObjectEnum.HealthPotionAssetId, new ItemAsset(Image.FromFile("GameAsset\\potion_03a.png")) },
                { ObjectEnum.SpeedPotionAssetId, new ItemAsset(Image.FromFile("GameAsset\\potion_03f.png")) },
                { ObjectEnum.TimeDilatorAssetId, new ItemAsset(Image.FromFile("GameAsset\\scroll_01d.png")) },
                { ObjectEnum.KeyAssetId, new ItemAsset(Image.FromFile("GameAsset\\key_02c.png")) },
                { ObjectEnum.NoteAssetId, new ItemAsset(Image.FromFile("GameAsset\\book_01d.png")) }
            };
        }
        
        public ItemAsset getAsset(ObjectEnum objectEnum)
        {
            return assets[objectEnum];
        }
    }
}