using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
	public class ArithmeticalProgression : ISeries
	{
		double start, step;
		int currentIndex;

		public ArithmeticalProgression(double start, double step)
		{
			this.start = start;
			this.step = step;
			currentIndex = 0;
		}

		public double GetCurrent()
		{
			return start + step * currentIndex;
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

	public class List : ISeries
	{
		private double[] series;
		private int currentIndex;

		public List(double[] series)
		{
			this.series = series;
			currentIndex = 0;
		}

		public double GetCurrent()
		{
			return series[currentIndex];
		}

		public bool MoveNext()
		{
			currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
			return true;
		}

		public void Reset()
		{
			currentIndex = 0;
		}
	}
}
