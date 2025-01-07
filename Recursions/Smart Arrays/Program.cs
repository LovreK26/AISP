using System;
using System.Collections;
using System.ComponentModel;

namespace Smart_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartArray smarty = new SmartArray(6);

            for (int i = 0; i < 8; i++)
            {
                smarty.Add(i);
            }

            Console.WriteLine("Contents of SmartArray after adding all the elements:");
            for (int i = 0; i < smarty.Length; i++)
            {
                Console.Write(smarty[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Contents of SmartArray using enumerator:");
            IEnumerator enumerator = smarty.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing elements from SmartArray:");
            while (smarty.Length > 0)
            {
                int valueToRemove = smarty[smarty.Length - 1];
                Console.WriteLine($"Removed: {valueToRemove}");
                smarty.Remove(valueToRemove);

                for (int j = 0; j < smarty.Length; j++)
                {
                    Console.Write(smarty[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
