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
    public partial class fBai3_Client : Form
    {
       
        public fBai3_Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread clientThread = new Thread(new ThreadStart(Connect));
            clientThread.Start();
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            btnSend.Enabled = true;
            txtMess.Enabled = true;
        }

        private void Connect()
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 9999);
            NetworkStream ns = tcpClient.GetStream();
            string message = "Connection accepted from: 127.0.0.1";
            byte[] data = Encoding.UTF8.GetBytes(message);
            ns.Write(data, 0, data.Length);
            tcpClient.Close();
            txtMess.Text = "";
            txtMess.Select();

        }
     

        private void btnSend_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse("127.0.0.1"),9999);
            NetworkStream ns = tcpClient.GetStream();
            string message = "From client: " + txtMess.Text;
            byte[] data = Encoding.ASCII.GetBytes(message);
            ns.Write(data, 0, data.Length);
            tcpClient.Close();
            txtMess.Text = "";
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 9999);
            byte[] message = Encoding.ASCII.GetBytes("Disconnected");
            NetworkStream ns = tcpClient.GetStream();
            ns.Write(message, 0, message.Length);
            ns.Close();
            tcpClient.Close();
            btnConnect.Enabled = true;
            btnSend.Enabled = false;
            txtMess.Enabled = false;
            btnDisconnect.Enabled = false;
            txtMess.Text = "";
            txtMess.Select();
                
           
        }

        private void txtMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                
            }
        }

        private void fBai3_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void fBai3_Client_Load(object sender, EventArgs e)
        {

        }

        private void fBai3_Client_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
