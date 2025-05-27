namespace IOOPassignment
{
    partial class FrmRegister
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
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtUPwd = new System.Windows.Forms.TextBox();
            this.txtRePwd = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            this.cbxManager = new System.Windows.Forms.CheckBox();
            this.cbxChief = new System.Windows.Forms.CheckBox();
            this.cbxCustomer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(98, 143);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(248, 22);
            this.txtUName.TabIndex = 1;
            this.txtUName.Text = "Enter Username";
            // 
            // txtUPwd
            // 
            this.txtUPwd.Location = new System.Drawing.Point(98, 201);
            this.txtUPwd.Name = "txtUPwd";
            this.txtUPwd.Size = new System.Drawing.Size(248, 22);
            this.txtUPwd.TabIndex = 1;
            this.txtUPwd.Text = "Enter Password";
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(98, 260);
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.Size = new System.Drawing.Size(248, 22);
            this.txtRePwd.TabIndex = 1;
            this.txtRePwd.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(681, 384);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(91, 33);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(56, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Location = new System.Drawing.Point(530, 143);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(67, 20);
            this.cbxAdmin.TabIndex = 4;
            this.cbxAdmin.Text = "Admin";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // cbxManager
            // 
            this.cbxManager.AutoSize = true;
            this.cbxManager.Location = new System.Drawing.Point(530, 220);
            this.cbxManager.Name = "cbxManager";
            this.cbxManager.Size = new System.Drawing.Size(83, 20);
            this.cbxManager.TabIndex = 5;
            this.cbxManager.Text = "Manager";
            this.cbxManager.UseVisualStyleBackColor = true;
            // 
            // cbxChief
            // 
            this.cbxChief.AutoSize = true;
            this.cbxChief.Location = new System.Drawing.Point(530, 182);
            this.cbxChief.Name = "cbxChief";
            this.cbxChief.Size = new System.Drawing.Size(59, 20);
            this.cbxChief.TabIndex = 6;
            this.cbxChief.Text = "Chief";
            this.cbxChief.UseVisualStyleBackColor = true;
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.AutoSize = true;
            this.cbxCustomer.Location = new System.Drawing.Point(530, 262);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(86, 20);
            this.cbxCustomer.TabIndex = 7;
            this.cbxCustomer.Text = "Customer";
            this.cbxCustomer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose your Role";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCustomer);
            this.Controls.Add(this.cbxChief);
            this.Controls.Add(this.cbxManager);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRePwd);
            this.Controls.Add(this.txtUPwd);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtUPwd;
        private System.Windows.Forms.TextBox txtRePwd;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbxAdmin;
        private System.Windows.Forms.CheckBox cbxManager;
        private System.Windows.Forms.CheckBox cbxChief;
        private System.Windows.Forms.CheckBox cbxCustomer;
        private System.Windows.Forms.Label label2;
    }
}