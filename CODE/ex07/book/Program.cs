/*
Bài tập 4:
Một cửa hàng có 2 loại sản phẩm là băng và sách. Băng cần lưu thông tin tựa đề, thời lượng, giá. 
Sách cần lưu tựa đề, tác giả, giá.
Sách và băng đều lưu chung vào trong 1 mảng. 
Hãy viết chương trình:
1.Nhập, xuất các sản phẩm của cửa hàng. Khi nhập, hãy hỏi người dùng muốn nhập sách hay băng và thực hiện việc nhập tương ứng.
2.Sắp xếp các sản phẩm theo tựa đề.
3.Thống kê tổng tiền sách.
*/

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class SanPham : IComparable
{
    public string Name { get; private set; }
    public double Price { get; private set; }

    public SanPham(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }

    public virtual void Print()
    {
    }

    public int CompareTo(object y)
    {
        SanPham r = (SanPham)y;
        return Name.CompareTo(r.Name);
    }

    public virtual string ID()
	{
		return "X";
	}
}

public class Bang : SanPham
{
    public double ThoiLuong { get; private set; }

    public Bang(string name, double thoiluong, double price) : base(name, price)
    {
        this.ThoiLuong = thoiluong;
    }

    public override void Print()
    {
        Console.WriteLine("Name: {0}", this.Name);
        Console.WriteLine("Thoi Luong: {0}", this.ThoiLuong);
        Console.WriteLine("Gia: {0}", this.Price);
    }

    public override string ID()
	{
		return "Bang";
	}
}

public class Sach : SanPham
{
    public string TacGia { get; private set; }
    public Sach (string name, double price, string tacgia) : base(name,price)
    {
        this.TacGia = tacgia;
    }
    public override void Print()
    {
        Console.WriteLine("Name: {0}", this.Name);
        Console.WriteLine("Tac Gia: {0}", this.TacGia);
        Console.WriteLine("Gia: {0}", this.Price);
    }

    
    public override string ID()
	{
		return "Sach";
	}
}

public class Programe
{
    public static void Main()
    {
        List<SanPham> sp = new List<SanPham> {};
        Console.WriteLine("Nhap so luong san pham: ");
        int size = int.Parse(Console.ReadLine());
        int chon;
        for (int i = 0; i< size; i++)
        {
            do
            {
                Console.WriteLine("****** Bang Chon Nhap ********");
                Console.WriteLine("1. Nhap Xe Bang");
                Console.WriteLine("2. Nhap Xe Sach");
                chon = int.Parse(Console.ReadLine());
            } while ((chon != 1) && (chon != 2));

            if (chon == 1)
            {
                Console.WriteLine("***** Ban chon nhap Bang *******");
                Console.WriteLine("Name");
                string ten = Console.ReadLine();
                Console.WriteLine("Gia");
                int gia = int.Parse(Console.ReadLine());
                Console.WriteLine("Thoi Luong");
                int thoiluong = int.Parse(Console.ReadLine());
                sp.Add(new Bang(ten,thoiluong,gia));
            }
            else
            {
                Console.WriteLine("***** Ban chon nhap Bang *******");
                Console.WriteLine("Name");
                string ten = Console.ReadLine();
                Console.WriteLine("Gia");
                int gia = int.Parse(Console.ReadLine());
                Console.WriteLine("Tac Gia ");
                string tacgia = Console.ReadLine();
                sp.Add(new Sach(ten, gia, tacgia));
            }
        }

        Console.WriteLine("Xuat tat ca nhung thong tin san pham");
        foreach (var s in sp)
        {
            s.Print();
        }

        Console.WriteLine("AFTER");
        sp.Sort();

        foreach (var s in sp)
        {
            s.Print();
        }

        double sum = 0;
        foreach (SanPham s in sp)
        {
            if (s.ID() != "Sach")
                continue;
            sum += s.Price;
        }
        Console.WriteLine("Tong tien sach: {0}", sum);
    }
}