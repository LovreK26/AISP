using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
    public class Student
    {
        public string name;
        public double grade;

        public Student(string name, double grade) { name = this.name; this.grade = grade; }

        public override string? ToString()
        {
            return "Student name: " + name + ", student grade: " + grade;
        }
    }
}