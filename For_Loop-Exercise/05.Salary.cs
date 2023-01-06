using System;
namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            int broy=int.Parse(Console.ReadLine()); 
            int salary=int.Parse(Console.ReadLine());
            int total = salary;
            for (int i =1; i<=broy; i++)
            {
                string words = Console.ReadLine();
                switch(words)
                {
                    case "Facebook":
                        total -= 150;
                        break;
                    case "Instagram":
                        total -= 100;
                        break;
                    case "Reddit":
                        total -= 50;
                        break ;

                }
                if (total<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;

                }
                
            }
            if (total==salary)
            {
                Console.WriteLine(salary);
            }
            else if (total<salary)
            {
                Console.WriteLine(total);
            }
           
        }
    }
}
