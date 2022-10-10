// Trong ví dụ lớp PhanSo ở trên, hãy bổ sung thêm toán tử ép kiểu phân số sang chuỗi một cách ngầm định

using System;
class PhanSo {
	int Tu, Mau; // private members
	//constructor
	public PhanSo(int TuSo, int MauSo) {
		this.Tu = TuSo;
		this.Mau = MauSo;
	}
	//constructor
	public PhanSo(int Number) {
		this.Tu = Number;
		this.Mau = 1;
	}
	//constructor
	public PhanSo() {
		this.Tu = 0;
		this.Mau = 1;
	}

	public String Info
	{
		get {return Tu + "/" + Mau;}
	}

	public static PhanSo operator + (PhanSo a, PhanSo b) 
	{
		int TuKq =  a.Tu * b.Mau + a.Mau;	
		int Maukq = a.Mau * b.Mau;
		return new PhanSo(TuKq,Maukq);
	}

	public static bool operator == (PhanSo a, PhanSo b)
	{
		if (a.Tu * b.Mau == a.Mau*b.Tu) return true;
		return false;
	}

	public static bool operator != (PhanSo a, PhanSo b)
	{
		if (a.Tu * b.Mau != a.Mau*b.Tu) return true;
		return false;
	}

	// public override int GetHashCode()
	// {
	// 	return base.GetHashCode();
	// }
	
	// Ép kiểu
	public static explicit operator int (PhanSo a)
	{
		return  a.Tu / a.Mau;
	}

	public static implicit operator string (PhanSo a)
	{
		return a.Info;
	}
}

class Program
{
	static void Main(string[] args)
	{
		PhanSo f1 = new PhanSo(9,3);
		Console.WriteLine("f1: {0}",f1.Info);

		PhanSo f2 = new PhanSo(2,4);
		Console.WriteLine("f2: {0}", f2.Info);

		PhanSo f3 = f1 + f2;
		Console.WriteLine("f1 + f2 = f3: {0}", f3.Info);

		Console.WriteLine(f1 == f2? "bang nhau" : "khac nhau");
		Console.WriteLine(f1.Info + " tuong ung voi so nguyen " + (int) f1);

		Console.WriteLine("f1 = " + f1);

	}

	
}