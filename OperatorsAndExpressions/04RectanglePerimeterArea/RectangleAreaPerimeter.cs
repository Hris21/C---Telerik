namespace RectanglePerimeterArea

{
    using System;

    class RectangleAreaPerimeter
    {
        static void Main()
        //Write an expression that calculates rectangle’s perimeter and area by given width and height.

        {
            Console.WriteLine("Enter the desired length : ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the desired width : ");
            int width = int.Parse(Console.ReadLine());
            int perimeter = (length + width) * 2;
            int area = length * width;
            Console.WriteLine("The area of the rectangle is {0} and the perimeter is {1} .",area, perimeter);
        }
    }
}
