using System;

namespace ReadOnlyFields
{
    class ReadOnlyDemo
    {
        private readonly int mSize;
        public ReadOnlyDemo(int aSize)
        {
            mSize = aSize; //cannot be further modified!
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
