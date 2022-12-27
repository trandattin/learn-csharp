using System;
namespace ConsoleApplication1 {
 
class Geeks {
 
    // Main Method
    static void Main(string[] args)
    {
 
        List<int> myValues = new List<int>() {1, 2,3,5,2 };
 
        // Finding the index of character
        // which is present in string and
        // this will show the value 5
        int index1 = myValues.IndexOf(2);
         
        Console.WriteLine("The Index Value of character 'F' is " + index1);
 
        // Now finding the index of that character which
        //  is not even present with the string
        int index2 = myValues.IndexOf('C');
		        // As expected, this will output value -1
        Console.WriteLine("The Index Value of character 'C' is " + index2);
    }
}
}