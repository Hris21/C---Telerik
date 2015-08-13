namespace NumbersFromOneToN

{
    using System;

    class NumberPrint
    {
        static void Main()
        {
            int first = 1;
            Console.Write("Please enter a value to end the interval : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        
        } 
    }
}
