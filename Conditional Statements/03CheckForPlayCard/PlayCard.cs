namespace CheckForPlayCard
{
    using System;
    class PlayCard
    {
        static void Main()
        {
            Console.WriteLine("Enter a card sign");
            string cardSign = Console.ReadLine();
            if (cardSign == "2" || cardSign == "3" || cardSign == "4" || cardSign == "5" || cardSign == "6" || cardSign == "7" || cardSign == "8" || cardSign == "9" || cardSign == "10" || cardSign == "J" || cardSign == "Q" || cardSign == "K" || cardSign == "A")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
