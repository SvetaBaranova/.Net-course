using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
         static void Pyramid (int n, int center)
        {
            int star = 1;
            int space = center - 1;
            for (int i = 0; i < n; i++)
            {
                string s1 = new string(' ', space);
                string s2 = new string('*', star);
                Console.WriteLine("{0}", s1+s2);
                star += 2;
                space--;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int n = Int32.Parse(Console.ReadLine());
            for (int i=0; i<=n; i++)
            {
                Pyramid(i, n);
            }
            Console.ReadKey();
        }
    }
}
