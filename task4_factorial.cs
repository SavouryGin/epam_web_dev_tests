using System;

namespace Task4
{
    class Factorial
    {
        // Рекурсивная функция для поиска факториала числа n
        static long CountFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CountFactorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое неотрицательнное число:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал:");
            Console.WriteLine(CountFactorial(x));
            Console.ReadLine();
        }
    }
}