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
            int[] mas = new int[4] { 1, 2, 3, 4 };
            DynamicArray<int> arr = new DynamicArray<int>(mas);
            Console.WriteLine("-------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-------");
            arr.Add(6);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-------");
            arr.RemoveIndex(4);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-------");
            arr.Insert(15, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-------");
            arr.SortArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            arr.Remove(15);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-------");
            arr.SortArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-------");
            foreach (int el in arr)
            {
                Console.WriteLine(el);
            }
            IEnumerable<int> arrayNew = new int[5] { 2, 5, 2, 5, 2};
            DynamicArray<int> arr1 = new DynamicArray<int>(arrayNew);
            Console.WriteLine("-------");
            foreach (int el in arr1)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
    }
}
