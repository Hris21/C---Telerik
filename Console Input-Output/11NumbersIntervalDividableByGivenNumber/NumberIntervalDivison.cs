namespace NumbersIntervalDividableByGivenNumber
{
    using System;

    class Program
    {
        static void Main()
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
        {
            Console.WriteLine("Enter the first number:");
            uint a = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter the secound number:");
            uint b = uint.Parse(Console.ReadLine());

            int p = 0;
            for (uint i = a; i <= b; i++)
            {
                if (i % 5 ==0)
                {
                    p = p + 1;
                    Console.Write("{0} | ",i);
                }

            }
            Console.WriteLine("\n{0} numbers in this interval are divided by 5",p);


        }
    }
}
