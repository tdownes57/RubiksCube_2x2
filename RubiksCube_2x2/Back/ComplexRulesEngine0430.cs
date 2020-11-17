using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.Back
{
    static class ComplexRulesEngine0430
    {
        //
        // This static class implements moves by the Bottom-Right piece, in the 4:30 pm position. 
        //
        public static RubikPieceCorner this_piece_startsAt_430;
        public static ComplexPieceMove this_complex_move;

        public static void FrontFace_430_ReorientTo()   // (EnumAll12Faces par_enum)
        {
            //---- ReorientPiece_Complex_From430
            //
            // Added 11/15/2020 thomas downes
            //
            //throw new NotImplementedException();
            EnumFaceNum start_whichIsFront = this_piece_startsAt_430.WhichFaceIsFront;
            //---n/a---EnumFaceNum start_whichIsNorth = this_piece_startsAt_430.WhichFaceIsN_of_front;
            EnumFaceNum start_whichIsEast = this_piece_startsAt_430.WhichFaceIsE_of_front;
            EnumFaceNum start_whichIsSouth = this_piece_startsAt_430.WhichFaceIsS_of_front;
            //---n/a---EnumFaceNum start_whichIsWest = this_piece_startsAt_430.WhichFaceIsW_of_front;

            //Added 11/15/2020 thomas downes
            //---n/a---EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

            //Added 11/15/2020 thomas downes
            EnumAll12Faces the_endpoint = this_complex_move.EndingPoint;

            switch (the_endpoint)
            {
                //
                // The bottom-right piece (4:30) is now moved to the upper-right corner (130). 
                //
                case EnumAll12Faces.F0130:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_430.WhichFaceIsN_of_front = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = start_whichIsSouth;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_NNE:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsSouth;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = start_whichIsFront;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_ENE:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = start_whichIsSouth;  // No change.
                    this_piece_startsAt_430.WhichFaceIsE_of_front = start_whichIsFront;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The bottom-right piece (4:30) is now moved to the bottom-right corner.  
                //
                case EnumAll12Faces.F0430:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_430.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = start_whichIsEast;  // i.e. !!! no change !!!
                    this_piece_startsAt_430.WhichFaceIsS_of_front = start_whichIsSouth;  // i.e. !!! no change !!!
                    this_piece_startsAt_430.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_ESE:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsSouth;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = start_whichIsFront;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_SSE:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = start_whichIsSouth;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = start_whichIsFront;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The bottom-right (4:30) piece is now in the bottom-left corner (F0730, etc.).  
                //
                case EnumAll12Faces.F0730:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_430.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = start_whichIsSouth;
                    break;

                case EnumAll12Faces._730_SSW:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsSouth;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = start_whichIsFront;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = start_whichIsEast;
                    break;

                case EnumAll12Faces._730_WSW:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = start_whichIsSouth;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = start_whichIsEast;
                    break;


                //
                // The bottom-right (4:30) piece is now in the top-left corner.  
                //
                case EnumAll12Faces.F1030:  
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsFront;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = start_whichIsSouth;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = start_whichIsEast;
                    break;

                case EnumAll12Faces._1030_WNW:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsSouth;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = start_whichIsFront;
                    break;

                case EnumAll12Faces._1030_NNW:
                    this_piece_startsAt_430.WhichFaceIsFront = start_whichIsEast;
                    this_piece_startsAt_430.WhichFaceIsN_of_front = start_whichIsFront;
                    this_piece_startsAt_430.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_430.WhichFaceIsW_of_front = start_whichIsSouth;
                    break;


            }

        }




    }
}
