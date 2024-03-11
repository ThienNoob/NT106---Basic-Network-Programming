namespace Lab05
{
    partial class Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai01));
            this.btnSend = new System.Windows.Forms.Button();
            this.btnNewMail = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbBody = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(410, 8);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 60);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnNewMail
            // 
            this.btnNewMail.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnNewMail.Location = new System.Drawing.Point(520, 8);
            this.btnNewMail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNewMail.Name = "btnNewMail";
            this.btnNewMail.Size = new System.Drawing.Size(103, 58);
            this.btnNewMail.TabIndex = 13;
            this.btnNewMail.Text = "NewMail";
            this.btnNewMail.UseVisualStyleBackColor = true;
            this.btnNewMail.Click += new System.EventHandler(this.btnNewMail_Click);
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBody.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtBody.Location = new System.Drawing.Point(87, 122);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(537, 228);
            this.txtBody.TabIndex = 3;
            this.txtBody.Text = "Hello world";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtTo.Location = new System.Drawing.Point(85, 46);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(306, 24);
            this.txtTo.TabIndex = 1;
            this.txtTo.Text = "chucthien2@gmail.com";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtSubject.Location = new System.Drawing.Point(85, 86);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(537, 24);
            this.txtSubject.TabIndex = 2;
            this.txtSubject.Text = "Test";
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtFrom.Location = new System.Drawing.Point(85, 10);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(306, 24);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.Text = "tranchucthienmt@gmail.com";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbFrom.Location = new System.Drawing.Point(11, 15);
            this.lbFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(43, 16);
            this.lbFrom.TabIndex = 6;
            this.lbFrom.Text = "From";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbSubject.Location = new System.Drawing.Point(10, 88);
            this.lbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(58, 16);
            this.lbSubject.TabIndex = 5;
            this.lbSubject.Text = "Subject";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTo.Location = new System.Drawing.Point(11, 51);
            this.lbTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(25, 16);
            this.lbTo.TabIndex = 4;
            this.lbTo.Text = "To";
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Font = new System.Drawing.Font("Maiandra GD", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbBody.Location = new System.Drawing.Point(12, 122);
            this.lbBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(42, 16);
            this.lbBody.TabIndex = 3;
            this.lbBody.Text = "Body";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 357);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnNewMail);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbFrom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNewMail;
        private Button btnSend;
        private TextBox txtBody;
        private TextBox txtTo;
        private TextBox txtSubject;
        private TextBox txtFrom;
        private Label lbFrom;
        private Label lbSubject;
        private Label lbTo;
        private Label lbBody;
    }
}