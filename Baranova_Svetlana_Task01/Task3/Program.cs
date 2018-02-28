using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int sum = 0;
            for (int i=0; i<n; i++)
            {
                if ((i%3==0)||(i%5==0))
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum = {0}", sum);
            int sum1 = 0;
            for (int i=0; i<n; i+=3)
            {
                sum1 += i;
            }
            for (int i = 0; i < n; i += 5)
            {
                if (!(i % 3 == 0))
                {
                    sum1 += i;
                }
            }
            Console.WriteLine("Sum1 = {0}", sum1);
            Console.ReadKey();
        }
    }
}
