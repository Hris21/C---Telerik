namespace CirclePerimeterAndArea



{
    using System;
    class CirclePerimeterArea
    {
        static void Main()
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
        //I will use the basic formulas area = [3,14]Pie * R*R, Perimeter = 2[3,14]*pie*R
        {
            Console.WriteLine("Enter the radius of the cirlce: ");
            double radius = float.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            double perimeter = 2 * radius * Math.PI;
            Console.WriteLine("The are of the circle is | {0:0.00} |" + " the perimeter of the circle is | {1:0.00} |",area,perimeter);
        }
    }
}
