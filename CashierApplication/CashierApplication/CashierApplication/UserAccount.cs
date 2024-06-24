using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        protected string username = "Cashier23";
        protected string password = "cashier23";
        public UserAccount(string name, string uName, string password)
        {
            this.full_name = "Dorong Freidrick craig ";
            this.user_name = uName;
            this.user_password = password;
        }

        public abstract bool validateLogin(string uName, string password);

        public string getFullName()
        {
            return full_name;
        }
    }
}