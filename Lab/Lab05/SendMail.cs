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
using MailKit.Net.Smtp;

namespace Lab05
{
    public partial class SendMail : Form
    {
        public SendMail(string from, string to)
        {
            InitializeComponent();
            if (to == "flag")
            {
                textBoxFrom.Text = "minhthienluu2406@gmail.com";
            }
            else
            {
                textBoxFrom.Text = to;
                textBoxTo.Text = from;
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);
            smtpClient.Authenticate("minhthienluu2406@gmail.com", "hajaatkifjynnnin");
            var mess = new MimeMessage();
            mess.From.Add(new MailboxAddress("Luu Minh Thien", textBoxFrom.Text));
            mess.To.Add(new MailboxAddress("", textBoxTo.Text));
            mess.Subject = textBoxSubject.Text;
            if(!checkBoxHTML.Checked)
            {
                mess.Body = new TextPart("plain")
                {
                    Text = richTextBoxMessage.Text
                };
            }
            mess.Body = new TextPart("html")
            {
                Text = richTextBoxMessage.Text
            };
            smtpClient.Send(mess);
            MessageBox.Show("Đã gửi thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
