namespace Lab06
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBai01 = new System.Windows.Forms.Button();
            this.buttonBai03 = new System.Windows.Forms.Button();
            this.buttonBai02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU LAB06";
            // 
            // buttonBai01
            // 
            this.buttonBai01.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBai01.Location = new System.Drawing.Point(82, 132);
            this.buttonBai01.Name = "buttonBai01";
            this.buttonBai01.Size = new System.Drawing.Size(121, 46);
            this.buttonBai01.TabIndex = 1;
            this.buttonBai01.Text = "Bài 1";
            this.buttonBai01.UseVisualStyleBackColor = true;
            this.buttonBai01.Click += new System.EventHandler(this.buttonBai01_Click);
            // 
            // buttonBai03
            // 
            this.buttonBai03.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBai03.Location = new System.Drawing.Point(499, 132);
            this.buttonBai03.Name = "buttonBai03";
            this.buttonBai03.Size = new System.Drawing.Size(121, 46);
            this.buttonBai03.TabIndex = 3;
            this.buttonBai03.Text = "Bài 3";
            this.buttonBai03.UseVisualStyleBackColor = true;
            this.buttonBai03.Click += new System.EventHandler(this.buttonBai03_Click);
            // 
            // buttonBai02
            // 
            this.buttonBai02.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBai02.Location = new System.Drawing.Point(290, 132);
            this.buttonBai02.Name = "buttonBai02";
            this.buttonBai02.Size = new System.Drawing.Size(121, 46);
            this.buttonBai02.TabIndex = 2;
            this.buttonBai02.Text = "Bài 2";
            this.buttonBai02.UseVisualStyleBackColor = true;
            this.buttonBai02.Click += new System.EventHandler(this.buttonBai02_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 253);
            this.Controls.Add(this.buttonBai03);
            this.Controls.Add(this.buttonBai02);
            this.Controls.Add(this.buttonBai01);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonBai01;
        private Button buttonBai03;
        private Button buttonBai02;
    }
}