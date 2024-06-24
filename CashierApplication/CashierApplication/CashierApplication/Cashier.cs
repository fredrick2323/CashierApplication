using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class Cashier : UserAccount
    {
        private string department;D

        public Cashier(string name, string uName, string password) : base(name, uName, password)
        {
            this.user_name = uName;
            this.user_password = password;
        }

        public override bool validateLogin(string uName, string password)
        {
            if (uName.Equals(this.username) && password.Equals(this.password))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public string getDepartment()
        {
            department = "Finance";
            return department;
        }
    }
}