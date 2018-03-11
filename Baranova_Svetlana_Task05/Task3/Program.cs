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
            Triangle ex = new Triangle();
            ex.LineA = double.Parse(Console.ReadLine());
            ex.LineB = double.Parse(Console.ReadLine());
            ex.LineC = double.Parse(Console.ReadLine());
            Console.WriteLine($"{ex.TrianglePerimeter()}, {ex.TriangleArea()}");
            Console.ReadKey();
        }
    }
}
