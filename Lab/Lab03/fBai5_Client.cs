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
    public partial class fBai5_Client : Form
    {
       
        public fBai5_Client()
        {
            InitializeComponent();
        }

        TcpClient client = null;
        byte[] buffer = new byte[1024];

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            try
            {
               
                string serverIP = "127.0.0.1";
                int serverPort = int.Parse("9999");
                client = new TcpClient(serverIP, serverPort);
                Task.Run(() => Listen());
                string message = "\nNew client connected from: 127.0.0.1 - " + txtName.Text;
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
                txtName.Enabled = false;
                txtMess.Enabled = true;
                //txtMess.Text = "";
                btnSend.Enabled = true;
                btnConnect.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server: " + ex.Message);
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
                    MessageBox.Show("Server has disconnected.");
                    client.Close();
                    break;
                }
            }
        }

        private void AddMessage(string s)
        {

            if (InvokeRequired)
            {
                Invoke(new Action(() =>AddMessage(s)));
                return;
            }
            richTextBox1.Text += s + "\n";


        }




        private void btnSend_Click(object sender, EventArgs e)
        {
           
            string message = txtName.Text + ": " + txtMess.Text;
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(buffer, 0, buffer.Length);
            richTextBox1.Text += message + "\n";
            txtMess.Text = "";

            
            
            
        }

        private void txtMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMess.Text.Contains("\n"))
                txtMess.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }


        private void fBai3_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close();
           
        }

        private void fBai5_Client_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMess_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
