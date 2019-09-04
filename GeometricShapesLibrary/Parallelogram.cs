using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesLibrary {
    public class Parallelogram : Quadrilateral {    // made purblic, on purpose   // and add Quadrilateral, inheritance.  Colon syntax

        public int Area() {
            //don't need to pass anything in.  All the data we need is part of the class
            //could use side1 and side4 too, if wanted ??  because it's a paraplllegoram,  some isid sides are equal
            return Side1 * Side2;
        }

        public Parallelogram(int side1, int side2) : base(side1, side2, side1, side2) {    // always should call the constructor from the bass class

            //we don't need to do anything inside this constructor.  It's just here to load stuff up ??

            // we already have a perimeter metehod, from Quadrilateral.  It's available to Pararllelgram
            // we'll check that out when we do our testing

            //now we'll add a method that calculates the area of the puarallegalraom (see above)



            //how pass 4 hwen only need 2?  (Or vise versa?))
            // only need 2, since opp. sides are equal

            //we want to inherit the Quadrilateral class.  Use   :  colonn
        }

    }
}


//base class; B     A : B      always want to execute the constructor in the base class
