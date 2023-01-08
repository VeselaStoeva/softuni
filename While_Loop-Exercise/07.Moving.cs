using System;
namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            int width=int.Parse(Console.ReadLine());    
            int lenght=int.Parse(Console.ReadLine());
            int height=int.Parse(Console.ReadLine());
            int lice = width * lenght * height;
            int total = 0;
            bool finish=false;
            while (true)
            {
                string words=Console.ReadLine();
                if (words=="Done")
                {
                    break;
                }
                int kashoni = int.Parse(words);
                total += kashoni;
                if (total>lice)
                {
                    finish= true;
                    break;
                }



            }
            if (finish)
            {
                int need = total - lice;
                Console.WriteLine($"No more free space! You need {need} Cubic meters more.");
            }
            else
            {
                int plase = lice - total;
                Console.WriteLine($"{plase} Cubic meters left.");
            }
        }
    }
}
