using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDReader2.model
{
    public class Manager
    {
        private int id;
        private string account;
        private string passwd;
        private int day;
        private int type;
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Account
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
        public string Passwd
        {
            set
            {
                passwd = value;
            }
            get
            {
                return passwd;
            }
        }
        public int Day
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
        public int Type
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
        public  override string ToString()
        {
            return this.account+":"+this.passwd+":"+this.type+":"+this.day;
        }
    }
}
