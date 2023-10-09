using System;
using System.Collections.Generic;
using System.Drawing.Configuration;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Drawing; //.color;

namespace RubiksCube_2x2 //.TilesAndPieces_Refactoring
{
    internal class RubiksFace_4Tiles
    {
        //
        // Added 8/23/2023 Thomas Downes  
        //
        // I am starting to question the need for this class.
        //    The original purpose of the class is to have the function Get_EntropyLevel(), 
        //    however I am realizing that we could have the same function 
        //    within the class RubiksSide_4Pieces.  
        //    ---8/25/2023  
        //
        RubiksFaceTile_Class mod_tile1;
        RubiksFaceTile_Class mod_tile2;
        RubiksFaceTile_Class mod_tile3;
        RubiksFaceTile_Class mod_tile4;

        RubiksFace_4Tiles(RubiksSide_4Pieces par_4pieces)
        {
            //
            // I am starting to question the need for this class.
            //    The original purpose of the class is to have the function Get_EntropyLevel(), 
            //    however I am realizing that we could have the same function 
            //    within the class RubiksSide_4Pieces.  
            //    ---8/25/2023  
            //
            // Just one possible constructor!   Create the object (RubiksFace_4Tiles)
            //   by using the four(4) "front-facing" tiles. 
            //
            //mod_tile1 = par_4pieces.NextPiece_Mutable().GetFrontTile();
            //mod_tile2 = par_4pieces.NextPiece_Mutable().GetFrontTile();
            //mod_tile3 = par_4pieces.NextPiece_Mutable().GetFrontTile();
            //mod_tile4 = par_4pieces.NextPiece_Mutable().GetFrontTile();

            mod_tile1 = par_4pieces.GetFaceTileAtPosition(FrontClockFace_Enum.one_thirty);
            mod_tile2 = par_4pieces.GetFaceTileAtPosition(FrontClockFace_Enum.four_thirty);
            mod_tile3 = par_4pieces.GetFaceTileAtPosition(FrontClockFace_Enum.seven_thirty);
            mod_tile4 = par_4pieces.GetFaceTileAtPosition(FrontClockFace_Enum.ten_thirty);



        }

        public int EntropyLevel()
        {
            //
            // Added 10/09/2023 
            //
            return Get_EntropyLevel();
        }

        public int Get_EntropyLevel()
        {
            //
            // Added 8/25/2023 
            //
            var colors_face = new HashSet<Color>() { mod_tile1.ColorOfTile };

            try
            {
                colors_face.Add(mod_tile2.ColorOfTile);
            }
            catch { }

            try
            {
                colors_face.Add(mod_tile3.ColorOfTile);
            }
            catch { }

            try
            {
                    colors_face.Add(mod_tile4.ColorOfTile);
            }
            catch { }

            //
            // Return the number of colors by 1, so that the minimum
            //   is a value of 0. 
            //
            return (colors_face.Count - 1);

        }



    }
}
