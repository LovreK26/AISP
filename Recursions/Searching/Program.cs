using System.Net.WebSockets;

namespace Searching
{
    internal class Program
    {

        public static int SequentialSearch(int[] array, int value)
        { 
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] array, int value) 
        {
            int min = 0;
            int max = array.Length - 1;

            while(min<=max)
            {
                int mid = min + (max - min)/2;
                if (array[mid] == value)
                    return mid;
                else if (value < array[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return -1;
        }

        public static int BinarySearch(int[] array, int value, int index_min, int index_max)
        {
            if (index_min > index_max)
                return -1;
            
            int i = index_min+(index_max-index_min)/2;

            if (value == array[i])
                return i;

            else if (value < array[i])
                return BinarySearch(array, value, index_min, i-1);

            else
                return BinarySearch(array, value, i+1, index_max);
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int index = SequentialSearch(array, 6);
            Console.WriteLine("Sequential search - index: " + index);
            
            index = BinarySearch(array, 6);
            Console.WriteLine("Binary search iterative - index: " + index);

            index = BinarySearch(array, 6, 1, 6);
            Console.WriteLine("Binary search with recursion - index: " + index);
        }
    }
}
