using System;

namespace ExampleProperties
{
    public class Person
    {
        private string mName;
        private DateTime mDateOfBirth;
        //Property Name of type string
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                if((value != null) && (value.Length > 0))
                {
                    mName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid name!");
                }
            }
        }
        //Property DateOfBirth of type DateTime
        public DateTime DateOfBirth
        {
            get 
            {
                return mDateOfBirth;
            }
            set
            {
                if((value.Year >= 1900) && (value.Year <= DateTime.Now.Year))
                {
                    mDateOfBirth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid date of birth");
                }
            }
        }
        //Read-only property Age of type int
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int yearsOld = now.Year - mDateOfBirth.Year;
                DateTime birthdayThisYear = new DateTime(now.Year, mDateOfBirth.Month, mDateOfBirth.Day, 
                    mDateOfBirth.Hour, mDateOfBirth.Minute, mDateOfBirth.Second);
                
                if(DateTime.Compare(now, birthdayThisYear) < 0)
                {
                    yearsOld--;
                }
                return yearsOld;
            }
        }
    }
    //Property usage example
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ivan Ivanov";
            person.DateOfBirth = new DateTime(1980, 6, 14);

            Console.WriteLine("{0} is born on {1:dd.MM.yyyy}.", person.Name, person.DateOfBirth);
            Console.WriteLine("{0} is {1} years old.", person.Name, person.Age);
        }
    }
}
