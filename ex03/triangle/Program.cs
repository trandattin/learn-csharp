/*
Bài tập 1: Viết chương trình xây dựng lớp TamGiac với dữ liệu là 3 cạnh của tam giác. Xây dựng các thuộc tính (property) ChuVi, DienTich và các phương thức kiểm tra kiểu của tam giác (thường, vuông, cân, vuông cân, đều).
*/

using System;

namespace Triangle
{
	public class TamGiac
	{
		double _CanhA,_CanhB,_CanhC;
		// double _ChuVi;
		// double _DienTich;

		public TamGiac()
		{
			_CanhA = 0;
			_CanhB = 0;
			_CanhC = 0;

		}

		public double CanhA
		{
			get {return _CanhA;}
			set 
			{ 
				_CanhA = value; 
			}
		}

		public double CanhB
		{
			get {return _CanhB;}
			set 
			{
				_CanhB = value; 
			}
		}

		public double CanhC
		{
			get {return _CanhC;}
			set 
			{ 
				_CanhC = value; 
			}
		}


		public double ChuVi 
		{
			get {return _CanhA + _CanhB + _CanhC;}
		}

		public double DienTich 
		{
			get 
			{
				double semi = ChuVi/2;
				return Math.Sqrt(semi*(semi - _CanhA)*(semi - _CanhB)*(semi - _CanhC));
			}
		}

		public void equilateral()
		{
			if (this._CanhA==this._CanhB && this._CanhB == this._CanhC) 
			{
				Console.WriteLine("This is an equilateral triangle");
			} 
			else
			{
				Console.Write("This is not an equilateral triangle.");
			}
		}

		public bool IsEquilateral
		{
			get 
			{ 
				return this._CanhA==this._CanhB && this._CanhB == this._CanhC;
			}
		}

		public void isosceles()
		{
			if (this._CanhA == this._CanhB || this._CanhA == this._CanhC || this._CanhB == this._CanhC)
			{
				Console.Write("This is an isosceles triangle.");  
			} 
			else 
			{
				Console.Write("This is not an isosceles triangle.");
			}
		}

		public void right()
		{
			bool a= false;
			bool b= false;
			bool c= false;
			if (this._CanhC*this._CanhC == this._CanhA*this._CanhA + this._CanhB*this._CanhB)
			{
				c = true;
			}

			if (this._CanhA*this._CanhA == this._CanhB*this._CanhB + this._CanhC*this._CanhC)
			{
				a = true;
			}

			if (this._CanhB*this._CanhB == this._CanhA*this._CanhA + this._CanhC*this._CanhC)
			{
				c = true;
			}
			if (a || b || c)
			{
				Console.WriteLine("This is a right triangle");
			}
			else
			{
				Console.WriteLine("This is not an right triangle.\n");
			}
		}
	}

	class Programe
	{
		static void Main (string[] args)
		{
			TamGiac ABC = new TamGiac();
			ABC.CanhA = 5;
			ABC.CanhB = 6;
			ABC.CanhC = 7;
			Console.WriteLine("Canh A: {0}, Canh B: {1}, Canh C: {2}, Chu Vi: {3}, Dien tich: {4}",ABC.CanhA,ABC.CanhB,ABC.CanhC,ABC.ChuVi, ABC.DienTich);
			ABC.right();
			ABC.equilateral();
			ABC.isosceles();
		}
	}
}