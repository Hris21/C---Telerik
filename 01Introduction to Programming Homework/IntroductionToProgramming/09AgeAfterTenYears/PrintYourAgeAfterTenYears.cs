namespace AgeAfterTenYears
{

    using System;
    class AgeInTenYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you age");         //I tried to find simple, yet effective solution to the problem without having to use .Parse method.
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("After ten years you will be {0} years old", Age + 10);

        }
    }
}
