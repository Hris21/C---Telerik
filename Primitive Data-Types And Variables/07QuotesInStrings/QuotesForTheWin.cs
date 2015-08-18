namespace QuotesInStrings


{
    using System;
    class QuotesForTheWin
    {
        static void Main(string[] args)
        {
            string quoted =  @"The ""use"" of quotations causes difficulties.";  //In the first case we add @ + " " to the quote ( "" "" ).
            string UnQuoted = "The \"use\" of quotations causes difficulties.";  //In the second case we simply add \ before the symbol ".
            Console.WriteLine(quoted);
            Console.WriteLine(UnQuoted);

        }
    }
}
