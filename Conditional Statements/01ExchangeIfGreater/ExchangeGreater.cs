namespace ExchangeIfGreater


{
    using System;

    class ExchangeGreater
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0}  {1}", a, b);
            }
            else
            {
                Console.WriteLine("The value of \"a\" must be greater than the value of \"b\"");
                Console.WriteLine("Please enter new values for \"a\" and \"b\"");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = 0;
                if (a > b)
                {
                    c = a;
                    a = b;
                    b = c;
                    Console.WriteLine("{0}  {1}", a, b);
                }
            }
        }
        
    }
}
