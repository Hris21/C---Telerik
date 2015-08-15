namespace Trapezoids
{
    using System;

    class TrapArea
    {
        static void Main()

        //Write an expression that calculates trapezoids' area by given sides a and b and height h.
        //I will use the formula [(sideA + sideB) / 2|) * height;
        {
            Console.Title = "Trapezoids' area";
            Console.WriteLine("Enter side a: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            double area = ((sideA + sideB) / 2) * height;
            Console.WriteLine("The area of the trapezoid is >> {0} <<", area);
        }
    }
}