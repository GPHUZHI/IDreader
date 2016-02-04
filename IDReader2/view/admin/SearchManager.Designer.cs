namespace IDReader2.view.admin
{
    partial class SearchManager
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.manager_password = new System.Windows.Forms.TextBox();
            this.manager_manager_day = new System.Windows.Forms.TextBox();
            this.update_manager = new System.Windows.Forms.Button();
            this.manager_account = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.show_all_manager = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userslist = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userslist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.manager_password);
            this.groupBox2.Controls.Add(this.manager_manager_day);
            this.groupBox2.Controls.Add(this.update_manager);
            this.groupBox2.Controls.Add(this.manager_account);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(479, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 362);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细管理员信息";
            // 
            // manager_password
            // 
            this.manager_password.Location = new System.Drawing.Point(19, 176);
            this.manager_password.Name = "manager_password";
            this.manager_password.Size = new System.Drawing.Size(258, 21);
            this.manager_password.TabIndex = 14;
            // 
            // manager_manager_day
            // 
            this.manager_manager_day.Location = new System.Drawing.Point(19, 301);
            this.manager_manager_day.Name = "manager_manager_day";
            this.manager_manager_day.Size = new System.Drawing.Size(258, 21);
            this.manager_manager_day.TabIndex = 13;
            // 
            // update_manager
            // 
            this.update_manager.Location = new System.Drawing.Point(293, 134);
            this.update_manager.Name = "update_manager";
            this.update_manager.Size = new System.Drawing.Size(100, 102);
            this.update_manager.TabIndex = 13;
            this.update_manager.Text = "修改管理员信息";
            this.update_manager.UseVisualStyleBackColor = true;
            this.update_manager.Click += new System.EventHandler(this.update_manager_Click);
            // 
            // manager_account
            // 
            this.manager_account.Location = new System.Drawing.Point(19, 81);
            this.manager_account.Name = "manager_account";
            this.manager_account.Size = new System.Drawing.Size(258, 21);
            this.manager_account.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 51);
            this.label5.TabIndex = 6;
            this.label5.Text = "登陆后管理的界面的有效时间（数字0-30）\r\n\r\n0表示不设置该用户可以自定义有效天数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "账号";
            // 
            // show_all_manager
            // 
            this.show_all_manager.Location = new System.Drawing.Point(30, 21);
            this.show_all_manager.Name = "show_all_manager";
            this.show_all_manager.Size = new System.Drawing.Size(185, 23);
            this.show_all_manager.TabIndex = 8;
            this.show_all_manager.Text = "显示所有管理员";
            this.show_all_manager.UseVisualStyleBackColor = true;
            this.show_all_manager.Click += new System.EventHandler(this.show_all_manager_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userslist);
            this.groupBox1.Location = new System.Drawing.Point(19, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 362);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所有管理员";
            // 
            // userslist
            // 
            this.userslist.AllowUserToAddRows = false;
            this.userslist.AllowUserToDeleteRows = false;
            this.userslist.AllowUserToResizeColumns = false;
            this.userslist.AllowUserToResizeRows = false;
            this.userslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userslist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userslist.Location = new System.Drawing.Point(11, 35);
            this.userslist.MultiSelect = false;
            this.userslist.Name = "userslist";
            this.userslist.ReadOnly = true;
            this.userslist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userslist.RowTemplate.Height = 23;
            this.userslist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userslist.Size = new System.Drawing.Size(437, 321);
            this.userslist.TabIndex = 0;
            this.userslist.TabStop = false;
            this.userslist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userslist_CellClick);
            // 
            // SearchManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(926, 482);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.show_all_manager);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userslist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox manager_password;
        private System.Windows.Forms.TextBox manager_manager_day;
        private System.Windows.Forms.Button update_manager;
        private System.Windows.Forms.TextBox manager_account;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button show_all_manager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView userslist;
    }
}