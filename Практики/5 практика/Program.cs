using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5_Практика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryPassword = 3;
            Console.WriteLine("Тест на проверки пароля через циклы, 3 попытки правильно ввести пароль, пароль сами придумываем");
            Console.Write("Придумайте пароль: ");
            //Придумываем пароль
            string password = Console.ReadLine();
            /// Эта строка ЮзерИнпут будет тем неправильным паролем
            string userInput;
            for (int i = 0; i <= tryPassword; i++)
            {
                Console.Write("Введите пароль, который вы только что задали(ведь вы же его забыли, да?): ");
                userInput = Console.ReadLine();
                if (password == userInput)
                {
                    Console.WriteLine("Поздравляю, вы всё таки списали пароль правильно!");
                    break;
                }
                else
                {
                    Console.WriteLine("Введён неверный пароль, попробуйте ещё раз.");
                    Console.WriteLine($"Осталось попыток {tryPassword - i}");
                } 
                    
            }
            Console.ReadLine();
        }
    }
}
