using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;
using System.Drawing;

namespace Task1
{
    class ConsoleCanvas : ICanvas
    {
        public void DrawCircle(Point point1, double radius)
        {
            Console.WriteLine($"Окружность с координатами центра ({point1}) и радиусом {radius}");
        }

        public void DrawLine(Point point1, Point point2)
        {
            Console.WriteLine($"Линия с координатами начала ({point1}) и конца ({point2})");
        }

        public void DrawRectangle(Point p1, Point p2, Point p3, Point p4)
        {
            Console.WriteLine($"Прямоугольник c координатами:\n{p1}\n{p2}\n{p3}\n{p4}");
        }
    }
}
