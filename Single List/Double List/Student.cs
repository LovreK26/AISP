
using System;

namespace DoubleList
{
    public class Student
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return $"Student Name: {name}, Grade: {grade:F2}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Student other = (Student)obj;

            return this.name == other.name && this.grade == other.grade;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, grade);
        }

        public static bool operator ==(Student a, Student b)
        {
            if ((object)a == null)
                if ((object)b == null) return true;
                else return false;
            return (a.Equals(b));
        }
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }
    }
}