using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2
{
    static class Rules_FrontPieceRotation
    {
        //
        // What happens to the opposite side (the backside), when the 
        //    frontside's lower-righthand (S.E., or 4:30 pm) piece
        //    is manipulated to experience a rotation-in-place
        //    which will cause the 3 colors to partially "revolve" about 
        //    the S.E. front vertex a number of degrees < 360 
        //    (360 degrees / 3 colors = 120 degrees/color)?   The frontmost
        //    color will become a side-facing color, and one of the side 
        //    colors comes forward to become the front-facing color. 
        //
        //These rules describe what then happens to the --BACK-- side,
        //    which is opposite to the front side.
        //     -----12/4/2020  thomas downes
        //
        //
        // This class was renamed to Rules_FrontPieceRotation, 
        //    from the former name of "ComplexRules". 
        //
        public static ComplexPieceMove move1_from130; // = new ComplexPieceMove();
        public static ComplexPieceMove move2_from430;
        public static ComplexPieceMove move3_from730;
        public static ComplexPieceMove move4_from1030;
        public static ComplexPieceMove move5_clockwise90;

        public static void BuildComplexRotationRules_Nov2020()
        {
            //
            // Added 11/13/2020 thomas downes
            //
            //FrontClockFace temp = _pieceBOY.FrontClockFacePosition;
            //_pieceBOY.FrontClockFacePosition = _pieceBYR.FrontClockFacePosition;
            //_pieceBYR.FrontClockFacePosition = _pieceGRY.FrontClockFacePosition;
            //_pieceGRY.FrontClockFacePosition = _pieceGYO.FrontClockFacePosition;
            //_pieceGYO.FrontClockFacePosition = temp;

            //_pieceBOY.ReorientPiece(_pieceBYR.FrontClockFacePosition, Color.Orange);
            //_pieceBYR.ReorientPiece( _pieceGRY.FrontClockFacePosition, Color.Yellow);
            //_pieceGRY.ReorientPiece(_pieceGYO.FrontClockFacePosition, Color.Lime);
            //_pieceGYO.ReorientPiece(temp, Color.Yellow);

            //ComplexPieceMove move1_from130; // = new ComplexPieceMove();
            //ComplexPieceMove move2_from430;
            //ComplexPieceMove move3_from730;
            //ComplexPieceMove move4_from1030;

            move1_from130.StartingPoint = FrontClockFace.one_thirty;
            move1_from130.EndingPoint = EnumAll12Faces.F0430;

            move2_from430.StartingPoint = FrontClockFace.four_thirty;
            move2_from430.EndingPoint = EnumAll12Faces._730_SSW;

            move3_from730.StartingPoint = FrontClockFace.seven_thirty;
            move3_from730.EndingPoint = EnumAll12Faces._1030_NNW;

            move4_from1030.StartingPoint = FrontClockFace.ten_thirty;
            //move4.StartingPoint = FrontClockFace.ten_thirty;
            move4_from1030.EndingPoint = EnumAll12Faces._130_ENE;

            //Added 11/18/2020 thomas downes
            move5_clockwise90.ClockwiseRevolution90_Deprecated = true;

        }


    }
}
