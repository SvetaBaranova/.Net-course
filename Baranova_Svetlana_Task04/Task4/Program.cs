using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            TimeSpan sec;
            string str = "";
            StringBuilder sb = new StringBuilder();
            int[] N = {5, 10, 100, 1000, 100000};
            foreach (int n in N)
            {
                Console.WriteLine("For {0}", n);
                time.Start();
                for (int i = 0; i < n; i++)
                {
                    str += "*";
                }
                time.Stop();
                sec = time.Elapsed;
                Console.WriteLine("String work ms: {0}", sec.TotalMilliseconds);
                time.Reset();
                time.Start();
                for (int i = 0; i < n; i++)
                {
                    sb.Append("*");
                }
                time.Stop();
                sec = time.Elapsed;
                Console.WriteLine("String Builder work ms: {0}", sec.TotalMilliseconds);
            }
            Console.ReadKey();
        }
    }
}
