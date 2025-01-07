using System;

public class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();

        stack.Push("Kim");
        stack.Push("Iva");
        stack.Push("Bob");
        stack.Push("Ana");
        stack.Push("Ivo");

        Console.WriteLine("Initial stack contents:");
        stack.Display();

        try
        {
            while (!stack.IsEmpty())
            {
                Console.WriteLine($"Popped: {stack.Pop()}");
                Console.WriteLine("Updated stack contents:");
                stack.Display();
            }

            Console.WriteLine("Attempting to pop from an empty stack...");
            stack.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}