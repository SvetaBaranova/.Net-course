using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double lineA;
        private double lineB;
        private double lineC;
        public Triangle()
        {
            lineA = 0;
            lineB = 0;
            lineC = 0;
        }
        public Triangle(double a, double b, double c)
        {
            LineA = a;
            LineB = b;
            LineC = c;
        }
        public double LineA
        {
            get
            {
                return lineA;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Line of triangle can't be less or equality 0");
                }
                if (LineB == 0 || LineC == 0)
                {
                    lineA = value;
                }
                else if (value < (LineB + LineC) && LineB < (value + LineC) && LineC < (LineB + value))
                {
                    lineA = value;
                }
                else
                {
                    throw new ArgumentException($"Values {value}, {LineB}, {LineC} don't form a triangle");
                }
            }
        }
        public double LineB
        {
            get
            {
                return lineB;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Line of triangle can't be less or equality 0");
                }
                if (LineA == 0 || LineC == 0)
                {
                    lineB = value;
                }
                else if (value < (LineA + LineC)&& LineA < (value + LineC)&& LineC < (LineA + value))
                {
                    lineB = value;
                }
                else
                {
                    throw new ArgumentException($"Values {LineA}, {value}, {LineC} don't form a triangle");
                }
            }
        }
        public double LineC
        {
            get
            {
                return lineC;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Line of triangle can't be less or equality 0");
                }
                if (LineB == 0 || LineA == 0)
                {
                    lineC = value;
                }
                else if (value < (LineA + LineB) && LineA < (value + LineB) && LineB < (LineA + value))
                {
                    lineC = value;
                }
                else
                {
                    throw new ArgumentException($"Values {LineA}, {LineB}, {value} don't form a triangle");
                }
            }
        }
        public double TrianglePerimeter ()
        {
            return LineA + LineB + LineC;
        }
        public double TriangleArea()
        {
            double p = TrianglePerimeter() / 2;
            return Math.Sqrt(p*(p-LineA)*(p-LineB)*(p-LineC));
        }
    }
}
