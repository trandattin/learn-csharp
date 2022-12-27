using System;

namespace cs09
{
    class Program
    {
        static void Main(string[] args)
        {
            Vukhi sungluc;
            sungluc = new Vukhi();
            sungluc.name = "Sung luc";
            sungluc.thietLapSathuong(5);
            Vukhi sungmay = new Vukhi("Sung may", 15);
            sungluc.tanCong();
            sungmay.tanCong();
            sungluc.satThuong = 100;
            Console.WriteLine(sungluc.satThuong);
        }
    }
}
