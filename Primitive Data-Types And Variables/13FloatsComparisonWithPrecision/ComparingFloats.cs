namespace FloatsComparisonWithPrecision


{
    using System;

    class ComparingFloats
    {
        static void Main(string[] args)
        //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.(up to sixth character)
        {
            Console.WriteLine("Enter the first number to be compared");          //5.00000001	5.00000003 |Random numbers to try, 
            float numberOne = float.Parse(Console.ReadLine());                   //5.00000005	5.00000001 |in case you can't think of
            Console.WriteLine("Enter the second number to be compared");         //4.999999	    4.999998   |anything :) .
            float numberTwo = float.Parse(Console.ReadLine());                               
            bool compare = (numberOne == numberTwo);
            Console.WriteLine(compare);
            
        }
    }
}
