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
            int[] mas = new int[4] { 1, 2, 3, 4 };
            DynamicArray<int> arr = new DynamicArray<int>(mas);
            arr = arr.Add(6);
            arr = arr.Insert(15, 4);
            foreach (int el in arr.arr)
            {
                Console.WriteLine(el);
            }
            arr.Remove(4);
            foreach (int el in arr.arr)
            {
                Console.WriteLine(el);
            }
            string[] mas2 = new string[4] { "bfc", "788", "bhk", "788" };
            DynamicArray<string> arr2 = new DynamicArray<string>(mas2);
            arr2 = arr2.Add("khhh");
            arr2 = arr2.Insert("hhg897", 4);
            foreach (string el in arr2.arr)
            {
                Console.WriteLine(el);
            }
            arr2.Remove(4);
            foreach (string el in arr2.arr)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
    }
}
