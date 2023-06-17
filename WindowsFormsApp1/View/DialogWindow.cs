using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DialogWindow : Form
    {
        private int price;
        
        public DialogWindow(bool isChest)
        {
            InitializeComponent();
            TopMost = true;
            moneyLabel.Text = $"Ваши деньги: {GameEngine.MainCharacter.Money}";

            if (isChest)
            {
                okButton.Text = "Забрать";
                moneyLabel.Text = "Открыт сундук.";
            }
                    
        }

        public void SetText(string text)
        {
            dialogText.Text = text;
        }

        public void SetPicture(Image img)
        {
            dialogPicture.BackgroundImage = img;
        }

        public void SetInventory(Inventory inventory)
        {
            foreach (var item in inventory.Items)
                price += item.Price;

            dialogText.Text = $"{dialogText.Text} {price}";

            if (GameEngine.MainCharacter.Money < price)
                okButton.Enabled = false;
        }
        
        private void okButton_Click_1(object sender, EventArgs e)
        {
            GameEngine.MainCharacter.Spend(price);
            
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}