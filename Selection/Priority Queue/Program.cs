using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap(10);

            try
            {
                for (int i = 0; i < 11; i++)
                    heap.Insert(i);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            Console.WriteLine("\nHeap after insertion:");
            heap.Display();

            Console.WriteLine("\nRetrieving values from the heap:");
            try
            {
                while (true)
                {
                    int priority = heap.Retrieve();
                    Console.WriteLine($"Retrieved: {priority}");
                    heap.Display();
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
