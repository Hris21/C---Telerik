namespace SquareRoot
{
    using System;

    class Sqrt
    {
        static void Main(string[] args)
        //Create a console application that calculates and prints the square root of the number 12345.
        {
            Console.WriteLine("Enter the number");       // You can enter any number that Integer type can hold, try it with 12345 .
            int Number = int.Parse(Console.ReadLine()); //I am using the ReadLine method here, so the program is more interactive :).
            Console.WriteLine(Math.Sqrt(Number));       // I am usting Math.Sqrt(The Variable you assigned). 
        }
    }
}
