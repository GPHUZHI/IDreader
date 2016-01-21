namespace IDReader2.view.hotel
{
    partial class SearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hotel_search_res_status = new System.Windows.Forms.TextBox();
            this.hotel_search_res_account = new System.Windows.Forms.TextBox();
            this.hotel_search_res_sex = new System.Windows.Forms.TextBox();
            this.hotel_search_res_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HotelSearchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hotel_search_account = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询客户信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hotel_search_res_status);
            this.groupBox3.Controls.Add(this.hotel_search_res_account);
            this.groupBox3.Controls.Add(this.hotel_search_res_sex);
            this.groupBox3.Controls.Add(this.hotel_search_res_name);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(251, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 249);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户信息";
            // 
            // hotel_search_res_status
            // 
            this.hotel_search_res_status.Location = new System.Drawing.Point(88, 191);
            this.hotel_search_res_status.Multiline = true;
            this.hotel_search_res_status.Name = "hotel_search_res_status";
            this.hotel_search_res_status.ReadOnly = true;
            this.hotel_search_res_status.Size = new System.Drawing.Size(266, 52);
            this.hotel_search_res_status.TabIndex = 3;
            // 
            // hotel_search_res_account
            // 
            this.hotel_search_res_account.Location = new System.Drawing.Point(88, 146);
            this.hotel_search_res_account.Name = "hotel_search_res_account";
            this.hotel_search_res_account.ReadOnly = true;
            this.hotel_search_res_account.Size = new System.Drawing.Size(266, 21);
            this.hotel_search_res_account.TabIndex = 3;
            // 
            // hotel_search_res_sex
            // 
            this.hotel_search_res_sex.Location = new System.Drawing.Point(88, 93);
            this.hotel_search_res_sex.Name = "hotel_search_res_sex";
            this.hotel_search_res_sex.ReadOnly = true;
            this.hotel_search_res_sex.Size = new System.Drawing.Size(266, 21);
            this.hotel_search_res_sex.TabIndex = 3;
            // 
            // hotel_search_res_name
            // 
            this.hotel_search_res_name.Location = new System.Drawing.Point(88, 42);
            this.hotel_search_res_name.Name = "hotel_search_res_name";
            this.hotel_search_res_name.ReadOnly = true;
            this.hotel_search_res_name.Size = new System.Drawing.Size(266, 21);
            this.hotel_search_res_name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.HotelSearchBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.hotel_search_account);
            this.groupBox2.Location = new System.Drawing.Point(26, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 249);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "账号查询";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 60);
            this.label6.TabIndex = 7;
            this.label6.Text = "可以刷客户身份证查询";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HotelSearchBtn
            // 
            this.HotelSearchBtn.Location = new System.Drawing.Point(20, 89);
            this.HotelSearchBtn.Name = "HotelSearchBtn";
            this.HotelSearchBtn.Size = new System.Drawing.Size(157, 46);
            this.HotelSearchBtn.TabIndex = 6;
            this.HotelSearchBtn.Text = "查询";
            this.HotelSearchBtn.UseVisualStyleBackColor = true;
            this.HotelSearchBtn.Click += new System.EventHandler(this.HotelSearchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "用户账号";
            // 
            // hotel_search_account
            // 
            this.hotel_search_account.Location = new System.Drawing.Point(77, 39);
            this.hotel_search_account.MaxLength = 20;
            this.hotel_search_account.Name = "hotel_search_account";
            this.hotel_search_account.Size = new System.Drawing.Size(100, 21);
            this.hotel_search_account.TabIndex = 3;
            this.hotel_search_account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HotelSearchAccount);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 329);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox hotel_search_res_status;
        private System.Windows.Forms.TextBox hotel_search_res_account;
        private System.Windows.Forms.TextBox hotel_search_res_sex;
        private System.Windows.Forms.TextBox hotel_search_res_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button HotelSearchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hotel_search_account;
    }
}