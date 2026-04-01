using System;

namespace SearchingAlgorithmes
{
    class Program
    {
        public static int LinearSearch(int[]array, int value, ref int steps)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
                else
                    steps++;
            }            
            return -1;
        }
        public static int BinarySearchRecursivly(int []array, int value)
        {
            return BinarySearchRecursivly(array, value, 0, array.Length - 1);
        }
        private static int BinarySearchRecursivly(int[]array, int value, int left, int right)
        {
            if (right > left)
            {
                int middle = (left + right) / 2;
                if (value == array[middle])
                    return middle;
                if (value < array[middle])
                    return BinarySearchRecursivly(array, value, 0, middle - 1);
                else
                    return BinarySearchRecursivly(array, value, middle + 1, array.Length - 1);
        
            }
            return -1;            
        }
        public static int BinarySearchItteratively(int[]array, int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (value == array[middle])
                    return middle;
                if (value < array[middle])
                    right = middle + 1;
                if (value > array[middle])
                    left = middle - 1;                    
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = { -32, -22, -18, -11, -5, -2, 1, 3, 7, 13, 17, 21, 23, 34, 45, 66, 78 };
            Console.WriteLine("Linear search:");
            Console.WriteLine("Searching 66");
            int steps = 0;
            Console.WriteLine($"Found in {steps} steps at index [{LinearSearch(array, 66, ref steps)}]");
            Console.WriteLine("\nBinary Search Recursivly:");
            Console.WriteLine($"Found in at index [{BinarySearchRecursivly(array, 66)}]");
            Console.WriteLine("\nBinary Searcg Itteratively:");
            Console.WriteLine($"Found in at index [{BinarySearchItteratively(array, 66)}]");


        }
    }
}
