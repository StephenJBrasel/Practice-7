using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_7._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Finalize Input Validation for the Customer Name.
            Console.WriteLine("Please enter your name. ");
            try 
	        {	        
                string input = Console.ReadLine();
	        }
	        catch (Exception)
	        {

		        throw;
	        }
            BankAccount mBank = new BankAccount(input);

        }
    }
}
