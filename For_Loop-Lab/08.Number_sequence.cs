using System;
namespace task42
{
    class Program
    {
        static void Main()
        {
           int n=int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for(int i=0; i<n; i++)
            {
                int curenceNumber=int.Parse(Console.ReadLine());
                if (curenceNumber>maxNumber)
                {
                    maxNumber = curenceNumber;
                }
                if (curenceNumber<minNumber)
                {
                    minNumber = curenceNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
           
        }
       
        
    }
}