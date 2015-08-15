namespace FourDigitNumber

{

    using System;
    class FourDigitNum
    {
        static void Main()
        //Write a program that takes as input a four-digit number in format abcd
        {
            Console.WriteLine("Enter a four-digit number : ");
            int numberABCD = int.Parse(Console.ReadLine());
            if(numberABCD < 1000 || numberABCD > 9999)
            {
                Console.WriteLine("You have to enter a FOUR digit number: ");
                numberABCD = int.Parse(Console.ReadLine());
            }
            int a = numberABCD % 10;                   //for example 123[4] 
            int b = (numberABCD / 10) % 10;            //12[3]4
            int c = (numberABCD / 100) % 10;           //1[2]34
            int d = (numberABCD / 1000) % 10;          //[1]234

            Console.WriteLine(new string('=', 40));
            Console.WriteLine("The sum of the digits : -> {0} + {1} + {2} + {3} = {4}",a ,b ,c, d, a+b+c+d);
            Console.WriteLine("The digits in reverse order : -> {0}{1}{2}{3}",a, b, c, d);
            Console.WriteLine("Last in digit first position : -> {3}{0}{1}{2}", d, c, b, a);
            Console.WriteLine("Third and second digit exchanged : -> {0}{2}{1}{3}", d, c, b, a);
        }
    }
}
