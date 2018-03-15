using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void PrintIndex(IIndexable ind, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Значение с индексом {0} = {1}", i, ind[i]);
            }
        }

        static void Main(string[] args)
        {
            IIndexable progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintIndex(progression, 29);

            IIndexable list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintIndex(list, 5);
            Console.ReadKey();
    }
    }
}
