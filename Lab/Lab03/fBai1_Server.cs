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
using System.Threading;

namespace Lab3
{
    public partial class fBai1_Server : Form
    {
        public fBai1_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.IsBackground = true;
            thdUDPServer.Start();
        }
        UdpClient udpClient;
        Thread thdUDPServer;

        public void serverThread()
        {
            int Port;
            try
            {
               Port= Int32.Parse(txtPort.Text);
                btnListen.Enabled = false;
                
            }
            catch
            {
                MessageBox.Show("Nhập số Port ");
                return;
            }
            udpClient = new UdpClient(Port);

            while ( true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = System.Text.Encoding.UTF8.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();
                rtxtReceive.Text += "\r\n" + mess;
            }
            udpClient.Close();
        }
        
        
    }
}
