using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student[] students = {
                new Student("Ivo", 4.1),
                new Student("Ana", 4.9),
                new Student("Iva", 4.3),
                new Student("Bob", 4.5),
                new Student("Joe", 4.7),
                new Student("Tom", 4.4),
                new Student("Iko", 4.6),
            };

            Console.WriteLine("Original array of students:");
            DisplayArray(students);

            Console.WriteLine("\nPartitioned array of students by name:");
            Quick.Partition(students, 0, students.Length - 1, (a, b) =>
            {
                Student student1 = (Student)a;
                Student student2 = (Student)b;
                return student1.CompareTo(student2) < 0;
            });
            DisplayArray(students);

            Console.WriteLine("\nSorted array of students by name:");
            Quick.Sort(students, 0, students.Length - 1, (a, b) =>
            {
                Student student1 = (Student)a;
                Student student2 = (Student)b;
                return student1.CompareTo(student2) < 0;
            });
            DisplayArray(students);

            Console.WriteLine("\nSorted array of students by grade:");
            Quick.Sort(students, 0, students.Length - 1, (a, b) =>
            {
                Student student1 = (Student)a;
                Student student2 = (Student)b;
                return Student.CompareGrade(student1, student2);
            });
            DisplayArray(students);
        }
        public static void DisplayArray(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
