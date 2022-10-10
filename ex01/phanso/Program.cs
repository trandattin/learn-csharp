// xay dung lai lop PhanSo phan truoc voi phuong khoi tao gom 2 phan so

using System;

namespace phanso
{
    public class PhanSo{
        public int tu,mau;
    
        public void Nhap(){
            int a = 0, b = 0;
            Console.Write("Nhap tu so: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            b = int.Parse(Console.ReadLine());
            this.tu = a;
            this.mau = b;
        }

        public void Xuat(){
            Console.WriteLine("Phan so la : {0}/{1}",tu,mau);
        }
        
        public PhanSo Cong(PhanSo b){
            PhanSo res = new PhanSo();
            res.tu = tu*b.mau + mau*b.tu;
            res.mau = mau*b.mau;
            return res;
        }

        public PhanSo Tru(PhanSo b){
            PhanSo res = new PhanSo();
            res.tu = tu*b.mau - mau*b.tu;
            res.mau = mau*b.mau;
            return res;
        }

         public void Gan(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }

        public PhanSo Nhan(PhanSo b){
            PhanSo res = new PhanSo();
            res.tu = b.tu*tu;
            res.mau = b.mau*mau;
            return res;
        }

        public PhanSo Chia(PhanSo b){
            PhanSo res = new PhanSo();
            if (b.tu == 0){
                res.tu = 0;
                res.mau = 0;
            } else {
                res.tu = b.tu*mau;
                res.mau = b.mau*tu;
            }
            return res;
        }

        private int UCLN(int a, int b)
        {
            if (a != 0)
            {
                if (a > 0)
                {
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
                else
                {
                    a = -a;
                    while (a != b)
                    {
                        if (a > b) a -= b;
                        else b -= a;
                    }
                    return a;
                }
            }
            else return 0;
        }

        public void rutGon()
        {
            int a = UCLN(this.tu, this.mau);

            if (a != 0)
            {
                    if (a > 0)
                    {
                        this.tu = this.tu / a;
                        this.mau = this.mau / a;
                    }
                    else
                    {
                        this.tu = this.tu / (-a);
                        this.mau = this.mau / (a);
                    }
            }
            else 
            {
                Gan(0, 0);
            }
        }
    }

    class Program{
        static void Main(string[] args){
            PhanSo ps1 = new PhanSo();
            ps1.Nhap();
            ps1.rutGon();
            ps1.Xuat();

            PhanSo ps2 = new PhanSo();
            ps2.Nhap();
            ps2.rutGon();
            ps2.Xuat();
            
            PhanSo res = ps1.Cong(ps2);
            res.rutGon();
            Console.WriteLine($"Ket qua cua {ps1.tu}/{ps1.mau} + {ps2.tu}/{ps2.mau} = {res.tu}/{res.mau}");
            
            res = ps1.Tru(ps2);
            res.rutGon();
            Console.WriteLine($"Ket qua cua {ps1.tu}/{ps1.mau} - {ps2.tu}/{ps2.mau} = {res.tu}/{res.mau}");

            res = ps1.Nhan(ps2);
            res.rutGon();
            Console.WriteLine($"Ket qua cua {ps1.tu}/{ps1.mau} x {ps2.tu}/{ps2.mau} = {res.tu}/{res.mau}");

            res = ps1.Chia(ps2);
            res.rutGon();
            Console.WriteLine($"Ket qua cua {ps1.tu}/{ps1.mau} : {ps2.tu}/{ps2.mau} = {res.tu}/{res.mau}");
        }
    }
}
