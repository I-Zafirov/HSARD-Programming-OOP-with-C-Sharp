using System;

namespace DefiningCircleClassCalculationAreaAndPerimeter
{
    class Circle 
    {
        public readonly string mName;
        private float mRadius;
        private const double PI = 3.1415926535897932384626433;
        
        public Circle(float R)
        {
            mName = "Circle";
            mRadius = R;
        }
        public double Lice()
        {
            return PI * mRadius * mRadius;
        }
        public double Perimeter()
        {
            return 2 * PI * mRadius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle GeoObj;
            GeoObj = new Circle(3);
            Console.WriteLine("Area of figure {0} e {1:F}", GeoObj.mName, GeoObj.Lice());
        }
    }
}
