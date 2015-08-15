namespace IsTheThirdDigitSeven


{
    using System;

    class IsItSeven
    {
        static void Main()
        //Write an expression that checks for given integer if its third digit from right-to-left is 7.

        {
            Console.WriteLine("Type the number: ");

            int theNumber = int.Parse(Console.ReadLine());
            if((theNumber / 100) % 10 == 7)
            {
                Console.WriteLine("The third digit (right-to-left) of number {0} is 7", theNumber);
            }
            else
            {
                 Console.WriteLine("The third digit (right-to-left) of number {0} is NOT 7", theNumber);
            }

        }
    }
}
