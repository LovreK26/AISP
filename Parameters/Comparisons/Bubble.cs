using System;

public class Bubble
{
    public delegate bool Comparison(object x, object y);

    public static void Sort(object[] array, Comparison compare)
    {
        if (array == null || compare == null)
        {
            throw new ArgumentNullException("Array and Comparison delegate must be non-null.");
        }

        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                if (compare(array[j], array[j + 1]))
                {
                    object temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
}