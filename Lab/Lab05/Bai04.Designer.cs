
namespace Lab05
{
    partial class Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDangNhap = new System.Windows.Forms.GroupBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCaiDat = new System.Windows.Forms.GroupBox();
            this.comboBoxPort_SMTP = new System.Windows.Forms.ComboBox();
            this.comboBoxPort_IMAP = new System.Windows.Forms.ComboBox();
            this.textBoxSMTP = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxIMAP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDangNhap.SuspendLayout();
            this.groupBoxCaiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDangNhap
            // 
            this.groupBoxDangNhap.Controls.Add(this.buttonLogOut);
            this.groupBoxDangNhap.Controls.Add(this.buttonRefresh);
            this.groupBoxDangNhap.Controls.Add(this.buttonSend);
            this.groupBoxDangNhap.Controls.Add(this.textBoxMatKhau);
            this.groupBoxDangNhap.Controls.Add(this.textBoxTaiKhoan);
            this.groupBoxDangNhap.Controls.Add(this.label2);
            this.groupBoxDangNhap.Controls.Add(this.label1);
            this.groupBoxDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDangNhap.Location = new System.Drawing.Point(14, 15);
            this.groupBoxDangNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDangNhap.Name = "groupBoxDangNhap";
            this.groupBoxDangNhap.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDangNhap.Size = new System.Drawing.Size(374, 144);
            this.groupBoxDangNhap.TabIndex = 2;
            this.groupBoxDangNhap.TabStop = false;
            this.groupBoxDangNhap.Text = "Đăng nhập";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(245, 99);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(122, 29);
            this.buttonLogOut.TabIndex = 10;
            this.buttonLogOut.Text = "Đăng Xuất";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Visible = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(127, 99);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(89, 29);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Visible = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(16, 99);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(79, 29);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Gửi mail";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Visible = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(103, 62);
            this.textBoxMatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(264, 22);
            this.textBoxMatKhau.TabIndex = 2;
            this.textBoxMatKhau.Text = "hajaatkifjynnnin";
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(103, 28);
            this.textBoxTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(264, 22);
            this.textBoxTaiKhoan.TabIndex = 1;
            this.textBoxTaiKhoan.Text = "minhthienluu2406@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // groupBoxCaiDat
            // 
            this.groupBoxCaiDat.Controls.Add(this.comboBoxPort_SMTP);
            this.groupBoxCaiDat.Controls.Add(this.comboBoxPort_IMAP);
            this.groupBoxCaiDat.Controls.Add(this.textBoxSMTP);
            this.groupBoxCaiDat.Controls.Add(this.buttonLogIn);
            this.groupBoxCaiDat.Controls.Add(this.textBoxIMAP);
            this.groupBoxCaiDat.Controls.Add(this.label5);
            this.groupBoxCaiDat.Controls.Add(this.label6);
            this.groupBoxCaiDat.Controls.Add(this.label4);
            this.groupBoxCaiDat.Controls.Add(this.label3);
            this.groupBoxCaiDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCaiDat.Location = new System.Drawing.Point(396, 15);
            this.groupBoxCaiDat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCaiDat.Name = "groupBoxCaiDat";
            this.groupBoxCaiDat.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCaiDat.Size = new System.Drawing.Size(501, 144);
            this.groupBoxCaiDat.TabIndex = 3;
            this.groupBoxCaiDat.TabStop = false;
            this.groupBoxCaiDat.Text = "Cài đặt";
            // 
            // comboBoxPort_SMTP
            // 
            this.comboBoxPort_SMTP.FormattingEnabled = true;
            this.comboBoxPort_SMTP.Location = new System.Drawing.Point(310, 60);
            this.comboBoxPort_SMTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxPort_SMTP.Name = "comboBoxPort_SMTP";
            this.comboBoxPort_SMTP.Size = new System.Drawing.Size(183, 24);
            this.comboBoxPort_SMTP.TabIndex = 6;
            this.comboBoxPort_SMTP.Text = "465";
            // 
            // comboBoxPort_IMAP
            // 
            this.comboBoxPort_IMAP.FormattingEnabled = true;
            this.comboBoxPort_IMAP.Location = new System.Drawing.Point(64, 60);
            this.comboBoxPort_IMAP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxPort_IMAP.Name = "comboBoxPort_IMAP";
            this.comboBoxPort_IMAP.Size = new System.Drawing.Size(174, 24);
            this.comboBoxPort_IMAP.TabIndex = 5;
            this.comboBoxPort_IMAP.Text = "993";
            // 
            // textBoxSMTP
            // 
            this.textBoxSMTP.Location = new System.Drawing.Point(310, 28);
            this.textBoxSMTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSMTP.Name = "textBoxSMTP";
            this.textBoxSMTP.Size = new System.Drawing.Size(183, 22);
            this.textBoxSMTP.TabIndex = 4;
            this.textBoxSMTP.Text = "smtp.gmail.com";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(10, 99);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(119, 29);
            this.buttonLogIn.TabIndex = 7;
            this.buttonLogIn.Text = "Đăng nhập";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxIMAP
            // 
            this.textBoxIMAP.Location = new System.Drawing.Point(64, 31);
            this.textBoxIMAP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIMAP.Name = "textBoxIMAP";
            this.textBoxIMAP.Size = new System.Drawing.Size(174, 22);
            this.textBoxIMAP.TabIndex = 3;
            this.textBoxIMAP.Text = "imap.gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "SMTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "IMAP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.From,
            this.Subject,
            this.Time,
            this.Body});
            this.dataGridView1.Location = new System.Drawing.Point(14, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 442);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // stt
            // 
            this.stt.HeaderText = " #";
            this.stt.Name = "stt";
            this.stt.Width = 40;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.Width = 250;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Width = 270;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Body
            // 
            this.Body.HeaderText = "Body";
            this.Body.Name = "Body";
            this.Body.Width = 180;
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxCaiDat);
            this.Controls.Add(this.groupBoxDangNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.groupBoxDangNhap.ResumeLayout(false);
            this.groupBoxDangNhap.PerformLayout();
            this.groupBoxCaiDat.ResumeLayout(false);
            this.groupBoxCaiDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDangNhap;
        private System.Windows.Forms.GroupBox groupBoxCaiDat;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.TextBox textBoxTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPort_SMTP;
        private System.Windows.Forms.ComboBox comboBoxPort_IMAP;
        private System.Windows.Forms.TextBox textBoxSMTP;
        private System.Windows.Forms.TextBox textBoxIMAP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSend;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Body;
    }
}