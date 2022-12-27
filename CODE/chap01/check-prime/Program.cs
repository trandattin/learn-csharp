using System;

namespace check_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a integer: ");
            num = int.Parse(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine("Not a prime number");
                return;
            }
            bool check = true;
            double length = Math.Sqrt(num); 
            for (int i = 2; i <= length; i++)
            {
                if (num % i == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
                Console.WriteLine("This is a prime number");
            else
                Console.WriteLine("This is not a prime number");
        }
    }
}
