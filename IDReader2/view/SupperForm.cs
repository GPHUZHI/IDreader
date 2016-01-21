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
    public partial class SupperForm : Form
    {
        private Manager user;
        public SupperForm()
        {
            InitializeComponent();
        }
        public Manager User
        {
            set
            {
                user = value;
            }
            get
            {
                return user;
            }
        }
    }
}
