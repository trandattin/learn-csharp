using System;
using System.Linq;

namespace cs06
{
    class Program
    {
        static void Main(string[] args)
        {
            string sinhvien1 = "Nguyen Van A";
            string sinhvien2 = "Nguyen Van B";
            string sinhvien3 = "Nguyen Van C";

            Console.WriteLine(sinhvien1);
            Console.WriteLine(sinhvien2);
            Console.WriteLine(sinhvien3);

            string[] ds;
            ds = new string[3];
            
            ds[0] = sinhvien1;
            ds[1] = sinhvien2;
            ds[2] = sinhvien3;

            for (int i = 0; i < 3;i++)
            {
                Console.WriteLine(ds[i]);
            }

            int[] mangsonguyen;
            mangsonguyen = new int[3] {1,2,3};
            string[] mangchuoi;
            mangchuoi = new string[3] {"Dien thoai","May tinh","Tivi"};

            foreach (var abc in mangchuoi)
            {
                Console.WriteLine(abc);
            }
            Console.WriteLine(mangchuoi.Rank);
            Console.WriteLine(mangsonguyen.Max());

            double[,] numbers = new double [2,3] {{1,2,3},{2,3,4}};

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.Write(numbers[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
