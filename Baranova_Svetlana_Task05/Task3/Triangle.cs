using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {

        public Triangle(double a, double b, double c)
        {
            if ((LineA <= 0) || (LineB <= 0) || (LineC <= 0))
            {
                throw new ArgumentOutOfRangeException("Line of triangle can't be less or equality 0");
            }
            else if (LineB < (LineA + LineC) && LineA < (LineB + LineC) && LineC < (LineA + LineB))
            {
                LineA = a;
                LineB = b;
                LineC = c;
            }
            else
            {
                throw new ArgumentException($"Values {LineA}, {LineB}, {LineC} don't form a triangle");
            }
        }

        public double LineA
        { get;  private set; }
        public double LineB
        { get; private set;}
        public double LineC
        { get; private set; }
        public double Perimeter ()
        {
            return LineA + LineB + LineC;
        }
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p*(p-LineA)*(p-LineB)*(p-LineC));
        }
    }
}
