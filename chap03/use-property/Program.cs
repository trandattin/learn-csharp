using System;

namespace property
{
	class Student 
	{
		string _Ten;
		float _DiemToan,_DiemTin,_DiemTB;

		// constructor
		public Student()
		{
			_Ten = "";
			_DiemToan = 0;
			_DiemTin = 0;
			_DiemTB = 0;
		}

		public string Ten
		{
			get {return _Ten; }
			set { _Ten = value;}
		}

		public float DiemToan
		{
			get {return _DiemToan;}
			set {
				_DiemToan = value;
				_DiemTB = (_DiemToan + _DiemTin)/2;
			}
		}

		public float DiemTin
		{
			get {return _DiemTin;}
			set {
				_DiemTin = value;
				_DiemTB = (_DiemToan + _DiemTin)/2;
			}
		}

		public float DiemTrungBinh 
		{
			get {return _DiemTB;}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.Ten = "Tin";
			s1.DiemToan = 101;
			s1.DiemTin = 10 ;
			Console.WriteLine("{0}",s1.Ten);
			Console.WriteLine("{0}",s1.DiemTin);
			Console.WriteLine("{0}",s1.DiemToan);
		}
	}
}