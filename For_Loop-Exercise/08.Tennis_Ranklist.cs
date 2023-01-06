using System;
namespace Task78
{
    class Program
    {
        static void Main()
        {
            int n =int.Parse(Console.ReadLine());
            int firstPoints=int.Parse(Console.ReadLine());
            int tourNum = 0;
            double wins = 0;
            for (int i = 1; i <= n; i++)
            {
                string tournir = Console.ReadLine();
                switch (tournir)
                {
                    case "W":
                        tourNum += 2000;
                        wins++;
                        break;
                    case "F":
                        tourNum += 1200;
                        break;
                    case "SF":
                        tourNum += 720;
                        break;
                }
            }
            double totalPoints = tourNum + firstPoints;
            Console.WriteLine( $"Final points: {totalPoints}");
            double avarage = tourNum / n;
            Console.WriteLine($"Average points: {Math.Floor(avarage)}");
            double percent = wins / n*100;
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
    