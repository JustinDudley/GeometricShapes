using System;
using GeometricShapesLibrary;

namespace GeometricShapesConsole {
    class Program {


        void Run() {   //instance method, not static.  We want main method to call run
            var quad1 = new Quadrilateral(2, 3, 4, 5);
            Console.WriteLine($"quad1: perimeter is {quad1.Perimeter()}");

            var pgram1 = new Parallelogram(6, 7); //create instance of parallelogram
            Console.WriteLine($"pgram1: perimeter is {pgram1.Perimeter()} and area is {pgram1.Area()}"); //calling perimeter, because it's inherited.

            var sqr1 = new Square(10);
            Console.WriteLine($"sqr1: perimeter is {sqr1.Perimeter()} and area is {sqr1.Area()}"); //calling perimeter, because it's inherited.


            var tri1 = new Triangle(2, 3, 4);
            Console.WriteLine($"tri1: perimeter is {tri1.Perimeter()}");
            // note tri-one   tri1   not "trill.    not el .  The number 1

        }


        static void Main(string[] args) {

            var pgm = new Program(); // creating instance of my program class
            pgm.Run();


            // using inheritance to leverage code already written
            // "Derived" class (the class that inherits)
            // vs. base class.
            // a class can be BOTH base and derived


            // i need to figure out the diff. between all the windows that keep popping up in VS.  Look at their titles.  Take time
            // to read.  


            //Q:  COULD you do all this in one class?  Yes, but there'd be a lot of complexity.  The parallelogram is simple, 
            // has only two sides, so we don't want too much sides.  
            // Justin sees a parallelorgram class, he knows how it should work.  
            // It's just a matter of organizing stuff so it's easy to understand.
            // we're modelling the world.
            // Other       creating a class library . We're creating a class library
            // What makes a library different?  If we put all classes in a console app, and everyone wanted to put gem    A library is designed to be created
            // so it can be shared.  The commonality:  All have geom shapes.  Everyone can use that same library .   Phil creates phone app, Tricia, creates webpage,
            // Alex creating his own library, using our library.  Libarries are not stand-alone.  They are meant to be used by something else.   Vs. Console app
            // is a standalone thing.    Runnable program might be diff on Linux, max, Windows.  But the library program can be used anywher.

            //  ??  Console program is the one being executed.  ???
            // 
            // I want a console app.  Console app.  Only works with the program.  A console app.  It's not a webpage, not a phone app.  It's a console app.  OH!  When
            // we first created the project, we clicked "console app", right/  ?   It's the simplest type we can interestact with.  
            // Greg has built far more libraries than applications taht have actually run.  
            // mid-tier, then eventually:  Architecxt.  Architects are tasked with making everyone else more productive.  They make libraries a lot.
            // 
            // a library would be on the... server?  I missed that.  
            // Class hierarchy, libraries:  This is important to understand . JD should google it on my own.  
            // 
            // The console class inherits from the Object class, per MS documentation
            /*properties:  ConsoleColor
             * Object just a few methods.  Lie  like 
             * I need to start my cube app.  I am struggling, this won't make sense until I make it my own.  Like I did with python and the cube,
             * like I did with java and Hamilton.  I need to put this all together into something I understand
             * 
             * 
             * object --> 
             * 
             *  !!!  Q.: can you inherit from console ? Greg says no, he doesn't think you can inherit from the Console class   !!!
             -So, you would HAVE to use a library?

            Some methods of a class are inherited.  Not in their source, but you can still use them.  Might be from base class, or base class's base class.
    */

        }
    }
}