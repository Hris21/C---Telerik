namespace PointInsideCircleAndOutsideRectangle            //Sorry for the long name, had to be descriptive..


{
    using System;

    class PointInCircleOutRectangle
    {
        static void Main()
        {
            Console.Write("Please enter X coordinate: ");
            decimal x = decimal.Parse(Console.ReadLine());         //I will use decimal as it is more accurate and precise.
                                                                   //However it is a bit slow.
            Console.Write("Please enter Y coordinate: ");
            decimal y = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            bool result = (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9) && ((x < -1) || ((x >= -1) && ((y <= -1) || (y >= 1))));
            Console.WriteLine("The coordinates are inside the circle and out of the rectangular: {0}", result);
        }
    }
}
