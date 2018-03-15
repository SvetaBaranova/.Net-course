using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Rectangle: Figure
    {
        private Point point1;
        private Point point3;

        public Rectangle (Point p1, Point p3)
        {
            if ((p1.X == p3.X) || (p1.Y == p3.Y))
            {
                throw new ArgumentException("Value of points don't form rectangle");
            }
            point1 = p1;
            point3 = p3;
        }

        public Point Point1
        {
            get
            {
                return point1;
            }
        }

        public Point Point2
        {
            get
            {
                return new Point (Point3.X, Point1.Y);
            }
        }


        public Point Point3
        {
            get
            {
                return point3;
            }
        }

        public Point Point4
        {
            get
            {
                return new Point(Point1.X, Point3.Y);
            }
        }


        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRectangle(Point1, Point2, Point3, Point4);
        }
    }
}
