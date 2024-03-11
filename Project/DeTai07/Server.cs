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
using System.IO;

namespace DeTai07
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            buttonListen.Focus();
        }
        UdpClient udpClient;
        Thread thdUDPServer;
        public void serverThread()
        {
            udpClient = new UdpClient(12345);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = new byte[1048576];
                receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string receiveFilePath = Encoding.UTF8.GetString(receiveBytes);

                try
                {
                    byte[] responseFile = new byte[1048576];
                    responseFile = File.ReadAllBytes(receiveFilePath);
                    udpClient.Send(responseFile, responseFile.Length, RemoteIpEndPoint);
                    AddMess(receiveFilePath + " - Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    AddMess(receiveFilePath + " - Failed");
                }
            }
        }
        public void AddMess(string mess)
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            listBoxMess.Items.Add(formattedTime + ": " + mess);
        }
        private void buttonListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
            buttonListen.Enabled = false;
            buttonListen.BackColor = Color.Lime;
            buttonListen.Text = "Listening...";
        }
    }
}
