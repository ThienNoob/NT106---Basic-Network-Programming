using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChat
{
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        public int check = 0;
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "admin")
            {
                check = 1;
                Close();
                return;
            }
            Message msg = new Message();
            msg.labelCaption.Text = "Incorrect password";
            msg.bunifuLabelText.Text = "Admin's password is incorrect. Please try again.";
            msg.ShowDialog();
        }
    }
}
