using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvASD_Alorithmes
{
    public class SelectionSort
    {
        public static void SelectionSort1(int[] array)
        {
            int i, j, minIndex;
            for (i = 0; i < array.Length - 1; i++)
            {
                // Find the minimum element in unsorted array:  
                minIndex = i;
                for (j = i + 1; j < array.Length; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;

                // Swap the found minimum element with the first element of the unsorted part of the array:  
                int swap = array[minIndex];
                array[minIndex] = array[i];
                array[i] = swap;
            }
        }

        public static void SelectionSort2(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i]>array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }
        }
    }
}
