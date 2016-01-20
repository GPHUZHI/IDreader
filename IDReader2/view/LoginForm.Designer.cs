namespace IDReader2.view
{
    partial class LoginForm
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
            this.logingroup = new System.Windows.Forms.GroupBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginPWD = new System.Windows.Forms.TextBox();
            this.LoginAccount = new System.Windows.Forms.TextBox();
            this.login_pwd_title = new System.Windows.Forms.Label();
            this.login_account_title = new System.Windows.Forms.Label();
            this.logingroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // logingroup
            // 
            this.logingroup.Controls.Add(this.ExitBtn);
            this.logingroup.Controls.Add(this.LoginBtn);
            this.logingroup.Controls.Add(this.LoginPWD);
            this.logingroup.Controls.Add(this.LoginAccount);
            this.logingroup.Controls.Add(this.login_pwd_title);
            this.logingroup.Controls.Add(this.login_account_title);
            this.logingroup.Location = new System.Drawing.Point(12, 12);
            this.logingroup.Name = "logingroup";
            this.logingroup.Size = new System.Drawing.Size(199, 184);
            this.logingroup.TabIndex = 0;
            this.logingroup.TabStop = false;
            this.logingroup.Text = "管理员登陆";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Location = new System.Drawing.Point(103, 123);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "退出";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(22, 123);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "登陆";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginAction);
            // 
            // LoginPWD
            // 
            this.LoginPWD.Location = new System.Drawing.Point(71, 80);
            this.LoginPWD.Name = "LoginPWD";
            this.LoginPWD.PasswordChar = '*';
            this.LoginPWD.Size = new System.Drawing.Size(107, 21);
            this.LoginPWD.TabIndex = 3;
            // 
            // LoginAccount
            // 
            this.LoginAccount.Location = new System.Drawing.Point(71, 48);
            this.LoginAccount.Name = "LoginAccount";
            this.LoginAccount.Size = new System.Drawing.Size(107, 21);
            this.LoginAccount.TabIndex = 2;
            // 
            // login_pwd_title
            // 
            this.login_pwd_title.AutoSize = true;
            this.login_pwd_title.Location = new System.Drawing.Point(22, 80);
            this.login_pwd_title.Name = "login_pwd_title";
            this.login_pwd_title.Size = new System.Drawing.Size(29, 12);
            this.login_pwd_title.TabIndex = 1;
            this.login_pwd_title.Text = "密码";
            // 
            // login_account_title
            // 
            this.login_account_title.AutoSize = true;
            this.login_account_title.Location = new System.Drawing.Point(20, 48);
            this.login_account_title.Name = "login_account_title";
            this.login_account_title.Size = new System.Drawing.Size(29, 12);
            this.login_account_title.TabIndex = 0;
            this.login_account_title.Text = "账号";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 214);
            this.Controls.Add(this.logingroup);
            this.Name = "LoginForm";
            this.Text = "登陆";
            this.logingroup.ResumeLayout(false);
            this.logingroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logingroup;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox LoginPWD;
        private System.Windows.Forms.TextBox LoginAccount;
        private System.Windows.Forms.Label login_pwd_title;
        private System.Windows.Forms.Label login_account_title;
    }
}