using System;

namespace meomeomeo
{
    public class Cat{
        private static int SoMeo = -6;
        private string TenMeo;

        static Cat(){   
            Console.WriteLine("Bat dau bat meo!!!");
            SoMeo = 0;
        }

        public Cat (string T){
            TenMeo  = T;
            Console.WriteLine ("WOAW!!!! {0} day !", TenMeo);
            SoMeo++;
        }
    
        public static void HowManyCats(){
            Console.WriteLine ("Dang bat {0} con meo!",SoMeo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat.HowManyCats();
            Cat tom = new Cat("Meo Tom");
            
            Cat.HowManyCats();
            Cat muop = new Cat("Meo Muop");
            
            Cat.HowManyCats();
            Console.ReadLine();
        }
    }
}
