namespace NumberComparer



{
    using System;

    class GreaterAB
    {
        static void Main()
        {
         Console.WriteLine("Enter the first number for comparison : ");
         int numberA = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter the second number for comparison: ");
         int numberB = int.Parse(Console.ReadLine());
         int greaterAB = Math.Max(numberA, numberB);
         int smallerAB = Math.Min(numberA, numberB);
         Console.WriteLine("The number {0} is bigger than {1} ",greaterAB, smallerAB);
        }
    }
}
