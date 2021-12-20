using System;

namespace ExampleOfInheritance
{
    class Student
    {
        private string mName;
        private int mStudentld;
        private string mPosition = "Student";

        public Student(string aName, int aStudentld)
            //...
        public Student(string aName):this(aName, -1)
            //...
        public void PrintName()
        {
            Console.WriteLine("Student name: {0}", mName);
        }
    }
    public sealed class Kiro: Student
    {
        public Kiro():base("Bai Kiro", 12345)
        {
        }
        public void Oversleep()
        {
            //...
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student tosho = new Student("Tosho", 54321);
            Kiro kiro1 = new Kiro();
            Student kiro2 = new Kiro();
            //Kiro kiro3 = new Student("Bai Kiro", 12345); //invalid!
            tosho.PrintName();
            kiro1.PrintName();
            //kiro2.Oversleep();
            ((Kiro)kiro2).Oversleep();
        }
    }
}
