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
            string s1;
            Console.WriteLine("Write first string");
            s1 = Console.ReadLine();
            string s2;
            Console.WriteLine("Write second string");
            s2 = Console.ReadLine();
            char[] mas = s2.Distinct().ToArray();
            for (int i = 0; i < mas.Length; i++)
            {
                int j = 0;
                while ((j = s1.IndexOf(mas[i], j)) > -1)
                {
                    s1 = s1.Insert(j, mas[i].ToString());
                    j += 2;
                }
            }
            Console.WriteLine("New string: \n{0}", s1);
            Console.ReadKey();
        }
    }
}
