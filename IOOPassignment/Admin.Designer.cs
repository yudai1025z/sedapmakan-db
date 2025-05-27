namespace IOOPassignment
{
    partial class FrmAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUMan = new System.Windows.Forms.Button();
            this.btnSReport = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWallet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // btnUMan
            // 
            this.btnUMan.Location = new System.Drawing.Point(78, 180);
            this.btnUMan.Name = "btnUMan";
            this.btnUMan.Size = new System.Drawing.Size(161, 34);
            this.btnUMan.TabIndex = 1;
            this.btnUMan.Text = "User Management";
            this.btnUMan.UseVisualStyleBackColor = true;
            // 
            // btnSReport
            // 
            this.btnSReport.Location = new System.Drawing.Point(78, 229);
            this.btnSReport.Name = "btnSReport";
            this.btnSReport.Size = new System.Drawing.Size(161, 34);
            this.btnSReport.TabIndex = 1;
            this.btnSReport.Text = "Sales Report";
            this.btnSReport.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(78, 130);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(161, 34);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(78, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnWallet
            // 
            this.btnWallet.Location = new System.Drawing.Point(78, 281);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Size = new System.Drawing.Size(161, 34);
            this.btnWallet.TabIndex = 1;
            this.btnWallet.Text = "Wallet Management";
            this.btnWallet.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWallet);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnSReport);
            this.Controls.Add(this.btnUMan);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUMan;
        private System.Windows.Forms.Button btnSReport;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWallet;
    }
}