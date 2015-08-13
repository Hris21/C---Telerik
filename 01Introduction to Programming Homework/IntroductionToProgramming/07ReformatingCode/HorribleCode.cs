using System;                                //I learned from a lection from the previous years, that the using System, should be put inside the namespace.
                                             //However I will now do it the ordinary way as I don't want to spoil my homework :)!
class HorribleCode
{
    static void Main()
    {
        Console.WriteLine("Hi, I am horribly formatted program"); 
        Console.WriteLine("Numbers and squares:"); 
        for (int i = 0;i < 10;i++)
        {
            Console.WriteLine(i + " --> " + i * i);
        }
    }
}