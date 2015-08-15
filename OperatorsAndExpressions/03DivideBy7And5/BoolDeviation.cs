namespace DivideBy7And5


{
    using System;

    class BoolDeviation
    {
        static void Main(string[] args)
        //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

        {
            Console.Write("Enter a number to check if it can be divided by 7 and 5 : ");
            int numberToCheck = int.Parse(Console.ReadLine());                                           
            bool divideNumber = numberToCheck % 7 == 0 && numberToCheck % 5 == 0;                        //I am using a basic bool expression here.
            Console.WriteLine(new string('=', 70));                                                     //This one was just to make it more appealing :).
            Console.WriteLine("The number {0} can be divided by 7 and 5 , at the same time --> {1}",numberToCheck, divideNumber);
            }
    }
}
