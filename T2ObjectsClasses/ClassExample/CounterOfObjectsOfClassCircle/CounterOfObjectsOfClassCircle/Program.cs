using System;

namespace CounterOfObjectsOfClassCircle
{
    class Program
    {
        private static int mNumberOfCircles = 0; //static field
        public static int NumberOfCircles //static property
        {
            get
            {
                return mNumberOfCircles;
            }
            set
            {
                mNumberOfCircles = value;
            }
        }
        public Circle(float R)
        {
            mName = "Circle";
            mRadius = R;
            NumberOfCircles++;
        }
        static void Main(string[] args)
        {
            Circle GeoObj;
            GeoObj = new Circle(3);
            Console.WriteLine("Area of figure N {2}{1} is {0:F}", GeoObj.Area(), GeoObj.mName, mNumberOfCircles);
            GeoObj = new Circle(4);
            Console.WriteLine("Area of figure N {2}{1} is {0:F}", GeoObj.Area(), GeoObj.mName, mNumberOfCircles);
        }
    }
}
