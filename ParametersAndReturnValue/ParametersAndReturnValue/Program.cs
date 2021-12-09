using System;

namespace ParametersAndReturnValue
{
    class MethodsDemo
    {
        public void SayHiGeargi() //does not accept value
        {
            SayHi("Gosho");
        }
        public void SayHiPeter() //does not accept value
        {
            SayHi("Pesho");
        }
        private void SayHi(string aName) //accepts a string parameter and does not return a value
        {
            if(aName == null || aName == "")
            {
                return; //to return value and to terminate the method, which does not return a value (SayHi(aName))
            }
            Console.WriteLine("Hello, {1}", aName);
        }
        public int Multiply(int x, int y) //takes two int parameters and returns an int value
        {
            return x * y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
