using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WindowsFormsApp1.GlobalEffectItem;
using WindowsFormsApp1.Objects.Assets;
using WindowsFormsApp1.Objects.Enemies;

namespace WindowsFormsApp1.Objects.Dungeon
{
    public class Dungeon : GameObject
    {
        private List<Chest> DungeonObjectsList { get; set; } = new List<Chest>();
        public TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();

        private List<Chest> chests = new List<Chest>();

        public Dungeon(Coordinates coordinates)
        {   
            Coordinates = coordinates;
            tableLayoutPanel1.BackgroundImage = Image.FromFile("GameAsset\\Dungeon.png");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.Size = new Size(600, 600);
            tableLayoutPanel1.Location = new Point((int)Coordinates.X, (int)Coordinates.Y);
            Type = ObjectType.BuildObject;
            ID = ObjectEnum.DungeonAssetId;
            this.tableLayoutPanel1.ColumnCount = 2;
            CreateChest();
        }  
        
        private void CreateChest()
        {
            var asset = new AssetFactory();
            var asset2 = new AssetFactory();

            tableLayoutPanel1.Controls.Add(asset.getAsset(ObjectEnum.ChestAssetId).PictureBox, 1, 0);
            var first = tableLayoutPanel1.Controls[0].Location;

            tableLayoutPanel1.Controls.Add(asset2.getAsset(ObjectEnum.ChestAssetId).PictureBox, 1, 1);
            var second = tableLayoutPanel1.Controls[1].Location;

            chests.Add(new Chest(new EnemyKiller(0, "s"), 1,
                new Coordinates(first.X + Coordinates.X, first.Y + Coordinates.Y)));
            chests.Add(new Chest(new EnemyKiller(0, "s"), 1,
                new Coordinates(second.X + Coordinates.X, second.Y + Coordinates.Y)));
        }

        public List<Chest> Chests => chests;
    }
}