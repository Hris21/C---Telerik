namespace ProgramThatPrintsTheASCIITable


{
    using System;

    class PrintASCII
    {
        static void Main(string[] args)
        //Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
        {
            for (int i = 0; i < 256; i++)
            {
                char character = (char)i;
                Console.WriteLine(" {1} |  {0}", i, character);
            }
        }
    }
}
      
