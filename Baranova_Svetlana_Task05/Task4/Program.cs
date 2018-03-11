using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString (Console.ReadLine().ToArray());
            MyString str1 = new MyString(Console.ReadLine().ToArray());
            Console.WriteLine($"+  {str+str1}");
            Console.WriteLine($"-  {str - str1}");
            Console.WriteLine($"==  {str == str1}");
            Console.ReadKey();
        }
    }
}
