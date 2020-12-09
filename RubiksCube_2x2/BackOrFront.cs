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

        //
        //Added 12/08/2020 thomas downes
        //
        public abstract bool PiecesAreAdjacent(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2);
        public abstract bool PiecesAre_BottomSWSE(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2);
        public abstract bool PiecesAreAdjacent_Clockwise(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2);
        public abstract bool PiecesBelongToThisSide(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2);


        public bool PiecesAre_BottomSWSE_Base(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
        {
            //throw new NotImplementedException();
            //bool bPiecesAreRecognized = PiecesBelongToThisSide(par_piece1, par_piece2);
            //if (!bPiecesAreRecognized) throw new ArgumentOutOfRangeException();

            FrontClockFace position1 = par_piece1.FrontClockFacePosition;
            FrontClockFace position2 = par_piece2.FrontClockFacePosition;

            bool bPosition1_SW = (position1 == FrontClockFace.seven_thirty);
            bool bPosition1_SE = (position1 == FrontClockFace.four_thirty);
            bool bPosition2_SW = (position2 == FrontClockFace.seven_thirty);
            bool bPosition2_SE = (position2 == FrontClockFace.four_thirty);

            bool b_1SW_2SE = (bPosition1_SW && bPosition2_SE);
            bool b_1SE_2SW = (bPosition1_SE && bPosition2_SW);

            bool bOutputValue = (b_1SE_2SW || b_1SW_2SE);
            return bOutputValue;

        }

    }
}
