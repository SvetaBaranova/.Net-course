using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex rgx = new Regex("[\\s\\p{P}]+");
            string str;
            str = Console.ReadLine();
            string[] arrWord = rgx.Split(str);
            IEnumerable < string > onlyWord = arrWord.Distinct(StringComparer.CurrentCultureIgnoreCase);
            foreach (var el in onlyWord)
            {
                double count = 0;
                for (int i = 0; i < arrWord.Length; i++)
                {
                    if (string.Compare(el, arrWord[i], true) == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{el} - {count/arrWord.Length*100}%");
            }
            Console.ReadKey();
        }
    }
}
