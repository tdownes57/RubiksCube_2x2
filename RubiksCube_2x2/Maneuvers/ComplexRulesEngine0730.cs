using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.Maneuvers  //---- .Back
{
    static class ComplexRulesEngine0730
    {
        //
        // This static class implements moves by the Bottom-Right piece, in the 4:30 pm position. 
        //
        public static RubiksPieceCorner this_piece_startsAt_730;
        public static ComplexPieceMove this_complex_move;

        public static void FrontFace_730_ReorientTo()  //  (EnumAll12Faces par_enum)
        {
            //---11/16 ---public static void ReorientPiece_Complex_From730(EnumAll12Faces par_enum)
            //
            // Added 11/15/2020 thomas downes
            //
            //throw new NotImplementedException();
            EnumFaceNum start_whichIsFront = this_piece_startsAt_730.WhichFaceIsFront;
            //---n/a---EnumFaceNum start_whichIsNorth = this_piece_startsAt_730.WhichFaceIsN_of_front;
            //---n/a---EnumFaceNum start_whichIsEast = this_piece_startsAt_730.WhichFaceIsE_of_front;
            EnumFaceNum start_whichIsSouth = this_piece_startsAt_730.WhichFaceIsS_of_front;
            EnumFaceNum start_whichIsWest = this_piece_startsAt_730.WhichFaceIsW_of_front;
            //Added 11/15/2020 thomas downes
            //---n/a---EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

            //throw new NotImplementedException();

            //Added 11/18/2020 thomas downes
            if (start_whichIsFront == EnumFaceNum.NotApplicable_DifferentPiece
                || start_whichIsSouth == EnumFaceNum.NotApplicable_DifferentPiece
                || start_whichIsWest == EnumFaceNum.NotApplicable_DifferentPiece) 
                throw new NotImplementedException();

            //Added 11/18/2020 thomas downes
            if (start_whichIsFront == EnumFaceNum.NotSpecified
                    || start_whichIsSouth == EnumFaceNum.NotSpecified
                    || start_whichIsWest == EnumFaceNum.NotSpecified)
                throw new NotImplementedException();

            //Added 11/15/2020 thomas downes
            EnumAll12Faces the_endpoint = this_complex_move.EndingPoint;

            switch (the_endpoint)
            {
                //
                // The bottom-left piece (7:30) is now moved to the upper-right corner (130). 
                //
                case EnumAll12Faces.F0130:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_730.WhichFaceIsN_of_front = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_NNE:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = start_whichIsFront;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_ENE:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = start_whichIsWest;  // No change.
                    this_piece_startsAt_730.WhichFaceIsE_of_front = start_whichIsFront;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The bottom-left piece (7:30) is now moved to the bottom-right corner.  
                //
                case EnumAll12Faces.F0430:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_730.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_ESE:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = start_whichIsFront;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_SSE:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = start_whichIsFront;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The bottom-left (7:30) piece is now in the bottom-left corner (F0730, etc.).  
                //
                case EnumAll12Faces.F0730:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_730.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = start_whichIsSouth;  // i.e. !!! no change !!!
                    this_piece_startsAt_730.WhichFaceIsW_of_front = start_whichIsWest;
                    break;

                case EnumAll12Faces._730_SSW:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = start_whichIsFront;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = start_whichIsSouth;
                    break;

                case EnumAll12Faces._730_WSW:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = start_whichIsFront;
                    break;


                //
                // The bottom-left (7:30) piece is now in the top-left corner.  
                //
                case EnumAll12Faces.F1030:  
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsFront;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = start_whichIsSouth;
                    break;

                case EnumAll12Faces._1030_WNW:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsWest;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = start_whichIsFront;
                    break;

                case EnumAll12Faces._1030_NNW:
                    this_piece_startsAt_730.WhichFaceIsFront = start_whichIsSouth;
                    this_piece_startsAt_730.WhichFaceIsN_of_front = start_whichIsFront;
                    this_piece_startsAt_730.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_730.WhichFaceIsW_of_front = start_whichIsWest;
                    break;


            }

        }


    }
}
