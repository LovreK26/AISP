using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparables

{
    public class Student : IComparable
    {
        private string name;
        private double grade;

        public Student(string name, double grade) { this.name = name; this.grade = grade; }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            else if (obj is Student otherStudent)
            {
                return this.grade.CompareTo(otherStudent.grade);
            }
            else
            {
                throw new ArgumentException("Object is not a student");
            }
        }

        public override string? ToString()
        {
            return "Student name: " + name + " and student grade: " + grade;
        }
    }
}