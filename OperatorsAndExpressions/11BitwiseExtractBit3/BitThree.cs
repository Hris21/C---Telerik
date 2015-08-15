namespace BitwiseExtractBit3


{
    using System;

    class BitThree
    {
        static void Main()
        {
            Console.WriteLine("Enter the number you would like to check: ");
            int position = 3;
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int bitAtPosition = number & mask;
            bitAtPosition = bitAtPosition >> position;
            Console.WriteLine("The bit in position 3 is {0}",bitAtPosition);
        }
    }
}
