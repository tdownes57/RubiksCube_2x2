using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2
{
    public enum EnumColors
    {
        //   ---10/09/2023 td
        Undetermined, // = 0,
        Red, //  = 1,
        Yellow, //  = 2,
        Orange, //  = 3,
        Blue, //  = 4,
        Green, //  = 5,
        White, //  = 6
    }

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
            if (param_buildNew) ClearCache_RebuildFromFactory();

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
            //----My4x4Cube = new RubiksCubeBothSides();

            // Encapsulated 10/09/2023  
            ClearCache_RebuildTilesOnly(); 

            //
            // Find a way to connect the construct the 
            //   cube (from factory specifications!!) 
            //   using the new tiles!!
            //
            // Probably, we need to call a constructor for the
            // new cube which will accept our face tiles as 
            // the six-times-four(24) parameters.  
            //
            //    ----10/09/2023 thomas downes
            //


        }


            private void ClearCache_RebuildTilesOnly()
            {
                //
                // Added 10/09/2023  
                //
                MyTileRed1 = new RubiksFaceTile_Class(EnumColors.Red); // MyTileRed1;
            MyTileRed2 = new RubiksFaceTile_Class(EnumColors.Red); //  MyTileRed2;
            MyTileRed3 = new RubiksFaceTile_Class(EnumColors.Red); //  MyTileRed3;
            MyTileRed4 = new RubiksFaceTile_Class(EnumColors.Red); //  MyTileRed4;

            MyTileYellow1 = new RubiksFaceTile_Class(EnumColors.Yellow); //  MyTileYellow1;
            MyTileYellow2 = new RubiksFaceTile_Class(EnumColors.Yellow); //  MyTileYellow2;
            MyTileYellow3 = new RubiksFaceTile_Class(EnumColors.Yellow); //  MyTileYellow3;
            MyTileYellow4 = new RubiksFaceTile_Class(EnumColors.Yellow); //  MyTileYellow4;

        public RubiksFaceTile_Class(EnumColors.Orange); //   MyTileOrange1;
        public RubiksFaceTile_Class(EnumColors.Orange); //   MyTileOrange2;
        public RubiksFaceTile_Class(EnumColors.Orange); //   MyTileOrange3;
        public RubiksFaceTile_Class(EnumColors.Orange); //   MyTileOrange4;

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


    }



}
}
