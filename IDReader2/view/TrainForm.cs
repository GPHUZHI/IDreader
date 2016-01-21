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
    public partial class TrainForm : Form
    {
        private Manager user;
        public TrainForm()
        {
            InitializeComponent();
        }

        public TrainForm(Manager user)
        {
            this.user = user;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "你真的要退出吗？", "提示信息：", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
