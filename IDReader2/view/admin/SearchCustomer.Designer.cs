namespace IDReader2.view.admin
{
    partial class SearchCustomer
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
            this.show_customer_account = new System.Windows.Forms.TextBox();
            this.show_customer_sex = new System.Windows.Forms.TextBox();
            this.show_customer_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_availableday_input = new System.Windows.Forms.TextBox();
            this.radio_customer_other = new System.Windows.Forms.RadioButton();
            this.radio_customer_five = new System.Windows.Forms.RadioButton();
            this.radio_customer_three = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.show_unavailable_customer_btn = new System.Windows.Forms.Button();
            this.show_available_customer_btn = new System.Windows.Forms.Button();
            this.userslist = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.update_customer_panel = new System.Windows.Forms.GroupBox();
            this.write_to_xls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userslist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.update_customer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // show_customer_account
            // 
            this.show_customer_account.Location = new System.Drawing.Point(94, 119);
            this.show_customer_account.Name = "show_customer_account";
            this.show_customer_account.ReadOnly = true;
            this.show_customer_account.Size = new System.Drawing.Size(191, 21);
            this.show_customer_account.TabIndex = 9;
            // 
            // show_customer_sex
            // 
            this.show_customer_sex.Location = new System.Drawing.Point(94, 76);
            this.show_customer_sex.Name = "show_customer_sex";
            this.show_customer_sex.ReadOnly = true;
            this.show_customer_sex.Size = new System.Drawing.Size(191, 21);
            this.show_customer_sex.TabIndex = 10;
            // 
            // show_customer_name
            // 
            this.show_customer_name.Location = new System.Drawing.Point(94, 36);
            this.show_customer_name.Name = "show_customer_name";
            this.show_customer_name.ReadOnly = true;
            this.show_customer_name.Size = new System.Drawing.Size(191, 21);
            this.show_customer_name.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "有效期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名";
            // 
            // customer_availableday_input
            // 
            this.customer_availableday_input.Enabled = false;
            this.customer_availableday_input.Location = new System.Drawing.Point(142, 86);
            this.customer_availableday_input.Name = "customer_availableday_input";
            this.customer_availableday_input.Size = new System.Drawing.Size(49, 21);
            this.customer_availableday_input.TabIndex = 13;
            // 
            // radio_customer_other
            // 
            this.radio_customer_other.AutoSize = true;
            this.radio_customer_other.Location = new System.Drawing.Point(32, 87);
            this.radio_customer_other.Name = "radio_customer_other";
            this.radio_customer_other.Size = new System.Drawing.Size(107, 16);
            this.radio_customer_other.TabIndex = 10;
            this.radio_customer_other.Text = "自定义(1-30天)";
            this.radio_customer_other.UseVisualStyleBackColor = true;
            this.radio_customer_other.CheckedChanged += new System.EventHandler(this.radio_customer_other_CheckedChanged);
            // 
            // radio_customer_five
            // 
            this.radio_customer_five.AutoSize = true;
            this.radio_customer_five.Location = new System.Drawing.Point(32, 54);
            this.radio_customer_five.Name = "radio_customer_five";
            this.radio_customer_five.Size = new System.Drawing.Size(83, 16);
            this.radio_customer_five.TabIndex = 11;
            this.radio_customer_five.Text = "有效期五天";
            this.radio_customer_five.UseVisualStyleBackColor = true;
            // 
            // radio_customer_three
            // 
            this.radio_customer_three.AutoSize = true;
            this.radio_customer_three.Checked = true;
            this.radio_customer_three.Location = new System.Drawing.Point(32, 20);
            this.radio_customer_three.Name = "radio_customer_three";
            this.radio_customer_three.Size = new System.Drawing.Size(83, 16);
            this.radio_customer_three.TabIndex = 12;
            this.radio_customer_three.TabStop = true;
            this.radio_customer_three.Text = "有效期三天";
            this.radio_customer_three.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "修改用户信息";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // show_unavailable_customer_btn
            // 
            this.show_unavailable_customer_btn.Location = new System.Drawing.Point(247, 23);
            this.show_unavailable_customer_btn.Name = "show_unavailable_customer_btn";
            this.show_unavailable_customer_btn.Size = new System.Drawing.Size(185, 23);
            this.show_unavailable_customer_btn.TabIndex = 4;
            this.show_unavailable_customer_btn.Text = "显示所有无效用户";
            this.show_unavailable_customer_btn.UseVisualStyleBackColor = true;
            this.show_unavailable_customer_btn.Click += new System.EventHandler(this.show_unavailable_customer_btn_Click);
            // 
            // show_available_customer_btn
            // 
            this.show_available_customer_btn.Location = new System.Drawing.Point(34, 23);
            this.show_available_customer_btn.Name = "show_available_customer_btn";
            this.show_available_customer_btn.Size = new System.Drawing.Size(185, 23);
            this.show_available_customer_btn.TabIndex = 5;
            this.show_available_customer_btn.Text = "显示所有有效用户";
            this.show_available_customer_btn.UseVisualStyleBackColor = true;
            this.show_available_customer_btn.Click += new System.EventHandler(this.show_available_customer_btn_Click);
            // 
            // userslist
            // 
            this.userslist.AllowUserToAddRows = false;
            this.userslist.AllowUserToDeleteRows = false;
            this.userslist.AllowUserToResizeColumns = false;
            this.userslist.AllowUserToResizeRows = false;
            this.userslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userslist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.userslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userslist.Location = new System.Drawing.Point(7, 21);
            this.userslist.MultiSelect = false;
            this.userslist.Name = "userslist";
            this.userslist.ReadOnly = true;
            this.userslist.RowTemplate.Height = 23;
            this.userslist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userslist.Size = new System.Drawing.Size(553, 316);
            this.userslist.TabIndex = 0;
            this.userslist.TabStop = false;
            this.userslist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userslist_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userslist);
            this.groupBox1.Location = new System.Drawing.Point(23, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所有有效/无效用户";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.customer_availableday_input);
            this.groupBox3.Controls.Add(this.radio_customer_other);
            this.groupBox3.Controls.Add(this.radio_customer_five);
            this.groupBox3.Controls.Add(this.radio_customer_three);
            this.groupBox3.Location = new System.Drawing.Point(94, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 123);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // update_customer_panel
            // 
            this.update_customer_panel.Controls.Add(this.button3);
            this.update_customer_panel.Controls.Add(this.groupBox3);
            this.update_customer_panel.Controls.Add(this.show_customer_account);
            this.update_customer_panel.Controls.Add(this.show_customer_sex);
            this.update_customer_panel.Controls.Add(this.show_customer_name);
            this.update_customer_panel.Controls.Add(this.label5);
            this.update_customer_panel.Controls.Add(this.label3);
            this.update_customer_panel.Controls.Add(this.label2);
            this.update_customer_panel.Controls.Add(this.label1);
            this.update_customer_panel.Enabled = false;
            this.update_customer_panel.Location = new System.Drawing.Point(595, 51);
            this.update_customer_panel.Name = "update_customer_panel";
            this.update_customer_panel.Size = new System.Drawing.Size(298, 362);
            this.update_customer_panel.TabIndex = 6;
            this.update_customer_panel.TabStop = false;
            this.update_customer_panel.Text = "详细用户信息";
            // 
            // write_to_xls
            // 
            this.write_to_xls.Location = new System.Drawing.Point(456, 23);
            this.write_to_xls.Name = "write_to_xls";
            this.write_to_xls.Size = new System.Drawing.Size(127, 23);
            this.write_to_xls.TabIndex = 1;
            this.write_to_xls.Text = "导出数据";
            this.write_to_xls.UseVisualStyleBackColor = true;
            this.write_to_xls.Click += new System.EventHandler(this.write_to_xls_Click);
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(918, 441);
            this.ControlBox = false;
            this.Controls.Add(this.write_to_xls);
            this.Controls.Add(this.show_unavailable_customer_btn);
            this.Controls.Add(this.show_available_customer_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.update_customer_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.userslist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.update_customer_panel.ResumeLayout(false);
            this.update_customer_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox show_customer_account;
        private System.Windows.Forms.TextBox show_customer_sex;
        private System.Windows.Forms.TextBox show_customer_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_availableday_input;
        private System.Windows.Forms.RadioButton radio_customer_other;
        private System.Windows.Forms.RadioButton radio_customer_five;
        private System.Windows.Forms.RadioButton radio_customer_three;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button show_unavailable_customer_btn;
        private System.Windows.Forms.Button show_available_customer_btn;
        private System.Windows.Forms.DataGridView userslist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox update_customer_panel;
        private System.Windows.Forms.Button write_to_xls;
    }
}