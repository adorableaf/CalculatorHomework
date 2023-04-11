using System;

namespace CalculatorHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Number1, Number2, Result;
            string WhatToDo;

            Console.WriteLine("Перед Вами простой калькулятор, который может сложить, вычесть, умножить и разделить два введённых числа");
            
            Console.WriteLine("Пожалуйста, введите первое число:");
            Number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите желаемое действие из доступных");
            
            Console.WriteLine("'+' сложить, '-' вычесть, '*' умножить, '/' разделить");
            WhatToDo = Console.ReadLine();

            Console.WriteLine("Пожалуйста, введите второе число:");
            Number2 = double.Parse(Console.ReadLine());

            switch (WhatToDo)
            {
                case "+":
                    Result = Number1 + Number2;
                    Console.WriteLine("Ответ: " + Result);
                    break;
                case "-":
                    Result = Number1 - Number2;
                    Console.WriteLine("Ответ: " + Result);
                    break;
                case "*":
                    Result = Number1 * Number2;
                    Console.WriteLine("Ответ: " + Result);
                    break;
                case "/":
                    Result = Number1 / Number2;
                    Console.WriteLine("Ответ: " + Result);
                    break;
                default: Console.WriteLine("Не удалось выполнить действие");
                    break;
            }
        }
    }
}
