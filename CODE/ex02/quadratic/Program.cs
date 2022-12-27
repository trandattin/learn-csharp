using System;

namespace quadratic
{
	class Quadratic 
	{
		double _a,_b,_c;

		public Quadratic()
		{
			_a = 0;
			_b = 0;
			_c = 0;
		}

		public double a
		{
			set
			{
				_a = value;
			}
		}

		public double b
		{
			set
			{
				_b = value;
			}
		}

		
		public double c
		{
			set
			{
				_c = value;
			}
		}

		public double delta
		{
			get
			{
				return Math.Pow(_b,2) - 4*_a*_c;
			}
		}

		public double x1
		{
			get
			{
				if (delta < 0)
				{
					throw new Exception("Vo nghiem");
				}
				else
				{
					return (-_b + Math.Sqrt(delta))/(2*_a);
				}
			}
		}
		public double x2
		{
			get
			{
				if (delta < 0)
				{
					throw new Exception("Vo nghiem");
				}
				else
				{
					return (-_b - Math.Sqrt(delta))/(2*_a);
				}
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Quadratic pt1 = new Quadratic();
			pt1.a = -1;
			pt1.b = -1;
			pt1.c = 2;
			Console.WriteLine("x1 = {0}, x2 = {1}",pt1.x1,pt1.x2);
		}
	}
}