using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_7._02
{
    class Program
    {
        public enum Choice 
        {
        DisplayAccountInfo, 
        ChangeCustomerName, 
        Withdraw,
        Deposit,
        Exit
        };
        static void WriteDash (string message)
        {
            for (int i = 0; i < message.Length; i++)
			{
                Console.Write("-");
		    }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            bool isReadGood = false;
            string input;
            string welcome = "Welcome to Federation Bank";
            do
	        {

                Console.WriteLine("Please enter your name. ");
                input = Console.ReadLine();
                do
	            {
                    if (input.Trim <= 1)
	                {
                        Console.WriteLine("Please enter your full name.");
	                }
	            } while (input.Trim <= 1);

                BankAccount mBank = new BankAccount(input, 0);
                
                Console.Clear();
                
                WriteDash(welcome);
                Console.WriteLine(welcome);
                WriteDash(welcome);
                Console.WriteLine("1) Display Account Info ");
                Console.WriteLine("2) Change Customer Name ");
                Console.WriteLine("3) Withdraw ");
                Console.WriteLine("4) Deposit ");
                Console.WriteLine("5) Exit ");
                WriteDash(welcome);
                do
	            {
                    Console.WriteLine("What would you like to do?");
                    try 
	                {	        
		                string choice = Console.ReadLine();
                        byte x = Convert.ToByte(choice);
                        isReadGood = true;
	                }
	                catch (Exception)
	                {
                        isReadGood = false;
	                }
	            } while (isReadGood == false || x < 1 || x > 5);
                switch (x - 1)
	            {
		            case (int)Choice.DisplayAccountInfo:
                        Console.WriteLine(mBank.GetCustomer);
                        Console.WriteLine(mBank.GetBalance);
                        break;
                    case (int)Choice.ChangeCustomerName:
                        Console.WriteLine("Please enter your name. ");
                        input = Console.ReadLine();
                        do
	                    {
                            if (input.Trim <= 1)
	                        {
                                Console.WriteLine("Please enter your full name.");
	                        }
	                    } while (input.Trim <= 1);
                        mBank.SetCustName(input);
                        break;
                    case (int)Choice.Withdraw:
                        do
	                    {
                            Console.WriteLine("How much would you like to Withdraw?");
                            try 
	                        {	        
		                        string input = Console.ReadLine();
                                float WithdrawalAmmount = (float)(Convert.ToDouble(input));
                                isReadGood = true;
	                        }
	                        catch (Exception)
	                        {
                                isReadGood = false;
	                        }

	                    } while (isReadGood == false);
                        mBank.Withdray(WithdrawalAmmount);
                        break;
                    case (int)Choice.Deposit:
                        do
	                    {
                            Console.WriteLine("How much would you like to Deposit?");
                            try 
	                        {	        
		                        string input = Console.ReadLine();
                                float DepositAmmount = (float)(Convert.ToDouble(input));
                                isReadGood = true;
	                        }
	                        catch (Exception)
	                        {
                                isReadGood = false;
	                        }

	                    } while (isReadGood == false);
                        mBank.Deposit(DepositAmmount);
                        break;
                    case (int)Choice.Exit:
                        break;
                    default:
                        break;
	            }
                
	        } while (true);

        }
    }
}
