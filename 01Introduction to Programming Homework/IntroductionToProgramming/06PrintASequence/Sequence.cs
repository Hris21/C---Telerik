
namespace PrintASequence

{

    using System;
    class Sequence
    {
        static void Main(string[] args)
        //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

        {
            int numberToPrint;                       //Declaring the variable which I am going to use operations on.,
            for (int i = 2; i < 11; i++)             //I am using for cycle to make sure the number which is divided increases with 1 (++ operator)
            {
                if(i % 2 == 0)                       //If the number diviation is 2 (for e.g. 4:2 =2) print positive number.
                {
                    numberToPrint = i;
                }
                else
                {
                    numberToPrint = i * (-1);        //If it does not diviate by 2 (for e.g 3 : 2 = 1, 5) print negative number  * (-1). 
                }
                Console.WriteLine(numberToPrint);
            }
           
        }
    }
}
