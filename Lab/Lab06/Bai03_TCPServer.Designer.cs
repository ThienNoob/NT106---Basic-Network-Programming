namespace Lab06
{
    partial class Bai03_TCPServer
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
            this.buttonListen = new System.Windows.Forms.Button();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxScreen = new System.Windows.Forms.RichTextBox();
            this.textBoxEncriptedMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonListen
            // 
            this.buttonListen.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonListen.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonListen.Location = new System.Drawing.Point(660, 27);
            this.buttonListen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(197, 48);
            this.buttonListen.TabIndex = 1;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = false;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.ItemHeight = 20;
            this.listBoxMembers.Location = new System.Drawing.Point(14, 82);
            this.listBoxMembers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(215, 564);
            this.listBoxMembers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Members";
            // 
            // richTextBoxScreen
            // 
            this.richTextBoxScreen.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxScreen.Location = new System.Drawing.Point(237, 134);
            this.richTextBoxScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxScreen.Name = "richTextBoxScreen";
            this.richTextBoxScreen.ReadOnly = true;
            this.richTextBoxScreen.Size = new System.Drawing.Size(620, 512);
            this.richTextBoxScreen.TabIndex = 4;
            this.richTextBoxScreen.Text = "";
            // 
            // textBoxEncriptedMsg
            // 
            this.textBoxEncriptedMsg.Enabled = false;
            this.textBoxEncriptedMsg.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEncriptedMsg.Location = new System.Drawing.Point(237, 82);
            this.textBoxEncriptedMsg.Name = "textBoxEncriptedMsg";
            this.textBoxEncriptedMsg.Size = new System.Drawing.Size(620, 25);
            this.textBoxEncriptedMsg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(237, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encripted message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(237, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Messagses";
            // 
            // Bai03_TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(872, 677);
            this.Controls.Add(this.textBoxEncriptedMsg);
            this.Controls.Add(this.richTextBoxScreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMembers);
            this.Controls.Add(this.buttonListen);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Bai03_TCPServer";
            this.Text = "Bai03_TCPServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bai05_TCPServer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxScreen;
        private TextBox textBoxEncriptedMsg;
        private Label label2;
        private Label label3;
    }
}