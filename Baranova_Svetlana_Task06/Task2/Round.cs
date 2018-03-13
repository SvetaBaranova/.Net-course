using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private double radius;
        private double coordinateX;
        private double coordinateY;

        public Round() { }

        public Round(double x, double y, double r)
        {
            CoordinateX = x;
            CoordinateY = y;
            Radius = r;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius can't be less that 0");
                }

                radius = value;
            }
        }

        public double CoordinateX
        {
            get
            {
                return coordinateX;
            }
            set
            {
                coordinateX = value;
            }
        }
        public double CoordinateY
        {
            get
            {
                return coordinateY;
            }
            set
            {
                coordinateY = value;
            }
        }
        public double Length
        {
            get
            {
                return 2 * 3.14 * Radius;
            }
        }
        public double Area
        {
            get
            {
                return 3.14 * Radius * Radius;
            }
        }
        static double AreaRound(double rad)
        {
            return Math.PI * rad * rad;
        }
    }
}
