using System;

namespace ClassExample
{
    class Student
    {
        //Private member declarations
        private string mFirstName;
        private string mLastName;
        private string mStudentld;
        //Constant
        private const double PI = 3.1415926535897932384626433;
        //Constructor
        public Student(string aStudentld)
        {
            mStudentld = aStudentld;
        }
        //Method
        public string StoreExamResult(string aSubject, double aGrade)
        {
            //...
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //...
        }
    }
}
