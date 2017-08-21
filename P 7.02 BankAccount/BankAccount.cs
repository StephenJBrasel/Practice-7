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
            name.Trim();
            while (name.Length <= 1)
	        {
                Console.WriteLine("Please enter your full name.");
                name.Trim = Console.ReadLine();
	        }
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
            if (ammount < float.MaxValue && mBalance-ammount >= 0)
            {
                mBalance -= ammount;
                return true;
            }
            else if (ammount < float.MaxValue && mBalance-ammount <0)
	        {
                Console.WriteLine("We're sorry, your account does not have overdraft protection.");
	        }
            else
	        {
                Console.WriteLine("We're sorry, this ATM cannot give you that ammount.");
                return false;
	        }
        }
        bool Deposit (float ammount)
        {
            if (ammount >= 0 && ammount + mBalance <= float.MaxValue)
            {
                mBalance += ammount;
                return true;
            }
            else
	        {
                Console.WriteLine("We're sorry, this ATM cannot accept that ammount.");
                return false;
	        }
        }
    }
}