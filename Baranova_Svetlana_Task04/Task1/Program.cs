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
            string s;
            Console.WriteLine("Write string");
            s = Console.ReadLine();
            double countWord = 0;
            int countChar = 0;
            string[] mas = s.Split(' ');
            char[] word = s.ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (!(char.IsPunctuation(word[i])||(char.IsWhiteSpace(word[i]))))
                {
                    countChar ++;
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] != "")
                {
                    countWord++;
                }
            }
            Console.WriteLine("Average length of word: {0}", countChar / countWord);
            Console.ReadKey();
        }
    }
}
