using IDReader2.dao;
using IDReader2.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDReader2.view.admin
{
    public partial class SearchManager : Form
    {
        public SearchManager()
        {
            InitializeComponent();
            show_all_manager_Click(null, null);
        }
        private List<Manager> admins = null;
        private int manager_id;

        private void show_all_manager_Click(object sender, EventArgs e)
        {
            admins =  AdminDao.getManagers();
            if (admins == null)
            {
                ((SupperForm)this.MdiParent).UpdateState("数据库连接失败，请重新连接数据库...");
            }
            else
            {
                ArrayList datas = new ArrayList();
                foreach (Manager m in admins) {
                    datas.Add(new MyItem(m.Account , m.Day+"", m.Type+""));
                }
                this.userslist.DataSource = datas;
            }
        }
        class MyItem
        {
            private string account;
            private string day;
            private string type;

            public MyItem(string account, string day,string type)
            {
                this.account = account;
                this.day = day;
                this.type = type;
            }

            public string 账号
            {
                set
                {
                    account = value;
                }
                get
                {
                    return account;
                }
            }
            public string 登陆界面显示的有效期
            {
                set
                {
                    day = value;
                }
                get
                {
                    return day;
                }
            }
            public string 用户类型
            {
                set
                {
                    type = value;
                }
                get
                {
                    return type;
                }
            }
        }

        private void userslist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得datagridview单元格里的数据
            try {
                int idx = e.RowIndex;
                Manager admin = admins.ElementAt(idx);
                this.manager_account.Text = admin.Account;
                this.manager_password.Text = admin.Passwd;
                if(admin.Type == 2)//前台管理员修改时间
                {
                    this.manager_manager_day.Text = "" + admin.Day;
                    this.manager_manager_day.Enabled = true;
                }//其他不修改
                else
                {
                    this.manager_manager_day.Text = "无需修改";
                    this.manager_manager_day.Enabled = false;
                }
                this.manager_id = admin.Id;
                this.update_manager.Enabled = true;
                ((SupperForm)this.MdiParent).UpdateState("查询管理员信息" + admin.Account);
            }
            catch(Exception ex) {
            }
        }

        private void update_manager_Click(object sender, EventArgs e)
        {
            try {
                string account = this.manager_account.Text;
                string password = this.manager_password.Text;
                int day = 0;
                if (!this.manager_manager_day.Text.Equals("无需修改"))
                {
                    try
                    {
                        day = Convert.ToInt32(this.manager_manager_day.Text);
                    }
                    catch
                    {
                        MessageBox.Show(this, "请输入有效天数(1-30)");
                        this.manager_manager_day.Text = "";
                        this.manager_manager_day.Focus();
                        return;
                    }
                }
                AdminDao.UpdateManager(manager_id,account, password, day);
                ((SupperForm)this.MdiParent).UpdateState("修改成功！");
                show_all_manager_Click(null, null);
            }
            catch(Exception ex)
            {
                ((SupperForm)this.MdiParent).UpdateState(ex.Message+"修改失败！");
            }
        }
    }
}
