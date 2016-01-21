using IDReader2.view.hotel;
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
using System.Threading;
using IDReader2.util;

namespace IDReader2.view
{
    public partial class HotelForm : Form
    {
        private Form center = null;
        private Manager user = null;
        private Thread readRun = null;

        public HotelForm(Manager user)
        {
            InitializeComponent();
            this.user = user;
            //读取卡
            new ReadCardUtil().ReadCustomer(readRun, this);
            RegitUser(new object(), new EventArgs());
        }

/*
        public void startSearchCard()
        {
            if (searchRun != null)
            {
                searchRun.Abort();
                searchRun = null;
            }
            new ReadCardUtil().SearchCustomer(searchRun,this);
        }
*/
        internal void UpdateState(string message)
        {
            this.hotel_panel_status.Text = message;
        }


        internal void ShowSearchRes(string str)
        {
            MessageBox.Show(str);
        }

        private void RegitUser(object sender, EventArgs e)
        {
            center = new ReadForm(user.Day);
            center.MdiParent = this;
            center.Show();
            this.hotel_opt.Text = "登记客户";
            this.hotel_panel_status.Text = "请放入客户的身份证...";
        }

        private void SearchUser(object sender, EventArgs e)
        {
            center = new SearchForm(user);
            center.MdiParent = this;
            center.Show();
            this.hotel_opt.Text = "查询客户";
            this.hotel_panel_status.Text = "请输入客户身份证后八位查询...";
            //读取卡
           // startSearchCard();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "你真的要退出吗？", "提示信息：", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (readRun != null)
                {
                    readRun.Abort();
                }
                Environment.Exit(0);
            }
        }
        
        internal void UpdateReadCard(string v)
        {
            if (v != null && v.Substring(0, 3) == "SUC")
            {
                string account = v.Substring(3, 8);
                string name = v.Substring(11, 15).Trim();
                string gender = v.Substring(26);
                if ("ReadForm" == ActiveMdiChild.Name)
                {
                    ReadForm form = (ReadForm)ActiveMdiChild;
                    form.UpdateRead(account, name, gender);
                this.hotel_panel_status.Text = "读取成功...";
                }
                else if("SearchForm" == ActiveMdiChild.Name){
                    SearchForm form = (SearchForm)ActiveMdiChild;
                    form.UpdateSearch(account);
                }
            }
            else
            {
                this.hotel_panel_status.Text = "读卡失败，请确定与读卡器成功连接...";
            }
        }

        private void Hotel_Closing(object sender, FormClosingEventArgs e)
        {
            ExitClick(sender, new EventArgs());
        }
    }
}
