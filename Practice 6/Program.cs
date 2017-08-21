using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class MySecondClass
    {
        public MySecondClass()
        {
            Console.WriteLine("Constructor!");
        }
        ~MySecondClass()
        {
            Console.WriteLine("Destructor!");
            Console.ReadLine();
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {do
            {
                MySecondClass classy = new MySecondClass();
                classy = null;
                GC.Collect();

                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write("Press ENTER to continue... ");
                Console.ReadLine();
                Console.Clear();
            } while (true);

        }
    }
}
