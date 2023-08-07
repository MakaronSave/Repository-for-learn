using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Первая_практическая_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health, armor, damage;
            Console.Write($"Введите количество здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());
            health -= damage * armor / 100;
            // Я не буду записывать 100 как переменную, т.к это не обязательно. Магическое число всё таки это магическое число.
            Console.WriteLine($"Вам нанесли {damage} урона, у вас осталось {health} здоровья.");
            // Не совсем понял, зачем мне делать практику, потому что он сам там всё решает прям на видео, так что я сильно не стараюсь :D

        }
    }
}
