using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 10/12/2021  
namespace RubiksCube_2x2 //.TilesAndPieces
{
    class RubiksFaceTile_Class
    {
        //
        // I am refactoring the PieceCorner & FaceTile classes, so that the 
        //     FaceTile class is given ample responsibilities, e.g. the 
        //     drawing of itself. 
        //
        // Added 10/12/2021  
        //
        public RubiksPieceCorner_3Tiles ParentPiece;

        private Color mod_colorOfTile = Color.Transparent;
        private bool mod_isLoadingComplete = false;  

        public RubiksFaceTile_Class mod_nextTileCW;
        public RubiksFaceTile_Class mod_nextTileCCW;

        public Color ColorOfTile {
            get
            {
                // Added 10/12/2021 td 
                return mod_colorOfTile;
            }
        }


        public RubiksFaceTile_Class(Color par_color, RubiksPieceCorner_3Tiles par_pieceParent,
               RubiksFaceTile_Class par_nextTileCW, 
               RubiksFaceTile_Class par_nextTileCCW)
        {
            //
            // Added 10/12/2021 td 
            //
            this.ParentPiece = par_pieceParent;
            mod_colorOfTile = par_color;
            mod_nextTileCW = par_nextTileCW;
            mod_nextTileCCW = par_nextTileCCW;
            mod_isLoadingComplete = true; 

        }


        public RubiksFaceTile_Class(Color par_color, RubiksPieceCorner_3Tiles par_pieceParent,
                                     RubiksFaceTile_Class par_nextTileCW)
        {
            //
            // Added 10/12/2021 td 
            //
            this.ParentPiece = par_pieceParent;
            mod_colorOfTile = par_color;
            mod_nextTileCW = par_nextTileCW;
            //mod_nextTileCCW = par_nextTileCCW;
            mod_isLoadingComplete = false;  // False. We haven't received both neighboring tiles, just one. 

        }


        public RubiksFaceTile_Class(Color par_color, RubiksPieceCorner_3Tiles par_pieceParent)
        {
            //
            // Added 10/12/2021 td 
            //
            this.ParentPiece = par_pieceParent;
            mod_colorOfTile = par_color;
            //mod_nextTileCW = par_nextTileCW;
            //mod_nextTileCCW = par_nextTileCCW;
            //mod_isLoadingComplete = true;
            mod_isLoadingComplete = false; // False. We haven't received any neighboring tiles.

        }


        public void Load_LastTile_NotInUse(RubiksFaceTile_Class par_tileRemaining)
        {
            //
            // Added 10/12/2021 td 
            //
            if (mod_isLoadingComplete) throw new Exception("We cannot load any more tiles, we are already done.");
            if (mod_nextTileCW == null) mod_nextTileCW = par_tileRemaining;
            if (mod_nextTileCCW == null) mod_nextTileCCW = par_tileRemaining;
            mod_isLoadingComplete = true;  // True. The last remaining tile has been supplied. 

        }


        public void Load_NeighborTiles(RubiksFaceTile_Class par_tileNextCW, RubiksFaceTile_Class par_tileNextCCW)
        {
            //
            // Added 10/12/2021 td 
            //
            if (mod_isLoadingComplete) throw new Exception("We cannot load any more tiles, we are already done.");
            mod_nextTileCW = par_tileNextCW;
            mod_nextTileCCW = par_tileNextCCW;
            mod_isLoadingComplete = true;  // True. The last remaining tile has been supplied. 

        }


        public RubiksFaceTile_Class NextFaceTile_CW()
        {
            //
            // Added 10/12/2021  
            //
            return mod_nextTileCW;

        }

        public RubiksFaceTile_Class NextFaceTile_CCW()
        {
            //
            // Added 10/12/2021  
            //
            return mod_nextTileCCW;

        }

        public string SerializeLocation()
        {
            //
            // Added 10/12/2021  
            //
            //    For example:      
            //       NE-N    The originally-1:30 piece's front face is now NE-N (north side face of the NE position)
            //       SW-W    The originally-1:30 piece's front face is now SW-W (west side face of the SW position)
            //       NE-N    The originally-1:30 piece's front face is now NE-N (north side face of the NE position)
            //       SE-E    The originally-1:30 piece's front face is now SE-E (east side face of the SE position)
            //
            //


        }

        private string GetSerializedLocation_OfPiece()
        {
            //
            // Added 10/12/2021  
            //
            return this.ParentPiece.SerializeLocation();
        
        }


        public EnumFacePositionNSWE FacePositionNSWE()
        {
            //
            // Added 10/12/2021  
            //

        }


        public void Repaint()
        {
            //
            // Added 10/12/2021  
            //


        }



    }
}
