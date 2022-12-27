using System;

namespace sort
{
    class Program
    {
        static void inputArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter arr[{0}]: ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void outputArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ",arr[i]);
            }
            Console.WriteLine();
        }

        static void bubbleSort(int[] arr, int size)
        {
            int tmp;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i+1; j < size; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter length of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr;
            arr = new int[size];
            inputArray(arr,size);
            outputArray(arr,size);
            bubbleSort(arr,size);
            outputArray(arr,size);
        }
    }
}
