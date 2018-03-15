using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GeometricalProgression : ISeries
    {
        public double start, denominator;
        int currentIndex;

        public GeometricalProgression(double start, double denominator)
        {
            this.start = start;
            this.denominator = denominator;
            currentIndex = 0;
        }
        public double GetCurrent()
        {
            return (start*Math.Pow(denominator, currentIndex));
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }
    }
}
