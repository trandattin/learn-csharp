/*
Xay dung lop hinh chu nhat voi thanh phan du lieu la toa do goc tren ben trai
(x1, y1) toa do goc duoi ben phai (x2, y2) va cac phuong thuc tinh chieu dai, 
chieu rong, dien tich, chu vi cua hinh chu nhat va phuong thuc ve hinh chu nhat 
voi cac ki tu '*' ra man hinh.
*/
using System;
namespace hinhchunhat
{
    public class HinhChuNhat
    {
        public double x1,y1,x2,y2;
        
        public HinhChuNhat(){
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
        }

        public double chieuDai(){
            return (x2 - x1);
        }

        public double chieuRong(){
            return (y1 - y2);
        }

        public double dienTich(){
            return ((x2-x1)*(y1-y2));
        }

        public double chuVi(){
            return 2*((x2-x1)+(y1-y2));
        }

        public void draw(){
            double length = x2-x1;
            double width = y1-y2;
            for (int i = 0; i < width; i++){
                for (int j = 0; j < length; j++){
                    if (j != 0 && j != (length-1) && i != 0 && i != (width-1)){
                        Console.Write("  ");
                    } else {
                        Console.Write("* ");
                    }

                }
                Console.WriteLine();
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.x1 = 1;
            hcn.y1 = 10;
            hcn.x2 = 6;
            hcn.y2 = 1;
            Console.WriteLine("Chieu dai hinh chu nhat la: {0}",hcn.chieuDai());
            Console.WriteLine("Chieu rong hinh chu nhat la: {0}",hcn.chieuRong());
            Console.WriteLine("Dien tich hinh chu nhat la: {0}",hcn.dienTich());
            Console.WriteLine("Chuvi hinh chu nhat la: {0}",hcn.chuVi());
            hcn.draw();
        }
    }
}
