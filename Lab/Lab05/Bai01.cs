using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;

namespace Lab05
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient();
            client.Connect("smtp.gmail.com", 465, true); // smtp host, port, use ssl.
            client.Authenticate("tranchucthienmt@gmail.com", "eqqxhuikvbgmpqbp"); // gmail account, app password
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Brothers", txtFrom.Text));
            message.To.Add(new MailboxAddress("", txtTo.Text));
            message.Subject = txtSubject.Text;
            message.Body = new TextPart("plain") // gửi ở dạng plain text, hoặc có thể thay bằng “html” nếu muốn gửi email dạng html
            {
                Text = txtBody.Text
            };
            client.Send(message);
            MessageBox.Show("Mail đã được gửi thành công !");
        }
        private void btnNewMail_Click(object sender, EventArgs e)
        {
            txtBody.Text = "";
            txtTo.Text = "";
            txtSubject.Text = "";
            txtTo.Select();
        }
    }
}

