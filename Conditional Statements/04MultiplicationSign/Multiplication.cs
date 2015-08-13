namespace MultiplicationSign

{
    using System;

    class Multiplication
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            if ((numberOne < 0 && numberTwo < 0 && numberThree < 0) || (numberOne > 0 && numberTwo > 0 && numberThree < 0) || (numberOne > 0 && numberTwo < 0 && numberThree > 0) || (numberOne < 0 && numberTwo > 0 && numberThree < 0))
            {
                Console.WriteLine("-");
            }
            else if ((numberOne < 0 && numberTwo < 0 && numberThree > 0) || (numberOne < 0 && numberTwo > 0 && numberThree < 0) || (numberOne > 0 && numberTwo < 0 && numberThree < 0) || (numberOne > 0 && numberTwo > 0 && numberThree > 0))
            {
                Console.WriteLine("+");
            }

        }
    }
}
