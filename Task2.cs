using System;
using System.Collections.Generic;

namespace Laba3
{
    public class Task2
    {
        public static void Second()
        {
            var dict = new Dictionary<int, string>()
            {
                { 1, "Один" },
                { 2, "Два" },
                { 3, "Три" },
                { 4, "Четыре" },
                { 5, "Пять" },
                { 6, "Шесть" },
                { 7, "Семь" },
                { 8, "Восемь" }
            };

            Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            Console.WriteLine("Словарь: ");
            foreach (var item in dict) Console.WriteLine(item.Key + " -> " + item.Value);

            var keys = new List<int>(dict.Keys);
            var values = new List<string>(dict.Values);

            Console.WriteLine($"\nКлючи: {string.Join(", ", keys)}");
            Console.WriteLine($"Значения: {string.Join(", ", values)}");
            Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
        }
    }
}
