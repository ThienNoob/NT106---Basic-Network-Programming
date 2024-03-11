using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai02
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void buttonServer_Click(object sender, EventArgs e)
        {
            Server formServer = new Server();
            buttonServer.Enabled = false;
            formServer.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client formClient = new Client();
            formClient.Show();
        }
    }
}
