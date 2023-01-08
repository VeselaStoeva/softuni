using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int brojGrades=int.Parse(Console.ReadLine());
            int times = 0;
            int task = 0;
            string lastTask = "";
            bool isFaild = true;
            double gradeSum = 0;
            while (times<brojGrades)
            {
                string name = Console.ReadLine();
                if (name=="Enough")
                {
                    isFaild = false;
                    break;
                }
                int grade=int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                    times++;    
                }
                gradeSum += grade;
                task++;
                lastTask = name;


            }
            if (isFaild)
            {
                Console.WriteLine($"You need a break, {brojGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(gradeSum/task):f2}");
                Console.WriteLine($"Number of problems: {task}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
