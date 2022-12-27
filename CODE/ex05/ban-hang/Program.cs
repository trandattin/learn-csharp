using System;

namespace CuaHang{

	class NhieuThucPham
	{
		private int _Size1;
		private int _Size2;
		private DongHop[] danhsachthucpham;
		private KhongDongHop[] danhsachthucpham2;

		public NhieuThucPham(int n, int m)
        {
            this._Size1= n;
            this._Size2= m;
            this.danhsachthucpham = new DongHop[n];
            this.danhsachthucpham2 = new KhongDongHop[m];
        }

        public void Nhap()
        {
			Console.WriteLine("THUC PHAM DONG HOP");
			for (int i = 0; i < this._Size1; i++)
			{
				Console.WriteLine("Name Product {0} = ", i+1);
				string name = Console.ReadLine();
				Console.WriteLine("Price Product {0} = ", i+1);
				double price = double.Parse(Console.ReadLine());
				Console.WriteLine("HSD Product {0} = ", i+1);
				string hsd = Console.ReadLine();
				this.danhsachthucpham[i] = new DongHop(name, price, hsd);
			}

			Console.WriteLine("THUC PHAM KHONG DONG HOP");
			for (int i = 0; i < this._Size2; i++)
			{
				Console.WriteLine("Name Product {0} = ", i+1);
				string name = Console.ReadLine();
				Console.WriteLine("Price Product {0} = ", i+1);
				double price = double.Parse(Console.ReadLine());
				Console.WriteLine("Weight Product {0} = ", i+1);
				double weight = double.Parse(Console.ReadLine());
				this.danhsachthucpham2[i] = new KhongDongHop(name, price, weight);
			}
        }

		public void xuat()
        {
        	foreach (DongHop x in danhsachthucpham)
            	if (x != null)
                	x.Xuat();
			foreach (KhongDongHop x in danhsachthucpham2)
            	if (x != null)
                	x.Xuat();
        }
	}
	class ThucPham 
	{
		protected string name;
		protected double price;
		public void Nhap ()
		{
			Console.Write("Name Product = ");
			this.name = Console.ReadLine();
			Console.Write("Price = ");
			this.price = double.Parse(Console.ReadLine());
		}

		public void Xuat()
		{
			Console.WriteLine("Name Product: {0}", name);
			Console.WriteLine("Price: {0}", price);
		}

		public ThucPham()
		{
			this.name = "0";
			this.price = 0;
		}

		public ThucPham(string name, double price)
		{
			this.name = name;
			this.price = price;
		}

		public string Name
		{
			get { return this.name;}
			set { this.name = value;}
		}

		public double Price
		{
			get { return this.price;}
			set { this.price = value;}
		}
	}

	class DongHop : ThucPham
	{
		string hsd;
		public new void Xuat()
		{
			base.Xuat();
			Console.WriteLine("HSD: {0}", hsd);
		}

		public new void Nhap()
		{
			base.Nhap();
			Console.Write("HSD = ");
			this.hsd = Console.ReadLine();
		}

		public DongHop(string name, double price, string hsd) : base (name, price)
		{
			this.hsd = hsd;
		}

		public DongHop()
		{
			this.name = "0";
			this.price = 0;
			this.hsd = "0";
		}

		public string HSD
		{
			get { return this.hsd;}
			set { this.hsd = value;}
		}
	}

	class KhongDongHop : ThucPham
	{
		double weight;
		public new void Xuat()
		{
			base.Xuat();
			Console.WriteLine("Weight: {0}", weight);
		}

		public new void Nhap()
		{
			base.Nhap();
			Console.Write("Weight = ");
			this.weight = double.Parse(Console.ReadLine());
		}

		public KhongDongHop(string name, double price, double weight) : base (name, price)
		{
			this.weight = weight;
		}

		public KhongDongHop()
		{
			this.name = "0";
			this.price = 0;
			this.weight = 0;
		}

		public double Weight
		{
			get { return this.weight;}
			set { this.weight = value;}
		}

	}

class Programe
	{
		static void Main(string[] args)
		{
			int n = 1;
			int m = 1;	

			NhieuThucPham CircleK = new NhieuThucPham(n,m);
			CircleK.Nhap();
			CircleK.xuat();
		}
	}
}