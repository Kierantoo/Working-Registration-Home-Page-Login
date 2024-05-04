using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Login_Page
{
    partial class Home
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

            this.MC = new System.Windows.Forms.Button();
            this.CD = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.Button();
            this.PC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // My Collection 
            // 
            this.MC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MC.Location = new System.Drawing.Point(25, 110);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(250, 50);
            this.MC.TabIndex = 0;
            this.MC.Text = "My Collection";
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.MC_Click);
            // 
            // Card Database 
            // 
            this.CD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CD.Location = new System.Drawing.Point(25, 170);
            this.CD.Name = "CD";
            this.CD.Size = new System.Drawing.Size(250, 50);
            this.CD.TabIndex = 1;
            this.CD.Text = "Card Database";
            this.CD.UseVisualStyleBackColor = true;
            this.CD.Click += new System.EventHandler(this.CD_Click);
            // 
            // Mail
            // 
            this.Mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Mail.Location = new System.Drawing.Point(25, 230);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(250, 50);
            this.Mail.TabIndex = 2;
            this.Mail.Text = "Mail";
            this.Mail.UseVisualStyleBackColor = true;
            this.Mail.Click += new System.EventHandler(this.Mail_Click);
            // 
            // Popular cards
            // 
            this.PC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PC.Location = new System.Drawing.Point(25, 300);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(250, 50);
            this.PC.TabIndex = 3;
            this.PC.Text = "Popular Cards";
            this.PC.UseVisualStyleBackColor = true;
            this.PC.Click += new System.EventHandler(this.PC_Click);
            // 
            // Home Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.CD);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.PC);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button CD;
        private System.Windows.Forms.Button Mail;
        private System.Windows.Forms.Button PC;
    }
}

