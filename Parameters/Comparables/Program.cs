namespace Comparables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student ("Ivo", 4.1),
                new Student ("Ana", 4.9),
                new Student ("Iva", 4.3),
                new Student ("Bob", 4.5),
                new Student ("Joe", 4.7)
                };

            Console.WriteLine("Students before bubble sort:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }

            Bubble.Sort(students);
            Console.WriteLine("\nStudents after bubble sort:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }
    }
}