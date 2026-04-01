using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvASD_Alorithmes
{
    class MergeSortClass
    {   
        //first method - recursivelly split the array
        //by calling the MERGE method - > it combines
        //the elements
        public static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;   //bottom of the recursion -> array with one element 
            }

            int middle = array.Length / 2;
            int[] leftHalf = new int[middle];
            int[] rightHalf = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                leftHalf[i] = array[i];
            }

            for (int i = middle, j=0; j < rightHalf.Length; i++, j++)
            {
                rightHalf[j] = array[i];
            }

            leftHalf = MergeSort(leftHalf);
            rightHalf = MergeSort(rightHalf);

            return Merge(leftHalf, rightHalf);
        }
        static int[] Merge(int[] left, int[] right)
        {
            int[] Merged = new int[left.Length + right.Length];
            int leftIndexIncrease = 0;  // the working index of the left array, it increases by 1 when an element from the left goes to Merged
            int rightIndexIncrease = 0; // the working index of the right array, it increases by 1 when an element from the right goes to Merged

            for (int i = 0; i < Merged.Length; i++)
            {
                if (rightIndexIncrease == right.Length ||
                    leftIndexIncrease < left.Length && left[leftIndexIncrease] <= right[rightIndexIncrease]
                    )
                {
                    Merged[i] = left[leftIndexIncrease];
                    leftIndexIncrease++;
                }
                else if (leftIndexIncrease == left.Length ||
                    rightIndexIncrease < right.Length && right[rightIndexIncrease] <= left[leftIndexIncrease])
                {
                    Merged[i] = right[rightIndexIncrease];
                    rightIndexIncrease++;
                }
            }

            return Merged;
        }
    }
}
