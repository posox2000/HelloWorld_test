using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_test
{
    public class Program
    {
        private static int cnt = 0;
        static void Main(string[] args)
        {
            MainProgram(args);
        }
        public static void MainProgram(string[] args)
        {
            string mode = "Prod";
            if (args.Length > 0)
            {
                var testMode = args[0];
                if (testMode == "Test" && args.Length == 3)
                    mode = args[0];
            }
            string text = string.Empty;
            if (cnt > 10)
                return;
            if (mode == "Prod")
            {
                Console.Clear();
                Console.Write("Please Enter Your Name: ");
                text = GetString();
            }
            else
            {
                Trace.Write("Please Enter Your Name: ");
                Trace.WriteLine(args[1]);
                text = args[1];
            }
            if (text.Length == 0)
            {
                cnt = cnt + 1;
                MainProgram(args);
            }
            else
            {
                cnt = 0;
                if (mode == "Prod")
                    Console.WriteLine(string.Format("Hello {0}!", text));
                else
                    Trace.WriteLine(string.Format("Hello {0}!", text));

                if (mode == "Test")
                    Year(text, args[2]);

                else
                    Year(text, null);

                if (mode == "Prod")
                {
                    Console.WriteLine("\nPress any key to exit!");
                    Console.ReadKey();
                }
            }
        }
        private static void Year(string name, string testData)
        {
            cnt = cnt + 1;
            int year = 0;
            string yearStr = string.Empty;
            if (cnt > 10)
                return;
            if (testData == null)
            {
                Console.Write(string.Format("{0}, what year were you born? ", name));

                yearStr = GetInt();
            }
            else
            {
                Trace.Write(string.Format("{0}, what year were you born? ", name));
                Trace.WriteLine(testData);
                yearStr = testData;
            }
            if(int.TryParse(yearStr, out year))
            {
                if (year > DateTime.Now.Year)
                    Year(name,testData);
                else {
                    switch (year % 12)
                    {
                        case 0:
                            if(testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the monkey.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the monkey.", name));
                            break;
                        case 1:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the rooster.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the rooster.", name));
                            break;
                        case 2:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the dog.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the dog.", name));
                            break;
                        case 3:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the pig.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the pig.", name));
                            break;
                        case 4:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the rat.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the rat.", name));
                            break;
                        case 5:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the ox.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the ox.", name));
                            break;
                        case 6:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the tiger.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the tiger.", name));
                            break;
                        case 7:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the rabbit.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the rabbit.", name));
                            break;
                        case 8:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the dragon.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the dragon.", name));
                            break;
                        case 9:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the snake.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the snake.", name));
                            break;
                        case 10:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the horse.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the horse.", name));
                            break;
                        case 11:
                            if (testData == null)
                                Console.WriteLine(string.Format("{0}, you were born in the year of the goat.", name));
                            else
                                Trace.WriteLine(string.Format("{0}, you were born in the year of the goat.", name));
                            break;
                        default:
                            Year(name, testData);
                            break;
                    }
                }
                
            }
            else
            {
                Year(name, testData);
            }
        }
        public static string GetString()
        {
            return Console.ReadLine();
        }
        public static string GetInt()
        {
            return Console.ReadLine();
        }

    }
}
