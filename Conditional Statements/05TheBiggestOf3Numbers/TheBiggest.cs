namespace TheBiggestOf3Numbers

{

    using System;
    class TheBiggest
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers to compare: ");
            double numberOne = double.Parse(Console.ReadLine());           
            double numberTwo = double.Parse(Console.ReadLine());            
            double numberThree = double.Parse(Console.ReadLine());
            double max = Math.Max(numberOne, Math.Max(numberTwo,numberThree));  //I am using Math.Max method, because it saves time and memory.
            Console.WriteLine("The biggest number of {0} {1} {2} is {3}",numberOne,numberTwo,numberThree,max);
        }
    }
}
