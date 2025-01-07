using System;

namespace SingleList;

public class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue("Ivo");
        queue.Enqueue("Ana");
        queue.Enqueue("Bob");
        queue.Enqueue("Iva");
        queue.Enqueue("Leo");

        Console.WriteLine("Initial queue contents:");
        queue.Display();

        try
        {
            while (!queue.IsEmpty())
            {
                Console.WriteLine($"Dequeued: {queue.Dequeue()}");
                Console.WriteLine("Updated queue contents:");
                queue.Display();
            }
            Console.WriteLine("Attempting to dequeue from an empty queue...");
            queue.Dequeue();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}