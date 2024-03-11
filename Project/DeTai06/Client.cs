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

namespace DeTai06
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            textBoxServerIP.Focus();
            textBoxServerIP.SelectAll();
        }
        TcpClient client = null;
        byte[] buffer = new byte[102400];
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string serverIP = textBoxServerIP.Text;
                int serverPort = int.Parse("9999");
                client = new TcpClient(serverIP, serverPort);
                Task.Run(() => Listen());
                textBoxDomain.Enabled = true;
                buttonSend.Enabled = true;
                buttonConnect.Enabled = false;
                buttonConnect.BackColor = Color.Lime;
                buttonConnect.Text = "Connected";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Listen()
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;
            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AddMessage(message);
                }
                catch
                {
                    MessageBox.Show("Server has disconnected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    client.Close();
                    break;
                }
            }
        }
        private void AddMessage(string str)
        {

            if (InvokeRequired)
            {
                Invoke(new Action(() => AddMessage(str)));
                return;
            }
            textBoxIP.Text = str;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            textBoxIP.Text = String.Empty;
            string message = textBoxDomain.Text;
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(buffer, 0, buffer.Length);
        }
        private void textBoxServerIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBoxDomain.Focus();
                textBoxDomain.SelectAll();
            }
        }
        private void textBoxDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSend.PerformClick();
            }
        }
    }
}
