using System;

class Xe
{
    //Cac thanh phan nay la protected de phuong thuc Xuat cua lop XeXat va XeHoi co the truy cap duoc

    public int TocDo;
    protected string BienSo;
    protected string HangSX;

    public Xe(int td, string BS, string HSX)
    {
        TocDo = td; BienSo = BS; HangSX = HSX;
    }

    //ham ảo
    public virtual void Xuat()
    {
        Console.Write("Xe: {0}, Bien so: {1}, Toc do: {2} kmh", HangSX, BienSo, TocDo);
    }

   /// <summary>
   /// ko la ham ảo
   /// </summary>
    public void Xuat2()
    {
        Console.Write("Xe: {0}, Bien so: {1}, Toc do: {2} kmh", HangSX, BienSo, TocDo);
    }
}

class XeBus : Xe
{
    public int SoHanhKhach;

    public XeBus(int td, string BS, string HSX, int SHK)  : base(td, BS, HSX)
    {
        SoHanhKhach = SHK;
    }

    //Tu khoa new che dau phuong thuc Xuat cua lop XeHoi vi phuong thuc Xuat cua lop XeHoi khong con phu hop voi lop XeCar.
    public override void Xuat()
    {
        Console.Write("Xe Bus: {0}, Bien so: {1}, Toc do: {2} kmh , {3} cho ngoi", HangSX, BienSo, TocDo, SoHanhKhach);
    }


    public new void Xuat2()
    {
        Console.Write("Xe Bus: {0}, Bien so: {1}, Toc do: {2} kmh , {3} cho ngoi", HangSX, BienSo, TocDo, SoHanhKhach);
    }
}

class XeTai: Xe
{
    int TrongTai;

    public  XeTai(int td, string BS, string HSX, int SHK)
        : base(td, BS, HSX)
    {
            TrongTai = SHK;
    }

    //Tu khoa new che dau phuong thuc Xuat cua lop XeHoi vi phuong thuc Xuat cua lop XeHoi khong con phu hop voi lop XeCar.
    public override void Xuat()
    {
        Console.Write("Xe tai: {0}, Bien so: {1}, Toc do: {2} kmh , {3} cho ngoi");
    }


    public new void Xuat2()
    {
        Console.Write("Xe tai: {0}, Bien so: {1}, Toc do: {2} kmh , {3} cho ngoi", HangSX, BienSo, TocDo, TrongTai);
    }
}


public class Test
{
    public static void Main()
    {

        XeBus c = new XeBus(150, "49A-4444", "Toyota", 24);
            
        Xe h = c;
        // Xuat ở class Xe Bus
        h.Xuat();
        Console.WriteLine();
        // Xuat2 o class Xe
        h.Xuat2();
        Console.WriteLine();

        h = new XeTai(150, "49A-555", "Benz", 10);
        h.Xuat();
        Console.WriteLine();
        h.Xuat2();
    }
}