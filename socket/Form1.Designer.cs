namespace wtel
{
    partial class Form1
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
            this.connector = new System.Windows.Forms.Button();
            this.inIP = new System.Windows.Forms.TextBox();
            this.inPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connector
            // 
            this.connector.Location = new System.Drawing.Point(12, 11);
            this.connector.Name = "connector";
            this.connector.Size = new System.Drawing.Size(75, 24);
            this.connector.TabIndex = 0;
            this.connector.Text = "Connect";
            this.connector.UseVisualStyleBackColor = true;
            this.connector.Click += new System.EventHandler(this.Connector_Click);
            // 
            // inIP
            // 
            this.inIP.Location = new System.Drawing.Point(93, 12);
            this.inIP.Name = "inIP";
            this.inIP.Size = new System.Drawing.Size(148, 23);
            this.inIP.TabIndex = 1;
            // 
            // inPort
            // 
            this.inPort.Location = new System.Drawing.Point(247, 13);
            this.inPort.Name = "inPort";
            this.inPort.Size = new System.Drawing.Size(100, 23);
            this.inPort.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(955, 541);
            this.Controls.Add(this.inPort);
            this.Controls.Add(this.inIP);
            this.Controls.Add(this.connector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button connector;
        private TextBox inIP;
        private TextBox inPort;
    }
}