using System;
namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int total = 0;
            int student = 0;
            int standard = 0;
            int kid = 0;
            while ((word=Console.ReadLine())!="Finish")
            {
                int freePlace=int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i <=freePlace; i++)
                {
                    string bilet = Console.ReadLine();
                    
                    if (bilet=="End")
                    {
                        break;
                    }
                    else if (bilet=="student")
                    {
                        student++;
                    }
                    else if (bilet=="standard")
                    {
                        standard++;
                    }
                    else if (bilet=="kid")
                    {
                        kid++;
                    }
                    sum++;
                    total++;

                }
                double ticketPer = (double)sum / (freePlace*1.00) * 100;
                Console.WriteLine($"{word} - {(ticketPer):f2}% full.");
            }
            Console.WriteLine($"Total tickets: {total}");
            double tick = (double)student / (total*1.00) * 100;
            Console.WriteLine($"{(tick):f2}% student tickets.");
            double ticke =(double) standard / (total * 1.00) * 100;
            Console.WriteLine($"{(ticke):f2}% standard tickets.");
            double ticka =(double) kid/ (total * 1.00) * 100;
            Console.WriteLine($"{(ticka):f2}% kids tickets.");
        }
    }
}