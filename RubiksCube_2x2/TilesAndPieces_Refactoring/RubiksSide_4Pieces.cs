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
        // Added 10/12/2021  
        //
        private RubiksPieceCorner_3Tiles mod_pieceCW1;
        private RubiksPieceCorner_3Tiles mod_pieceCW2;
        private RubiksPieceCorner_3Tiles mod_pieceCW3;
        private RubiksPieceCorner_3Tiles mod_pieceCW4;

        public RubiksSide_4Pieces(bool bBackside_BOY_BYR_GRY_GYO)
        {
            //
            // Constructor added 10/12/2021  
            //
            if (bBackside_BOY_BYR_GRY_GYO)
            {
                mod_pieceCW1 = new RubiksPieceCorner_3Tiles(this, Color.Blue, Color.Orange, Color.Yellow);
                mod_pieceCW2 = new RubiksPieceCorner_3Tiles(this, Color.Blue, Color.Yellow, Color.Red);
                mod_pieceCW3 = new RubiksPieceCorner_3Tiles(this, Color.Lime, Color.Red, Color.Yellow);   // Lime = Green. 
                mod_pieceCW4 = new RubiksPieceCorner_3Tiles(this, Color.Lime, Color.Yellow, Color.Orange);   // Lime = Green. 

                mod_pieceCW1.NextPieceCW = mod_pieceCW2;
                mod_pieceCW2.NextPieceCW = mod_pieceCW3;
                mod_pieceCW3.NextPieceCW = mod_pieceCW4;
                mod_pieceCW4.NextPieceCW = mod_pieceCW1;

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
            mod_pieceCW1 = par_pieceFirst;  //par_pieceAny;
            mod_pieceCW2 = par_pieceNext1CW;
            mod_pieceCW3 = par_pieceNext2CW;
            mod_pieceCW4 = par_pieceNext3CW;

            mod_pieceCW1.FrontClockFacePosition = par_positionOfFirstPiece;
            mod_pieceCW2.FrontClockFacePosition = EnumStaticClass.NextPositionClockwise(mod_pieceCW1.FrontClockFacePosition);
            mod_pieceCW3.FrontClockFacePosition = EnumStaticClass.NextPositionClockwise(mod_pieceCW2.FrontClockFacePosition);
            mod_pieceCW4.FrontClockFacePosition = EnumStaticClass.NextPositionClockwise(mod_pieceCW3.FrontClockFacePosition);

            mod_pieceCW1.NextPieceCW = mod_pieceCW2;
            mod_pieceCW2.NextPieceCW = mod_pieceCW3;
            mod_pieceCW3.NextPieceCW = mod_pieceCW4;
            mod_pieceCW4.NextPieceCW = mod_pieceCW1;
        }

        public RubiksPieceCorner_3Tiles GetPieceAtPosition(FrontClockFace par_enum)
        {
            //
            // Added 1/16/2020 thomas downes   
            //
            if (mod_pieceCW1.FrontClockFacePosition == par_enum) return mod_pieceCW1;
            else if (mod_pieceCW2.FrontClockFacePosition == par_enum) return mod_pieceCW2;
            else if (mod_pieceCW3.FrontClockFacePosition == par_enum) return mod_pieceCW3;
            else if (mod_pieceCW4.FrontClockFacePosition == par_enum) return mod_pieceCW4;
            else return null;

        }







    }
}
