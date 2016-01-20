using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDReader2.view
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "你真的要退出吗？", "提示信息：", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginAction(object sender, EventArgs e)
        {
            string account = this.LoginAccount.Text.Trim();
            string passwd = this.LoginPWD.Text.Trim();
            MessageBox.Show(account + passwd);
        }
    }
}
