using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace RubiksCube_2x2.Back
namespace RubiksCube_2x2.Maneuvers
{
    class ComplexRulesEngine0130
    {
        //
        // This static class implements moves by the Bottom-Right piece, in the 4:30 pm position. 
        //
        public static RubiksPieceCorner this_piece_startsAt_130;
        public static ComplexPieceMove this_complex_move;


        public static void FrontFace_130_ReorientTo()  // (EnumAll12Faces par_enum)
        {
            //
            // Added 11/15/2020 thomas downes
            //
            //throw new NotImplementedException();
            EnumFaceNum start_whichIsFront = this_piece_startsAt_130.WhichFaceIsFront;
            EnumFaceNum start_whichIsNorth = this_piece_startsAt_130.WhichFaceIsN_of_front;
            EnumFaceNum start_whichIsEast = this_piece_startsAt_130.WhichFaceIsE_of_front;
            //---n/a---EnumFaceNum start_whichIsSouth = this_piece_startsAt_130.WhichFaceIsS_of_front;
            //---n/a---EnumFaceNum start_whichIsWest = this_piece_startsAt_130.WhichFaceIsW_of_front;
            //Added 11/15/2020 thomas downes
            //---n/a---EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

            //Added 11/18/2020 thomas downes
            if (start_whichIsFront == EnumFaceNum.NotApplicable_DifferentPiece
                || start_whichIsNorth == EnumFaceNum.NotApplicable_DifferentPiece
                || start_whichIsEast == EnumFaceNum.NotApplicable_DifferentPiece)
                throw new NotImplementedException();

            //Added 11/18/2020 thomas downes
            if (start_whichIsFront == EnumFaceNum.NotSpecified
                    || start_whichIsNorth == EnumFaceNum.NotSpecified
                    || start_whichIsEast == EnumFaceNum.NotSpecified)
                throw new NotImplementedException();

            //
            //We have to specify the new side-faces. 
            //
            //switch (par_enum)
            //Added 11/15/2020 thomas downes
            EnumAll12Faces the_endpoint = this_complex_move.EndingPoint;

            switch (the_endpoint)
            {
                //
                // The top-right piece (1:30) is now moved to the upper-right corner (130). 
                //
                case EnumAll12Faces.F0130: break; // No change !!!

                case EnumAll12Faces._130_NNE:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsEast;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = start_whichIsFront;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_ENE:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = start_whichIsEast;  // No change.
                    this_piece_startsAt_130.WhichFaceIsE_of_front = start_whichIsFront;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The top-right piece (1:30) is now moved to the bottom-right corner.  
                //
                case EnumAll12Faces.F0430:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_130.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = start_whichIsEast;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_ESE:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsEast;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = start_whichIsFront;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_SSE:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = start_whichIsEast;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = start_whichIsFront;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The top-left (1:30) piece is now in the bottom-left corner.  
                //
                case EnumAll12Faces.F0730:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_130.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = start_whichIsEast;
                    break;

                case EnumAll12Faces._730_SSW:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsEast;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = start_whichIsFront;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = start_whichIsNorth;
                    break;

                case EnumAll12Faces._730_WSW:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = start_whichIsEast;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = start_whichIsFront;
                    break;


                //
                // The top-right (1:30 pm) piece is now in the top-left corner. 
                //
                case EnumAll12Faces.F1030:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsFront;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = start_whichIsEast;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = start_whichIsNorth;
                    break;

                case EnumAll12Faces._1030_WNW:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsEast;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = start_whichIsFront;
                    break;

                case EnumAll12Faces._1030_NNW:
                    this_piece_startsAt_130.WhichFaceIsFront = start_whichIsNorth;
                    this_piece_startsAt_130.WhichFaceIsN_of_front = start_whichIsFront;
                    this_piece_startsAt_130.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_130.WhichFaceIsW_of_front = start_whichIsEast;
                    break;

            }
        }



        //public void ReorientPiece_Complex_From130(EnumAll12Faces par_enum)
        //{
        //    //
        //    // Added 11/15/2020 thomas downes
        //    //
        //    //throw new NotImplementedException();
        //    EnumFaceNum start_whichIsFront = this_piece_startsAt_430.WhichFaceIsFront;
        //    EnumFaceNum start_whichIsNorth = this_piece_startsAt_430.WhichFaceIsN_of_front;
        //    EnumFaceNum start_whichIsEast = this_piece_startsAt_430.WhichFaceIsE_of_front;
        //    EnumFaceNum start_whichIsSouth = this_piece_startsAt_430.WhichFaceIsS_of_front;
        //    EnumFaceNum start_whichIsWest = this_piece_startsAt_430.WhichFaceIsW_of_front;
        //    //Added 11/15/2020 thomas downes
        //    EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

        //}


    }
}
