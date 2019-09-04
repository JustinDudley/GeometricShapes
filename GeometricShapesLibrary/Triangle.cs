using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesLibrary {
    public class Triangle : Quadrilateral {


        // CONSTRUCTOR
        //public Triangle(int side1, int side2, int side3) : base(side1, side2, side3, 0) {  // fourth parameter is ZERO  (0)
        public Triangle(int side1, int side2, int height) : base(side1, side2, height, 0) {  // fourth parameter is ZERO  (0)
            // we changed one parametrer to height, to help us to write a separate method for area.
            // we could have made one of them "base", but base is a keyword already
            // I guess we're not going to make this method, but we could if we wanted to.  
            //Note the doubling of "height" in line 11.  Must mean something.
            //




            // triangle has 3 sides, quad has 4.  parallegram has 2.  But quad requires 4 numbers.  How to adapt to Triangle?
            // perimeter of trianlgle:  Add 3 sides.  So:  If we make one side of Quadrilateral zero, that will work.  
            // this should always be okay.  Can downgrade and be okay.  

        }


        // Sticky wicket:  How to compute area of triangle?  quad.  doesn't have this ??  So, do we need to write our own method for
        // the Triangle?  How shall we make an assumption , which one is the base?  
        // We could change the constructor of the triange . Put "base " into one of the sides parameters  



        //make public, so it's accessible from the PRogram class











    }
}
