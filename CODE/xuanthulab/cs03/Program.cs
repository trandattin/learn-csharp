using System;

namespace cs03
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %
            float a = 5;
            int b = 4;

            int z1 = 2 * b++;
            int z2 = 2 * ++b;

            Console.WriteLine("a + b = {0}",a+b);
            Console.WriteLine("a - b = {0}",a-b);
            Console.WriteLine("a % b = {0}",a%b);
            Console.WriteLine("a / b = {0}",a/b);
            Console.WriteLine("a * b = {0}",a*b);
            Console.WriteLine("z1 = {0}",z1);
            Console.WriteLine("z2 = {0}",z2);
        }
    }
}
