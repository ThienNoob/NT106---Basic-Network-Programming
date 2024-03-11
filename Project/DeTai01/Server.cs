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

namespace DeTai01
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            textBoxPort.Focus();
            textBoxPort.SelectAll();
        }
        private void buttonListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.IsBackground = true;
            thdUDPServer.Start();
            buttonListen.Enabled = false;
            buttonListen.BackColor = Color.Lime;
            buttonListen.Text = "Listening...";
        }
        UdpClient udpClient;
        Thread thdUDPServer;
        public void serverThread()
        {
            int Port;
            try
            {
                Port = Int32.Parse(textBoxPort.Text);
                buttonListen.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hiệu port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            udpClient = new UdpClient(Port);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = System.Text.Encoding.UTF8.GetString(receiveBytes);
                stringHanding(returnData);
                AddMess(returnData);
                
            }
            udpClient.Close();
        }
        void stringHanding(string s)
        {
            if (s.Contains("SHUTDOWN"))
            {
                MessageBox.Show("Server will be shutdown.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Thread.Sleep(1000);
                Close();
            }
            else if (s.Contains("#"))
            {
                try
                {
                    string[] strings = s.Split('#');
                    string filepath = strings[1];
                    MessageBox.Show(GetType(filepath), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(GetType(filepath), filepath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public string GetType(string filepath)
        {
            string[] str = filepath.Split('.');
            string type = "";
            switch (str[1])
            {
                case "txt":
                    type = "notepad.exe";
                    break;
                case "docx":
                    type = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
                    break;
                case "xlsx":
                    type = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";
                    break;
                case "pptx":
                    type = @"C:\Program Files\Microsoft Office\root\Office16\POWERPNT.EXE";
                    break;
                case "pdf":
                    type = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
                    break;
                case "jpg":
                case "jpeg":
                case "png":
                case "gif":
                    type = "photos.exe"; // MS Paint
                    break;
                // Thêm các kiểu dữ liệu khác tại đây
                default:
                    type = "explorer.exe"; // Ứng dụng mặc định khi không có kiểu dữ liệu tương ứng
                    break;
            }
            return type;
        }
        void AddMess(string s)
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            listBoxMess.Items.Add(formattedTime + ": " + s);
        }
    }
}
