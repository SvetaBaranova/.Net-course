using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                if (!series.MoveNext())
                {
                    break;
                }
                
            }
        }
        static void Main(string[] args)
        {
            ISeries progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            PrintSeries(progression);

            ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintSeries(list);

            ISeries my = new GeometricalProgression(1, 4);
            Console.WriteLine("Geometrical Progression:");
            PrintSeries(my);
            Console.ReadKey();
        }
    }
}
