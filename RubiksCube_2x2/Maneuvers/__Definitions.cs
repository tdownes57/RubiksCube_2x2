using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2
{
    // Added 11/14/2020 thomas downes 
    public enum EnumAll12Faces
    {
        NotSpecified,
        F0130, F0430, F0730, F1030,
        _130_NNE, _130_ENE,
        _430_ESE, _430_SSE,
        _730_SSW, _730_WSW,
        _1030_WNW, _1030_NNW
    }

    // Added 8/25/2023 
    public enum EnumAll8Pieces
    {
        // Added 8/25/2023 
        NotSpecified,
        //Front
        BlueRedWhite, 
        BlueWhiteOrange,
        GreenOrangeWhite,
        GreenWhiteRed,

        //Back
        BlueOrangeYellow,
        BlueYellowRed,
        GreenRedYellow,
        GreenYellowOrange,

    }

}

namespace RubiksCube_2x2  //.Maneuvers
{
    // Added 11/14/2020 thomas downes 
    public struct ComplexPieceMove
    {
        public FrontClockFace StartingPoint;
        public EnumAll12Faces EndingPoint;
        //Added 11/18/2020 thomas downes
        public bool ClockwiseRevolution90_Deprecated;
        //public bool FrontFaceMovement; //Added 12/9/2020 td
        public bool NothingHappens;  // Added 1/13/2021 thomas downes

        //Added 8/17/2023
        public void SetStartingPoint(FrontClockFace_Enum par_enum)
        {
            //Added 8/17/2023
            StartingPoint.SetFrontClockPosition(par_enum);
        }

        //Added 8/17/2023
        public void SetEndingPoint(EnumAll12Faces par_enum)
        {
            //Added 8/17/2023
            EndingPoint = par_enum;
        }

    }

    // Added 12/09/2020 thomas downes 
    //Renamed from ComplexPieceMoves_Five 10/6/2021
    public struct ComplexPieceMoves_OneSide //Renamed from ComplexPieceMoves_Five 10/6/2021
    {
        public ComplexPieceMove move1_from130; // = new ComplexPieceMove();
        public ComplexPieceMove move2_from430;
        public ComplexPieceMove move3_from730;
        public ComplexPieceMove move4_from1030;
        public bool move5_Clockwise90;             
        //public bool move7_RotateEntireCubeLeft;   // Added 10/6/2021 thomas Downes
        //public bool move8_RotateEntireCubeRight;   // Added 10/6/2021 thomas Downes
    }


    public struct Manuever_EntireCube //Added 10/6/2021
    {
        public bool RotateEntireCubeLeft;   // Added 10/6/2021 thomas Downes
        public bool RotateEntireCubeRight;   // Added 10/6/2021 thomas Downes
        public bool ComplexPieceMoves;   // Added 10/6/2021 thomas Downes
        public ComplexPieceMoves_OneSide moves_front; 
        public ComplexPieceMoves_OneSide moves_back;
    }

    //
    //  Serialization of maneuver, one side only:
    //
    //       [Current location of originally-1:30 piece's front face, e.g. SE or SE-S], 
    //         [Current location of originally-4:30 piece's front face, e.g. NE or NE-N], 
    //           [Current location of originally-7:30 piece's front face, e.g. SW or SW-W], 
    //              [Current location of originally-10:30 piece's front face, e.g. NW or NW-E] 
    //
    // Examples of serialization-of-maneuver, one side only: 
    //
    //       NE-N, SE, SW-S, NW-W      The originally-1:30 piece's front face is now NE-N (north side face of the NE position)
    //       SW-W, SE-S, NE-N, NW-W     The originally-1:30 piece's front face is now SW-W (west side face of the SW position)
    //       NE-N, NW-W, SW-S, SE-E     The originally-1:30 piece's front face is now NE-N (north side face of the NE position)
    //       SE-E, NW, SW-W, NW-W     The originally-1:30 piece's front face is now SE-E (east side face of the SE position)
    //
    //  ---10/11/2021 thomas c. downes
    //




}
