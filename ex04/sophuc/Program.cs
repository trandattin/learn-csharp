// Xây dựng lớp SoPhuc(số phức) với các phương thức và các toán tử +,-,*,/, ép kiểu số phức sang kiểu số thực một cách tường minh, ép kiểu số phức sang chuỗi một cách ngầm định

using System;

class SoPhuc
{
	double _real,_image;

	// constructor 1
	public SoPhuc(double real, double image)
	{
		this._real = real;
		this._image = image;
	}

	// constructor 2
	public SoPhuc(double real)
	{
		this._real = real;
		this._image = 0;
	}

	// constructor 4
	public SoPhuc()
	{
		this._real = 0;
		this._image = 0;
	}

	public String Info
	{
		get {return _real + " + i"+_image;}
	}

	// +
	public static SoPhuc operator +(SoPhuc z1, SoPhuc z2)
	{
		double real_part = z1._real + z2._real;
		double image_part = z1._image + z2._image;
		return new SoPhuc(real_part, image_part);
	}

	// -
	public static SoPhuc operator -(SoPhuc z1, SoPhuc z2)
	{
		double real_part = z1._real - z2._real;
		double image_part = z1._image - z2._image;
		return new SoPhuc(real_part, image_part);
	}

	// *
	public static SoPhuc operator *(SoPhuc z1, SoPhuc z2)
	{
		double real_part = (z1._real*z2._real - z1._image*z2._image);
		double image_part = (z1._real*z2._image + z1._image*z2._real);
		return new SoPhuc(real_part, image_part);
	}

	// divide

	public static SoPhuc operator /(SoPhuc z1, SoPhuc z2)
	{
		double real_part = (z1._real*z2._real + z1._image*z2._image)/(z2._real*z2._real + z2._image*z2._image);

		double image_part = (z1._image*z2._real - z1._real*z2._image)/(z2._real*z2._real + z2._image*z2._image);

		return new SoPhuc(real_part, image_part);
	}

	public static explicit operator double(SoPhuc z)
	{
		return z._real;
	}

	public static implicit operator string (SoPhuc z)
	{
		Console.WriteLine("Thong bao");
		return z.Info;
	}
}

class Program
{
	static void Main(string[] args)
	{
		SoPhuc z1 = new SoPhuc(3,4);
		Console.WriteLine("z1: {0}",z1.Info);

		SoPhuc z2 = new SoPhuc(7,6);
		Console.WriteLine("z2: {0}",z2.Info);

		SoPhuc z3 = z1+z2;
		Console.WriteLine("z1 + z2: {0}", z3.Info);

		SoPhuc z4 = z1-z2;
		Console.WriteLine("z1 - z2: {0}", z4.Info);

		SoPhuc z5 = z1*z2;
		Console.WriteLine("z1 * z2: {0}", z5.Info);

		SoPhuc z6 = z1/z2;
		Console.WriteLine("z1 / z2: {0}", z6.Info);

		SoPhuc z7 = new SoPhuc(3,0);
		Console.WriteLine("z7: {0}",(double)z7);
	}
}