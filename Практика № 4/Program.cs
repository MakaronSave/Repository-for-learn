using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика___4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dollarsInWallet, rublesInWallet;
            int RubToUsd = 64, UsdToRub = 66;
            float exchangeCurrencyCount;
            string desiredOperation;
            Console.WriteLine("Привет, это обменник валют написаный специально для Юри!");
            Console.Write("Введите колличество ваших рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите колличество ваших дешёвых американских грязных бумажек: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите нужную команду: ");
            Console.WriteLine("1 - Обменять ваши дешёвые американские грязные бумажки на рубли.");
            Console.WriteLine("2 - Обменять рубли на дешёвые американские грязные бумажки.");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine();
            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен дешёвых американских грязных бумажек на рубли: ");
                    Console.Write("Сколько вы хотите обменять?: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        exchangeCurrencyCount *= Convert.ToSingle(UsdToRub);
                        rublesInWallet += exchangeCurrencyCount;
                        Console.WriteLine($"Вам зачислено {exchangeCurrencyCount} руб., теперь у вас на счёте {rublesInWallet} рублей.");
                        Console.WriteLine($"У вас осталось {dollarsInWallet}$," +
                                          $" было снято {exchangeCurrencyCount / UsdToRub}$.");
                    }
                    else
                        Console.WriteLine("Извините, вы ввели число больше, чем у вас есть в кашельке, вы бы могли пополнить ваш кошелёк, " +
                                          "но я пока не знаю как это закодить, возможно в будующем сделаю.");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Обмен рублей на дешёвые американские грязные бумажки: ");
                    Console.Write("Сколько вы хотите обменять?: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWallet >= exchangeCurrencyCount)
                    {
                        rublesInWallet -= exchangeCurrencyCount;
                        exchangeCurrencyCount /= Convert.ToSingle(RubToUsd);
                        dollarsInWallet += exchangeCurrencyCount;
                        Console.WriteLine($"Вам зачислено {exchangeCurrencyCount} Долларов., теперь у вас на счёте {dollarsInWallet}$.");
                        Console.WriteLine($"У вас осталось {rublesInWallet}руб.," +
                                          $" было снято {exchangeCurrencyCount * RubToUsd}руб.");
                    }
                    else
                        Console.WriteLine("Извините, вы ввели число больше, чем у вас есть в кашельке, вы бы могли пополнить ваш кошелёк, " +
                                         "но я пока не знаю как это закодить, возможно в будующем сделаю.");
                    Console.ReadLine();
                    break;
                    default:
                    Console.WriteLine("Не опознанная операция.");
                    Console.ReadLine();
                    break;

            }
        }
    }
}