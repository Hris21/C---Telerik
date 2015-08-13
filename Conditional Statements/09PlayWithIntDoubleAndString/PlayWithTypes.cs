namespace PlayWithIntDoubleAndString

{
    using System;

    class PlayWithTypes
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type 1 -- > int , 2 -- > double , 3 -- > string : ");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine("You have selected int, please enter a value ");
                int typeOne = int.Parse(Console.ReadLine());
                typeOne = typeOne + 1;
                Console.WriteLine("Your number  + 1 = {0}", typeOne);
            }
            else if (type == 2)
            {
                Console.WriteLine("You have selected int, please enter a value ");
                double typeTwo = double.Parse(Console.ReadLine());
                typeTwo = typeTwo + 1;
                Console.WriteLine("Your number  + 1 = {0}", typeTwo);
            }
            else if (type == 3)
            {
                Console.WriteLine("You have selected string, please enter a word or sentence ");
                string typeThree = Console.ReadLine();
                Console.WriteLine("Your word combination is {0}*", typeThree);

            }
            else 
            {
                Console.WriteLine("Please restart the program and select from types 1 | 2 or | 3 ");
            }
        }

    }
}
