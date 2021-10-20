using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;   // Added 10/12/2021 Thomas Downes  

namespace RubiksCube_2x2 //.TilesAndPieces
{
    class RubiksPieceCorner_3Tiles
    {
        //
        // I am refactoring the PieceCorner & FaceTile classes, so that the 
        //     FaceTile class is given ample responsibilities, e.g. the 
        //     drawing of itself. 
        //
        // Added 10/12/2021  
        //
        //Added 2/5/2021 thomas downes
        //  This determines if the front face & sides are filled in with color 
        //  or not.  
        public bool FillFacesWithText = false;  // Default to False. 
        public bool FillFacesWithColor = true; // Default to True. 

        //
        //          [.N.]   [.N.]
        //   [.W.] [10:30] [1:30]  [.E.]
        //   [.W.]  [ 7:30] [3:30]  [.E.]
        //           [.S.]   [.S.]
        //
        // (The [._.] faces are _side_ faces, e.g. [.W.].) 
        //
        //  ----DIFFICULT & CONFUSING-----
        //  FrontClockFacePosition is where the piece appears on the Clock Dial (Face),
        //    ONLY FROM THE FRONT OR BACK PERSPECTIVE.  NOT FROM THE SIDEVIEW. 
        //    ----4/2/2021 Thomas C. Downes
        //
        public FrontClockFace FrontClockFacePosition;
        public FrontClockFace FrontClockFacePosition_Prior;
        public RubiksSide_4Pieces ParentSide;

        public RubiksPieceCorner_3Tiles NextPieceCW_Immutable;  // The adjacent piece when considering the clockwise (CW) motion of a hand which is at the centerpoint of the four pieces.
        public RubiksPieceCorner_3Tiles NextPieceCW_Mutable_Denigrated;  // The adjacent piece when considering the clockwise (CW) motion of a hand which is at the centerpoint of the four pieces.


        public RubiksPieceCorner_3Tiles(RubiksSide_4Pieces par_sideParent, 
            Color par_colorFrontFace, 
            Color par_colorNextCW, 
            Color par_colorNextCCW) :this(par_colorFrontFace, par_colorNextCW, par_colorNextCCW)
        {
            //
            // Added 10/12/2021 Thomas Downes
            //
            this.ParentSide = par_sideParent;

            // Instead, we can use the :this(...) terminology. ---10/12/2021 td
            //---RubiksPieceCorner_3Tiles(par_colorFrontFace, par_colorNextCW, par_colorNextCCW);

        }


            public RubiksPieceCorner_3Tiles(Color par_colorFrontFace, Color par_colorNextCW, Color par_colorNextCCW)
        {
            //
            // Added 10/12/2021 Thomas Downes
            //
            var tileFrontFace = new RubiksFaceTile_Class( par_colorFrontFace, this);
            var tileNextFaceCW = new RubiksFaceTile_Class(par_colorNextCW, this);
            var tileNextFaceCCW = new RubiksFaceTile_Class(par_colorNextCCW, this);

            //
            // Step #0 of 2.  Load the Front Face.  
            //
            tileFrontFace.Load_NeighborTiles(tileNextFaceCW, tileNextFaceCCW);

            //
            // Step #1 of 2.   Load the piece which is clockwise (CW) from the 
            //     front face, when the piece's central corner is directly ahead,
            //     or at the center of an imaginary clock face.  
            //     (And we can imagine the Front Face is above the side faces,
            //     with the side faces being below-left & below-right, respectively;
            //     although that is only important for visualizing purposes.)
            //
            var perCW_tileNextFaceCW = tileNextFaceCCW;   //Pertaining to the NextFaceCW piece, the next-clockwise face is the NextFaceCCW. 
            var perCW_tileNextFaceCCW = tileFrontFace;     //Pertaining to the NextFaceCW piece, the next-counter-clockwise face is the FrontFace. 
            tileNextFaceCW.Load_NeighborTiles(perCW_tileNextFaceCW, perCW_tileNextFaceCCW);

            //
            // Step #2 of 2.   Load the piece which is counter-clockwise (CCW) from the 
            //     front face, when the piece's central corner is directly ahead,
            //     or at the center of an imaginary clock face.  
            //     (And we can imagine the Front Face is above the side faces,
            //     with the side faces being below-left & below-right, respectively;
            //     although that is only important for visualizing purposes.)
            //
            //----tileNextFaceCCW.Load_NeighborTiles(tileFrontFace, tileNextFaceCW);
            var perCCW_tileNextFaceCW = tileFrontFace;  //Pertaining to the NextFaceCCW piece, the next-clockwise face is the Front Face. 
            var perCCW_tileNextFaceCCW = tileNextFaceCW; //Pertaining to the NextFaceCCW piece, the next-counter-clockwise face is NextFaceCW. 
            tileNextFaceCCW.Load_NeighborTiles(perCCW_tileNextFaceCW, perCCW_tileNextFaceCCW);

        }



    }
}
