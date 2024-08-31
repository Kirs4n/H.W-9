using System;
using System.Collections.Generic;

namespace ДЗ_контроль_выхода
{
    internal class Program
    {
        static void Main(string[] args)
        {
             bool login=true;
            string commandExit = "exit";
            string userInput;
            
            while (login) 
            {
               Console.WriteLine($"Произведен вход в систему");
               userInput = Console.ReadLine();

                if (commandExit==userInput)
                {
                    login = false;
                    Console.WriteLine("Выход из системы");
                        break;
                }
            }
        }
    }
}
