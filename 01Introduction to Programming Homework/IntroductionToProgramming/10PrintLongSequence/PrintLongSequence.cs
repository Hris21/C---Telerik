namespace PrintLongSequence



{
    using System;


    class PrintLongSequence
    {
        static void Main(string[] args)
      
            //Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
            //I will use the same method as in project 06PrintASequence.
        {
            int NumberToPrint;
            for (int i = 2; i < 1001; i++)         //However this time we want the numbers to be 1000 not 10, so we change the for cycle.
            {
               
                if (i % 2 == 0)
                {
                    NumberToPrint = i;                  
                }
                else
                {
                    NumberToPrint = i * (-1);
                }
                Console.WriteLine(NumberToPrint);
           }
        }
    }
}
