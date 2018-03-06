using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string html;
            Console.WriteLine("Write text");
            html = Console.ReadLine();
            Regex rg = new Regex (@"\<[\/\w\=\''\""\;\,\s]+\>");
            string replacement = "_";
            string result = rg.Replace(html, replacement);
            Console.WriteLine("Result: {0}", result);
            Console.ReadKey();
        }
    }
}
