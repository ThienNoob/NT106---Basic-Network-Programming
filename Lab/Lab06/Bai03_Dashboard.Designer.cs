namespace Lab06
{
    partial class Bai03_Dashboard
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
            this.btOpenTCPClient = new System.Windows.Forms.Button();
            this.btOpenTCPServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpenTCPClient
            // 
            this.btOpenTCPClient.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenTCPClient.Location = new System.Drawing.Point(121, 128);
            this.btOpenTCPClient.Name = "btOpenTCPClient";
            this.btOpenTCPClient.Size = new System.Drawing.Size(448, 46);
            this.btOpenTCPClient.TabIndex = 3;
            this.btOpenTCPClient.Text = "Open new TCP client ";
            this.btOpenTCPClient.UseVisualStyleBackColor = true;
            this.btOpenTCPClient.Click += new System.EventHandler(this.btOpenTCPClient_Click);
            // 
            // btOpenTCPServer
            // 
            this.btOpenTCPServer.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenTCPServer.Location = new System.Drawing.Point(121, 47);
            this.btOpenTCPServer.Name = "btOpenTCPServer";
            this.btOpenTCPServer.Size = new System.Drawing.Size(448, 46);
            this.btOpenTCPServer.TabIndex = 2;
            this.btOpenTCPServer.Text = "Open TCP Server";
            this.btOpenTCPServer.UseVisualStyleBackColor = true;
            this.btOpenTCPServer.Click += new System.EventHandler(this.btOpenTCPServer_Click);
            // 
            // Bai05_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(691, 221);
            this.Controls.Add(this.btOpenTCPClient);
            this.Controls.Add(this.btOpenTCPServer);
            this.Name = "Bai05_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai05_Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenTCPClient;
        private System.Windows.Forms.Button btOpenTCPServer;
    }
}