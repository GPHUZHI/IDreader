using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDReader2.view.hotel
{
    public partial class ReadForm : Form
    {

        public ReadForm()
        {
            InitializeComponent();
        }

        public ReadForm(int day)
        {
            this.day = day;
            InitializeComponent();
            this.hotel_day.Text = "有效期为"+day+"天";
        }
        

        internal void UpdateRead(string account, string name, string gender)
        {
            this.hotel_account.BeginInvoke(new System.EventHandler(UpdateAccount), account);
            this.hotel_name.BeginInvoke(new System.EventHandler(UpdateName), name);
            this.hotel_sex.BeginInvoke(new System.EventHandler(UpdateSex), gender);
        }

        private void UpdateSex(object sender, EventArgs e)
        {
            if (sender != null)
            {
                this.hotel_sex.Text = (string)sender;
            }
        }

        private void UpdateName(object sender, EventArgs e)
        {
            if (sender != null)
            {
                this.hotel_name.Text = (string)sender;
            }
        }

        private void UpdateAccount(object sender, EventArgs e)
        {
            if (sender != null) { 
                this.hotel_account.Text = (string)sender;
            }
        }
    }
}
