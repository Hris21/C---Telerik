namespace IsoscelesTriangle

{
    using System;
    using System.Text;   // Needed for the encoding to work.

    class TriangleOfSymbols
    {
        static void Main(string[] args)
        //Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("   \u00A9");
            Console.WriteLine(" \u00A9\u00A9\u00A9");
            Console.WriteLine("\u00A9\u00A9\u00A9\u00A9\u00A9");   
        }
    }
}
