using System;
namespace task42
{
    class Program
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            int curence = 0;
            for(int i=0; i<n; i++)
            {
                int currenceNumber=int.Parse(Console.ReadLine());
                curence += currenceNumber;
            }
            Console.WriteLine(curence);

           
        }
       
        
    }
}