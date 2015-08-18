namespace DeclareVariables
{

    using System;

    class DeclareVariables
    {
        static void Main(string[] args)


        //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
        {
            Console.Title = "Hello Console";
            short Number0 = -10000;
            sbyte Number1 = -115;
            byte Number2 = 97;
            int Number3 = 53130;
            long Number4 = 4825932;
            Console.WriteLine("The first number is {0}, the second number is {1}, the third number is {2},  the fourth number is {3} the fifth number is {4}", Number0, Number1, Number2, Number3, Number4);


        }
    }
}
