using System;

namespace Task3
{
    class Program
    {
        static void PrintIndex(IIndexable ind, int i)
        {
                Console.WriteLine("Значение с индексом {0} = {1}", i, ind[i]);
        }

        static void Main(string[] args)
        {
            IIndexable progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintIndex(progression, 29);

            IIndexable list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintIndex(list, 3);
            Console.ReadKey();
    }
    }
}
