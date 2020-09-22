using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyLobbyAD
{
    public partial class ActiveDirectoryForm : Form
    {
        public ActiveDirectoryForm()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success!");
        }
    }
}
