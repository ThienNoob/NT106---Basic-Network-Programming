using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace AppChat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetAccount();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        public class Account
        {
            public string username { get; set; }
            public string password { get; set; }
            public string name { get; set; }
            public Image avt { get; set; }
            public Account(string Username, string Password, string Name, Image Avt)
            {
                username = Username;
                password = Password;
                avt = Avt;
                name = Name;
            }
        }
        Account[] accounts = new Account[3];
        public void SetAccount() 
        {
            accounts[0] = new Account("luuminhthien", "luuminhthien", "Lưu Minh Thiện", Properties.Resources.luuminhthien);
            accounts[1] = new Account("tranchucthien", "tranchucthien", "Trần Chức Thiện", Properties.Resources.tranchucthien);
            accounts[2] = new Account("vuonghoangthinh", "vuonghoangthinh", "Vương Hoàng Thịnh", Properties.Resources.vuonghoangthinh);
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        { 
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                Server formServer = new Server();
                formServer.Show();
                return;
            }
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].username == textBoxUsername.Text && accounts[i].password == textBoxPassword.Text)
                {
                    Client formClient = new Client();
                    formClient.Show();
                    formClient.labelName.Text = accounts[i].name;
                    formClient.pictureBoxAvt.Image = accounts[i].avt;
                    return;
                }
            }
            Message msg = new Message();
            msg.labelCaption.Text = "Login Failed";
            msg.bunifuLabelText.Text = "Your username or password is incorrect. Please try again.";
            msg.ShowDialog();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBoxPassword.Focus();
                textBoxPassword.SelectAll();
            }
        }
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
