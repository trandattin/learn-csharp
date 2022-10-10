//Bai tap 1: Xay dung lop HocSinh(hoten, diem toan, diem van) với các phương thức: khoi tao, xuat , tinh diem trung binh
using System;

namespace bt01
{
    class HocSinh {
        public string hoten;
        public double diemtoan, diemvan;

        public HocSinh(){
            hoten = "";
            diemtoan = 0;
            diemvan = 0;
        }

        public void Xuat(){
            Console.WriteLine("Ho va ten : {0}", hoten);
            Console.WriteLine("Diem mon van: {0}",diemvan);
            Console.WriteLine("Diem mon toan : {0}", diemtoan);
        }

        public double DiemTrungBinh()
        {
            return((diemtoan+diemvan)/2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HocSinh hs = new HocSinh();
            hs.hoten = "Tran Dat Tin";
            hs.diemvan = 10;
            hs.diemtoan = 10;
            hs.Xuat();
            Console.WriteLine("Diem trung binh cua hoc sinh: {0:0.00}",hs.DiemTrungBinh());
        }
    }
}