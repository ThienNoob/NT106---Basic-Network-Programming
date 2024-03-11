namespace Lab1
{
    partial class fBai4
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbB_loaixe = new System.Windows.Forms.ComboBox();
            this.cbB_LoaiXang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_tien = new System.Windows.Forms.TextBox();
            this.tx_soKm = new System.Windows.Forms.TextBox();
            this.tB_dungtich = new System.Windows.Forms.TextBox();
            this.tB_muctieuhao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(507, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dung tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại xăng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tiền phải trả";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 80);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thông tin tỉ giá xăng dầu\r\n- Xăng RON 95-III: 29,830 đồng/lít\r\n- Xăng E5 RON 92-I" +
    "I: 26,070 đồng/lít\r\n- Dầu DO 0,05S-II: 21,310 đồng/lít";
            // 
            // cbB_loaixe
            // 
            this.cbB_loaixe.FormattingEnabled = true;
            this.cbB_loaixe.Location = new System.Drawing.Point(209, 196);
            this.cbB_loaixe.Name = "cbB_loaixe";
            this.cbB_loaixe.Size = new System.Drawing.Size(361, 28);
            this.cbB_loaixe.TabIndex = 2;
            this.cbB_loaixe.SelectedValueChanged += new System.EventHandler(this.cbB_loaixe_SelectedValueChanged);
            // 
            // cbB_LoaiXang
            // 
            this.cbB_LoaiXang.FormattingEnabled = true;
            this.cbB_LoaiXang.Location = new System.Drawing.Point(209, 347);
            this.cbB_LoaiXang.Name = "cbB_LoaiXang";
            this.cbB_LoaiXang.Size = new System.Drawing.Size(361, 28);
            this.cbB_LoaiXang.TabIndex = 3;
            this.cbB_LoaiXang.SelectedIndexChanged += new System.EventHandler(this.cbB_LoaiXang_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số km đi được";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // tB_tien
            // 
            this.tB_tien.Enabled = false;
            this.tB_tien.Location = new System.Drawing.Point(209, 456);
            this.tB_tien.Name = "tB_tien";
            this.tB_tien.Size = new System.Drawing.Size(361, 27);
            this.tB_tien.TabIndex = 5;
            // 
            // tx_soKm
            // 
            this.tx_soKm.Enabled = false;
            this.tx_soKm.Location = new System.Drawing.Point(209, 406);
            this.tx_soKm.Name = "tx_soKm";
            this.tx_soKm.Size = new System.Drawing.Size(361, 27);
            this.tx_soKm.TabIndex = 5;
            // 
            // tB_dungtich
            // 
            this.tB_dungtich.Enabled = false;
            this.tB_dungtich.Location = new System.Drawing.Point(209, 243);
            this.tB_dungtich.Name = "tB_dungtich";
            this.tB_dungtich.Size = new System.Drawing.Size(361, 27);
            this.tB_dungtich.TabIndex = 5;
            // 
            // tB_muctieuhao
            // 
            this.tB_muctieuhao.Enabled = false;
            this.tB_muctieuhao.Location = new System.Drawing.Point(209, 289);
            this.tB_muctieuhao.Name = "tB_muctieuhao";
            this.tB_muctieuhao.Size = new System.Drawing.Size(361, 27);
            this.tB_muctieuhao.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mức tiêu hao nhiên liệu";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(22, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nạp dữ liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fBai4
            // 
            this.ClientSize = new System.Drawing.Size(644, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_soKm);
            this.Controls.Add(this.tB_muctieuhao);
            this.Controls.Add(this.tB_dungtich);
            this.Controls.Add(this.tB_tien);
            this.Controls.Add(this.cbB_LoaiXang);
            this.Controls.Add(this.cbB_loaixe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fBai4";
            this.Text = "Tính tiền xăng";
            this.Load += new System.EventHandler(this.fBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox cbB_loaixe;
        private ComboBox cbB_LoaiXang;
        private Label label7;
        private TextBox tB_tien;
        private TextBox tx_soKm;
        private TextBox tB_dungtich;
        private TextBox tB_muctieuhao;
        private Label label5;
        private Button button1;
    }
}