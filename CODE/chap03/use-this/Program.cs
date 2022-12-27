using System;
class Cot
{
	char Ten;
	uint[] Disks;
	static uint Size = 10;
	uint Top = 0;

	public Cot(char TenCot)
	{
		this.Disks = new uint[Size];
		this.Top = 0;
		this.Ten = TenCot;
	}

	public Cot(char TenCot, uint SoDia)
	{
		this.Disks = new uint [Size];
		this.Top = SoDia;
		this.Ten = TenCot;
		for (uint n = SoDia; n > 0; n--)
			Disks[SoDia - n] = n;
	}

	public void chuyen1Dia(Cot Dich)
	{
		this.Top--;
		Console.WriteLine("Chuyen dia {0} tu {1} sang {2}",this.Disks[Top],this.Ten,Dich.Ten);
		Dich.Disks[Dich.Top] = this.Disks[Top]; 
		Dich.Top++;
	}

	// Chuyển n đĩa trên cùng từ cột hiện tại sang C lấy B làm trung gian
	public void chuyenNhieuDia(uint n, Cot B, Cot C)
	{
		if (n == 0) return;
		if (n == 0) chuyen1Dia(C);
		else 
		{
			this.chuyenNhieuDia(n-1,C,B);
			this.chuyen1Dia(C);
			B.chuyenNhieuDia(n-1, this, C);
		}
	}
}

class Program{
	static void Main(string[] args) 
	{
		Cot A = new Cot('A',3);
		Cot B = new Cot('B');
		Cot C = new Cot('C');

		A.chuyenNhieuDia(3,B,C);
	}
}