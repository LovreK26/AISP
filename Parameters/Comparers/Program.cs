namespace Comparers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
                {
                new Student ("Ivo", 4.1),
                new Student ("Ana", 4.9),
                new Student ("Iva", 4.3),
                new Student ("Bob", 4.5),
                new Student ("Joe", 4.7)
                };

            Console.WriteLine("Students before bubble sort:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }

            StudentComparer comparer = new StudentComparer(StudentComparerType.Name);
            Bubble.Sort(students, comparer);

            Console.WriteLine("\nStudents after name bubble sort:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }



            comparer = new StudentComparer(StudentComparerType.Grade);
            Bubble.Sort(students, comparer);

            Console.WriteLine("\nStudents after grade bubble sort:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}