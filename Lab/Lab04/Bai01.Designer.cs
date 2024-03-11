namespace Lab04
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btGET = new System.Windows.Forms.Button();
            this.rtbXuat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbURL.Location = new System.Drawing.Point(12, 25);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(687, 27);
            this.tbURL.TabIndex = 0;
            // 
            // btGET
            // 
            this.btGET.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGET.Location = new System.Drawing.Point(716, 23);
            this.btGET.Name = "btGET";
            this.btGET.Size = new System.Drawing.Size(117, 32);
            this.btGET.TabIndex = 1;
            this.btGET.Text = "GET";
            this.btGET.UseVisualStyleBackColor = true;
            this.btGET.Click += new System.EventHandler(this.btGET_Click);
            // 
            // rtbXuat
            // 
            this.rtbXuat.Location = new System.Drawing.Point(13, 62);
            this.rtbXuat.Name = "rtbXuat";
            this.rtbXuat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbXuat.Size = new System.Drawing.Size(819, 501);
            this.rtbXuat.TabIndex = 2;
            this.rtbXuat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            // 
            // Bai01
            // 
            this.AcceptButton = this.btGET;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbXuat);
            this.Controls.Add(this.btGET);
            this.Controls.Add(this.tbURL);
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbURL;
        private Button btGET;
        private RichTextBox rtbXuat;
        private Label label1;
    }
}