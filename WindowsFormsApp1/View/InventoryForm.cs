using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WindowsFormsApp1.Objects.Assets;

namespace WindowsFormsApp1
{
    public partial class InventoryForm : Form
    {
        private Inventory inventory;
        private List<PictureBox> slots = new List<PictureBox>();
        private List<PictureBox> equipmentSlots = new List<PictureBox>();

        private Item selectedItem = null;
        
        // Перерисовка формы
        private void UpdateForm()
        {
            while (Controls.OfType<PictureBox>().ToArray().Length != 0)
                Controls.Remove(Controls.OfType<PictureBox>().ToArray()[0]);
            
            foreach (var slot in slots)
            {
                Controls.Add(slot);
                slot.Click += new System.EventHandler(this.SelectItem);
                ((System.ComponentModel.ISupportInitialize)(slot)).EndInit();
            }

            foreach (var slot in equipmentSlots)
            {
                Controls.Add(slot);
                ((System.ComponentModel.ISupportInitialize)(slot)).EndInit();
            }
        }
        
        public InventoryForm(Inventory inventory)
        {
            InitializeComponent();

            this.inventory = inventory;
            
            FillSlotsLits();
            SetItems();
            UpdateForm();
        }

        // Заполнение списка слотов инвенторя
        private void FillSlotsLits()
        {
            var slotsList = from p in Controls.OfType<PictureBox>().ToArray()
                where p.Name.StartsWith("slot")
                orderby int.Parse(p.Name.Substring(4))
                    select p;

            foreach (PictureBox slot in slotsList)
            {
                slots.Add(slot);
            }

            equipmentSlots.Add(headSlot);
            equipmentSlots.Add(bodySlot);
            equipmentSlots.Add(legsSlot);
            equipmentSlots.Add(weaponSlot);
        }
        
        // Расставление предметов по слотам
        private void SetItems()
        {
            for (int i = 0; i < inventory.Items.Count; i++)
            {
                var location = slots[i].Location;
                var name = slots[i].Name;
                slots[i] = (new ItemAssetsFactory()).getAsset(inventory.Items[i].Id).PictureBox;
                slots[i].Location = location;
                slots[i].Name = name;
            }

            if (inventory.Head != null)
                headSlot.BackgroundImage =
                    (new ItemAssetsFactory()).getAsset(inventory.Head.Id).PictureBox.BackgroundImage;
            
            if (inventory.Body != null)
                bodySlot.BackgroundImage =
                    (new ItemAssetsFactory()).getAsset(inventory.Body.Id).PictureBox.BackgroundImage;

            if (inventory.Legs != null)
                legsSlot.BackgroundImage =
                    (new ItemAssetsFactory()).getAsset(inventory.Legs.Id).PictureBox.BackgroundImage;
            
            if (inventory.Weapon != null)
                weaponSlot.BackgroundImage =
                    (new ItemAssetsFactory()).getAsset(inventory.Weapon.Id).PictureBox.BackgroundImage;
        }

        // Отмена
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        // Применение предмета
        private void acceptButton_Click_1(object sender, EventArgs e)
        {
            switch (selectedItem.Id)
            {
                case ObjectEnum.HelmetAssetId:
                    GameEngine.MainCharacter.Inventory.Head = selectedItem;
                    break;
                case ObjectEnum.PlateAssetId:
                    GameEngine.MainCharacter.Inventory.Body = selectedItem;
                    break;
                case ObjectEnum.BootsAssetId:
                    GameEngine.MainCharacter.Inventory.Legs = selectedItem;
                    break;
                case ObjectEnum.AxeAssetId:
                    GameEngine.MainCharacter.Inventory.Weapon = selectedItem;
                    break;
                case ObjectEnum.SwordAssetId:
                    GameEngine.MainCharacter.Inventory.Weapon = selectedItem;
                    break;
                case ObjectEnum.SpearAssetId:
                    GameEngine.MainCharacter.Inventory.Weapon = selectedItem;
                    break;
            }
            
            selectedItem.UseItem();
            DialogResult = DialogResult.OK;
            acceptButton.Enabled = false;
            this.Close();
        }

        // Выбор предмета
        private void SelectItem(object sender, EventArgs e)
        {
            int selectedIndex = int.Parse(((PictureBox)sender).Name.Substring(4));

            if (selectedIndex > inventory.Items.Count())
                return;

            acceptButton.Enabled = true;
            selectedItem = inventory.Items[selectedIndex];
        }
    }
}