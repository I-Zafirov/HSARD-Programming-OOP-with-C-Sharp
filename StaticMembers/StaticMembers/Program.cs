using System;

namespace StaticMembers
{
    class Bulgaria
    {
        private static int mNumberOfCities = 267; //static field
        public static int NumberOfCities //static property
        {
            get
            {
                return mNumberOfCities;
            }
        }
        public static void AddCity(string aCityName) //static method
        {
            mNumberOfCities++;
            //...
        }

        //...
 

    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("In Bulgaria have {0} cities.", Bulgaria.NumberOfCities);
        }
    }

