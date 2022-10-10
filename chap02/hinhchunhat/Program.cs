using System;
namespace LopDoiTuongHCN {
    class HCN {
        
        public float Dai, Rong;
        
        public float ChuVi() {
            return (Dai + Rong )*2;
        }
        
        public float DienTich() {
            return Dai* Rong;
        }
        
        public void Nhap() {
            Console.WriteLine("Nhap chieu dai: ");
            Dai = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            Rong = float.Parse(Console.ReadLine());
        }
        
        public void Xuat() {
            Console.WriteLine("Hinh chu nhat: Dai = {0}, Rong = {1}", Dai, Rong);
        }
    }

    class Programe{
        static void Main(string[] args) {
            HCN h;
            h = new HCN();
            h.Nhap();
            h.Xuat();
            Console.WriteLine("Chu vi hinh chu nhat: {0}", h.ChuVi());
            Console.WriteLine("Dien tich hinh chu nhat: {0}", h.DienTich());
            Console.ReadLine();
        }
    }
}