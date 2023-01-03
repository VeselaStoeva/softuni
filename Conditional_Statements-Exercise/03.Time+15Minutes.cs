using System;
namespace task22
{
    class Program
    {
        static void Main()
        {
            int hours=int.Parse(Console.ReadLine());
            int minets=int.Parse(Console.ReadLine());
            int timeInfifteen = minets + 15;
            if (timeInfifteen>59)
            {
                hours++;
                if (hours>23)
                {
                    hours = 0;
                }
                timeInfifteen -= 60;
            }
            Console.WriteLine($"{hours}:{timeInfifteen:D2}");
        }
    }
}