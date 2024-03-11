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
using System.Net.Sockets;
namespace Lab3
{
    public partial class fBai1_Client : Form
    {
        public fBai1_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string hostIP;
            int hostPort;
            try
            {
                hostIP= txtIP.Text;
                hostPort = Int32.Parse(txtPort.Text);
            }
            catch
            {
                MessageBox.Show("Nhập địa chỉ IP và số Port theo đúng format");
                return;
            }
            
            UdpClient udpClient = new UdpClient();
            Byte[] sendBytes = System.Text.Encoding.UTF8.GetBytes(txtMess.Text);
            udpClient.Send(sendBytes, sendBytes.Length, hostIP, hostPort);
            txtMess.Text = "";
            txtMess.Select();

        }

        private void txtMess_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend.PerformClick();
        }
    }
}
