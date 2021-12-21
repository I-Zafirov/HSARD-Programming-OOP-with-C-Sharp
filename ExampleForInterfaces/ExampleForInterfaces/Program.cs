using System;

namespace ExampleForInterfaces
{
    interface IMovable
    {
        void Move(int aDeltaX, int aDeltaY);
    }
    interface IShape
    {
        void SetPosition(int aX, int aY);
        double CalculateSurface();
    }
    interface IPerimeterShape:IShape
    {
        double CalculatePerimeter();
    }
    interface IResizable
    {
        void Resize(int aWeight);
        void Resize(int aWeight, int aWeightY);
        void ResizeByX(int aWeightX);
        void ResizeByY(int aWeightY);
    }
    interface IDrawableShape : IShape, IResizable, IMovable
    {
        void Delete();
        Color Color
        {
            get;
            set;
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
