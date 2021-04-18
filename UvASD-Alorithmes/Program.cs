using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UvASD_Alorithmes;

namespace UvASD_Algorithmes
{
    class Program
    {
        static int[] CreateRandomDataArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-1000, 1000);
            }

            return array;
        }

        static void EnterArrayData(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element[{0}]: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static bool IsContains(int[]array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    return true;
                }
            }

            return false;
        }

        static int LinearSearch(int[]array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static void DisplayArrayData(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element[{0}] = {1}",i, array[i]);
            }
        }

        static bool IsChangeNeeded(int a, int b)
        {
            if (a > b)
                return true;
            return
                false;
        }

        static void Swap(ref int a, ref int b)
        {
            int swap = a;
            a = b;
            b = swap;
        }

        static void Main(string[] args)
        {
            int[] Array1 = new int[10];
            Array1 = CreateRandomDataArray(Array1);
            Console.WriteLine();
            DisplayArrayData(Array1);
            Console.WriteLine(IsContains(Array1, -13) ? "The array contains -13" : "The array doesn't contains -13");
            //BubbleSort.BubbleSort1(Array1);
            SelectionSort.SelectionSort1(Array1);
            Console.WriteLine(String.Join(" ", Array1));
            
            //int[] Array2 = new int[5];
            //Console.WriteLine();
            //EnterArrayData(Array2);            
            //DisplayArrayData(Array2);
            //Console.WriteLine(IsContains(Array2, -13) ? "The array contains -13" : "The array doesn't contains -13");

            int[] Array3 = new int[7] { -1, 9, 0, -13, 44, 6, 9 };
            Console.WriteLine();
            DisplayArrayData(Array3);
            Console.WriteLine(IsContains(Array3, -13) ? "The array contains -13" : "The array doesn't contains -13");
            //BubbleSort.BubbleSort2(Array3);
            SelectionSort.SelectionSort2(Array3);
            Console.WriteLine(String.Join(" ", Array3));

            Console.ReadKey();
        }
    }
}
