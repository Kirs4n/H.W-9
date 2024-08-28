using System;
using System.Collections.Generic;

namespace ДЗ_контроль_выхода
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int specifiedLiftDepth;
            Console.Write("Введите с какой глубины необходимо осуществить подьём: ");
            specifiedLiftDepth = Convert.ToInt32(Console.ReadLine());

            while (specifiedLiftDepth-- > 0) 
            {
               Console.WriteLine($"Груз поднялся на {specifiedLiftDepth} метров");

                string stopCommand = "exit";
                string userInput;
                userInput = Console.ReadLine();

                if (userInput == stopCommand)
                {
                    Console.WriteLine("Остановка лифта!!");
                        break;
                }
            }

             




        }
    }
}
