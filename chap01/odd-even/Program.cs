using System;

namespace odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a integer number: ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.Write("This is a even number");
            }
            else
            {
                Console.Write("This is a odd number");
            }
        }
    }
}
