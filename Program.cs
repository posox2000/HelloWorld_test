using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(string.Format("Hello {0}!",args[0]));
            }
            else
            {
                Console.WriteLine("Hello World");
            }
            Console.WriteLine("Today's Date is: " + System.DateTime.Now);
            Console.WriteLine("\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
