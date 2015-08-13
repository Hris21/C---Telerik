using System;


namespace SumOfNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            Console.Title = "Sum of three numbers";
            Console.WriteLine("Enter the first number: ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double numberTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            var numberThree = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum is :>> {0} + {1} + {2} = {3} <<:",numberOne, numberTwo, numberThree, numberOne+numberTwo+numberThree);
        }
    }
}
