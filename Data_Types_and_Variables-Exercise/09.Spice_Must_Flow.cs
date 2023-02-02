using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n= int.Parse(Console.ReadLine());
            
            
            if (n<100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }else
            {
                int box = 0;
                int days = 0;
                for (int i = n; i>=100 ; i-=10)
                {
                    days++;
                    box += i - 26;

                }
                box -= 26;
                Console.WriteLine(days);
                Console.WriteLine(box);
            }
            
                
                

           
        }
    }
}