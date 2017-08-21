using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_7._02
{
    public class BankAccount
    {
        public string mCustomer;
        float mBalance;
        //constructors
        public BankAccount() {}
        public BankAccount(string name)
        {
            mCustomer = name;
        }
        public BankAccount(string name, float InitBalance)
        {
            mCustomer = name;
            mBalance = InitBalance;
        }
        //methods
        public void SetCustName (string name)
        {
            mCustomer = name;
        }
        public string GetCustomer ()
        {
            return mCustomer;
        }
        public float GetBalance()
        {
            return mBalance;
        }
        bool Withdraw (float ammount)
        {
            if (ammount >= 0)
            {

            }
            return false;
        }
        bool Deposit (float ammount)
        {
            if (ammount >= 0)
            {

            }
            return false;
        }
    }
}