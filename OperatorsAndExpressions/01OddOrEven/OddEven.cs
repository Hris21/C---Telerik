namespace OddOrEven


{
    using System;

    class OddEven
    {
        static void Main()
        //Write an expression that checks if given integer is odd or even.

        {
            Console.WriteLine("Enter the number you would like to check");
            int someInteger = int.Parse(Console.ReadLine());                                          
            if (someInteger % 2 == 0)                                                        
            {
            Console.WriteLine("The number {0} is even", someInteger);
            }
            else
            {
            Console.WriteLine("The number {0} is odd", someInteger);
            }
        }
    }
}
