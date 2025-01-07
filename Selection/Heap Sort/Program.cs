using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 8, 3, 4, 2, 1, 7, 3, 5, 4, 5, 4, 8 };

            Console.WriteLine("Original array:");
            Display(array);

            Heap.Sort(array);

            Console.WriteLine("\nSorted array:");
            Display(array);
        }

        static void Display(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
