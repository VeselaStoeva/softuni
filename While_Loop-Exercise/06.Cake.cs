using System;
namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int totalPiece = lenght * width;
            bool totalFinish = false;
            string word = "";

            while (true)
            {
                 word = Console.ReadLine();
                if (word == "STOP")
                {
                    break;
                }
                int guests = int.Parse(word);
                totalPiece -= guests;
                if (totalPiece <= 0)
                {
                    totalFinish = true;
                    break;


                }
            }
            if (totalFinish)
            {
                
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPiece)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{totalPiece} pieces are left.");
            }
        }  
    }
}
