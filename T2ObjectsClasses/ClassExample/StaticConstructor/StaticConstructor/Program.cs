using System;

namespace StaticConstructor
{
    class SqrtPrecalculated
    {
        public const int MAX_VALUE = 1000;
        private static int[] mSqrtValues; //static field
        //Static constructor
        static SqrtPrecalculated()
        {
            mSqrtValues = new int[MAX_VALUE + 1];
            for (int i = 0; i <= MAX_VALUE; i++)
                mSqrtValues[i] = (int)Math.Sqrt(i);
        }
        //Static method
        public static int GetSqrt(int aValue)
        {
            return mSqrtValues[aValue];
        }
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(GetSqrt(1000));
            }
        }
    }
}
