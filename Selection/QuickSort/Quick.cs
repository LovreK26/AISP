using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuickSort
{
    public delegate bool Comparison(object a, object b);
    public class Quick
    {
        public static void Sort(object[] array, int left, int right, Comparison cmp)
        {
            if (left >= right) return;
            int last = Partition(array, left, right, cmp);
            Sort(array, left, last - 1, cmp);
            Sort(array, last + 1, right, cmp);
        }
        public static int Partition(object[] array, int left, int right, Comparison cmp)
        {
            object pivot = array[left];
            int i = left + 1;  
            int j = right;

            while (i <= j)
            {
                while (i <= right && cmp(array[i], pivot)) i++;

                while (j >= left && cmp(pivot, array[j])) j--;

                if (i < j)
                {
                    Swap(array, i, j);
                    i++;
                    j--;
                }
            }

            Swap(array, left, j);
            return j;
        }
        static void Swap(object[] array, int first, int second)
        {
            object temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}