using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.GlobalEffectItem;
using WindowsFormsApp1.Objects.Assets;
using WindowsFormsApp1.Objects.Dungeon;
using WindowsFormsApp1.Objects.Enemies;

namespace WindowsFormsApp1.Objects
{
    public class MainCharacter : Creature
    {
        private int money = 2000;
        private int defense;
        private int maxHealth = 20;
        private int bleedingDuration = 5;
        private bool isBleeding = false;
        
        public MainCharacter(Coordinates coordinates)
        {
            Coordinates = coordinates;
            Type = ObjectType.CreatureObject;
            healthPoint = maxHealth;
            speed = 20;
            damage = 10;
            ID = ObjectEnum.MainCharacterAssetId;
            detectionRange = 500;
            attackRange = 100;

            inventory = new Inventory(24);
        }

        public async void Bleed()
        {
            await Task.Run(() =>
            {
                if (isBleeding && bleedingDuration > 0)
                {
                    if (HealthPoint > 0)
                        HealthPoint--;

                    bleedingDuration--;
                }
                else
                {
                    bleedingDuration = 5;
                    isBleeding = false;
                }
            });
            
        }

        public void PutArmor(ArmorEnum armorType, int armorDefense, int armorSpeedDecrease)
        {
            switch (armorType)
                {
                    case ArmorEnum.Head:
                        if (Inventory.Head != null)
                        {
                            defense += armorDefense;
                            speed -= armorSpeedDecrease;
                        }
                        else
                        {
                            defense -= armorDefense;
                            speed += armorSpeedDecrease;
                        }
                        break;
                    case ArmorEnum.Plate:
                        if (Inventory.Body != null)
                        {
                            defense += armorDefense;
                            speed -= armorSpeedDecrease;
                        }
                        else
                        {
                            defense -= armorDefense;
                            speed += armorSpeedDecrease;
                        }
                        break;
                    case ArmorEnum.Foot:
                        if (Inventory.Body != null)
                        {
                            defense += armorDefense;
                            speed += armorSpeedDecrease;
                        }
                        else
                        {
                            defense -= armorDefense;
                            speed -= armorSpeedDecrease;
                        }
                        break;
                }
        }

        public void DrinkPotion(int amount, PotionType potionType)
        {
            switch (potionType)
            {
                case PotionType.DefensePotion:
                    defense += amount;
                    break;
                case PotionType.HealthPotion:
                    if (healthPoint + amount > maxHealth)
                        healthPoint = maxHealth;
                    else
                        healthPoint += amount;
                    break;
                case PotionType.SpeedPotion:
                    speed += amount;
                    break; 
            }
        }
        
        public override void OnDie()
        {
            Coordinates = new Coordinates(0, 0);
            healthPoint = 20;
        }
        
        public void OpenChest()
        {
            Chest currentChest = (Chest)GameEngine.GetNearestObject<Chest>();

            if (CalculateDistance(currentChest) > attackRange)
                return;
            
            DialogWindow dialog = new DialogWindow(true);
            GameEngine.IsRunning = false;
            
            dialog.SetText("");
            dialog.SetPicture(new AssetFactory().getAsset(ObjectEnum.ChestAssetId).PictureBox.BackgroundImage);

            if (dialog.ShowDialog() == DialogResult.OK)
                NPCinteraction.GetInteraction(currentChest.ID)(currentChest);
            
            GameEngine.IsRunning = true;
        }
        
        public void InteractNPC()
        {
            NPC currentNPC = (NPC)GameEngine.GetNearestObject<NPC>();

            if (CalculateDistance(currentNPC) > attackRange)
                return;
            
            DialogWindow dialog = new DialogWindow(false);
            GameEngine.IsRunning = false;

            switch (currentNPC.ID)
            {
                case ObjectEnum.FirekeeperAssetId:
                    dialog.SetText("Цена лечения: ");
                    dialog.SetPicture(new AssetFactory().getAsset(ObjectEnum.FirekeeperAssetId).PictureBox.BackgroundImage);
                    dialog.SetInventory(currentNPC.Inventory);
                    break;
                case ObjectEnum.BlacksmithAssetId:
                    dialog.SetText("Взаимодействие с кузнецом");
                    dialog.SetPicture(new AssetFactory().getAsset(ObjectEnum.BlacksmithAssetId).PictureBox.BackgroundImage);
                    dialog.SetInventory(currentNPC.Inventory);
                    break;
                case ObjectEnum.VendorAssetId:
                    dialog.SetText("Взаимодействие с торговцем");
                    dialog.SetPicture(new AssetFactory().getAsset(ObjectEnum.VendorAssetId).PictureBox.BackgroundImage);
                    dialog.SetInventory(currentNPC.Inventory);
                    break;
                case ObjectEnum.ChestAssetId:
                    dialog.SetText("");
                    dialog.SetPicture(new AssetFactory().getAsset(ObjectEnum.ChestAssetId).PictureBox.BackgroundImage);
                    break;
                default:
                    dialog.SetText("Взаимодействие с unknown");
                    break;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
                NPCinteraction.GetInteraction(currentNPC.ID)(currentNPC);
            
            GameEngine.IsRunning = true;
        }
        
        public void OpenInventory()
        {
            InventoryForm inventoryForm = new InventoryForm(inventory);
            GameEngine.IsRunning = false;

            inventoryForm.ShowDialog();

            GameEngine.IsRunning = true;
        }
        
        public override void Move(float formWidth, float formHeight)
        { }
        
        public void Spend(int amount)
        {
            money -= amount;
        }
        
        public int Defense
        {
            get => defense;
            set => defense = value;
        }

        public int Money => money;

        public int MaxHealth
        {
            get => maxHealth;
            set => maxHealth = value;
        }

        public bool IsBleeding
        {
            get => isBleeding;
            set => isBleeding = value;
        }
    }
}