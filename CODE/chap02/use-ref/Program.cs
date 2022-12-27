using System;
class PhanSo{
	
	int Tu, Mau;

	public PhanSo() {
		Tu = 0;
		Mau = 1;
	}

	public PhanSo(int x) {
		Tu = x;
		Mau = 1;
	}
	
	public PhanSo(int t, int m) {
		Tu = t;
		Mau = m;
	}
	
	public void XuatPhanSo() {
		Console.WriteLine("({0}/{1})", Tu, Mau);
	}
	
	/*Hàm này có tác dụng nghịch đảo vì nó làm thay đổi
	các biến dữ liệu của p nhưng không làm thay đổi vùng
	nhớ của tham trị p.*/

	public static void NghichDao1(PhanSo p) {
		int t = p.Tu;
		p.Tu = p.Mau;
		p.Mau = t;
	}
	
	//Hàm này không có tác dụng nghịch đảo vì nó làm thay đổi vùng nhớ của tham trị p.
	public static void NghichDao2(PhanSo p) {
		PhanSo p2 = new PhanSo();
		p2.Mau = p.Tu;
		p2.Tu = p.Mau;
		p = p2;
	}
	
	//Hàm này có tác dụng nghịch đảo vì có từ khóa ref
	public static void NghichDao3(ref PhanSo p) {
		PhanSo p2 = new PhanSo();
		p2.Mau = p.Tu;
		p2.Tu = p.Mau;
		p = p2;
	}
}

class Program {
	static void Main(string[] args) 
	{
		PhanSo p1 = new PhanSo(3,1); // p1 = 3/1
		p1.XuatPhanSo(); 
		Console.WriteLine();
		
		PhanSo.NghichDao1(p1);
		p1.XuatPhanSo(); Console.WriteLine();
		
		PhanSo.NghichDao2(p1);
		p1.XuatPhanSo(); Console.WriteLine();
		
		PhanSo.NghichDao3(ref p1);
		p1.XuatPhanSo();
		Console.ReadLine();
	}
}