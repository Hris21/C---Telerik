namespace PrimeNumberCheck
{
    using System;
    class PrimeCheck
    {


        static void Main()
        {
            Console.WriteLine("Enter a number to check if it is prime : ");
            int number = int.Parse(Console.ReadLine());

              bool isPrime = ((number % 2 > 0)
              && (number % 3 > 0) && (number % 5 > 0)
              && (number % 7 > 0)) || ((number == 2) || (number == 3)
              || (number == 5) || (number == 7));

              Console.WriteLine("The number {0} is prime : >> {1} << ", number, isPrime);
        }
    }
}
