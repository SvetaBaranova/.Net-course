using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void RemoveEachSecondItem<T>(ICollection<T> list)
        {
            T[] mas = new T[list.Count / 2];
            int j = 0;
            if (list.Count%2 == 0)
            {
                for (int i = 0; i < list.Count; i++)
                    {
                        if (i % 2 != 0)
                        {
                            mas[j] = list.ElementAt(i);
                            j++;
                        }
                    }
                for (int i = 0; i < mas.Length; i++)
                {
                    list.Remove(mas[i]);
                }
            }
            mas = new T[(list.Count+1) / 2];
            j = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0)
                {
                    mas[j] = list.ElementAt(i);
                    j++;
                }
            }
            while (list.Count > 1)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    list.Remove(mas[i]);
                }
                mas = new T[(list.Count + 1) / 2];
                j = 0;
                for (int i = 0; i < list.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            mas[j] = list.ElementAt(i);
                            j++;
                        }
                    }
            }
        }
        static void Main(string[] args)
        {
            int[] people = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            List<int> myList = new List<int>(people);
            LinkedList<int> myLinked = new LinkedList<int>(people);
            RemoveEachSecondItem(myList);
            RemoveEachSecondItem(myLinked);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----");
            foreach (int i in myLinked)
            {
                Console.WriteLine(i);
            }
            string[] people1 = new string[11] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "M", "N" };
            List<string> myList1 = new List<string>(people1);
            LinkedList<string> myLinked1 = new LinkedList<string>(people1);
            RemoveEachSecondItem(myList1);
            RemoveEachSecondItem(myLinked1);
            foreach (string i in myList1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----");
            foreach (string i in myLinked1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
