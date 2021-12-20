using System;

namespace ExampleNestedClasses
{
    public class Container
    {
        public class Nasted //If it is not public it will not be visible
                            //and accessible from the outside.
        {
            private Container parent;//To use the components of the outer class.
            public Nested() { }
            public Nested(Container parent)
            {
                this.parent = parent;
            }
        }
    }
    class Test
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an exemplar using its full name.
            Container.Nested nest = new Container.Nasted();
            //Wrong:
            //Nested nest = new Nested();
        }
    }
}
