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
            //count sort the collection with only positive elements:
            

            int[] output = new int[array.Length];

            // Find the largest element of the array
            int max = array.Max();           

            int[] count = new int[max + 1];

            // Store the count of each element
            for (int i = 0; i < array.Length; i++)

                count[array[i]]++;//or count

            // Store the cummulative count of each array
            for (int i = 1; i <= max; i++)            
                count[i] += count[i - 1];

            // Find the index of each element of the original array in count array, and
            // place the elements in output array
            for (int i = array.Length - 1; i >= 0; i--)
            { 
                output[count[array[i]] - 1] = array[i];
                count[array[i]]--;
            }
            // Copy the sorted elements into original array          

             array = output;

            
        }
        static void CountingSortSimle(int[] array)
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
