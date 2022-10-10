using System;

namespace check_prime2
{
    class Program
    {
        static bool isPrime(int num)
        {
            if (num < 2) return false;
            double length = Math.Sqrt(num);
            for (int i = 2; i <= length; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter a integer: ");
                int num = int.Parse(Console.ReadLine());
                bool check; 
                if (num < 0)
                {
                    Console.WriteLine("Enter a number again");
                    continue;
                }
                else if (num == 1 || num == 0)
                {
                    check = false;
                }
                check = isPrime(num);
                if (check == true)
                    Console.WriteLine("This is a prime");
                else
                    Console.WriteLine("This is not a prime");
                break;
            }
        }
    }
}
