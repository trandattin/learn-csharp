using System;

namespace cs07
{
    class Count {
        public int c = 1;
    }

    class Program
    {
        /*
        <Access Modifiers> <return type> <name_method>(<parameters>)
        {   
        // Các câu lệnh trong phương thức
        }
        */


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(multipy(5,6));
            Console.WriteLine(Tinhtoan.tong(123,456));

            float a = 12.12f;
            float b = 10.0f;
            var result = Tinhtoan.tong(a,b);
            Console.WriteLine(result);
            xinChao(ho: "Nguyen", ten: "Tin");
            xinChao(ten: "Tin");
            int k = 5;
            int res;
            binhphuong(ref k, out res);
            Console.WriteLine(k);
            Console.WriteLine("res = {0}",res);
            
            Count count = new Count();
            Console.WriteLine(count.c);
            dem(count);
            Console.WriteLine(count.c);
        }

        static void dem(Count count)
        {
            count.c ++;
        }

        static void xinChao(string ten, string ho = "Tran"){
            string fullname;
            fullname = ho + " " + ten;
            Console.WriteLine($"Xin chao {fullname}");
        }

        public static int multipy(int a, int b){
            //...
            return a*b;
        }

        public static void binhphuong (ref int x, out int kq){
            kq = x * x;
            Console.WriteLine(kq);
        }

    }
}
