/*
Bài tập 2: Viết chương trình xây dựng lớp HinhTruTron (hình trụ tròn) với dữ liệu chiều cao và bán kính. Xây dựng các thuộc tính (property) DienTichDay (diên tích mặt đáy), DienTichXungQuanh (diên tích mặt xung quanh), TheTich (thể tích).
*/

using System;

namespace hinhtrutron{
	class HinhTruTron
	{
		double _Chieucao;
		double _Bankinh;

		public HinhTruTron()
		{
			_Chieucao = 0;
			_Bankinh = 0;
		}

		public double Bankinh
		{
			get { return _Bankinh; }
			set 
			{ 
				_Bankinh = value;
			}
		}

		public double Chieucao
		{
			get { return _Chieucao; }
			set 
			{ 
				_Chieucao = value;
			}
		}

		public double TheTich
		{
			get {return 3.14*Math.Pow(_Bankinh,2)*_Chieucao;}
		}

		public double DienTichXungQuanh
		{
			get {return 2*3.14*_Chieucao;}
		}

		public double DienTichDay
		{
			get {return 3.14*Math.Pow(_Bankinh,2);}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			HinhTruTron S = new HinhTruTron();
			S.Chieucao = 7; 
			S.Bankinh = 3;
			Console.WriteLine("Chieu Cao: {0}, Ban Kinh: {1}, The Tich: {2}, DienTichXungQuanh: {3}, DienTichDay: {4}",S.Chieucao,S.Bankinh,S.TheTich, S.DienTichXungQuanh,S.DienTichDay);
		}
	}
}