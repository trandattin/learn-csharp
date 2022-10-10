using System;

namespace matrix
{
    class Program
    {
        static void inputMatrix(double[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[{0},{1}] = ",i,j);
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void outputMatrix(double[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ",matrix[i,j]);;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter size of matrix with m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter size of matrix with n = ");
            int n = int.Parse(Console.ReadLine());
            
            double[,] matrix = new double [m,n];

            inputMatrix(matrix,m,n);
            outputMatrix(matrix,m,n);
        }
    }
}
