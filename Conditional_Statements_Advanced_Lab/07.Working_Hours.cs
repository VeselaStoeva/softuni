using System;
namespace task30
{
    class Program
    {
        static void Main()
        {
            int number=int.Parse(Console.ReadLine());
            string day=Console.ReadLine();
            if (number >= 10 && number <= 18)
            {
                if ( day == "Monday" || day =="Tuesday" || day=="Wednesday" || day=="Thursday" || day=="Friday" || day=="Saturday")
                {
                    Console.WriteLine("open");
                    
                }
                else if (number >= 10 && number <= 18 && day=="Sunday")
                {
                    Console.WriteLine("closed");
                }
            }
            else if ( number>=18)
            {
                if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday" || day=="Sunday" )
                {
                    Console.WriteLine("closed");
                }
            }
        }
    }
}


