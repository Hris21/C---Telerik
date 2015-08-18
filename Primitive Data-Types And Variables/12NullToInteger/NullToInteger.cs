namespace NullToInteger


{
    using System;

    class Program
    {
        static void Main(string[] args)
            //Create a program that assigns null values to an integer and to a double variable.Try to print these variables at the console.Try to add some number or the null literal to these variables and print the result.
        {
            int? firstInteger = null;                                                     
            Console.WriteLine("This is an integer with Null value -> " + firstInteger);     //"Nothing" prints on the console.
            firstInteger = 5;
            Console.WriteLine(  "This is an integer with value 5 -> " + firstInteger);     //Now as we set the value to 5, "5" prints on the console.
            double? secondInteger = null;
            Console.WriteLine("This is an integer, type double with value -> " + secondInteger); //The same processes repeat.
            secondInteger = 21;
            Console.WriteLine("This is an integer, type double with value 21 -> " + secondInteger);

        }
    }
}
