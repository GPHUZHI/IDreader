namespace IDReader2.view
{
    partial class SupperForm
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
            this.查看客户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看管理员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推迟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看客户信息ToolStripMenuItem,
            this.查看管理员信息ToolStripMenuItem,
            this.推迟ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看客户信息ToolStripMenuItem
            // 
            this.查看客户信息ToolStripMenuItem.Name = "查看客户信息ToolStripMenuItem";
            this.查看客户信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.查看客户信息ToolStripMenuItem.Text = "查看客户信息";
            // 
            // 查看管理员信息ToolStripMenuItem
            // 
            this.查看管理员信息ToolStripMenuItem.Name = "查看管理员信息ToolStripMenuItem";
            this.查看管理员信息ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.查看管理员信息ToolStripMenuItem.Text = "查看管理员信息";
            // 
            // 推迟ToolStripMenuItem
            // 
            this.推迟ToolStripMenuItem.Name = "推迟ToolStripMenuItem";
            this.推迟ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.推迟ToolStripMenuItem.Text = "退出";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip2.Location = new System.Drawing.Point(0, 439);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(894, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel3.Text = "登记/查看用户";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel4.Text = "状态";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel5.Text = "成功/失败+原因";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 414);
            this.panel1.TabIndex = 4;
            // 
            // SupperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supper Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看客户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看管理员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推迟ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Panel panel1;
    }
}