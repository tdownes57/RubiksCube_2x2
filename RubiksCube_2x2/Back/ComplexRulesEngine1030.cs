using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.Back
{
    static class ComplexRulesEngine1030
    {
        //
        // This static class implements moves by the Top-Left piece, in the 10:30 pm position. 
        //
        public static RubikPieceCorner this_piece_startsAt_1030;
        public static ComplexPieceMove this_complex_move;

        public static void FrontFace_1030_ReorientTo() // (EnumAll12Faces par_enum)
        {
            //
            // Added 11/15/2020 thomas downes
            //

            //This will take care of determining the o'clock position
            //  of the piece.  
            //this_piece_startsAt_1030.ReorientPiece_Complex(par_enum);

            //throw new NotImplementedException("The side faces must be addressed.");

            EnumFaceNum start_whichIsFront = this_piece_startsAt_1030.WhichFaceIsFront;
            EnumFaceNum start_whichIsNorth = this_piece_startsAt_1030.WhichFaceIsN_of_front;
            //---n/a---EnumFaceNum start_whichIsEast = this_piece_startsAt_1030.WhichFaceIsE_of_front;
            //---n/a---EnumFaceNum start_whichIsSouth = this_piece_startsAt_1030.WhichFaceIsS_of_front;
            EnumFaceNum start_whichIsWest = this_piece_startsAt_1030.WhichFaceIsW_of_front;

            //Added 11/15/2020 thomas downes
            //---n/a---EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

            //Added 11/18/2020 thomas downes
            if (start_whichIsFront == EnumFaceNum.NotApplicable_DifferentPiece
                || start_whichIsNorth == EnumFaceNum.NotApplicable_DifferentPiece
                || start_whichIsWest == EnumFaceNum.NotApplicable_DifferentPiece)
                throw new NotImplementedException();

            //Added 11/18/2020 thomas downes
            if (start_whichIsFront == EnumFaceNum.NotSpecified
                    || start_whichIsNorth == EnumFaceNum.NotSpecified
                    || start_whichIsWest == EnumFaceNum.NotSpecified)
                throw new NotImplementedException();

            //Added 11/15/2020 thomas downes
            EnumAll12Faces the_endpoint = this_complex_move.EndingPoint;

            switch (the_endpoint)
            {
                //
                // The top-left piece (10:30) is now moved to the upper-right corner (130). 
                //
                case EnumAll12Faces.F0130:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = start_whichIsNorth;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_NNE:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsNorth;
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = start_whichIsFront;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_ENE:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = start_whichIsNorth;  // No change.
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = start_whichIsFront;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The top-left piece (10:30) is now moved to the bottom-right corner.  
                //
                case EnumAll12Faces.F0430:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = start_whichIsNorth;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_ESE:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsNorth;
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = start_whichIsFront;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_SSE:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = start_whichIsNorth;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = start_whichIsFront;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The top-left (10:30) piece is now in the bottom-left corner.  
                //
                case EnumAll12Faces.F0730:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = start_whichIsNorth;
                    break;

                case EnumAll12Faces._730_SSW:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsNorth;
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = start_whichIsFront;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = start_whichIsWest;
                    break;

                case EnumAll12Faces._730_WSW:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = start_whichIsNorth;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = start_whichIsFront;
                    break;


                //
                // The top-left piece is now in the top-left corner.... not likely!!?? 
                //
                case EnumAll12Faces.F1030: break; // No change !!!

                case EnumAll12Faces._1030_WNW:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsNorth;
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = start_whichIsFront;
                    break;

                case EnumAll12Faces._1030_NNW:
                    this_piece_startsAt_1030.WhichFaceIsFront = start_whichIsWest;
                    this_piece_startsAt_1030.WhichFaceIsN_of_front = start_whichIsFront;
                    this_piece_startsAt_1030.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this_piece_startsAt_1030.WhichFaceIsW_of_front = start_whichIsNorth;
                    break;


            }

        }


        //public static void ReorientPiece_Complex(FrontClockFace par_clockPosition_Start, 
        //                        EnumAll12Faces par_enum)
        //{
        //    //public virtual void ReorientPiece_Complex(EnumAll12Faces par_enum)
        //    //public void ReorientPiece_Complex(EnumFaceNum frontFaceColorNum_Start, EnumAll12Faces par_enum)
        //    //
        //    //Added 11/14/2020 thomas downes 
        //    //
        //    switch (par_enum)
        //    {
        //        case EnumAll12Faces.F0130: this_piece.FrontClockFacePosition = FrontClockFace.one_thirty; break;
        //        case EnumAll12Faces._130_ENE: this_piece.FrontClockFacePosition = FrontClockFace.one_thirty; break;
        //        case EnumAll12Faces._130_NNE: this_piece.FrontClockFacePosition = FrontClockFace.one_thirty; break;

        //        case EnumAll12Faces.F0430: this_piece.FrontClockFacePosition = FrontClockFace.four_thirty; break;
        //        case EnumAll12Faces._430_ESE: this_piece.FrontClockFacePosition = FrontClockFace.four_thirty; break;
        //        case EnumAll12Faces._430_SSE: this_piece.FrontClockFacePosition = FrontClockFace.four_thirty; break;

        //        case EnumAll12Faces.F0730: this_piece.FrontClockFacePosition = FrontClockFace.seven_thirty; break;
        //        case EnumAll12Faces._730_SSW: this_piece.FrontClockFacePosition = FrontClockFace.seven_thirty; break;
        //        case EnumAll12Faces._730_WSW: this_piece.FrontClockFacePosition = FrontClockFace.seven_thirty; break;

        //        case EnumAll12Faces.F1030: this_piece.FrontClockFacePosition = FrontClockFace.ten_thirty; break;
        //        case EnumAll12Faces._1030_NNW: this_piece.FrontClockFacePosition = FrontClockFace.ten_thirty; break;
        //        case EnumAll12Faces._1030_WNW: this_piece.FrontClockFacePosition = FrontClockFace.ten_thirty; break;

        //        default: throw new Exception("EnumAll12Faces par_enum value is not recognized.");
        //    }

        //    //EnumFaceNum frontFaceColorNum_Start = this_piece.WhichFaceIsFront;
        //    //EnumFaceNum frontFaceColorNum_End = ??????;
        //    //this_piece.ReorientPiece(this_piece.FrontClockFacePosition, frontfaceColor);

        //    switch (par_clockPosition_Start)
        //    {
        //        case FrontClockFace.ten_thirty: ReorientPiece_Complex_From1030(par_enum); break;
        //        case FrontClockFace.one_thirty: ReorientPiece_Complex_From130(par_enum); break;
        //        case FrontClockFace.four_thirty: ReorientPiece_Complex_From430(par_enum); break;
        //        case FrontClockFace.seven_thirty: ReorientPiece_Complex_From730(par_enum); break;
        //        default:
        //            throw new Exception("Parameter par_clockPosition_Start is not specified.");
        //    }

        //}

        //public void ReorientPiece_Complex_From1030(EnumAll12Faces par_enum)
        //{
        //    //
        //    // Added 11/15/2020 thomas downes
        //    //

        //    //This will take care of determining the o'clock position
        //    //  of the piece.  
        //    //this_piece.ReorientPiece_Complex(par_enum);

        //    //throw new NotImplementedException("The side faces must be addressed.");

        //    EnumFaceNum start_whichIsFront = this_piece_startsAt_1030.WhichFaceIsFront;
        //    EnumFaceNum start_whichIsNorth = this_piece_startsAt_1030.WhichFaceIsN_of_front;
        //    EnumFaceNum start_whichIsEast = this_piece_startsAt_1030.WhichFaceIsE_of_front;
        //    EnumFaceNum start_whichIsSouth = this_piece.WhichFaceIsS_of_front;
        //    EnumFaceNum start_whichIsWest = this_piece.WhichFaceIsW_of_front;
        //    //Added 11/15/2020 thomas downes
        //    EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

        //    switch (par_enum)
        //    {
        //        //
        //        // The top-left piece (10:30) is now moved to the upper-right corner (130). 
        //        //
        //        case EnumAll12Faces.F0130:
        //            this_piece.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
        //            this_piece.WhichFaceIsN_of_front = start_whichIsWest;
        //            this_piece.WhichFaceIsE_of_front = start_whichIsNorth;
        //            this_piece.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            break;

        //        case EnumAll12Faces._130_NNE:
        //            this_piece.WhichFaceIsFront = start_whichIsNorth;
        //            this_piece.WhichFaceIsN_of_front = start_whichIsFront;
        //            this_piece.WhichFaceIsE_of_front = start_whichIsWest;
        //            this_piece.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            break;

        //        case EnumAll12Faces._130_ENE:
        //            this_piece.WhichFaceIsFront = start_whichIsWest;
        //            this_piece.WhichFaceIsN_of_front = start_whichIsNorth;  // No change.
        //            this_piece.WhichFaceIsE_of_front = start_whichIsFront;
        //            this_piece.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            break;


        //        //
        //        // The top-left piece (10:30) is now moved to the bottom-right corner.  
        //        //
        //        case EnumAll12Faces.F0430:
        //            this_piece.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
        //            this_piece.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsE_of_front = start_whichIsWest;
        //            this_piece.WhichFaceIsS_of_front = start_whichIsNorth;
        //            this_piece.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            break;

        //        case EnumAll12Faces._430_ESE:
        //            this_piece.WhichFaceIsFront = start_whichIsNorth;
        //            this_piece.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsE_of_front = start_whichIsFront;
        //            this_piece.WhichFaceIsS_of_front = start_whichIsWest;
        //            this_piece.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            break;

        //        case EnumAll12Faces._430_SSE:
        //            this_piece.WhichFaceIsFront = start_whichIsWest;
        //            this_piece.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsE_of_front = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsS_of_front = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            break;


        //        //
        //        // The top-left (10:30) piece is now in the bottom-left corner.  
        //        //
        //        case EnumAll12Faces.F0730:
        //            this_piece.WhichFaceIsFront = start_whichIs_NotSpecified;  // i.e. !!! no change !!!
        //            this_piece.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsS_of_front = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsW_of_front = start_whichIs_NotSpecified;
        //            break;

        //        case EnumAll12Faces._730_SSW:
        //            this_piece.WhichFaceIsFront = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsS_of_front = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsW_of_front = start_whichIs_NotSpecified;
        //            break;

        //        case EnumAll12Faces._730_WSW:
        //            this_piece.WhichFaceIsFront = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsS_of_front = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsW_of_front = start_whichIs_NotSpecified;
        //            break;


        //        //
        //        // The top-left piece is now in the top-left corner.... not likely!!?? 
        //        //
        //        case EnumAll12Faces.F1030: break; // No change !!!

        //        case EnumAll12Faces._1030_WNW:
        //            this_piece.WhichFaceIsFront = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsN_of_front = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsW_of_front = start_whichIs_NotSpecified;
        //            break;

        //        case EnumAll12Faces._1030_NNW:
        //            this_piece.WhichFaceIsFront = start_whichIsWest;
        //            this_piece.WhichFaceIsN_of_front = start_whichIs_NotSpecified;
        //            this_piece.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
        //            this_piece.WhichFaceIsW_of_front = start_whichIs_NotSpecified;
        //            break;


        //    }

        //}




    }
}
