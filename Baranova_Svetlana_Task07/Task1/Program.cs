using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;
using System.Drawing;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] my = new Figure[4];
            Point p1 = new Point(3, 5);
            Point p2 = new Point(6, 9);
            my[0] = new Circle(p1, 4);
            my[1] = new Line(p1, p2);
            my[2] = new FigureLibrary.Rectangle(p1, p2);
            my[3] = new Ring(p2, 7, 2);
            ConsoleCanvas can = new ConsoleCanvas();
            for(int i=0; i<4; i++)
            {
                my[i].Draw(can);
            }
            Console.ReadKey();
        }
    }
}
