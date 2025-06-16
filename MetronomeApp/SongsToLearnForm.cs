using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetronomeApp
{
    public partial class SongsToLearnForm : Form
    {
        public SongsToLearnForm()
        {
            InitializeComponent();
            this.Load += SongsToLearnForm_Load;
            focusTextBox.Visible = false;
            this.ActiveControl = focusTextBox;
        }

        private void SongsToLearnForm_Load(object sender, EventArgs e)
        {
            songsToLearnTextBox.Text = Properties.Settings.Default.SongsToLearn;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SongsToLearn = songsToLearnTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
