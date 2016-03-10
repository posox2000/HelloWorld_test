using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld_test.Utils;

namespace HelloWorld_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTimeCalculator = new TimeHelper();
            var days = myTimeCalculator.GetDayOfTheYear(DateTime.Now);
            
            if (args.Length > 0)
            {
                Console.WriteLine(string.Format("Hello {0}!",args[0]));
                
            }
            else
            {
                Console.WriteLine("Hello World");
            }
            Console.WriteLine(string.Format("{0} - days after year begins...", days));

            Console.WriteLine("\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
