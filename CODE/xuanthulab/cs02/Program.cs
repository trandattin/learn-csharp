using System;

namespace cs02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kieu_du_lieu Ten_bien;
            Ten_bien:
                _-a...z A...Z
                -0 .. 9
                - _
                - Khong bat dau bang, phan biet chu hoa va thuong
            */
            string studentName = "Tran Dat Tin";
            int studentAge = 20;

            float c;
            c = 12.12f;

            double so_pi;
            so_pi = 3.14;

            double hai_pi;
            hai_pi = 2*so_pi;


            // Console.Title = "Vi du su dung"; 
            // Console.Clear();
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.ResetColor();
            // Console.BackgroundColor = ConsoleColor.BLue;

            string hovaten;
            string sinput;
            int a;
            Console.Write("Ho va ten cua ban: ");
            hovaten = Console.ReadLine();
            Console.WriteLine("Xin chao {0}",hovaten);
            Console.Write("Hay nhap so a: ");
            sinput = Console.ReadLine();
            a = int.Parse(sinput);

            Console.WriteLine(hai_pi);
            Console.WriteLine("Hello World!");

            var tin = "tin";
            Console.WriteLine("My name is {0}",tin);

            
        }
    }
}
