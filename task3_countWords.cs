using System;
using System.Linq;

namespace Task3
{
    class OnlyOnce
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            // Разбиваем строку на отдельные слова
            var words = text.Split(new[] { '.', ',', ' ', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Эти слова встречаются только один раз: ");
            foreach (var w in words.Where(x => words.Count(v => v == x) == 1))
            {
                Console.WriteLine(w);
            }
            Console.ReadLine();
        }
    }
}