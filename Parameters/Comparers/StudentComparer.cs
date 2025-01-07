using Comparers;
using System.Collections.Generic;

namespace Comparers
{

    public enum StudentComparerType { Name, Grade }
    public class StudentComparer : IComparer<Student>
    {

        private StudentComparerType criterion;

        public StudentComparer(StudentComparerType criterion) { this.criterion = criterion; }
        public int Compare(Student x, Student y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return criterion switch
            {
                StudentComparerType.Name => string.Compare(x.name, y.name, StringComparison.Ordinal),
                StudentComparerType.Grade => x.grade.CompareTo(y.grade),
                _ => 0
            };

        }
    }
}