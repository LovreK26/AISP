namespace Comparisons
{

    //ZADATAK 5.
    public class Program
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
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("\nStudents after sorting by name:");
            Bubble.Sort(students, Student.compareName);
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("\nStudents after sorting by grade:");
            Bubble.Sort(students, Student.compareGrade);
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}