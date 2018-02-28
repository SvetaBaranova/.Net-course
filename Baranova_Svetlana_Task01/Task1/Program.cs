using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write lenght a");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Write lenght b");
            int b = Int32.Parse(Console.ReadLine());
            int s = 0;
            if (a <= 0)
            {
                Console.WriteLine("Wrong value a");
            }
            else if (b <= 0)
            {
                Console.WriteLine("Wrong value b");
            }
            else
            {
                s = a * b;
                Console.WriteLine("Square = {0}", s);
            }
            Console.ReadKey();
        }
    }
}

