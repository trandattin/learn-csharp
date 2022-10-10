using System;

namespace GOTO
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Laplai:
            Console.WriteLine("i: {0}",i);
            i++;
            if (i < 10) goto Laplai;
        }
    }
}
