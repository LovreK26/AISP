namespace Selection
{

    //1. ZADATAK


    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 8, 4, 11, 5, 7, 3, 1 };
            Console.WriteLine("Array before sorting:");
            for (int i = 0; i < array.Length; i++) { Console.WriteLine(array[i]); }
            Console.WriteLine("Array after sorting:");
            Selection.Sort(array, 0);
            for (int i = 0; i < array.Length; i++) { Console.WriteLine(array[i]); }
        }
    }
}