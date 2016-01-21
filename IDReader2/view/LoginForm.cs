using IDReader2.model;
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

        private void CheckPWD_KEYPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13)
            {
                LoginBtn_Click(sender, new EventArgs());
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string account = this.LoginAccount.Text.Trim();
            string passwd = this.LoginPWD.Text.Trim();
            Manager user = CheckUser(account, passwd);
            Form show = null;
             if (user == null)//用户或密码错误
            {
                MessageBox.Show(this, "用户不存在或者密码错误", "错误信息");
            }
            else
            {
                int type = user.Type;
                if (type == 0)//系统用户
                {
                    show = new SupperForm();
                    ((SupperForm)show).User = user;
                }
                else if (type == 1)//培训部管理员
                {
                    show = new TrainForm(user);
                }
                else if (type == 2)//招待所管理员
                {
                    show = new HotelForm(user);
                }
            }
            if (show != null)
            {
                show.Show();
                this.Hide();
            }
        }

        private Manager CheckUser(string account, string passwd)
        {
            return dao.AdminDao.getManager(account);
        }

        private void CheckAccount_KEYPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }else if(!((e.KeyChar >= 'a' && e.KeyChar <= 'z')
                || (e.KeyChar >='A' &&e.KeyChar <= 'A')
                || (e.KeyChar == (Char)Keys.Delete)
                || (e.KeyChar == (Char)Keys.Back) 
                || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
    }
}
