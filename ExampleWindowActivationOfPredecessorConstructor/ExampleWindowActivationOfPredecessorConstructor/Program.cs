using System;

namespace ExampleWindowActivationOfPredecessorConstructor
{
    //Declaring class Window.
    public class Window
    {
        public Window(Rect rSize) {/*... */}
    }
    //Declaring class DialogBox, inheritor of class Window.
    public class DialogBox:Window
    {
        //Defines a constructor for DialogBox.
        //This constructor requires the predecessor constructor Windows.
        public DialogBox(Rect rSize):base(rSize)
        { /*...*/}
        //Exemplars creation and calling constructors.
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Calling constructors.
            DialogBox DB = new DialogBox(rS);
            //...
        }
    }
}
