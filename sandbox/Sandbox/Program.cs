using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        //This is the object
        //An object is collection of characterisitcs(variables) and behaviors(methods) needed to complete a task
        //Objects can be put into variables, lists, and other objects
        var Blind = new Blind();
        
        //This executes the behavior of the object.  The ".GetArea" is the behavior method of the object
        double blindArea = Blind.GetArea();

        Console.WriteLine(blindArea);
    }

    //Class
    //The blueprint to creating an object
    public class Blind
    {
        //Attributes
        //These are characteristics that an object needs to complete a task
        //Sometimes these can be called member variables
        //Member variables can have complex data types and be an object within themselves
        //It's standard practice to start the name of a member variable with a "_"
        public double _width;
        public double _height;
        public string _color;

        //Behaviors
        //The behavoiors that an object needs to do to complete a task
        public double GetArea()
        {
            return _width * _height;
        }
    }
}