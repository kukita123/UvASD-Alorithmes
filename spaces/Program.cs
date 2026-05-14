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
