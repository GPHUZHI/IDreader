namespace IDReader2.view
{
    partial class TrainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regit_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.search_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.train_opt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.train_panel_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regit_customer,
            this.search_customer,
            this.exit_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regit_customer
            // 
            this.regit_customer.Name = "regit_customer";
            this.regit_customer.Size = new System.Drawing.Size(68, 21);
            this.regit_customer.Text = "登记客户";
            // 
            // search_customer
            // 
            this.search_customer.Name = "search_customer";
            this.search_customer.Size = new System.Drawing.Size(68, 21);
            this.search_customer.Text = "查询客户";
            // 
            // exit_menu
            // 
            this.exit_menu.Name = "exit_menu";
            this.exit_menu.Size = new System.Drawing.Size(44, 21);
            this.exit_menu.Text = "退出";
            this.exit_menu.Click += new System.EventHandler(this.Exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.train_opt,
            this.toolStripStatusLabel3,
            this.train_panel_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(833, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // train_opt
            // 
            this.train_opt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.train_opt.Name = "train_opt";
            this.train_opt.Size = new System.Drawing.Size(109, 17);
            this.train_opt.Text = "登记/查询客户信息";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel3.Text = "状态";
            // 
            // train_panel_status
            // 
            this.train_panel_status.ForeColor = System.Drawing.Color.Red;
            this.train_panel_status.Name = "train_panel_status";
            this.train_panel_status.Size = new System.Drawing.Size(94, 17);
            this.train_panel_status.Text = "成功/失败+原因";
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 396);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TrainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "培训部管理员";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regit_customer;
        private System.Windows.Forms.ToolStripMenuItem search_customer;
        private System.Windows.Forms.ToolStripMenuItem exit_menu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel train_opt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel train_panel_status;
    }
}