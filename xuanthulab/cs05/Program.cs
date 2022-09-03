using System;

namespace cs05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (i =1, Console.WriteLine("Hello World2!");i<=10;i++)
            {
                Console.WriteLine("Hello World!");
            }
            int length = 5;
            for (int k = 0; k < length; k++)
            {
                Console.WriteLine("Hello");
            }
            int length2 = 5;
            for (int k = 0; k < length2; k++)
            {
                Console.WriteLine("Hello");
            }

            int j = 11;
            while (j<=13)
            {
                Console.WriteLine($"j = {j}");
                j++;
            }

            do
            {
                Console.WriteLine($"jj = {j}");
                j++;
                break;
            } while (j < 15);
        }
    }
}
