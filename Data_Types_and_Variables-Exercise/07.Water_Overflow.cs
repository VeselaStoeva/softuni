using System;

namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n= int.Parse(Console.ReadLine());
            int total = 0;
          
            for (int i = 1; i <=n ; i++)
            {

                int number = int.Parse(Console.ReadLine());

               
                if (total+number>255)
                {
                    
                        Console.WriteLine("Insufficient capacity!");
                        
                    
                    
                }
                else
                {
                    total += number;
                }
                
            }
            Console.WriteLine(total);

        }
    }
}