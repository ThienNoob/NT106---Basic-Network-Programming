using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Bai03_Dashboard : Form
    {
        public Bai03_Dashboard()
        {
            InitializeComponent();
        }

        private void btOpenTCPServer_Click(object sender, EventArgs e)
        {
            Bai03_TCPServer bai03_TCPServer = new Bai03_TCPServer();
            bai03_TCPServer.Show();
        }

        private void btOpenTCPClient_Click(object sender, EventArgs e)
        {
            Bai03_TCPClient bai03_TCPClient = new Bai03_TCPClient();
            bai03_TCPClient.Show();
        }
    }
}
