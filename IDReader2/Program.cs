using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDReader2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //auto hotel
            model.Manager user = new model.Manager();
            user.Account = "trainning";
            user.Passwd = "trainning";
            user.Day = 3;
            user.Id = 1;
            user.Type = 2;
            Application.Run(new view.TrainForm());
        }
    }
}
