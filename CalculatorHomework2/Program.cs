using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHomework2
{

    //Я не знаю как грамотнее сделать простой калькулятор на if else
    //Поэтому оставил как есть :з

    internal class Program
    {
        static void Main(string[] args)
        {
            double Number1, Number2, Result;
            string WhatToDo;

            Console.WriteLine("Перед Вами простой калькулятор, который может сложить, вычесть, умножить и разделить два введённых числа");

            Console.WriteLine("Пожалуйста, введите первое число:");
            Number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите желаемое действие из доступных");

            Console.WriteLine("(сложить, вычесть, умножить, разделить)");
            WhatToDo = Console.ReadLine();

            Console.WriteLine("Пожалуйста, введите второе число:");
            Number2 = double.Parse(Console.ReadLine());

            if (WhatToDo == "сложить") {
                Result = Number1 + Number2;
                Console.WriteLine("Ответ: " + Result);
            }
            if (WhatToDo == "вычесть") {
                    Result = Number1 - Number2;
                    Console.WriteLine("Ответ: " + Result);
            }
            if (WhatToDo == "умножить") {
                Result = Number1 * Number2;
                Console.WriteLine("Ответ: " + Result);
            }
            if (WhatToDo == "разделить")
            {
                Result = Number1 / Number2;
                Console.WriteLine("Ответ: " + Result);
            }
            else
                Console.WriteLine("Действие не распознано, убедитесь в правильности написания действия");
         }
            
       
    }
}
