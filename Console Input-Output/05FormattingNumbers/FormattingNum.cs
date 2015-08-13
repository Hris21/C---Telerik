using System;


namespace FormattingNumbers
{
    class FormattingNum
    {
        static void Main()
        {
            Console.WriteLine("Enter number 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter floating point value 'b': ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter floating point value 'c': ");
            double c = double.Parse(Console.ReadLine());
            Console.Clear();
         

                Console.WriteLine("{0:X} | {1} | {2, 5:0.00} | {3,-10:0.000}", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
            
        }
    }
}
