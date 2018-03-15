using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Ring: Circle
    {
        private double innerRadius;

        public Ring(Point p, double r, double ir) : base(p, r)
        {
            InnerRadius = ir;
        }

        public double InnerRadius
        {
            get
            {
                return innerRadius;
            }
            set
            {
                if (value < 0 || value >= Radius)
                {
                    throw new ArgumentException("Inner radius have wrong value");
                }
                innerRadius = value;
            }
        }

        public override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);
            canvas.DrawCircle(Coordinate, InnerRadius);
        }
    }
}
