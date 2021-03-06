using System;
namespace Task2

{
    class Search
    {
        // Алгоритм бинарного поиска
        static int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            // Если границы сошлись
            if (first > last)
            {
                // то элемент не найден
                return -1;
            }
            // Находим средний индекс подмассива
            var middle = (first + last) / 2;
            // Значение в средине подмассива
            var middleValue = array[middle];
            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    // Рекурсивный вызов поиска для левого подмассива
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    // Рекурсивный вызов поиска для правого подмассива
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }

        static void Main(string[] args)
        {
            // Ввод массива
            Console.Write("Введите элементы массива через запятую: ");
            var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                array[i] = Convert.ToInt32(s[i]);
            }

            // Отсортируем массив с помощью встроенной функции
            Array.Sort(array);
            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", array));

            while (true)
            {
                Console.Write("Введите искомое значение или -777 для выхода из программы: ");
                var k = Convert.ToInt32(Console.ReadLine());
                if (k == -777)
                {
                    break;
                }
                var searchResult = BinarySearch(array, k, 0, array.Length - 1);
                if (searchResult < 0)
                {
                    Console.WriteLine("Элемент со значением {0} не найден", k);
                }
                else
                {
                    Console.WriteLine("Элемент найден. Индекс элемента со значением {0} равен {1}", k, searchResult);
                }
            }
        }
    }
}