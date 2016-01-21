namespace IDReader2.view.hotel
{
    partial class ReadForm
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
            this.hotel_day = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hotel_account = new System.Windows.Forms.TextBox();
            this.hotel_sex = new System.Windows.Forms.TextBox();
            this.hotel_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Size = new System.Drawing.Size(655, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登记客户信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hotel_day);
            this.groupBox3.Location = new System.Drawing.Point(342, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 259);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "有效期";
            // 
            // hotel_day
            // 
            this.hotel_day.AutoSize = true;
            this.hotel_day.Font = new System.Drawing.Font("宋体", 24F);
            this.hotel_day.Location = new System.Drawing.Point(35, 102);
            this.hotel_day.Name = "hotel_day";
            this.hotel_day.Size = new System.Drawing.Size(159, 33);
            this.hotel_day.TabIndex = 0;
            this.hotel_day.Text = "有效期X天";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hotel_account);
            this.groupBox2.Controls.Add(this.hotel_sex);
            this.groupBox2.Controls.Add(this.hotel_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 259);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户信息";
            // 
            // hotel_account
            // 
            this.hotel_account.Location = new System.Drawing.Point(86, 199);
            this.hotel_account.Name = "hotel_account";
            this.hotel_account.ReadOnly = true;
            this.hotel_account.Size = new System.Drawing.Size(202, 21);
            this.hotel_account.TabIndex = 5;
            // 
            // hotel_sex
            // 
            this.hotel_sex.Location = new System.Drawing.Point(86, 116);
            this.hotel_sex.Name = "hotel_sex";
            this.hotel_sex.ReadOnly = true;
            this.hotel_sex.Size = new System.Drawing.Size(202, 21);
            this.hotel_sex.TabIndex = 4;
            // 
            // hotel_name
            // 
            this.hotel_name.Location = new System.Drawing.Point(86, 47);
            this.hotel_name.Name = "hotel_name";
            this.hotel_name.ReadOnly = true;
            this.hotel_name.Size = new System.Drawing.Size(202, 21);
            this.hotel_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(21, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(705, 341);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReadForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReadForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private int day = 0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label hotel_day;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox hotel_account;
        private System.Windows.Forms.TextBox hotel_sex;
        private System.Windows.Forms.TextBox hotel_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}