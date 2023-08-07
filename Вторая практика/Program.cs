using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Первая_практика_Задание__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money, food, inFoodUnitPrise;
            bool isAbleToPay;
            inFoodUnitPrise = 10;
            Console.WriteLine($"Добрый день, сегодняшняя цена на еду: {inFoodUnitPrise} монет.");
            Console.WriteLine("Сколько у вас золота?");
            Console.Write("У меня золота: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько вы хотите купить еды?");
            Console.Write("Я хотел бы купить еды в количестве: ");
            food = Convert.ToInt32(Console.ReadLine());


            isAbleToPay = money >= food * inFoodUnitPrise;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * inFoodUnitPrise;
            Console.Write($"Вы купили еды: {food} едениц, у вас осталось {money} монет.");
            Console.ReadLine();

        }
    }
}