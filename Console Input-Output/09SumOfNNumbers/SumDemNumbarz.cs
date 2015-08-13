namespace SumOfNNumbers


{
    using System;

    class SumDemNumbarz                          //Sorry I was on a 8 hour streak, had to put a little fun in it.:)
    {
        static void Main()
        {
            Console.WriteLine("Please enter N-numbers to be summed: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Please enter the numbers: ");
            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = number + sum;
            }
            Console.WriteLine("The sum of entered numbers is {0}\n", sum);
            
        }

    }
}
