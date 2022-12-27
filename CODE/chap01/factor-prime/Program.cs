using System;

namespace factor_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a integer number > 1: ");
            num = int.Parse(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.Write("{0} = ",num);
            int i = 2;
            int num2 = num;
            while (num2 > 1)
            {
                if (num2 % i == 0)
                {
                    num2 = num2/i;
                    Console.Write("{0} ",i); 
                    if (num2 != 1)
                    {
                        Console.Write("x ");
                    }
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
