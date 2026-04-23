using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvASD_Alorithmes
{
    internal class CountingSortClass
    {
        static void CountingSort(int[] array)
        {
            if (array.Length == 0)
                return;
            int max = array.Max();  //find the maximum value in the array to determine the size of the count array
            int min = array.Min();  //find the minimum value in the array to determine the size of the count array
            int range = max - min + 1;
            int[] count = new int[range];
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - min]++;
            }
            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    array[index++] = i + min;
                    count[i]--;
                }
            }
        }
    }
}
