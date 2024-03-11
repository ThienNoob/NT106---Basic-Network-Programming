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
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            btnListen.Enabled = false;
        }
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            // khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];
            // tạo socket bên gửi
            Socket clientSocket;
            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
            listenerSocket.Bind(ipepServer);
            // Bắt đầu lắng nghe. Socket.Listen(int backlog)
            // Với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            listenerSocket.Listen(-1);
            // đồng ý kết nối
            clientSocket = listenerSocket.Accept();
            // nhận dữ liệu
            richTextBox1.Text = String.Concat(richTextBox1.Text, "New client connected\n");
            while (clientSocket.Connected)
            {
                String text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                richTextBox1.Text = String.Concat(richTextBox1.Text, text + "\n");

            }
            listenerSocket.Close();
        }
    }
}
