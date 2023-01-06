using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int years = 1;
            double grades = 0;
            bool hasFailed=false;
            bool hasGraduated = true;
            while (years<=12)
            {
                
                double grade=double.Parse(Console.ReadLine());
                grades += grade;
                if (grade<4)
                {
                    if (hasFailed)
                    {
                        Console.WriteLine($"{name} has been excluded at {years} grade");
                        hasGraduated=false;
                        break;
                    }
                    hasFailed = true;
                    continue;
                }
                years++;    
            }
            if (hasGraduated)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(grades/12):f2}");
            }
                
        }

    }
}

