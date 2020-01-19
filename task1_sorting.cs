using System;
namespace Task1
{
    class Sorting
    {
        // Алгоритм пузырьковой сортировки
        public static void SortingFunction(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Ввод массива
            Console.Write("Введите числа через запятую или пробел: ");
            var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new int[s.Length];
            // Преобразуем строку в массив чисел
            for (int i = 0; i < s.Length; i++)
            {
                numbers[i] = Convert.ToInt32(s[i]);
            }
            // Вывод результата
            Console.WriteLine("По возрастанию:");
            SortingFunction(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}