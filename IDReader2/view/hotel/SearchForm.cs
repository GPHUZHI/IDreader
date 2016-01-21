using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDReader2.model;
using IDReader2.dao;
using System.Runtime.InteropServices;
using System.Threading;

namespace IDReader2.view.hotel
{
    public partial class SearchForm : Form
    {
        private Manager user;

        public SearchForm(Manager user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void HotelSearchBtn_Click(object sender, EventArgs e)
        {
            string account = this.hotel_search_account.Text.Trim();
            try {
                Customer c = CustomerDao.getCustomerByAccount(account);
                showCustomer(c);
            }catch(Exception ex)
            {
                ((HotelForm)this.MdiParent).UpdateState(ex.Message);
            }
        }

        private void showCustomer(Customer c)
        {
            if (c != null)
            {
                this.hotel_search_res_account.BeginInvoke(new System.EventHandler(UpdateAccount), c.Account);
                this.hotel_search_res_name.BeginInvoke(new System.EventHandler(UpdateTime), c.Name);
                this.hotel_search_res_sex.BeginInvoke(new System.EventHandler(UpdateSex), c.Gender);
                this.hotel_search_res_status.BeginInvoke(new System.EventHandler(UpdateStaute), "注册时间为:" + c.StartTime+"\r\n有效时间是"+c.AvailableDay+"天");
                ((HotelForm)this.MdiParent).UpdateState("查询成功!");
            }
            else
            {
                ((HotelForm)this.MdiParent).ShowSearchRes("没有该用户注册信息!");
            }
        }

        private void UpdateStaute(object o, EventArgs e)
        {
            if (o != null)
            {
                this.hotel_search_res_status.Text = o.ToString();
            }
        }

        private void UpdateSex(object o, EventArgs e)
        {
            if (o != null)
            {
                this.hotel_search_res_sex.Text = o.ToString();
            }
        }

        private void UpdateTime(object o, EventArgs e)
        {
            if (o != null)
            {
                this.hotel_search_res_name.Text = o.ToString();
            }
        }

        private void UpdateAccount(object o, EventArgs e)
        {
            if (o != null)
            {
                this.hotel_search_res_account.Text = o.ToString();
            }
        }

        private void HotelSearchAccount(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                HotelSearchBtn_Click(sender, new EventArgs());
            }
            else if (e.KeyChar == ' '||!((e.KeyChar >= 'a' && e.KeyChar <= 'z')
               || (e.KeyChar >= 'A' && e.KeyChar <= 'A')
               || (e.KeyChar == (Char)Keys.Delete)
               || (e.KeyChar == (Char)Keys.Back)
               || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
        
        internal void UpdateSearch(string account)
        {
            this.hotel_search_account.BeginInvoke(new System.EventHandler(UpdateSearchAccount), account);
            if (account == "")
            {
                return;
            }
            HotelSearchBtn_Click(null, null);
        }

        private void UpdateSearchAccount(object o, EventArgs e)
        {
            if (o != null)
            {
                this.hotel_search_account.Text = o.ToString();
            }
        }
    }
}
