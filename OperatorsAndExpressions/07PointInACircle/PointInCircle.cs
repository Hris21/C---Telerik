namespace PointInACircle


{
    using System;

    class PointInCircle
    {
        static void Main()
            //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
        {
            Console.WriteLine("Enter coordinates for X : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinates for Y:  ");
            int y = int.Parse(Console.ReadLine());
            int radius = 5;
            bool result = x * x + y * y < radius * radius; //We use the x2 + y2 < r2 formula
            Console.WriteLine();
            Console.WriteLine(result ? "The given point is within the circle" : "The given point is outside the circle"); //? and : replace the 'If / else' construction.
        }   
    }
}
