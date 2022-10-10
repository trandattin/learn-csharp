using System;
namespace Programming_C_Sharp {
    namespace Programming_C_Sharp_Test1 {
        public class Tester {
            public static void Main( ) {
                for (int i = 0;i < 10;i++)
                    Console.WriteLine("i: {0}",i);
                Programming_C_Sharp_Test2.Tester.function2();
            }
        }
    }
    namespace Programming_C_Sharp_Test2 {
        public class Tester {
            public static void function2( ) {
                for (int i=0;i<=10;i++) {
                    Console.WriteLine("i: {0}",i);
                }
            }
        }
    }
}