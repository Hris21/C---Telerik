namespace QuadraticEquation


{
    using System;

    class Equation
    {
        static void Main()
        {
            Console.Title = "Equation ax2 + bx + c =0";
            Console.WriteLine("Enter the first coefficient of the equation \"a\" = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second coefficient of the equation \"b\" = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third coefficient of the equation \"c\" = ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - 4 * a * c;
            Console.Clear();
            if(discriminant<0)
            {
                Console.WriteLine("Please restart the program and enter new values discriminant can't be  < 0 ");
            }
            else if (discriminant == 0)
            {
                 double xEqual = (-b) / (2 * a);
                 Console.WriteLine("You have entered {0} | {1} | {2}",a,b,c);
                 Console.WriteLine("The result is D = {0:0.00} >> x1 = x2 = {1:0.00}",discriminant, xEqual); 
            }

            else
            {
                double xOne = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double xTwo = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("You have entered {0} | {1} | {2}",a,b,c);
                Console.WriteLine("The result is D = {0:0.00} >> x1 = {1:0.00}  >> x2 = {2:0.00}",discriminant,xOne,xTwo);
            }
          
        
        }


    }
}
