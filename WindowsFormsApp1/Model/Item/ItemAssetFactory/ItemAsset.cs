using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.WeaponType
{
    public class ItemAsset
    {
        private System.Windows.Forms.PictureBox pictureBox;
        
        public ItemAsset(Image objectAssetImage)
        {
            pictureBox = new PictureBox();
            
            pictureBox.BackgroundImage = objectAssetImage;
            pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox.Location = new System.Drawing.Point(271, 223);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new System.Drawing.Size(50, 50);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
        }
        
        public System.Windows.Forms.PictureBox PictureBox => pictureBox;
    }
}