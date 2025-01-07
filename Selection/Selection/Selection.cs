using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    public class Selection
    {
        public static void Sort(int[] array, int startIndex)
        {
            if (startIndex >= array.Length - 1)
                return;
            int minIndex = startIndex;
            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
            }
            if (minIndex != startIndex)
            {
                int temp = array[startIndex];
                array[startIndex] = array[minIndex];
                array[minIndex] = temp;
            }
            Sort(array, startIndex + 1);
        }
    }
}