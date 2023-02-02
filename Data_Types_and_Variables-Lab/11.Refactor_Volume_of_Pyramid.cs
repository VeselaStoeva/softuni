using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal lenght, width, height;
            
            lenght = decimal.Parse(Console.ReadLine());
           
            width = decimal.Parse(Console.ReadLine());
           
            height = decimal.Parse(Console.ReadLine());
            decimal v = (lenght * width * height)/3M ;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {v:f2}");


        }
    }
}