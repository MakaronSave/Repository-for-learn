using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Третяя_практика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Придумайте пароль: ");
            Console.Write("Пароль: ");
            string password = Console.ReadLine();
            Console.WriteLine("Пароль задан.");
            Console.Write("Введите пароль повторно: ");
            string repassword = Console.ReadLine();
            if (password != repassword)
            {
                Console.WriteLine("Пароли не совпадают, попробуйте ещё раз. ");
                Console.Write("Введите пароль повторно: ");
                repassword = Console.ReadLine();
                if (password == repassword) {
                    Console.WriteLine("Пароль задан успешно. ");

                }
                else
                {
                    Console.WriteLine("Попытки закончились, попробуйте запустить программу ещё раз.");
                }

            }
            else if (repassword == password)
            {
                Console.WriteLine("Пароль задан успено. ");
            }
            Console.ReadKey();
        }
    }
}
