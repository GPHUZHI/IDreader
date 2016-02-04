using IDReader2.dao;
using IDReader2.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDReader2.view.admin
{
    public partial class SearchCustomer : Form
    {
        private List<Customer> customers;
        private bool availableflg = true;

        public int customer_id;

        public SearchCustomer()
        {
            InitializeComponent();
            show_available_customer_btn_Click(null, null);
        }

        private void radio_customer_other_CheckedChanged(object sender, EventArgs e)
        {
            this.customer_availableday_input.Enabled = this.radio_customer_other.Checked;
        }

        private void show_available_customer_btn_Click(object sender, EventArgs e)
        {
            availableflg = true;
            ClearAllShowCustomer();
            customers = CustomerDao.GetAvailableUser();
            if (customers != null)
            {
                ArrayList datas = new ArrayList();
                foreach (Customer c in customers)
                {
                    datas.Add(new MyItem(c.Account, c.Name,c.Gender,c.AvailableDay,c.StartTime));
                }
                this.userslist.DataSource = datas;
            }
        }
        private class MyItem
        {
            private string account;
            private int availableDay;
            private string gender;
            private string name;
            private DateTime startTime;

            public MyItem(string account, string name, string gender, int availableDay)
            {
                this.account = account;
                this.name = name;
                this.gender = gender;
                this.availableDay = availableDay;
            }

            public MyItem(string account, string name, string gender, int availableDay, DateTime startTime) : this(account, name, gender, availableDay)
            {
                this.startTime = startTime;
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
            public string 姓名
            {
                set
                {
                    name = value;
                }
                get
                {
                    return name;
                }
            }
            public string 性别
            {
                set
                {
                    gender = value;
                }
                get
                {
                    return gender;
                }
            }
            public int 有效天数
            {
                set
                {
                    availableDay = value;
                }
                get
                {
                    return availableDay;
                }
            }
            public DateTime 注册时间
            {
                set
                {
                    startTime = value;
                }
                get
                {
                    return startTime;
                }
            }
        }

        private void show_unavailable_customer_btn_Click(object sender, EventArgs e)
        {
            availableflg = false;
            ClearAllShowCustomer();
            customers = CustomerDao.GetUnAvailableUser();
            if (customers == null)
            {
                ((SupperForm)this.MdiParent).UpdateState("数据库连接失败，请重新连接数据库...");
            }
            else
            {
                ArrayList datas = new ArrayList();
                foreach (Customer c in customers)
                {
                    datas.Add(new MyItem(c.Account, c.Name, c.Gender, c.AvailableDay,c.StartTime));
                }
                this.userslist.DataSource = datas;
                ((SupperForm)this.MdiParent).UpdateState("查询全部失效用户成功!");
            }
        }

        private void userslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得datagridview单元格里的数据
            try
            {
                int idx = e.RowIndex;
                Customer cus = customers.ElementAt(idx);
                this.show_customer_account.Text = cus.Account;
                this.show_customer_name.Text = cus.Name;
                this.show_customer_sex.Text = cus.Gender;
                this.customer_id = cus.Id;
                this.update_customer_panel.Enabled = true;
                ((SupperForm)this.MdiParent).UpdateState("查询客户信息" + cus.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearAllShowCustomer()
        {
            this.show_customer_account.Text = "";
            this.show_customer_name.Text =  "";
            this.show_customer_sex.Text = "";
            this.customer_id = 0;
            this.update_customer_panel.Enabled = false;
        }
        
        private void write_to_xls_Click(object sender, EventArgs e)
        {
            string filename = (availableflg ? "有效" : "无效") + "用户"+DateTime.Now.ToFileTime()+ ".csv";
            if (MessageBox.Show(this, "是否导出所有"+(availableflg?"有效":"无效")+"用户信息到"+filename+"？", "提示信息：", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WriteToXls(filename);
                MessageBox.Show("文件已经保存到"+ Application.StartupPath);
            }
        }

        private void WriteToXls(string filename)
        {
            FileStream fs = null;
            string path = Application.StartupPath;
            if (!File.Exists(filename))
            {
                 fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Write);
            }
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            string str = "序号,姓名,账号,性别,有效天,开始时间";
            sw.WriteLine(str);//开始写入值
            int id = 1;
            foreach (Customer c in customers)
            {
                str = (id++) + "," + c.Name + "," + c.Account + "," + c.Gender + "," + c.AvailableDay + "," + c.StartTime;
                sw.WriteLine(str);//开始写入值
            }
            sw.Close();
            fs.Close();
        }
    }
}
