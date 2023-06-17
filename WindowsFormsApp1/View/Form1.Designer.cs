namespace WindowsFormsApp1
{ 
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.hpBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // hpBar
            // 
            this.hpBar.BackColor = System.Drawing.Color.Red;
            this.hpBar.Location = new System.Drawing.Point(16, 15);
            this.hpBar.Margin = new System.Windows.Forms.Padding(4);
            this.hpBar.Name = "hpBar";
            this.hpBar.Size = new System.Drawing.Size(576, 42);
            this.hpBar.TabIndex = 0;
            this.hpBar.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.hpBar);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HITSrpg";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.PlayerAttack);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ProgressBar hpBar;


        private System.Windows.Forms.ColorDialog colorDialog1;

        #endregion
    }
}