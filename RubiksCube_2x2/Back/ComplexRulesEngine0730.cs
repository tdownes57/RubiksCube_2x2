using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.Back
{
    static class ComplexRulesEngine0730
    {
        //
        // This static class implements moves by the Bottom-Right piece, in the 4:30 pm position. 
        //
        public static RubikPieceCorner this_piece_startsAt_730;
        public static ComplexPieceMove this_complex_move;

        public static void ReorientPiece_Complex_From730(EnumAll12Faces par_enum)
        {
            //
            // Added 11/15/2020 thomas downes
            //
            //throw new NotImplementedException();
            EnumFaceNum start_whichIsFront = this_piece.WhichFaceIsFront;
            EnumFaceNum start_whichIsNorth = this_piece.WhichFaceIsN_of_front;
            EnumFaceNum start_whichIsEast = this_piece.WhichFaceIsE_of_front;
            EnumFaceNum start_whichIsSouth = this_piece.WhichFaceIsS_of_front;
            EnumFaceNum start_whichIsWest = this_piece.WhichFaceIsW_of_front;
            //Added 11/15/2020 thomas downes
            EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

            throw new NotImplementedException();

        }


    }
}
