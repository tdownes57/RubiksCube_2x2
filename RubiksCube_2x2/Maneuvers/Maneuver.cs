using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.Maneuvers
{
    public class Maneuver
    {
        //
        // Added 1/13/2021 thomas downes
        //
        public ComplexPieceMove frontside_move1_from130 = new ComplexPieceMove();
        public ComplexPieceMove frontside_move2_from430 = new ComplexPieceMove();
        public ComplexPieceMove frontside_move3_from730 = new ComplexPieceMove();
        public ComplexPieceMove frontside_move4_from1030 = new ComplexPieceMove();

        public ComplexPieceMove backside_move1_from130 = new ComplexPieceMove();
        public ComplexPieceMove backside_move2_from430 = new ComplexPieceMove();
        public ComplexPieceMove backside_move3_from730 = new ComplexPieceMove();
        public ComplexPieceMove backside_move4_from1030 = new ComplexPieceMove();
        public ComplexPieceMove backside_move5_Clockwise90 = new ComplexPieceMove();   // Added 1/15/2021 thomas downes

        internal void Execute_Backside(Back.ClassBackside par_backside)
        {
            //
            // Added 1/15/2021  
            //
            Execute_OneSide(par_backside);

        }


        internal void Execute_OneSide(RubiksCubeOneSide par_oneSide)
        {
            //
            // Added 1/15/2021  
            //
            // First, set the clock position of the piece.   
            //    ----11/18/2020 thomas downes
            //
            ComplexPieceMove move1_from130 = backside_move1_from130;
            ComplexPieceMove move2_from430 = backside_move2_from430;
            ComplexPieceMove move3_from730 = backside_move3_from730;
            ComplexPieceMove move4_from1030 = backside_move4_from1030;
            ComplexPieceMove move5_Clockwise90 = backside_move5_Clockwise90;

            RubiksPieceCorner piece_starting_at_130 = par_oneSide.GetPieceAtPosition(FrontClockFace.one_thirty);
            RubiksPieceCorner piece_starting_at_430 = par_oneSide.GetPieceAtPosition(FrontClockFace.four_thirty);
            RubiksPieceCorner piece_starting_at_730 = par_oneSide.GetPieceAtPosition(FrontClockFace.seven_thirty);
            RubiksPieceCorner piece_starting_at_1030 = par_oneSide.GetPieceAtPosition(FrontClockFace.ten_thirty);

            const bool c_boolOnlySetClockPosition = true;
            piece_starting_at_130.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_430.ReorientPiece_Complex(move2_from430.StartingPoint, move2_from430.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_730.ReorientPiece_Complex(move3_from730.StartingPoint, move3_from730.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_1030.ReorientPiece_Complex(move4_from1030.StartingPoint, move4_from1030.EndingPoint, c_boolOnlySetClockPosition);

            //
            // Use the static class, ComplexRulesEngine.  
            //
            // Move #1 of 5. 
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            ComplexRulesEngine0130.this_piece_startsAt_130 = piece_starting_at_130;
            ComplexRulesEngine0130.this_complex_move = move1_from130;
            ComplexRulesEngine0130.FrontFace_130_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #2 of 5. 
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            ComplexRulesEngine0430.this_piece_startsAt_430 = piece_starting_at_430;
            ComplexRulesEngine0430.this_complex_move = move2_from430;
            ComplexRulesEngine0430.FrontFace_430_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #3 of 5. 
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            ComplexRulesEngine0730.this_piece_startsAt_730 = piece_starting_at_730;
            ComplexRulesEngine0730.this_complex_move = move3_from730;
            ComplexRulesEngine0730.FrontFace_730_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #4 of 5. 
            //ComplexRulesEngine.FrontFace_1030_ReorientTo(move1_from130.StartingPoint, move1_from130.EndingPoint);
            ComplexRulesEngine1030.this_piece_startsAt_1030 = piece_starting_at_1030;
            ComplexRulesEngine1030.this_complex_move = move4_from1030;
            ComplexRulesEngine1030.FrontFace_1030_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            //
            // Move #5 of 5.    ----11/18/2020 thomas d. 
            //
            if (move5_Clockwise90.ClockwiseRevolution90_Deprecated)
            {
                // Added 11/18/2020 td 
                piece_starting_at_130.Revolve_Clockwise90();
                piece_starting_at_430.Revolve_Clockwise90();
                piece_starting_at_730.Revolve_Clockwise90();
                piece_starting_at_1030.Revolve_Clockwise90();

            }

            //
            // Debugging!!!!!
            //
            // As a check, let's count the number of side faces with valid colors. 
            //
            //
            int intCountValidSidefaces = 0;
            //Check the enumerated value.
            Func<EnumFaceNum, bool> isValidFace = enumFN =>
               (enumFN == EnumFaceNum.Face1 || enumFN == EnumFaceNum.Face2 || enumFN == EnumFaceNum.Face3);

            if (isValidFace(piece_starting_at_1030.WhichFaceIsN_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_1030.WhichFaceIsE_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_1030.WhichFaceIsS_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_1030.WhichFaceIsW_of_front)) intCountValidSidefaces++;

            if (isValidFace(piece_starting_at_130.WhichFaceIsN_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_130.WhichFaceIsE_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_130.WhichFaceIsS_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_130.WhichFaceIsW_of_front)) intCountValidSidefaces++;

            if (isValidFace(piece_starting_at_430.WhichFaceIsN_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_430.WhichFaceIsE_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_430.WhichFaceIsS_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_430.WhichFaceIsW_of_front)) intCountValidSidefaces++;

            if (isValidFace(piece_starting_at_730.WhichFaceIsN_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_730.WhichFaceIsE_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_730.WhichFaceIsS_of_front)) intCountValidSidefaces++;
            if (isValidFace(piece_starting_at_730.WhichFaceIsW_of_front)) intCountValidSidefaces++;

            //The count should be 8. 
            if (8 != intCountValidSidefaces) throw new NotImplementedException();

            //
            // More checks. 
            //
            if (piece_starting_at_1030.FrontClockFacePosition == FrontClockFace.ten_thirty)
            {
                if (piece_starting_at_1030.WhichFaceIsW_of_front == EnumFaceNum.NotApplicable_DifferentPiece)
                {
                    throw new NotImplementedException();
                }
            }


        }


    }
}
