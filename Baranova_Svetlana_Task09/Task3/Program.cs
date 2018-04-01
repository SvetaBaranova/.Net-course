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
            Regex rgx = new Regex("[^\\w]+");
            string str;
            str = Console.ReadLine();
            str.Trim();
            string[] arrWord = rgx.Split(str);
            Dictionary<string, int> word = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
            foreach (var el in arrWord)
            {
                if (word.ContainsKey(el))
                {
                    word[el]++;
                }
                else
                {
                    word.Add(el, 1);
                }
            }
            foreach (var el in word)
            {
                Console.WriteLine($"{el.Key} - {el.Value}");
            }
            Console.WriteLine("-----");
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
