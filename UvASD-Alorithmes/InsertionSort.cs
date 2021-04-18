using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvASD_Alorithmes
{
    public class InsertionSort
    {
       
           public static int[] InsertionSortImplementation(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int value = array[i];
                    int index = i;
                    while (index > 0 && array[index - 1] >= value)
                    {
                        array[index] = array[index - 1]; //pushing the all bigger values to the right
                        index--;
                    }
                    array[index] = value; //sets the value at a specific index
                }
                return array; //sorted array
            }
        
    }
}
