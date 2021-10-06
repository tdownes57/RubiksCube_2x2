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
    }

    // Added 12/09/2020 thomas downes 
    //Renamed from ComplexPieceMoves_OneSide 10/6/2021
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





}
