using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
        static void WriteDash(string message)
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
            bool MExit = false;
            string Input;
            string input = "";
            string welcome = "Welcome to Federation Bank";
            do
            {

                do
                {
                Console.WriteLine("Please enter your full name. ");
                Input = Console.ReadLine();
                input = Input.Trim();
                } while (input.Length <= 1);

                BankAccount mBank = new BankAccount(input, 0);
                do
                {
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
                    byte x = 0;
                    do
                    {
                        Console.WriteLine("What would you like to do?");
                        try
                        {
                            string choice = Console.ReadLine();
                            x = Convert.ToByte(choice);
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
                            Console.WriteLine(mBank.GetCustomer());
                            Console.WriteLine(mBank.GetBalance());
                            Console.ReadLine();
                            break;
                        case (int)Choice.ChangeCustomerName:
                            do
                            {
                                Console.WriteLine("Please enter your full name. ");
                                Input = Console.ReadLine();
                                input = Input.Trim();
                            } while (input.Length <= 1);
                            mBank.SetCustName(input);
                            break;
                        case (int)Choice.Withdraw:
                            float WithdrawalAmmount = 0;
                            do
                            {
                                Console.WriteLine("How much would you like to withdraw?");
                                try
                                {
                                    string Winput = Console.ReadLine();
                                    WithdrawalAmmount = (float)(Convert.ToDouble(Winput));
                                    isReadGood = true;
                                }
                                catch (Exception)
                                {
                                    isReadGood = false;
                                }

                            } while (isReadGood == false);
                            mBank.Withdraw(WithdrawalAmmount);
                            break;
                        case (int)Choice.Deposit:
                            float DepositAmmount = 0;
                            do
                            {
                                Console.WriteLine("How much would you like to deposit?");
                                try
                                {
                                    string Dinput = Console.ReadLine();
                                    DepositAmmount = (float)(Convert.ToDouble(Dinput));
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
                            if (mBank.GetmHist() > 0)
                            {
                                int ReceiptChoice = 0;
                                do
                                {
                                    Console.WriteLine("Would you like a receipt? \r\n1) Yes. \r\n2) No.");
                                    try
                                    {
                                        string Rinput = Console.ReadLine();
                                        ReceiptChoice = (int)(Convert.ToDouble(Rinput));
                                        isReadGood = true;
                                    }
                                    catch (Exception)
                                    {
                                        isReadGood = false;
                                    }
                                } while (isReadGood == false || ReceiptChoice > 2 || ReceiptChoice < 1);
                                if (ReceiptChoice == 1)
                                {
                                    mBank.Receipt();
                                }
                            }
                            MExit = true;
                            break;
                        default:
                            break;
                    }
                } while (MExit == false);
                Console.Clear();
                Console.WriteLine("Thank you, and have a nice day!");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }
    }
}
