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

namespace DeTai01
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            textBoxIP.Focus();
            textBoxIP.SelectAll();
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            string hostIP;
            int hostPort;
            try
            {
                hostIP = textBoxIP.Text;
                hostPort = Int32.Parse(textBoxPort.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập địa chỉ IP và số hiệu port đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UdpClient udpClient = new UdpClient();
            Byte[] sendBytes = System.Text.Encoding.UTF8.GetBytes(textBoxMessage.Text);
            udpClient.Send(sendBytes, sendBytes.Length, hostIP, hostPort);
            textBoxMessage.Text = string.Empty;
            textBoxMessage.Select();
        }
        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSend.PerformClick();
            }
        }
    }
}
