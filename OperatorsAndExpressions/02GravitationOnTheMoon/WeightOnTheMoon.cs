namespace GravitationOnTheMoon


{
    using System;

    class WeightOnTheMoon
    {
        static void Main()
            //The gravitational field of the Moon is approximately 17% of that on the Earth.Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
        {
            Console.Write("Please enter your weight in numbers : ");
            float earthWeight = float.Parse(Console.ReadLine());   
            float moonWeight = (earthWeight * 17) / 100;           //Since calculating % equals : (number * percent (17 in this case)) / 100
            Console.WriteLine("Your weight on the moon would be : " + moonWeight);


        }
    }
}
