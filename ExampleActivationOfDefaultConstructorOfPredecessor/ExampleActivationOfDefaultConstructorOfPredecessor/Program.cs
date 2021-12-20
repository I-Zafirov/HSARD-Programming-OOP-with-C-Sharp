using System;

namespace ExampleActivationOfDefaultConstructorOfPredecessor
{
    public class Name
    {
        public Name() { myName = 0; }
        //...
    }
    public class Contact:Name
    {
        public Contact() { myAddress = 0; }
        public Contact() : base() { myAddress = 0; }
        //...
    }
    class Program
    {
        static void Main(string[] args)
        {
            Contact Cont = new Contact(); //Activation default constructor.
            //...
        }
    }
}
