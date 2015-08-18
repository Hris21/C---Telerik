namespace StringsConcatenation


{
    using System;
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object fullWord = firstWord + " "+ secondWord;
            string greeting = (string)fullWord;
            Console.WriteLine(greeting);
        }
    }
}
