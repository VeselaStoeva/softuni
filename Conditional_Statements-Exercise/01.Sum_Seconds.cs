using System;
namespace task24
{
    class Program
    {
        static void Main()
        {
            int firstTime=int.Parse(Console.ReadLine());
            int secondTime=int.Parse(Console.ReadLine());
            int trirdTime=int.Parse(Console.ReadLine());
            int totalTime=firstTime+secondTime+trirdTime;
            int minutes=totalTime/60;
            int seconds = totalTime % 60;
            if (seconds<10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");

            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}