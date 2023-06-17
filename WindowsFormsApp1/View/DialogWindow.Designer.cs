using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class DialogWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.dialogText = new System.Windows.Forms.Label();
            this.dialogPicture = new System.Windows.Forms.PictureBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dialogPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(350, 129);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(126, 45);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Купить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click_1);
            // 
            // dialogText
            // 
            this.dialogText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dialogText.Location = new System.Drawing.Point(12, 46);
            this.dialogText.Name = "dialogText";
            this.dialogText.Size = new System.Drawing.Size(405, 35);
            this.dialogText.TabIndex = 1;
            this.dialogText.Text = "label1";
            // 
            // dialogPicture
            // 
            this.dialogPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dialogPicture.Location = new System.Drawing.Point(12, 84);
            this.dialogPicture.Name = "dialogPicture";
            this.dialogPicture.Size = new System.Drawing.Size(86, 90);
            this.dialogPicture.TabIndex = 2;
            this.dialogPicture.TabStop = false;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(12, 9);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(464, 23);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "label1";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(218, 129);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 45);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 186);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.dialogPicture);
            this.Controls.Add(this.dialogText);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 221);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 221);
            this.Name = "DialogWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Взаимодействие";
            ((System.ComponentModel.ISupportInitialize)(this.dialogPicture)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.Label moneyLabel;

        private System.Windows.Forms.PictureBox dialogPicture;

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label dialogText;

        #endregion
    }
}