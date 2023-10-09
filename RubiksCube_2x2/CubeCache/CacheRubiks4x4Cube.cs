using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.CubeCache
{
    internal class CacheRubiks4x4Cube
    {
        //
        // Use for --CACHING PATTERN---
        //   (vs. --SINGLE PATTERN--)
        //
        //   ---10/09/2023 td
        //
        //
        public RubiksCubeBothSides My4x4Cube;  // <<<<< Entire cube!!!

        public RubiksFaceTile_Class MyTileRed1;
        public RubiksFaceTile_Class MyTileRed2;
        public RubiksFaceTile_Class MyTileRed3;
        public RubiksFaceTile_Class MyTileRed4;
        
        public RubiksFaceTile_Class MyTileYellow1;
        public RubiksFaceTile_Class MyTileYellow2;
        public RubiksFaceTile_Class MyTileYellow3;
        public RubiksFaceTile_Class MyTileYellow4;

        public RubiksFaceTile_Class MyTileOrange1;
        public RubiksFaceTile_Class MyTileOrange2;
        public RubiksFaceTile_Class MyTileOrange3;
        public RubiksFaceTile_Class MyTileOrange4;

        public RubiksFaceTile_Class MyTileBlue1;
        public RubiksFaceTile_Class MyTileBlue2;
        public RubiksFaceTile_Class MyTileBlue3;
        public RubiksFaceTile_Class MyTileBlue4;

        public RubiksFaceTile_Class MyTileGreen1;
        public RubiksFaceTile_Class MyTileGreen2;
        public RubiksFaceTile_Class MyTileGreen3;
        public RubiksFaceTile_Class MyTileGreen4;
 
        public RubiksFaceTile_Class MyTileWhite1;
        public RubiksFaceTile_Class MyTileWhite2;
        public RubiksFaceTile_Class MyTileWhite3;
        public RubiksFaceTile_Class MyTileWhite4;


        public CacheRubiks4x4Cube(bool param_buildNew)
        {
            // Added 10/09/2023 td
            if (param_buildNew) ClearCache_RebuildFromFactory()

        }

        public void ClearCache_RebuildFromFactory()
        {
            //
            // Added 10/09/2023  
            //
            // Build a cube, as it comes from the factory!!!
            //
            // All sides will be uni-color... entroy level: zero(0).  
            //




        }



    }
}
