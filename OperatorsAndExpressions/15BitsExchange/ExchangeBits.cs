namespace BitsExchange


{
    using System;

    class ExchangeBits             //This on is though so I will try to explain the logic behind the solution.
    { 
        static void Main()   
        {
            int number, bitPosition, bitPosition2, blank, blank2, newBit, newBit2, pairOfBits, bitValue, bitValue2, i, area;

            Console.WriteLine("This program will switch the values of bit's 3,4,5 with 24,25,26");
            Console.Write("Write some number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("This is your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));

            bitPosition = 3;
            bitPosition2 = 24;
            area = 3;

            for (i = area; i >= 0; i = i - 1)
            {

                blank = 1 << bitPosition + i;     // Creates a bit(..0001) and moves it to the position we want 
                blank2 = 1 << bitPosition2 + i;
                newBit = number & blank;       // Leaves the bit at the specifyed location unmodifyed
                newBit2 = number & blank2;
                bitValue2 = newBit >> bitPosition;// Moves the bit we wanted to the [0] position , I use it to compare the 2 bits
                bitValue = newBit2 >> bitPosition2;
                pairOfBits = blank | blank2; // This creates a new number where the only 1's are at the specified locations

                if (bitValue2 == bitValue) // If the two bit's have equal values then there iss no point of doing anything 
                {

                }
                else   // If the bits are not equal then I use the ^ operator to change their values (from 0 to 1 and vise versa)
                {
                    number = number ^ pairOfBits;
                }
            }

            Console.WriteLine("This is the new number:        " + Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
