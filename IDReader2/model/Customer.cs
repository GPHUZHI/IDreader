using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDReader2.model
{
    class Customer
    {
        private int id;
        private string account;
        private string name;
        private string password;
        private string gender;
        private int availableday;
        private DateTime starttime;
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
        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }
        public string Gender
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
        public int AvailableDay
        {
            set
            {
                availableday = value;
            }
            get
            {
                return availableday;
            }
        }
        public DateTime StartTime
        {
            set
            {
                starttime = value;
            }
            get
            {
                return starttime;
            }
        }
        public string Name
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
        public override string ToString()
        {
            return this.id+":"+this.name+":"+this.account+":"+this.gender+":"
                +this.AvailableDay+":"+this.password+":"+this.starttime;
        }
    }
}
