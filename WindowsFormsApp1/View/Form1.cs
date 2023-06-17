using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Objects;
using System.Threading;
using WindowsFormsApp1.GlobalEffectItem;
using WindowsFormsApp1.Objects.Assets;
using WindowsFormsApp1.Objects.Dungeon;
using WindowsFormsApp1.Objects.Enemies;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isMovingLeft;
        private bool isMovingRight;
        private bool isMovingUp;
        private bool isMovingDown;
        
        private void DrawCreatures(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < GameEngine.Creatures.Count; i++)
            {
                var asset = GameEngine.AssetFactory.getAsset(GameEngine.Creatures[i].ID).PictureBox;
                asset.Location = new Point((int)GameEngine.Creatures[i].Coordinates.X,
                    (int)GameEngine.Creatures[i].Coordinates.Y);
                this.Controls.Add(asset);
                ((System.ComponentModel.ISupportInitialize)(asset)).EndInit();
            }
        }

        public Form1()
        {
            InitializeComponent();
            
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
            
            this.Paint += DrawCreatures;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;

            GameEngine.GenerateCreatures(this.Width, this.Height);
            GameEngine.Dungeon.tableLayoutPanel1.Location = new Point(400, 400);
            
            TimerCallback creatureMoveTm = new TimerCallback(UpdateForm);
            GameEngine.CreatureMoveTimer = new System.Threading.Timer(creatureMoveTm, this, 0, 100);
            Controls.Add(GameEngine.Dungeon.tableLayoutPanel1);
        }
        
        private void UpdateForm(object form)
        {
            if (!GameEngine.IsRunning)
                return;
            
            GameEngine.UpdateGameEngine(this.Width, this.Height);
            hpBar.Value = (int)(GameEngine.MainCharacter.HealthPoint / (float)GameEngine.MainCharacter.MaxHealth * 100);
            
            if (GameEngine.IsRunning)
                this.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    isMovingLeft = true;
                    break;
                case Keys.D:
                    isMovingRight = true;
                    break;
                case Keys.W:
                    isMovingUp = true;
                    break;
                case Keys.S:
                    isMovingDown = true;
                    break;
                case Keys.F:
                    GameEngine.MainCharacter.InteractNPC();
                    break;
                case Keys.E:
                    GameEngine.MainCharacter.OpenInventory();
                    break;
            }

            UpdateMovement();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    isMovingLeft = false;
                    break;
                case Keys.D:
                    isMovingRight = false;
                    break;
                case Keys.W:
                    isMovingUp = false;
                    break;
                case Keys.S:
                    isMovingDown = false;
                    break;
            }

            UpdateMovement();
        }

        private void UpdateMovement()
        {
            if (isMovingLeft)
            {
                if (isMovingUp)
                    GameEngine.MainCharacter.MoveUpLeft();
                else if (isMovingDown)
                    GameEngine.MainCharacter.MoveDownLeft();
                else
                    GameEngine.MainCharacter.MoveLeft();
            }
            else if (isMovingRight)
            {
                if (isMovingUp)
                    GameEngine.MainCharacter.MoveUpRight();
                else if (isMovingDown)
                    GameEngine.MainCharacter.MoveDownRight();
                else
                    GameEngine.MainCharacter.MoveRight();
            }
            else if (isMovingUp)
            {
                GameEngine.MainCharacter.MoveUp();
            }
            else if (isMovingDown)
            {
                GameEngine.MainCharacter.MoveDown();
            }

            if (GameEngine.IsRunning)
                this.Invalidate();
        }
        
        private void PlayerAttack(object sender, EventArgs e)
        {
            GameEngine.PlayerAttack(sender, e);
        }
    }
}
