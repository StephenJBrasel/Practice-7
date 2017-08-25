using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_7._02
{
    public class BankAccount
    {
        string mCustomer;
        float mBalance;
        private List<float> mDep;
        private List<float> mWith;
        private List<float> mHist;

        //constructors
        public BankAccount()
        {
            this.mDep = new List<float>();
            this.mWith = new List<float>();
            this.mHist = new List<float>();
        }
        public BankAccount(string name)
        {
            mCustomer = name;
            this.mDep = new List<float>();
            this.mWith = new List<float>();
            this.mHist = new List<float>();
        }
        public BankAccount(string name, float InitBalance)
        {
            mCustomer = name;
            mBalance = InitBalance;
            this.mDep = new List<float>();
            this.mWith = new List<float>();
            this.mHist = new List<float>();
        }
        //methods
        public void SetCustName(string name)
        {
            name.Trim();
            while (name.Length <= 1)
            {
                Console.WriteLine("Please enter your full name.");
                string Name = Console.ReadLine();
                name = Name.Trim();
            }
            mCustomer = name;
        }
        public string GetCustomer()
        {
            return mCustomer;
        }
        public float GetBalance()
        {
            return mBalance;
        }
        public int GetmHist()
        {
            return mHist.Count();
        }
        public bool Withdraw(float withd)
        {
            if (withd < float.MaxValue && mBalance - withd >= 0)
            {
                mBalance -= withd;
                mWith.Add(withd);
                mHist.Add(-withd);
                return true;
            }
            else if (withd < float.MaxValue && mBalance - withd < 0)
            {
                Console.WriteLine("We're sorry, your account does not have overdraft protection.");
                return false;
            }
            else
            {
                Console.WriteLine("We're sorry, this ATM cannot give you that ammount.");
                return false;
            }
        }
        public bool Deposit(float dep)
        {
            if (dep >= 0 && dep + mBalance <= float.MaxValue)
            {
                mBalance += dep;
                mDep.Add(dep);
                mHist.Add(dep);
                return true;
            }
            else
            {
                Console.WriteLine("We're sorry, this ATM cannot accept that ammount.");
                return false;
            }
        }
        public void Receipt()
        {
            Console.WriteLine("Your balance is {0: #.00}", mBalance);
            for (int i = 0; i < mDep.Count; i++)
            {
                Console.WriteLine("Your transactions were: {0: #.00}", mDep[i]);
                mDep.Remove(mDep[i]); 
                i--;
            }
            for (int i = 0; i < mWith.Count; i++)
            {
                Console.WriteLine("Your transactions were: -{0: #.00}", mWith[i]);
                mWith.Remove(mWith[i]); 
                i--;
            }
            Console.ReadLine();
        }

    }
}
