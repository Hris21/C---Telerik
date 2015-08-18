namespace UnicodeCharacter


{
    using System;
    class VariableFourtyTwo
    {
        static void Main(string[] args)
        //Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
        {
            char variableChar = '\u002A';
            Console.WriteLine(variableChar);
        }
    }
}
 