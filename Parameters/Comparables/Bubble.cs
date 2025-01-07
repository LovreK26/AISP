namespace Comparables

{
    public class Bubble
    {
        public static void Sort(IComparable[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) < 0)
                    {
                        IComparable temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                }
            }

        }
    }
}
