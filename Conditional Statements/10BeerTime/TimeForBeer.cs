namespace BeerTime

{
    
  
    using System;
    class TimeForBeer
    {
        static void Main()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            Console.WriteLine("Please enter hour to check if it's beer time : ");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter minutes : ");
            int minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter seconds : ");
            int second = int.Parse(Console.ReadLine());
            Console.Clear();

            DateTime moment = new DateTime(year, month, day, hour, minute, second);
            if ((hour >= 3) && (hour <= 13))
            {
                Console.WriteLine(moment.ToString("F"));
                Console.WriteLine("It's BEER time !!");

            }
            else
            {
                Console.WriteLine(moment.ToString("F"));
                Console.WriteLine("Non-beer time :( ");
            }
        } 
    }
}
