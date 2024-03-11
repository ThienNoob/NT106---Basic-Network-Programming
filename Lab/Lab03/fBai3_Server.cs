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
    public partial class fBai3_Server : Form
    {
        public fBai3_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Receive));
            thread.Start();

            rtxtMess.Text = "Server Started" + "\n";
            btnListen.Enabled = false;
        }

        private void Receive()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 9999);
            tcpListener.Start();
            
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                NetworkStream ns = tcpClient.GetStream();
                byte[] data = new byte[1024];
                int length = ns.Read(data, 0, data.Length);
                string message = Encoding.UTF8.GetString(data, 0, length);
                rtxtMess.Text += message + "\n";
                if (message == "Disconnected")
                {
                    tcpClient.Close();
                }
            }
        }

        private void fBai3_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void rtxtMess_TextChanged(object sender, EventArgs e)
        {

        }

        private void fBai3_Server_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }
    }
}
