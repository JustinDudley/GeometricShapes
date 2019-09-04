using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesLibrary {
    public class Quadrilateral {  // we made this PUBLIC on purpose.  AND changed class name to Quadrilateral, from quad  .  Why??

        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; } // so we have four properties for lengths

        public int Perimeter() {        // this public method will be called by other classes
            return Side1 + Side2 + Side3 + Side4;
        }





        //now, make a constructor
        public Quadrilateral /* wnat to create all four sides*/ (int side1, int side2, int side3, int side4) {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;


        }
    }
}
// we want to prodcuce the perimeter