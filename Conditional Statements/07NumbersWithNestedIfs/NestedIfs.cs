namespace NumbersWithNestedIfs
{
    using System;
    class NestedIfs
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double c = double.Parse(Console.ReadLine());
            double first = 0;
            double second = 0;
            double third = 0;

            if (a >= b)
            {
                if (a >= c)
                {
                    first = a;

                    if (b >= c)
                    {
                        second = b;
                        third = c;
                    }
                    else
                    {
                        second = c;
                        third = b;
                    }
                }
                else
                {
                    first = c;
                    second = a;
                    third = b;
                }
            }

            else
            {
                if (b >= c)
                {
                    first = b;

                    if (a >= c)
                    {
                        second = a;
                        third = c;
                    }
                    else
                    {
                        second = c;
                        third = a;
                    }
                }
                else
                {
                    first = c;
                    second = b;
                    third = a;
                }
            }

            Console.WriteLine(first + " " + second + " " + third);
        }
    }
}