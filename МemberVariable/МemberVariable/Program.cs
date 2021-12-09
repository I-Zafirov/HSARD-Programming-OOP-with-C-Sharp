using System;

namespace МemberVariable
{
    class Student
    {
        private string mFirstName;
        private string mLastName;
        private string mStudentld;
        private int mCourse = 1;
        private string mSpeciality;
        private Course[] mCoursesTaken;

        //Avoid missing the visibility modifier
        string mRemarks = "(няма забележки)";
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
