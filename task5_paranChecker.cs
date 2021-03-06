using System;
using System.Collections.Generic;

namespace Task5
{
    public class BalancedParan
    {
        /* Возвращает true, если char1 и char2 
         * являются совпадающими правой и левой скобками */
        static Boolean IsMatchingPair(char char1, char char2)
        {
            if (char1 == '(' && char2 == ')')
                return true;
            else if (char1 == '{' && char2 == '}')
                return true;
            else if (char1 == '[' && char2 == ']')
                return true;
            else
                return false;
        }

        // Возвращает true, если последовательность правильная
        static Boolean AreParenthesisBalanced(char[] exp)
        {
            // Создаем пустой стек
            Stack<char> st = new Stack<char>();

            // Проверяем каждый символ в массиве
            for (int i = 0; i < exp.Length; i++)
            {

                // Если exp[i] - это открывающая скобка
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                    // отправляем ее в стек
                    st.Push(exp[i]);

                // Если exp[i] - это закрывающая скобка  
                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {

                    // Если стек пуст, возвращаем false
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    /* Берем последний элемент стека,
                     * если он не составляет пару,
                     * то последовательность неправильная */
                    else if (!IsMatchingPair(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }

            }
            /* Если в стеке что-то осталось,
             * то это открывающая скобка без закрывающей */
            if (st.Count == 0)
                return true; 
            else
            { 
                return false;
            }
        }
        public static void Main(String[] args)
        {
            Console.Write("Введите скобочную последовательность: ");
            string s = Console.ReadLine();
            // Превращаем строку в массив символов
            char[] arr = s.ToCharArray();
            
            if (AreParenthesisBalanced(arr))
                Console.WriteLine("Правильная последовательность!");
            else
                Console.WriteLine("Это неправильная последовательность!");
        }
    }
}