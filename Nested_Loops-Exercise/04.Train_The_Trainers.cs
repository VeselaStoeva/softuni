using System;
namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jyries = int.Parse(Console.ReadLine());
            string task;
            int totalGrades = 0;
            double total = 0;
            
            while ((task=Console.ReadLine())!="Finish")
            {
                double sum = 0;
                for (int i = 1; i <=jyries; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    
                    total += grade;
                    sum += grade;
                   


                    totalGrades++;
                }
                Console.WriteLine($"{task} - {(sum/jyries):f2}.");
                
            }
            Console.WriteLine($"Student's final assessment is {total/totalGrades:f2}.");
        }
    }
}