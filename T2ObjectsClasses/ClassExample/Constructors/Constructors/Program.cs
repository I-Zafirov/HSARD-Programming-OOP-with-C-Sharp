using System;

namespace Constructors
{
    class Student
    {
        private string mName;
        private int mStudentld;
        private string mPosition = "Student";
        public Student(string aName, int aStudentld)
        {
            mName = aName;
            mStudentld = aStudentld;
        }
        public Student(string aName) : this(aName, -1)
        {

        }

        public static void Main()
        {
            Student s = new Student("Kiro", 12345);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
