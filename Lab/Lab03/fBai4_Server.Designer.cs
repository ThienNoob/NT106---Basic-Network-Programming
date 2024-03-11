namespace Lab3
{
    partial class fBai4_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBai4_Server));
            btnListen = new Button();
            rtxtMess = new RichTextBox();
            lboxMember = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.BackColor = Color.Red;
            btnListen.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnListen.FlatAppearance.BorderSize = 5;
            btnListen.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnListen.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnListen.FlatStyle = FlatStyle.Flat;
            btnListen.Font = new Font("VNI-Avo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnListen.ForeColor = SystemColors.ActiveCaptionText;
            btnListen.Location = new Point(17, 13);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(87, 39);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = false;
            btnListen.Click += btnListen_Click;
            // 
            // rtxtMess
            // 
            rtxtMess.BackColor = SystemColors.ButtonHighlight;
            rtxtMess.Font = new Font("VNI-Awchon", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            rtxtMess.Location = new Point(12, 33);
            rtxtMess.Name = "rtxtMess";
            rtxtMess.Size = new Size(406, 256);
            rtxtMess.TabIndex = 1;
            rtxtMess.Text = "";
            // 
            // lboxMember
            // 
            lboxMember.Font = new Font("VNI-Awchon", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            lboxMember.FormattingEnabled = true;
            lboxMember.ItemHeight = 19;
            lboxMember.Location = new Point(424, 57);
            lboxMember.Name = "lboxMember";
            lboxMember.Size = new Size(152, 232);
            lboxMember.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("VNI-Awchon", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(424, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 26);
            label1.TabIndex = 3;
            label1.Text = "Members";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fBai4_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(589, 308);
            Controls.Add(label1);
            Controls.Add(lboxMember);
            Controls.Add(rtxtMess);
            Controls.Add(btnListen);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fBai4_Server";
            Text = "Server";
            FormClosed += fBai3_Server_FormClosed;
            Load += fServer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnListen;
        private RichTextBox rtxtMess;
        private ListBox lboxMember;
        private Label label1;
    }
}