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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            serverEndpoint = new IPEndPoint(IPAddress.Parse(textBoxServerIP.Text), 12345);
            textBoxServerIP.Focus();
            textBoxServerIP.SelectAll();
        }
        private UdpClient udpClient;
        IPEndPoint serverEndpoint;
        DateTime dt;
        public void Receive()
        {
            while (true)
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] receiveFile = new byte[1048576];
                receiveFile = udpClient.Receive(ref remoteEP);

                string savePath = textBoxSaveAt.Text;

                try
                {
                    File.WriteAllBytes(savePath, receiveFile);
                    MessageBox.Show("File has been downloaded successfully!\nSaved at: " + savePath, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            textBoxSaveAt.Text = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveAt.Text = sfd.FileName;
            }
            try
            {
                serverEndpoint = new IPEndPoint(IPAddress.Parse(textBoxServerIP.Text), 12345);
                udpClient = new UdpClient();

                string mess = textBoxServerFilePath.Text;
                Byte[] sendBytes = Encoding.UTF8.GetBytes(mess);
                udpClient.Send(sendBytes, sendBytes.Length, serverEndpoint);

                Thread.Sleep(200);

                Thread thread = new Thread(new ThreadStart(Receive));
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void Client_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBoxServerFilePath.Focus();
                textBoxServerFilePath.SelectAll();
            }
        }
        private void textBoxServerFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSend.PerformClick();
            }
        }
    }
}
