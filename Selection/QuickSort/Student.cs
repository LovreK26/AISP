using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Student : IComparable<Student>
    {
        private string name;
        private double grade;
        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }
        public int CompareTo(Student other)
        {
            if (other == null)
                throw new ArgumentNullException("Students can't be null");
            return this.name.CompareTo(other.name);
        }
        public static bool CompareName(Student student1, Student student2)
        {
            return student1.CompareTo(student2) > 0;
        }
        public static bool CompareGrade(Student student1, Student student2)
        {
            if (student1 == null || student2 == null)
                throw new ArgumentNullException("Students can't be null");
            return student1.grade > student2.grade;
        }
        public override string? ToString()
        {
            return "Student name: " + name + " and student grade: " + grade;
        }
    }
}