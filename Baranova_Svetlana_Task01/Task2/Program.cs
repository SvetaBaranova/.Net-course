using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int n = Int32.Parse(Console.ReadLine());
            int star = 1;
            for (int i=0; i<n; i++)
            {
                string s1 = new string('*', star);
                Console.WriteLine("{0}", s1);
                star ++;
            }
            Console.ReadKey();
        }
    }
}
