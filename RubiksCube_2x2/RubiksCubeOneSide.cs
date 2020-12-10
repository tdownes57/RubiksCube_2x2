using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/17/2020 thomas downes

namespace RubiksCube_2x2
{
    abstract class RubiksCubeOneSide
    {
        // Renamed to "RubiksCubeOneSide" from "BackOrFront" on 12/89/2020 td
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


        public abstract RubikPieceCorner GetPiece(FrontClockFace par_enum);

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


        public void GodlikeSwitch_Base(RubikPieceCorner par_dragged, RubikPieceCorner par_replaced)
        {
            //
            // Added 11/17/2020 thomas downes
            //
            FrontClockFace clock_dragged = par_dragged.FrontClockFacePosition;
            FrontClockFace clock_replaced = par_replaced.FrontClockFacePosition;
            FrontClockFace tempClock = FrontClockFace.unassigned;
            FrontClockFace targetClock = FrontClockFace.unassigned;

            //
            // Position the dragged piece. 
            //
            targetClock = clock_replaced; // We will place the selected/dragged piece at the Replaced position.
            do
            {
                par_dragged.Revolve_Clockwise90();
                tempClock = par_dragged.FrontClockFacePosition;
            } while (tempClock != targetClock);

            //
            // Position the replaced piece. 
            //
            targetClock = clock_dragged; // We will place the selected/dragged piece at the Replaced position.
            do
            {
                par_replaced.Revolve_Clockwise90();
                tempClock = par_replaced.FrontClockFacePosition;
            } while (tempClock != targetClock);

        }


        public void ComplexRules_Perform(ComplexPieceMoves_Five par_rules)
        {
            //
            // Added 12/9/2020 thomas downes 
            //
            //
            //
            // Implementing the movements described above, as follows: 
            //
            RubikPieceCorner piece_starting_at_130 = GetPiece(FrontClockFace.one_thirty);
            RubikPieceCorner piece_starting_at_430 = GetPiece(FrontClockFace.four_thirty);
            RubikPieceCorner piece_starting_at_730 = GetPiece(FrontClockFace.seven_thirty);
            RubikPieceCorner piece_starting_at_1030 = GetPiece(FrontClockFace.ten_thirty);

            //First, set the clock position of the piece.   
            //    ----11/18/2020 thomas downes
            //
            const bool c_boolOnlySetClockPosition = true;
            piece_starting_at_130.ReorientPiece_Complex(par_rules.move1_from130.StartingPoint, par_rules.move1_from130.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_430.ReorientPiece_Complex(par_rules.move2_from430.StartingPoint, par_rules.move2_from430.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_730.ReorientPiece_Complex(par_rules.move3_from730.StartingPoint, par_rules.move3_from730.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_1030.ReorientPiece_Complex(par_rules.move4_from1030.StartingPoint, par_rules.move4_from1030.EndingPoint, c_boolOnlySetClockPosition);

            //
            // Use the static class, ComplexRulesEngine.  
            //
            // Move #1 of 5. 
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            Back.ComplexRulesEngine0130.this_piece_startsAt_130 = piece_starting_at_130;
            Back.ComplexRulesEngine0130.this_complex_move = par_rules.move1_from130;
            Back.ComplexRulesEngine0130.FrontFace_130_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #2 of 5. 
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            Back.ComplexRulesEngine0430.this_piece_startsAt_430 = piece_starting_at_430;
            Back.ComplexRulesEngine0430.this_complex_move = par_rules.move2_from430;
            Back.ComplexRulesEngine0430.FrontFace_430_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #3 of 5. 
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            Back.ComplexRulesEngine0730.this_piece_startsAt_730 = piece_starting_at_730;
            Back.ComplexRulesEngine0730.this_complex_move = par_rules.move3_from730;
            Back.ComplexRulesEngine0730.FrontFace_730_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #4 of 5. 
            //ComplexRulesEngine.FrontFace_1030_ReorientTo(move1_from130.StartingPoint, move1_from130.EndingPoint);
            Back.ComplexRulesEngine1030.this_piece_startsAt_1030 = piece_starting_at_1030;
            Back.ComplexRulesEngine1030.this_complex_move = par_rules.move4_from1030;
            Back.ComplexRulesEngine1030.FrontFace_1030_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #5 of 5. ----11/18/2020 thomas d. 
            if (par_rules.move5_Clockwise90)  //.ClockwiseRevolution90)
            {
                // Added 11/18/2020 td 
                piece_starting_at_130.Revolve_Clockwise90();
                piece_starting_at_430.Revolve_Clockwise90();
                piece_starting_at_730.Revolve_Clockwise90();
                piece_starting_at_1030.Revolve_Clockwise90();

            }

        }




    }
}
