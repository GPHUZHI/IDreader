namespace IDReader2.view
{
    partial class HotelForm
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
            this.regin_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.search_customer = new System.Windows.Forms.ToolStripMenuItem();
            this.exitbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.hotel_opt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.hotel_panel_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regin_customer,
            this.search_customer,
            this.exitbtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regin_customer
            // 
            this.regin_customer.Name = "regin_customer";
            this.regin_customer.Size = new System.Drawing.Size(68, 21);
            this.regin_customer.Text = "登记用户";
            this.regin_customer.Click += new System.EventHandler(this.RegitUser);
            // 
            // search_customer
            // 
            this.search_customer.Name = "search_customer";
            this.search_customer.Size = new System.Drawing.Size(68, 21);
            this.search_customer.Text = "查看用户";
            this.search_customer.Click += new System.EventHandler(this.SearchUser);
            // 
            // exitbtn
            // 
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(44, 21);
            this.exitbtn.Text = "退出";
            this.exitbtn.Click += new System.EventHandler(this.ExitClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotel_opt,
            this.toolStripStatusLabel1,
            this.hotel_panel_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // hotel_opt
            // 
            this.hotel_opt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hotel_opt.Name = "hotel_opt";
            this.hotel_opt.Size = new System.Drawing.Size(85, 17);
            this.hotel_opt.Text = "登记/查看用户";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "状态";
            // 
            // hotel_panel_status
            // 
            this.hotel_panel_status.ForeColor = System.Drawing.Color.Red;
            this.hotel_panel_status.Name = "hotel_panel_status";
            this.hotel_panel_status.Size = new System.Drawing.Size(94, 17);
            this.hotel_panel_status.Text = "成功/失败+原因";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 360);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "招待所管理员";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hotel_Closing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regin_customer;
        private System.Windows.Forms.ToolStripMenuItem search_customer;
        private System.Windows.Forms.ToolStripMenuItem exitbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel hotel_opt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel hotel_panel_status;
    }
}