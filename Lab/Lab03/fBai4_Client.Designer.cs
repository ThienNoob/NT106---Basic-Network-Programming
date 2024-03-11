namespace Lab3
{
    partial class fBai4_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBai4_Client));
            btnSend = new Button();
            txtMess = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            btnConnect = new Button();
            rtxtMessages = new RichTextBox();
            btnClear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Transparent;
            btnSend.BackgroundImage = (Image)resources.GetObject("btnSend.BackgroundImage");
            btnSend.BackgroundImageLayout = ImageLayout.Stretch;
            btnSend.Enabled = false;
            btnSend.FlatAppearance.BorderColor = Color.White;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatAppearance.MouseDownBackColor = Color.White;
            btnSend.FlatAppearance.MouseOverBackColor = Color.White;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Location = new Point(390, 87);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(40, 20);
            btnSend.TabIndex = 3;
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtMess
            // 
            txtMess.BackColor = SystemColors.ButtonHighlight;
            txtMess.Enabled = false;
            txtMess.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtMess.Location = new Point(2, 84);
            txtMess.Multiline = true;
            txtMess.Name = "txtMess";
            txtMess.Size = new Size(434, 27);
            txtMess.TabIndex = 2;
            txtMess.TextChanged += txtMess_TextChanged;
            txtMess.KeyDown += txtMess_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(2, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Message";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(2, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 22);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnConnect
            // 
            btnConnect.AutoSize = true;
            btnConnect.BackColor = Color.Red;
            btnConnect.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(204, 30);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(102, 30);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // rtxtMessages
            // 
            rtxtMessages.BackColor = SystemColors.ButtonHighlight;
            rtxtMessages.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rtxtMessages.Location = new Point(2, 112);
            rtxtMessages.Name = "rtxtMessages";
            rtxtMessages.Size = new Size(434, 149);
            rtxtMessages.TabIndex = 4;
            rtxtMessages.Text = "";
            rtxtMessages.TextChanged += richTextBox1_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnClear.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnClear.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(312, 30);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(49, 30);
            btnClear.TabIndex = 6;
            btnClear.TextAlign = ContentAlignment.TopCenter;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2, 16);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // fClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(443, 273);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(rtxtMessages);
            Controls.Add(btnConnect);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtMess);
            Controls.Add(btnSend);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fClient";
            Text = "Client";
            FormClosed += fBai5_Client_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnSend;
        public TextBox txtMess;
        public Label label2;
        public TextBox txtName;
        public Button btnConnect;
        public RichTextBox rtxtMessages;
        private Button btnClear;
        private Label label1;
    }
}