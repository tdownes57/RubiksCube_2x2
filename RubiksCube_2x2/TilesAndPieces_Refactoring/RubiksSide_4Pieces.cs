using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;    // Added 10/12/2021 thomas downes
//
// Added 10/12/2021  
//

namespace RubiksCube_2x2 //.TilesAndPieces
{
    class RubiksSide_4Pieces
    {
        //
        // I am refactoring the PieceCorner & FaceTile classes (et al.), so that the 
        //     FaceTile class is given ample responsibilities, e.g. the 
        //     drawing of itself. ----10/12/2021 
        //
        // Added 10/12/2021  
        //
        private RubiksPieceCorner_3Tiles mod_pieceCW1_Immutable;  // Suffixed _Immutable to indicate that these don't change after "Load" is complete.
        private RubiksPieceCorner_3Tiles mod_pieceCW2_Immutable; // Suffixed _Immutable to indicate that these don't change after "Load" is complete.
        private RubiksPieceCorner_3Tiles mod_pieceCW3_Immutable; // Suffixed _Immutable to indicate that these don't change after "Load" is complete.
        private RubiksPieceCorner_3Tiles mod_pieceCW4_Immutable; // Suffixed _Immutable to indicate that these don't change after "Load" is complete.

        private RubiksPieceCorner_3Tiles CurrentEnumeratedPiece; // Used by FirstPiece_Mutable() & NextPiece_Mutable().  Added 10/15/2021  

        // The following does _NOT_ initiate the string to "NE-E, SE-S, SW-W, NW-N".
        //    However, the string literal is providing a possible example of the 
        //    eventual string value, and calculates the number of bytes to 
        //    set aside in memory. 
        //   ----10/15/2021 td
        private StringBuilder ToString_Builder = new StringBuilder("NE-E, SE-S, SW-W, NW-N".Length);


        public RubiksSide_4Pieces(bool bBackside_BOY_BYR_GRY_GYO)
        {
            //
            // Constructor added 10/12/2021  
            //
            if (bBackside_BOY_BYR_GRY_GYO)
            {
                mod_pieceCW1_Immutable = new RubiksPieceCorner_3Tiles(this, Color.Blue, Color.Orange, Color.Yellow);
                mod_pieceCW2_Immutable = new RubiksPieceCorner_3Tiles(this, Color.Blue, Color.Yellow, Color.Red);
                mod_pieceCW3_Immutable = new RubiksPieceCorner_3Tiles(this, Color.Lime, Color.Red, Color.Yellow);   // Lime = Green. 
                mod_pieceCW4_Immutable = new RubiksPieceCorner_3Tiles(this, Color.Lime, Color.Yellow, Color.Orange);   // Lime = Green. 

                //
                // This constructor counts as "Load" time, so this is fine to set these "_Immutable" properties. 
                //
                mod_pieceCW1_Immutable.NextPieceCW_Immutable = mod_pieceCW2_Immutable;
                mod_pieceCW2_Immutable.NextPieceCW_Immutable = mod_pieceCW3_Immutable;
                mod_pieceCW3_Immutable.NextPieceCW_Immutable = mod_pieceCW4_Immutable;
                mod_pieceCW4_Immutable.NextPieceCW_Immutable = mod_pieceCW1_Immutable;

            }



        }


        public RubiksSide_4Pieces(RubiksPieceCorner_3Tiles par_pieceFirst,
                                  FrontClockFace par_positionOfFirstPiece, 
                                  RubiksPieceCorner_3Tiles par_pieceNext1CW,
                                  RubiksPieceCorner_3Tiles par_pieceNext2CW,
                                  RubiksPieceCorner_3Tiles par_pieceNext3CW)
        {
            //
            // Constructor added 10/12/2021  
            //
            mod_pieceCW1_Immutable = par_pieceFirst;  //par_pieceAny;
            mod_pieceCW2_Immutable = par_pieceNext1CW;
            mod_pieceCW3_Immutable = par_pieceNext2CW;
            mod_pieceCW4_Immutable = par_pieceNext3CW;

            mod_pieceCW1_Immutable.FrontClockFacePosition = par_positionOfFirstPiece;
            mod_pieceCW2_Immutable.FrontClockFacePosition = EnumStaticClass.NextPositionClockwise(mod_pieceCW1_Immutable.FrontClockFacePosition);
            mod_pieceCW3_Immutable.FrontClockFacePosition = EnumStaticClass.NextPositionClockwise(mod_pieceCW2_Immutable.FrontClockFacePosition);
            mod_pieceCW4_Immutable.FrontClockFacePosition = EnumStaticClass.NextPositionClockwise(mod_pieceCW3_Immutable.FrontClockFacePosition);

            mod_pieceCW1_Immutable.NextPieceCW_Immutable = mod_pieceCW2_Immutable;
            mod_pieceCW2_Immutable.NextPieceCW_Immutable = mod_pieceCW3_Immutable;
            mod_pieceCW3_Immutable.NextPieceCW_Immutable = mod_pieceCW4_Immutable;
            mod_pieceCW4_Immutable.NextPieceCW_Immutable = mod_pieceCW1_Immutable;
        }

