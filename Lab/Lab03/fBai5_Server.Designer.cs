namespace Lab3
{
    partial class fBai5_Server
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
            this.btnListen = new System.Windows.Forms.Button();
            this.rtxtMess = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.BackColor = System.Drawing.Color.LightGray;
            this.btnListen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListen.Location = new System.Drawing.Point(423, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(137, 49);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = false;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // rtxtMess
            // 
            this.rtxtMess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtxtMess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtxtMess.Location = new System.Drawing.Point(12, 67);
            this.rtxtMess.Name = "rtxtMess";
            this.rtxtMess.Size = new System.Drawing.Size(548, 371);
            this.rtxtMess.TabIndex = 1;
            this.rtxtMess.Text = "";
            // 
            // fBai5_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.rtxtMess);
            this.Controls.Add(this.btnListen);
            this.Name = "fBai5_Server";
            this.Text = "Bai5_Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fBai3_Server_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListen;
        private RichTextBox rtxtMess;
    }
}