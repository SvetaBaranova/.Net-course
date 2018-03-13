using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring: Round
    {
        private double innerRadius;

        public Ring (double x, double y, double r, double ir) : base (x, y, r)
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
                if (value < 0)
                {
                    throw new ArgumentException("Radius can't be less that 0");
                }

                innerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                return (base.Area - Math.PI * InnerRadius * InnerRadius);
            }
        }

        public double Length
        {
            get
            {
                return (base.Length + 2 * Math.PI * InnerRadius);
            }
        }

    }
}
