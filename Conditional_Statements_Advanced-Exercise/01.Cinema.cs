using System;
namespace task34
{
    class Program
    {
        static void Main()
        {
            string type=Console.ReadLine();
            int rows=int.Parse(Console.ReadLine());
            int colums=int.Parse(Console.ReadLine());
            double rezult = 0;
            if (type=="Premiere")
            {
                rezult = rows * colums * 12;
                Console.WriteLine($"{rezult:f2}");
            }
            else if (type=="Normal")
            {
                rezult = rows * colums * 7.50;
                Console.WriteLine($"{rezult:f2}");
            }
            else if (type=="Discount")
            {
                rezult = rows * colums * 5;
                Console.WriteLine($"{rezult:f2}");
            }
        }
    }
}


