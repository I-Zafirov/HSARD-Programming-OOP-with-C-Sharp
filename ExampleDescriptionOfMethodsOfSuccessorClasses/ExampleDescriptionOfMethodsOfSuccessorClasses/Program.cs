using System;

namespace ExampleDescriptionOfMethodsOfSuccessorClasses
{
    public class Name
    {
        public Name() { }
        ~Name() { }
        public void SetName(string n) { }
        public void Print()
        {
            Console.WriteLine(myName);
        }
        private string myName = "ime";
    }
    public class Contact: Name
    {
        public Contact() { }
        ~Contact() { }
        public void SetAddress(string c) { }
        public void Print()
        {
            base.Print();
            Console.WriteLine(myAddress);
        }
        private string myAddress = "adres";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Contact Cont = new Contact();
            Cont.Print();
        }
    }
}
