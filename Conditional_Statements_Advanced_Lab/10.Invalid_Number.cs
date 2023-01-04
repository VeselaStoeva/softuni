using System;
namespace task31
{
    class Program
    {
        static void Main()
        {
           int number=int.Parse(Console.ReadLine());
            if ( number!=0 && number<100 || number>200)
            {
                Console.WriteLine("invalid");
            }
            else if (number >= 100 || number <= 200 || number == 0)
            {
                Console.WriteLine();
            }
            
            
        }
    }
}

