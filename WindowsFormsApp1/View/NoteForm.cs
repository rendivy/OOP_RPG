using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();

            int length = 100;
            
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            noteText.Text = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[GameEngine.Rnd.Next(s.Length)]).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}