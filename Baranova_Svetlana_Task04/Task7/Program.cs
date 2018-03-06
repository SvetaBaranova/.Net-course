using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Write string");
            text = Console.ReadLine();
            Regex rgTime = new Regex(@"([01][0-9]:[0-5][0-9])|([2][0-3]:[0-5][0-9])
                                        |(\D[0-9]:[0-5][0-9])");
            int n = rgTime.Matches(text).Count;
            Console.WriteLine("Count of time: {0}", n);
            Console.ReadKey();
        }
    }
}
