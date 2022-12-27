using System;
enum NhietDo: uint
{
    GiaBuot = 0, DongDac = 32, AmAp = 72, NuocSoi = 212
}

namespace num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhiet do dong dac cua nuoc la: {0}",NhietDo.DongDac);
        }
    }
}
