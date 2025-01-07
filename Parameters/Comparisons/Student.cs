using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    public class Student
    {
        public string name;
        public double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }
        public static bool compareName(object x, object y)
        {
            Student student1 = x as Student;
            Student student2 = y as Student;

            if (student1 == null || student2 == null)
            {
                throw new ArgumentNullException("Both students must be non-null to compare their names.");
            }
            return student1.name.CompareTo(student2.name) > 0;
        }
        public static bool compareGrade(object x, object y)
        {
            Student student1 = x as Student;
            Student student2 = y as Student;

            if (student1 == null || student2 == null)
            {
                throw new ArgumentNullException("Both students must be non-null to compare their names.");
            }
            return student1.grade > student2.grade;
        }
        public override string? ToString()
        {
            return "Student name: " + name + ", student grade:" + grade;
        }
    }
}