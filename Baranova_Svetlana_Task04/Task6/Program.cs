using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("Write number");
            number = Console.ReadLine();
            Regex rgsience = new Regex(@"([0-9][e*^][\-0-9])");
            Regex rgnormal = new Regex(@"([0-9]\.[0-9]*)|([0-9])");
            if (rgsience.IsMatch(number))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else if (rgnormal.IsMatch(number))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
            Console.ReadKey();
        }
    }
}
