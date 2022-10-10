using System;
enum ThucDon:int 
{
    Xoai,Oi,Coc
}

namespace switchh
{
    class Program
    {
        static void Main(string[] args)
        {
            int Chon;

            NhapLai:
                Console.WriteLine("Chon mot mon!");
                Console.WriteLine("{0} - Xoai", (int)ThucDon.Xoai);
                Console.WriteLine("{0} - Oi", (int)ThucDon.Oi);
                Console.WriteLine("{0} - Coc", (int)ThucDon.Coc);
                Chon = int.Parse(Console.ReadLine());
                if (Chon < 0) goto NhapLai;
            
            switch(Chon) 
            {
                case (int)ThucDon.Xoai:
                    Console.WriteLine("Chon 1 qua xoai!");
                    break;
                case (int)ThucDon.Oi:
                    Console.WriteLine("Chon an 1 qua oi!");
                    break;
                case (int)ThucDon.Coc:
                    Console.WriteLine("Chon an 1 qua coc!");
                    break;
                default:
                    Console.WriteLine("Vui long chon lai!");
                    break;
            }
            Console.WriteLine("Chuc ban ngon mieng!");
        }
    }
}
