using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Circle: Figure
    {
        private double radius;
        public Point Coordinate { get; set; }

        public Circle (Point p, double r)
        {
            Coordinate = p;
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
                    throw new ArgumentException("Radius can't be less than 0");
                }
                radius = value;
            }
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawCircle(Coordinate, Radius);
        }
    }
}
