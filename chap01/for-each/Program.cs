using System;

namespace for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "He no";
            string[] MonAn;
            MonAn = new string[3] {"Ga", "Vit", "Ngang"};

            foreach (char item in S)
            {
                Console.Write("{0} ",item);
            }

            Console.WriteLine();

            foreach (string Si in MonAn)
            {
                Console.Write("{0} ",Si);
            }
        }
    }
}
