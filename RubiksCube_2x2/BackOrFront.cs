using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/17/2020 thomas downes

namespace RubiksCube_2x2
{
    abstract class BackOrFront
    {
        //
        // Added 11/12/2020 Thomas Downes 
        //
        public abstract void Simple_Clockwise90();
        public abstract void Simple_Counterwise90();


        //Added 11/13/2020 thomas downes
        public abstract bool SideIsASolidColor();
        public abstract void ComplexRevolution();   //Renamed from "ComplexRotation". 


        //Added 11/14/2020 thomas downes
        public abstract void LoadInitialPositions();

        //
        //Added 11/17/2020 thomas downes
        //
        public abstract RubikPieceCorner WhichPieceIsClicked(Point par_point);
        public abstract RubikPieceCorner WhichPieceHasMouseHover(Point par_point);


    }
}
