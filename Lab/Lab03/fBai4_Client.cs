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
using Project;

namespace Lab3
{
    public partial class fBai4_Client : Form
    {

        public fBai4_Client()
        {
            InitializeComponent();
            btnSend.BringToFront();
            btnConnect.Select();
        }

        TcpClient client = null;
        byte[] buffer = new byte[1024];


        public void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.BackColor == Color.Red)
            {
                if (txtName.Text == "" || txtName.Text == "\n")
                {
                    MessageBox.Show("Invalid name");
                }
                else
                {
                    try
                    {

                        string serverIP = "127.0.0.1";
                        int serverPort = int.Parse("9999");
                        client = new TcpClient(serverIP, serverPort);
                        Task.Run(() => Listen());
                        string message = "\nNew member - " + txtName.Text;
                        byte[] buffer = Encoding.ASCII.GetBytes(message);
                        NetworkStream stream = client.GetStream();
                        stream.Write(buffer, 0, buffer.Length);
                        txtName.Enabled = false;
                        txtMess.Enabled = true;
                        //txtMess.Text = "";
                        btnSend.Enabled = true;

                        btnConnect.BackColor = Color.Lime;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to connect to server: " + ex.Message);
                    }
                }
            }
            else if (btnConnect.BackColor == Color.Lime)
            {
                SendMessage(txtName.Text + " has left the chat");
                client.Close();
                btnConnect.BackColor = Color.Red;
                btnSend.Enabled = false;
                txtMess.Enabled = false;


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
                    if (message.Contains("Server disconnected"))
                    {
                        btnConnect.Enabled = true;
                        btnSend.Enabled = false;
                        btnConnect.Select();
                        btnConnect.BackColor = Color.Red;
                        txtMess.Enabled = false;
                        Thread.Sleep(1000);
                        btnConnect.PerformClick();
                    }
                    AddMessage(message);
                }
                catch
                {

                    client.Close();
                    break;
                }
            }
        }

        private void AddMessage(string s)
        {

            if (InvokeRequired)
            {
                Invoke(new Action(() => AddMessage(s)));
                return;
            }
            rtxtMessages.Text += s + "\n";


        }




        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMess.Text == "" || txtMess.Text == "\n")
            {
                MessageBox.Show("Type your message");
            }

            else
            {
                string message = txtName.Text + ": " + txtMess.Text;
                SendMessage(message);
            }
        }


        //void CheckAdminstrator()

        void SendMessage(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(buffer, 0, buffer.Length);
            rtxtMessages.Text += message + "\n";
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




        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMess_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fBai5_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btnConnect.BackColor == Color.Lime)
            {
                SendMessage(txtName.Text + " has left the chat");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtMessages.Text = "";
            txtMess.Text = "";
        }
    }
}
