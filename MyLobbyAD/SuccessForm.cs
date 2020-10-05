using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyLobbyAD
{
    public partial class SuccessForm : Form
    {
        public SuccessForm(string successMessage = "Success")
        {
            InitializeComponent();

            successLabel.Text = successMessage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
