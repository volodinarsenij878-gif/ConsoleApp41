using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Стоимость блюд (руб.): ");
            decimal totalDishes = decimal.Parse(Console.ReadLine());

            Console.Write("Размер сервисного сбора в процентах: ");
            decimal percent = decimal.Parse(Console.ReadLine());

            Console.Write("Количество персон: ");
            int persons = int.Parse(Console.ReadLine());

            decimal serviceCharge = totalDishes * percent / 100M;
            decimal grandTotal = totalDishes + serviceCharge;
            decimal perPerson = grandTotal / persons;

            Console.WriteLine("\n--- ЧЕК ---");
            Console.WriteLine($"Стоимость блюд:      {totalDishes:C}");
            Console.WriteLine($"Сервисный сбор:     {serviceCharge:C}");
            Console.WriteLine($"Итого к оплате:     {grandTotal:C}");
            Console.WriteLine($"На одного гостя:    {perPerson:C}");
        }
    }
}


