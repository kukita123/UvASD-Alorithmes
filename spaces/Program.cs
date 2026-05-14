/*
 * 🔹 Задача 1: Намери първата площадка

Даден е масив от цели числа. Да се намери първата последователност от еднакви съседни елементи (с дължина ≥ 2).

Пример:

Вход: 1 2 2 2 3 4  
Изход: Площадка: 2 2 2 (индекси 1 до 3)
🔹 Задача 2: Брой на площадките

Да се преброят всички площадки в масива (дължина ≥ 2).

Пример:

Вход: 1 1 2 3 3 3 4 5 5  
Изход: 3 площадки
🔹 Задача 3: Най-дълга площадка

Да се намери най-дългата площадка в масива.

Пример:

Вход: 1 2 2 3 3 3 4  
Изход: 3 3 3
🔹 Задача 4: Всички площадки и техните дължини

Да се изведат всички площадки заедно с тяхната дължина.

Пример:

Вход: 1 1 2 3 3 3 4  
Изход:
1 -> дължина 2  
3 -> дължина 3
🔹 Задача 5: Площадка с максимална стойност

Да се намери площадката, която съдържа най-голямото число.

Пример:

Вход: 1 1 5 5 2 2 2  
Изход: 5 5
🔹 Задача 6: Премахване на площадки

Да се създаде нов масив, в който са премахнати всички площадки (остават само елементи, които не се повтарят съседно).

Пример:

Вход: 1 1 2 3 3 4  
Изход: 2 4
🔹 Задача 7 (по-трудна): Индекси на всички площадки

Да се намерят началния и крайния индекс на всяка площадка.

Пример:

Вход: 1 1 2 3 3 3 4  
Изход:
Площадка от 0 до 1  
Площадка от 3 до 5
🔹 Задача 8 (предизвикателство): Площадка с най-голяма сума

Ако площадките са от различни числа, да се намери тази с най-голяма сума (стойност × брой елементи).

Пример:

Вход: 2 2 3 3 3 1 1 1 1  
Изход: 3 3 3 (сума 9)
 */
using System;

namespace Plateaus

{
    class Program
    {
        static void FirstSpace(int[] array)
        {
            int startIndex = 0, endIndex = 0, value = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    startIndex = i;
                    value = array[i];
                    while (array[i] == array[i + 1] && i <= array.Length - 1)
                    {
                        i++;
                    }
                    endIndex = i;
                    break;
                }
            }
            if (startIndex == endIndex)
            {
                Console.WriteLine("\nNo plateaus found");
            }
            else
            {
                Console.WriteLine("\nIndexes: start index: {0}, end index: {1}", startIndex, endIndex);
                Console.WriteLine("Value: {0}", value);
            }
        }
        static void CountPlateaus(int[] array)
        {
            int startIndex = 0, endIndex = 0, value = 0;
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    startIndex = i;
                    value = array[i];
                    while (array[i] == array[i + 1] && i <= array.Length - 1)
                    {
                        i++;
                    }
                    endIndex = i;
                    count++;
                    Console.WriteLine("\nPlateau: start index: {0}, end index: {1}", startIndex, endIndex);
                    Console.WriteLine("Value: {0}", value);
                }                
            }
            Console.WriteLine("\nPlateaus count: {0}", count);
        }
        static void Main(string[] args)
        {
            int[] array = { 7, -8, 13, 2, 3, 3, 7, 7, 7, 61, 7};
            FirstSpace(array);
            CountPlateaus(array);
        }
    }
}
