using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Let's see if you understand math.");
            Console.WriteLine("Here are two accurate statements:\n");

            Console.WriteLine($"3 times 3 is {SquareMathTest(3)}.");
            Console.WriteLine($"3.1 times 3.1 is {SquareMathTest(3.1)}.");

            Console.WriteLine("Did you understand these math problems? yes/no");
            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Good, because it took me forever to figure out how to code that.");
            }
            else
            {
                Console.WriteLine("Too bad. Consider rolling a rogue.");
            }

            Console.ReadLine();
        }

        static int SquareMathTest(int intValue)  //this is the method for squaring integers
        {
            return intValue * intValue;
        }

        static double SquareMathTest(double doubleValue)  //this one squares doubles
        {
            return doubleValue * doubleValue;
        }
    }
}
