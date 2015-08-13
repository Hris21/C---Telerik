namespace SumOfFiveNums


{
    using System;
    class FiveNumberSum
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers by using \"space\" instead of \"enter\" :");
            string[] userinput = Console.ReadLine().Split();
            int a = int.Parse(userinput[0]);
            int b = int.Parse(userinput[1]);
            int c = int.Parse(userinput[2]);
            int d = int.Parse(userinput[3]);
            int e = int.Parse(userinput[4]);
            Console.Clear();
            int sumOfAll = a + b + c + d;
            Console.WriteLine("The sum of {0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, sumOfAll);
        }
    }
}
