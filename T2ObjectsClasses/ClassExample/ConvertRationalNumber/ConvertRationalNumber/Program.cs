using System;

namespace ConvertRationalNumber
{
    class TRacional //defines a class
    {
        private int mNumber, mDenom; //numerator and denominator field
        private bool mPositive; //sign number

        public TRacional (int N, int D)
        {
            if (D == 0)
            {
                Console.WriteLine("Error: Rational number with denominator 0!");
            }
            else
            {
                mNumber = Math.Abs(N);
                mDenom = Math.Abs(D);
                mPositive = (N * D) >= 0;
            }
        }
        public int Number
        {//return value of number
            get
            {
                return mNumber;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
