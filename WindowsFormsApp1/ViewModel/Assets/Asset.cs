using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Objects.Assets
{
    public class Asset
    {
        private System.Windows.Forms.PictureBox pictureBox;
        
        public Asset(Image objectAssetImage)
        {
            pictureBox = new PictureBox();
            
            pictureBox.BackgroundImage = objectAssetImage;
            pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox.Location = new System.Drawing.Point(271, 223);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new System.Drawing.Size(100, 50);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
        }
        
        public System.Windows.Forms.PictureBox PictureBox => pictureBox;
    }
}