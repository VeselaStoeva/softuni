using System;
namespace task28
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int timeEpizod=int.Parse(Console.ReadLine());
            int timeHoliday=int.Parse(Console.ReadLine());
            double timeLunch = timeHoliday * 0.125;
            double timeOtdih = timeHoliday * 0.25;
            double newTime = timeHoliday - timeLunch - timeOtdih;
            if (timeEpizod<=newTime)
            {
                int ostavat = (int)newTime - timeEpizod;
                Console.WriteLine($"You have enough time to watch {name} and left with {ostavat} minutes free time.");
            }
            else if (timeEpizod>=newTime)
            {
                int nyvni = timeEpizod - (int)newTime;
                Console.WriteLine($"You don't have enough time to watch {name}, you need {nyvni} more minutes.");
            }


        }
    }
}