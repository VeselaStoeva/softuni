using System;
namespace task33
{
    class Program
    {
        static void Main()
        {
            int numOne=int.Parse(Console.ReadLine());
            int numTwo=int.Parse(Console.ReadLine()); 
            char operation=char.Parse(Console.ReadLine());
            double mathRezult = 0;
            string finalRezult = "";
            switch (operation)
            {
                case '+':
                    mathRezult = numOne + numTwo;
                    if (mathRezult % 2 ==0)
                    {
                        finalRezult = $"{numOne} {operation} {numTwo} = {mathRezult} - even";
                    }
                    else
                    {
                        finalRezult = $"{numOne} {operation} {numTwo} = {mathRezult} - odd";
                    }
                    break;
                    case '-':
                    mathRezult = numOne - numTwo;
                    if (mathRezult % 2==0)
                    {
                        finalRezult = $"{numOne} {operation} {numTwo} = {mathRezult} - even";
                    }
                    else
                    {
                        finalRezult = $"{numOne} {operation} {numTwo} = {mathRezult} - odd";
                    }
                    break;
                case '*':
                    mathRezult = numOne * numTwo;
                    if (mathRezult % 2==0)
                    {
                        finalRezult = $"{numOne} {operation} {numTwo} = {mathRezult} - even";
                    }
                    else
                    {
                        finalRezult = $"{numOne} {operation} {numTwo} = {mathRezult} - odd";
                    }
                    break;
                case '/':
                    if (numTwo == 0)
                    {
                        finalRezult = $"Cannot divide {numOne} by zero";
                    }
                    else
                    {
                        mathRezult = numOne /(double) numTwo;
                        finalRezult = $"{numOne} {operation} {numTwo} = {mathRezult:f2}";
                    }
                    break;
                case '%':
                    if (numTwo == 0)
                    {
                        finalRezult = $"Cannot divide {numOne} by zero";
                    }
                    else
                    {
                        mathRezult = numOne % numTwo;
                        finalRezult = $"{numOne} {operation} {numTwo} = {mathRezult}";
                    }
                    break;

            }
            Console.WriteLine(finalRezult);
        }
    }
}