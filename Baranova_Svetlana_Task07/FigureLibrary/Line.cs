using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FigureLibrary
{
    public class Line: Figure
    {
        public Point CoordinateStart { get; set; }
        public Point CoordinateEnd { get; set; }

        public Line(Point pstart, Point pend)
        {
            CoordinateStart = pstart;
            CoordinateEnd = pend;
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawLine(CoordinateStart, CoordinateEnd);
        }
    }
}
