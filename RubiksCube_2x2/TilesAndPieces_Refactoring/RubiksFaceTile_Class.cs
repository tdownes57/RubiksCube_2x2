﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 10/12/2021  
using System.Runtime.InteropServices;

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

        //
        // Suffixed "_Mutable" per https://www.lexico.com/en/definition/mutable?locale=en
        //
        public int OrdinalPositionAmongPieces1234_Mutable = 0;  // The function RubiksPiece_4Pieces.ToString() will refer to this. Added 10/15/2021 td  

        private Color mod_colorOfTile = Color.Transparent;
        private bool mod_isLoadingComplete = false;

        //
        // Too many public properties!!  See C++ at Orange Coast College.
        //   ---8/9/2023
        //
        public Boolean ManueverText_IsMarked = false;  // Added 10/20/2021.
        public string ManueverTextMarker = "";  // Default to "". E.g. "10:30".   Added 10/20/2021. 
        public Color ManueverTextMarker_Color = Color.Black;  // Added 10/20/2021.
         
        public RubiksFaceTile_Class mod_nextTileCW_Immutable;  // This is "_Immutable" because its determined at "Load" time and cannot be changed.
        public RubiksFaceTile_Class mod_nextTileCCW_Immutable; // This is "_Immutable" because its determined at "Load" time and cannot be changed.

        // Red tiles
        //
        //     if (par_enum == EnumAll8Pieces.BlueRedWhite) return mod_tileRedBRW;
        //     else if (par_enum == EnumAll8Pieces.BlueYellowRed) return mod_tileRedBYR;
        //     else if (par_enum == EnumAll8Pieces.GreenRedYellow) return mod_tileRedGRY;
        //     else if (par_enum == EnumAll8Pieces.GreenWhiteRed) return mod_tileRedGWR;
        //
        private static RubiksFaceTile_Class mod_tileRedBRW = new RubiksFaceTile_Class(Color.Red);
        private static RubiksFaceTile_Class mod_tileRedBYR = new RubiksFaceTile_Class(Color.Red);
        private static RubiksFaceTile_Class mod_tileRedGRY = new RubiksFaceTile_Class(Color.Red);
        private static RubiksFaceTile_Class mod_tileRedGWR = new RubiksFaceTile_Class(Color.Red);

        // Blue tiles
        //
        //    //if (par_enum == EnumAll8Pieces.BlueOrangeYellow)      return mod_tileBlueBOY;
        //    //else if (par_enum == EnumAll8Pieces.BlueRedWhite)     return mod_tileBlueBRW;
        //    //else if (par_enum == EnumAll8Pieces.BlueWhiteOrange)  return mod_tileBlueBWO;
        //    //else if (par_enum == EnumAll8Pieces.BlueYellowRed)    return mod_tileBlueBYR;
        //
        private static RubiksFaceTile_Class mod_tileBlueBOY = new RubiksFaceTile_Class(Color.Blue);
        private static RubiksFaceTile_Class mod_tileBlueBRW = new RubiksFaceTile_Class(Color.Blue);
        private static RubiksFaceTile_Class mod_tileBlueBWO = new RubiksFaceTile_Class(Color.Blue);
        private static RubiksFaceTile_Class mod_tileBlueBYR = new RubiksFaceTile_Class(Color.Blue);


        //    Green tiles  
        //
        //    //Added 8/25/2023 td
        //    //if (par_enum == EnumAll8Pieces.GreenOrangeWhite) return mod_tileGreenGOW;
        //    //else if (par_enum == EnumAll8Pieces.GreenRedYellow) return mod_tileGreenGRY;
        //    //else if (par_enum == EnumAll8Pieces.GreenWhiteRed) return mod_tileGreenGWR;
        //    //else if (par_enum == EnumAll8Pieces.GreenYellowOrange) return mod_tileGreenGYO;
        //
        private static RubiksFaceTile_Class mod_tileGreenGOW = new RubiksFaceTile_Class(Color.Lime); // Limegreen
        private static RubiksFaceTile_Class mod_tileGreenGRY = new RubiksFaceTile_Class(Color.Lime); // Limegreen
        private static RubiksFaceTile_Class mod_tileGreenGWR = new RubiksFaceTile_Class(Color.Lime); // Limegreen
        private static RubiksFaceTile_Class mod_tileGreenGYO = new RubiksFaceTile_Class(Color.Lime); // Limegreen


        //    //Yellow tiles
        //    ////Added 8/25/2023 td
        //    //if (par_enum == EnumAll8Pieces.BlueOrangeYellow) return mod_tileYellowBOY;
        //    //else if (par_enum == EnumAll8Pieces.BlueYellowRed) return mod_tileYelloBYR;
        //    //else if (par_enum == EnumAll8Pieces.GreenRedYellow) return mod_tileYellowGRY;
        //    //else if (par_enum == EnumAll8Pieces.GreenYellowOrange) return mod_tileYellowGYO;
        //
        private static RubiksFaceTile_Class mod_tileYellowBOY = new RubiksFaceTile_Class(Color.Yellow);
        private static RubiksFaceTile_Class mod_tileYellowBYR = new RubiksFaceTile_Class(Color.Yellow);
        private static RubiksFaceTile_Class mod_tileYellowGRY = new RubiksFaceTile_Class(Color.Yellow);
        private static RubiksFaceTile_Class mod_tileYellowGYO = new RubiksFaceTile_Class(Color.Yellow);


        //    Orange tiles
        //    ////Added 8/25/2023 td
        //    if (par_enum == EnumAll8Pieces.BlueRedWhite) return mod_tileWhiteBRW;
        //    else if (par_enum == EnumAll8Pieces.BlueWhiteOrange) return mod_tileWhiteBWO;
        //    else if (par_enum == EnumAll8Pieces.GreenOrangeWhite) return mod_tileWhiteGOW;
        //    else if (par_enum == EnumAll8Pieces.GreenWhiteRed) return mod_tileWhiteGWR;
        /
        private static RubiksFaceTile_Class mod_tileWhiteBRW = new RubiksFaceTile_Class(Color.White);
        private static RubiksFaceTile_Class mod_tileWhiteBWO = new RubiksFaceTile_Class(Color.White);
        private static RubiksFaceTile_Class mod_tileWhiteGOW = new RubiksFaceTile_Class(Color.White);
        private static RubiksFaceTile_Class mod_tileWhiteGWR = new RubiksFaceTile_Class(Color.White);


        //    White tiles
        //    Added 8/25/2023 td
        //    /if (par_enum == EnumAll8Pieces.BlueOrangeYellow) return mod_tileoOrangeBOY;
        //    /else if (par_enum == EnumAll8Pieces.BlueWhiteOrange) return mod_tileOrangeBWO;
        //    /else if (par_enum == EnumAll8Pieces.GreenOrangeWhite) return mod_tileOrangeGOW;
        //    /else if (par_enum == EnumAll8Pieces.GreenYellowOrange) return mod_tileOrangeGYO;
        //
        private static RubiksFaceTile_Class mod_tileOrangeBOY = new RubiksFaceTile_Class(Color.Orange);
        private static RubiksFaceTile_Class mod_tileOrangeBWO = new RubiksFaceTile_Class(Color.Orange);
        private static RubiksFaceTile_Class mod_tileOrangeGOW = new RubiksFaceTile_Class(Color.Orange);
        private static RubiksFaceTile_Class mod_tileOrangeGYO = new RubiksFaceTile_Class(Color.Orange);


        public static RubiksFaceTile_Class GetRed(EnumAll8Pieces par_enum)
        {
            //
            // -----SINGLETON PATTERN----- (vs. CACHE PATTERN) 
            //
            // Red tiles
            //Added 8/25/2023 td
            if (par_enum == EnumAll8Pieces.BlueRedWhite) return mod_tileRedBRW;
            else if (par_enum == EnumAll8Pieces.BlueYellowRed) return mod_tileRedBYR;
            else if (par_enum == EnumAll8Pieces.GreenRedYellow) return mod_tileRedGRY;
            else if (par_enum == EnumAll8Pieces.GreenWhiteRed) return mod_tileRedGWR;
            else return null; 
        }


        public static RubiksFaceTile_Class GetBlue(EnumAll8Pieces par_enum)
        {
            //
            // -----SINGLETON PATTERN----- (vs. CACHE PATTERN) 
            //
            // Blue tiles
            //Added 8/25/2023 td
            if (     par_enum == EnumAll8Pieces.BlueOrangeYellow) return mod_tileBlueBOY;
            else if (par_enum == EnumAll8Pieces.BlueRedWhite)     return mod_tileBlueBRW;
            else if (par_enum == EnumAll8Pieces.BlueWhiteOrange)  return mod_tileBlueBWO;
            else if (par_enum == EnumAll8Pieces.BlueYellowRed)    return mod_tileBlueBYR;
            else return null;
        }


        public static RubiksFaceTile_Class GetGreen(EnumAll8Pieces par_enum)
        {
            //
            // -----SINGLETON PATTERN----- (vs. CACHE PATTERN) 
            //
            // This static function is useful if we are using a "Singleton" 
            //  software-design pattern for the Rubik's 4X4X4 cube... but NOT if we
            //  deviate from the Singleton design pattern.  ---10/2023 td
            //
            // Green tiles
            //Added 8/25/2023 td
            if (par_enum == EnumAll8Pieces.GreenOrangeWhite) return mod_tileGreenGOW;
            else if (par_enum == EnumAll8Pieces.GreenRedYellow) return mod_tileGreenGRY;
            else if (par_enum == EnumAll8Pieces.GreenWhiteRed) return mod_tileGreenGWR;
            else if (par_enum == EnumAll8Pieces.GreenYellowOrange) return mod_tileGreenGYO;
            else return null;
        }

        public static RubiksFaceTile_Class GetYellow(EnumAll8Pieces par_enum)
        {
            //
            // -----SINGLETON PATTERN----- (vs. CACHE PATTERN) 
            //
            // This static function is useful if we are using a "Singleton" 
            //  software-design pattern for the Rubik's 4X4X4 cube... but NOT if we
            //  deviate from the Singleton design pattern.  ---10/2023 td 
            //
            // Yellow tiles
            //Added 8/25/2023 td
            if (par_enum == EnumAll8Pieces.BlueOrangeYellow) return mod_tileYellowBOY;
            else if (par_enum == EnumAll8Pieces.BlueYellowRed) return mod_tileYellowBYR;
            else if (par_enum == EnumAll8Pieces.GreenRedYellow) return mod_tileYellowGRY;
            else if (par_enum == EnumAll8Pieces.GreenYellowOrange) return mod_tileYellowGYO;
            else return null;
        }

        public static RubiksFaceTile_Class GetWhite(EnumAll8Pieces par_enum)
        {
            //
            // -----SINGLETON PATTERN----- (vs. CACHE PATTERN) 
            //
            // This static function is useful if we are using a "Singleton" 
            //  software-design pattern for the Rubik's 4X4X4 cube... but NOT if we
            //  deviate from the Singleton design pattern.   ---10/2023 td
            //
            // White tiles
            //     ----Added 8/25/2023 td
            //
            if (par_enum == EnumAll8Pieces.BlueRedWhite) return mod_tileWhiteBRW;
            else if (par_enum == EnumAll8Pieces.BlueWhiteOrange) return mod_tileWhiteBWO;
            else if (par_enum == EnumAll8Pieces.GreenOrangeWhite) return mod_tileWhiteGOW;
            else if (par_enum == EnumAll8Pieces.GreenWhiteRed) return mod_tileWhiteGWR;
            else return null;
        }


        public static RubiksFaceTile_Class GetOrange(EnumAll8Pieces par_enum)
        {
            //
            // -----SINGLETON PATTERN----- (vs. CACHE PATTERN) 
            //
            // This static function is useful if we are using a "Singleton" 
            //  software-design pattern for the Rubik's 4X4X4 cube... but NOT if we
            //  deviate from the Singleton design pattern.  ---10/2023 td 
            //
            // Orange Tile 
            //     ----Added 8/25/2023 td
            //
            if (par_enum == EnumAll8Pieces.BlueOrangeYellow) return mod_tileOrangeBOY;
            else if (par_enum == EnumAll8Pieces.BlueWhiteOrange) return mod_tileOrangeBWO;
            else if (par_enum == EnumAll8Pieces.GreenOrangeWhite) return mod_tileOrangeGOW;
            else if (par_enum == EnumAll8Pieces.GreenYellowOrange) return mod_tileOrangeGYO;
            else return null;
        }

        //
        /// <summary>
        /// Done with the static section. 
        /// </summary>


        public Color ColorOfTile {
            get
            {
                // Added 10/12/2021 td 
                return mod_colorOfTile;
            }
        }


        public RubiksFaceTile_Class(Color par_color)
        {
            //Added 8/25/2023  
            mod_colorOfTile = par_color;

        }


        public RubiksFaceTile_Class(Color par_color, RubiksPieceCorner_3Tiles par_pieceParent,
                 RubiksFaceTile_Class par_nextTileCW, 
                 RubiksFaceTile_Class par_nextTileCCW)
        {
            //
            // Working constructor...
            //
            // Added 10/12/2021 td 
            //
            this.ParentPiece = par_pieceParent;
            mod_colorOfTile = par_color;
            mod_nextTileCW_Immutable = par_nextTileCW;
            mod_nextTileCCW_Immutable = par_nextTileCCW;
            mod_isLoadingComplete = true; 

        }


        public RubiksFaceTile_Class(Color par_color, RubiksPieceCorner_3Tiles par_pieceParent,
                                     RubiksFaceTile_Class par_nextTileCW)
        {
            //
            // Another working constructor. 
            //
            // Added 10/12/2021 td 
            //
            this.ParentPiece = par_pieceParent;
            mod_colorOfTile = par_color;
            mod_nextTileCW_Immutable = par_nextTileCW;
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
            //if (mod_nextTileCW == null) mod_nextTileCW = par_tileRemaining;
            //if (mod_nextTileCCW == null) mod_nextTileCCW = par_tileRemaining;
            //
            // During "Load" time, it's fine to set _Immutable properties. ---10/15/2021 td 
            //
            if (mod_nextTileCW_Immutable == null) mod_nextTileCW_Immutable = par_tileRemaining;
            if (mod_nextTileCCW_Immutable == null) mod_nextTileCCW_Immutable = par_tileRemaining;

            mod_isLoadingComplete = true;  // True. The last remaining tile has been supplied. 

        }


        public void Load_NeighborTiles(RubiksFaceTile_Class par_tileNextCW, RubiksFaceTile_Class par_tileNextCCW)
        {
            //
            // Added 10/12/2021 td 
            //
            if (mod_isLoadingComplete) throw new Exception("We cannot load any more tiles, we are already done.");

            //
            // During "Load" time, it's fine to set _Immutable properties. ---10/15/2021 td 
            //
            mod_nextTileCW_Immutable = par_tileNextCW;   // mod_nextTileCW = par_tileNextCW;
            mod_nextTileCCW_Immutable = par_tileNextCCW;  // mod_nextTileCCW = par_tileNextCCW;

            mod_isLoadingComplete = true;  // True. The last remaining tile has been supplied. 

        }


        public RubiksFaceTile_Class NextFaceTile_CW_Immutable()
        {
            //---public RubiksFaceTile_Class NextFaceTile_CW()
            //
            // Added 10/12/2021  
            //
            //  Suffixed "_Immutable" on 10/15/2021 thomas d.
            // // This is "_Immutable" because its determined at "Load" time and cannot be changed.
            //
            //return mod_nextTileCW;
            return mod_nextTileCW_Immutable;

        }

        public RubiksFaceTile_Class NextFaceTile_CCW_Immutable()
        {
            //---public RubiksFaceTile_Class NextFaceTile_CCW()
            //
            //  Suffixed "_Immutable" on 10/15/2021 thomas d.
            // // This is "_Immutable" because its determined at "Load" time and cannot be changed.
            //
            // Added 10/12/2021  
            //
            //return mod_nextTileCW;
            //return mod_nextTileCCW;
            return mod_nextTileCCW_Immutable;

        }


        public void RenumberOrdinalPosition1234_Mutable(int par_newOrdinalPosition1234)
        {
            // Added 10/15/2021 td 
            //
            // Give it a new position among its sister RubiksPieces--1, 2, 3, or 4. 
            //
            // This obviously changes the "_Mutable" property this.OrdinalPositionAmongPieces1234_Mutable 
            //
            this.OrdinalPositionAmongPieces1234_Mutable = par_newOrdinalPosition1234;

        }

        public string SerializeManeuver()
        {
            //{{{{ public string SerializeLocation()
            //
            // Added 10/12/2021  
            //
            //    For example:      
            //       NE-N    The originally-1:30 piece's front face is now NE-N (north side face of the NE position)
            //       SW-W    The originally-1:30 piece's front face is now SW-W (west side face of the SW position)
            //       NE-N    The originally-1:30 piece's front face is now NE-N (north side face of the NE position)
            //       SE-E    The originally-1:30 piece's front face is now SE-E (east side face of the SE position)
            //       SE      The originally-1:30 piece's front face is now SE (front face of the SE position)
            //       SW      The originally-1:30 piece's front face is now SW (front face of the SW position)
            //
            string strTextMarker = this.ManueverTextMarker;
            string twoChars = (strTextMarker == "1:30" ? "NE" :
                               (strTextMarker == "4:30" ? "SE" :
                               (strTextMarker == "7:30" ? "SW" :
                               (strTextMarker == "10:30" ? "NW" : ""))));

            string oneChar = (FacePositionNSWE()  == EnumFacePositionNSWE.N_side_of_front ? "N" :
                               (FacePositionNSWE() == EnumFacePositionNSWE.S_side_of_front ? "S" :
                               (FacePositionNSWE() == EnumFacePositionNSWE.E_side_of_front ? "E" :
                               (FacePositionNSWE() == EnumFacePositionNSWE.W_side_of_front ? "W" : ""))));

            if (oneChar == "") return twoChars;
            //else return (twoChars + "-" + oneChar);

            // https://www.c-sharpcorner.com/article/6-effective-ways-to-concatenate-strings-in-c-sharp-and-net-core/
            else return ($"{twoChars}-{oneChar}");

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
