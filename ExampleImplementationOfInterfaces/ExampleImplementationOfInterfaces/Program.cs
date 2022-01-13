using System;

namespace ExampleImplementationOfInterfaces
{
    public class IShape
    {
        private int mX, mY, mSize;
        public Square(int aX, int aY, int aSize)
        {
            mX = aX;
            mY = aY;
            mSize = aSize;
        }
        public void SetPosition(int aX, int aY) // From IShape 
        {
            mX = aX;
            mY = aY;
        }
        public double CalculateSurface() // Derived from IShape 
        {
            return mSize * mSize;
        }
    }
    public struct Rectangle : IShape, IMovable, IResizable
    {
        private int mX, mY, mWidth, mHeight;
        public Rectangle(int aX, int aY, int aWidth, int aHeight)
        {
            mX = aX;
            mY = aY;
            mWidth = aWidth;
            mHeight = aHeight;
        }
        public void SetPosition(int aX, int aY) // From IShape 
        {
            mX = aX;
            mY = aY;
        }
        public double CalculateSurface() // Derived from IShape 
        {
            return mWidth * mHeight;
        }
        public void Move(int aDeltaX, int aDeltaY) // From IMovable
        {
            mX += aDeltaX;
            mY += aDeltaY;
        }
        public void Resize(int aWeight) // Derived from IResizable
        {
            mWidth = mWidth * aWeight;
            mHeight = mHeight * aWeight;
        }
        public void Resize(int aWeightX, int aWeightY) // IResizable
        {
            mWidth = mWidth * aWeightX;
            mHeight = mHeight * aWeightY;
        }
        public void ResizeByX(int aWeightX) // From IResizable
        {
            mWidth = mWidth * aWeightX;
        }
        public void ResizeByY(int aWeightY) // From IResizable
        {
            mHeight = mHeight * aWeightY;
        }
    }
    public class Circle : IPerimeterShape
    {
        private int mX, mY, mRadius;
        public Circle(int aX, int aY, int aRadius)
        {
            mX = aX;
            mY = aY;
            mRadius = aRadius;
        }
        public void SetPosition(int aX, int aY) // From IShape
        {
            mX = aX;
            mY = aY;
        }
        public double CalculateSurface() // From IShape
        {
            return Math.PI * mRadius * mRadius;
        }
        public double CalculatePerimeter() // From IPerimeterShape
        {
            return 2 * Math.PI * mRadius;
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
