namespace DeTai05
{
    partial class Message
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.labelCaption = new System.Windows.Forms.Label();
            this.bunifuLabelText = new Bunifu.UI.WinForms.BunifuLabel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaption.ForeColor = System.Drawing.Color.Blue;
            this.labelCaption.Location = new System.Drawing.Point(12, 9);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(69, 19);
            this.labelCaption.TabIndex = 0;
            this.labelCaption.Text = "Caption";
            // 
            // bunifuLabelText
            // 
            this.bunifuLabelText.AllowParentOverrides = false;
            this.bunifuLabelText.AutoEllipsis = false;
            this.bunifuLabelText.AutoSize = false;
            this.bunifuLabelText.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabelText.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabelText.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabelText.Location = new System.Drawing.Point(40, 46);
            this.bunifuLabelText.Name = "bunifuLabelText";
            this.bunifuLabelText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabelText.Size = new System.Drawing.Size(242, 73);
            this.bunifuLabelText.TabIndex = 2;
            this.bunifuLabelText.Text = "Text";
            this.bunifuLabelText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabelText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(132, 138);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(56, 38);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Message
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(323, 188);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.bunifuLabelText);
            this.Controls.Add(this.labelCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        internal System.Windows.Forms.Label labelCaption;
        internal Bunifu.UI.WinForms.BunifuLabel bunifuLabelText;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}