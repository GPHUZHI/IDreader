using IDReader2.dao;
using IDReader2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IDReader2.util
{
    class CustomerServer
    {
        internal void OpenCheckUser()
        {
            Thread checkUser = new Thread(new ThreadStart(CheckUser));
            checkUser.IsBackground = true;
            checkUser.Start();
        }
        //每隔1小时修改数据库中的过期用户
        private void CheckUser()
        {
            while (true)
            {
                Console.WriteLine("睡眠" + (1000 * 60 * 60) + "ms，读取数据库");
                try {
                    RemoveUnavailableUser();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                Thread.Sleep(1000 * 60 * 60);
            }
        }
        private void RemoveUnavailableUser()
        {
            List<Customer> users = CustomerDao.GetAvailableUser();
            if (users != null)
            {
                foreach (Customer u in users)
                {
                    if ((DateTime.Now - u.StartTime).Days > u.AvailableDay)
                    {
                        CustomerDao.RemoveCustomerDao(u);
                        Console.WriteLine(u);
                    }
                }
            }
        }
    }
}