        //public RubiksPieceCorner_3Tiles GetPieceAtPosition(FrontClockFace par_clockFace)
        //{
        //    //
        //    // Added 1/16/2020 thomas downes   
        //    //
        //    if (mod_pieceCW1_Immutable.FrontClockFacePosition == par_clockFace) return mod_pieceCW1_Immutable;
        //    else if (mod_pieceCW2_Immutable.FrontClockFacePosition == par_clockFace) return mod_pieceCW2_Immutable;
        //    else if (mod_pieceCW3_Immutable.FrontClockFacePosition == par_clockFace) return mod_pieceCW3_Immutable;
        //    else if (mod_pieceCW4_Immutable.FrontClockFacePosition == par_clockFace) return mod_pieceCW4_Immutable;
        //    else return null;

        //}


        public RubiksPieceCorner_3Tiles GetPieceAtPosition(FrontClockFace_Enum par_enum)
        {
            //
            // Added 8/09/2023 thomas downes   
            //
            if (mod_pieceCW1_Immutable.FrontClockFacePosition.EnumValue() == par_enum) return mod_pieceCW1_Immutable;
            else if (mod_pieceCW2_Immutable.FrontClockFacePosition.EnumValue() == par_enum) return mod_pieceCW2_Immutable;
            else if (mod_pieceCW3_Immutable.FrontClockFacePosition.EnumValue() == par_enum) return mod_pieceCW3_Immutable;
            else if (mod_pieceCW4_Immutable.FrontClockFacePosition.EnumValue() == par_enum) return mod_pieceCW4_Immutable;
            else return null;

        }


        public RubiksPieceCorner_3Tiles FirstPiece_Mutable()
        {
            //
            // Added 10/29/2021 thomas downes
            //
            //if (CurrentEnumeratedPiece == null)
            //{
                CurrentEnumeratedPiece = GetPieceAtPosition(FrontClockFace.one_thirty);
                return CurrentEnumeratedPiece;
            //}
            //else
            //{
            //    // CW = Clockwise (rotation) 
            //    FrontClockFace nextClockPositionCW = CurrentEnumeratedPiece
            //        .FrontClockFacePosition_NextCW();
            //    CurrentEnumeratedPiece = GetPieceAtPosition(nextClockPositionCW);
            //    return CurrentEnumeratedPiece; 
            //}

        }


        public RubiksPieceCorner_3Tiles NextPiece_Mutable()
        {
            //
            // Added 10/29/2021 thomas downes
            //
            if (CurrentEnumeratedPiece == null)
            {
                //CurrentEnumeratedPiece = GetPieceAtPosition(FrontClockFace.one_thirty());
                //return CurrentEnumeratedPiece;
                throw new Exception("First call FirstPiece_Mutable, then call the present function!!");
            }
            else
            {
                // This function should only be called three(3) times, so
                //   let's run an error check.  ---10/29/2021 td  
                var currentClock = CurrentEnumeratedPiece.FrontClockFacePosition.EnumValue();
                if (currentClock == FrontClockFace.ten_thirty) 
                    throw new Exception("I think you have already asked for four(4) pieces.");

                // CW = Clockwise (rotation) 
                FrontClockFace nextClockPositionCW = CurrentEnumeratedPiece.FrontClockFacePosition_NextCW();
                CurrentEnumeratedPiece = GetPieceAtPosition(nextClockPositionCW);
                return CurrentEnumeratedPiece;

            }

        }


        public string ToString_MutableOrder()
        {
            //
            // Added 10/15/2021 thomas downes
            //
            //
            //
            return FirstPiece_Mutable().ToString() + ", " +
                   NextPiece_Mutable().ToString() + ", " +
                   NextPiece_Mutable().ToString() + ", " +
                   NextPiece_Mutable().ToString();

        }





    }
}
