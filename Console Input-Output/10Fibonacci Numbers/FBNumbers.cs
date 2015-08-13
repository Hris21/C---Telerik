namespace Fibonacci_Numbers

{
    using System;
    using System.Numerics;

    class FBNumbers                //FB is Fibonacci not Facebook hehe :).
    {
        static void Main(string[] args)
        {
           Console.WriteLine("The first 100 members of Fibonacci sequence: ");

           BigInteger firstNumber = 0;
           BigInteger secondNumber = 1;
           BigInteger neutralNumber;
           Console.WriteLine(secondNumber);
           for (int i = 1; i < 100; i++)
           {
               neutralNumber = firstNumber + secondNumber;
               firstNumber = secondNumber;
               secondNumber = neutralNumber;
               Console.WriteLine(neutralNumber);
           }
        }
    }
}
