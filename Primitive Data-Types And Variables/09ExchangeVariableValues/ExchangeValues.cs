namespace ExchangeVariableValues


{
    using System;
    class ExchangeValues
    {
        static void Main()
        //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.

        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before the exchange the values are, a = {0} and b = {1}", a, b);  
            a = b;
            b = a - 5; //Nothing more than basic mathematics.
            Console.WriteLine("After the exchange the values are, a = {0} and b = {1}",a, b);   


        }
    }
}
