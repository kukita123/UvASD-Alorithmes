using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvASD_Alorithmes
{
    internal class QuickSortClass
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        private static void QuickSort(int[]array, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(array, start, end);
                QuickSort(array, start, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, end);
            }   
        }
        static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;
            for (int j = start; j < end; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, end);
            return i + 1;
        }
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
