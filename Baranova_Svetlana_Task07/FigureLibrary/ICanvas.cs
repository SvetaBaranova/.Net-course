using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public interface ICanvas
    {
        void DrawLine(Point point1, Point point2);
        void DrawCircle(Point point1, double radius);
        void DrawRectangle(Point point1, Point point2, Point point3, Point point4);
    }
}
