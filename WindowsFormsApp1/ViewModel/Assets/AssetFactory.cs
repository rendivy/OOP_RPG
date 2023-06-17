using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp1.Objects.Assets
{
    public class AssetFactory
    {
        public Dictionary<Enum, Asset> assets;
        
        public AssetFactory()
        {
            assets = new Dictionary<Enum, Asset>()
            {
                { ObjectEnum.MainCharacterAssetId, new Asset(Image.FromFile("GameAsset\\MainCharacter.png")) },
                { ObjectEnum.FirekeeperAssetId, new Asset(Image.FromFile("GameAsset\\Firekeeper.png")) },
                { ObjectEnum.VendorAssetId, new Asset(Image.FromFile("GameAsset\\Vendor.png")) },
                { ObjectEnum.BlacksmithAssetId, new Asset(Image.FromFile("GameAsset\\Blacksmith.png")) },
                { ObjectEnum.ArcherAssetId, new Asset(Image.FromFile("GameAsset\\Archer.png")) },
                { ObjectEnum.WarriorAssetId, new Asset(Image.FromFile("GameAsset\\Warrior.png")) },
                { ObjectEnum.OgreAssetId, new Asset(Image.FromFile("GameAsset\\Ogre.png")) },
                { ObjectEnum.MageAssetId, new Asset(Image.FromFile("GameAsset\\Mage.png")) },
                { ObjectEnum.GeneralRadahnAssetId, new Asset(Image.FromFile("GameAsset\\GeneralRadahn.png")) },
                { ObjectEnum.MosquitoAssetId, new Asset(Image.FromFile("GameAsset\\Mosquitto.png")) },
                { ObjectEnum.DungeonAssetId, new Asset(Image.FromFile("GameAsset\\dungeon.png")) },
                { ObjectEnum.ChestAssetId, new Asset(Image.FromFile("GameAsset\\Chest.png")) }
            };
        }
            
        public Asset getAsset(ObjectEnum objectEnum)
        {
            return assets[objectEnum];
        }
    }
}