using System;

namespace cs04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOnline; 

            isOnline = true;

            int a = 5;
            int b = 6;

            bool kq = a == b; 
            Console.WriteLine(" a == b ==> {0}",kq);
            bool x = false;
            bool y = true;

            bool kq2 = x && y;

            Console.WriteLine(kq2);
        }
    }
}
