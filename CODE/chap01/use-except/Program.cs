using System;
class Class1{
    static void Main(string[] args) 
    {
        int x=0;
        Console.WriteLine("Nhap mot so nguyen");
        NHAPLAI:
        try {
            x = int.Parse(Console.ReadLine());
        }
        //catch(System.Exception e)
        catch(System.FormatException e) {
            Console.WriteLine("Loi : " + e.ToString()); //TODO:
            Console.WriteLine("Hay nhap lai 1 so nguyen!");
            goto NHAPLAI;
        }
        Console.WriteLine("So nguyen vua nhap {0}",x);
        Console.ReadLine();
    }
}