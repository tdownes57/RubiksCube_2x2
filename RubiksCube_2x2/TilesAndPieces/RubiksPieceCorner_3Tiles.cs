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
        public RubiksPieceCorner_3Tiles(Color par_colorFrontFace, Color par_colorNextCW, Color par_colorNextCCW)
        {
            //
            // Added 10/12/2021 Thomas Downes
            //
            var tileFrontFace = new RubiksFaceTile_Class( par_colorFrontFace, this);


        }



    }
}
