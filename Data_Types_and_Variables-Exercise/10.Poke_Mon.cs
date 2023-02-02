using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n= int.Parse(Console.ReadLine());
            var  m= int.Parse(Console.ReadLine());
            var y=int.Parse(Console.ReadLine());
            int x = n;

            int counter = 0;
            while (n>=m)
            {
                counter++;
                n = Math.Abs(n - m);
                
                if (n==x/2 && y>0)
                {
                    n=(n/y);
                    
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);





        }
    }
}