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
        public static int BinarySearchRecursivly(int []array, int value, ref int steps)
        {
            return BinarySearchRecursivly(array, value, 0, array.Length - 1, ref steps);
        }
        private static int BinarySearchRecursivly(int[]array, int value, int left, int right, ref int steps)
        {
            if (right > left)
            {
                int middle = (left + right) / 2;
                if (value == array[middle])
                    return middle;
                if (value < array[middle])
                {
                    steps++;
                    return BinarySearchRecursivly(array, value, 0, middle - 1, ref  steps); 
                }
                else
                {
                    steps++;
                    return BinarySearchRecursivly(array, value, middle + 1, array.Length - 1, ref steps);
                }
                    
        
            }
            return -1;            
        }
        public static int BinarySearchItteratively(int[]array, int value, ref int steps)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (value == array[middle])
                    return middle;
                if (value < array[middle])
                {
                    right = middle - 1; 
                    steps++; 
                }
                if (value > array[middle])
                {
                    left = middle + 1;
                    steps++;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = { -32, -22, -18, -11, -5, -2, 1, 3, 7, 13, 17, 21, 23, 34, 45, 66, 78 };
            Console.WriteLine("Linear search:");
            Console.WriteLine("Searching 66");
            int steps = 0;
            int index = LinearSearch(array, 66, ref steps);
            Console.WriteLine($"Found in {steps} steps at index [{index}]");
            Console.WriteLine("\nBinary Search Recursivly:");
            steps = 0;
            index = BinarySearchRecursivly(array, 66, ref steps);
            Console.WriteLine($"Found in {steps} at index [{index}]");
            Console.WriteLine("\nBinary Searcg Itteratively:");
            steps = 0;
            index = BinarySearchItteratively(array, 66,ref steps);
            Console.WriteLine($"Found in in {steps} steps at index [{index}]");


        }
    }
}
