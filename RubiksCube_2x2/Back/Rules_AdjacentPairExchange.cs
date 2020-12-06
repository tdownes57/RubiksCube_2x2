using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.Back
{
    class Rules_AdjacentPairExchange
    {
        //
        // What happens to the opposite side, when an 
        //    adjacent pair of pieces are switched on 
        //    a particular side of the 2x2 Rubik's Cube?
        //     -----12/4/2020  thomas downes
        //
        public static ComplexPieceMove backside_move1_from130; // = new ComplexPieceMove();
        public static ComplexPieceMove backside_move2_from430;
        public static ComplexPieceMove backside_move3_from730;
        public static ComplexPieceMove backside_move4_from1030;

        public static void BuildBacksideRules()
        {
            //
            // Added 12/5/2020 thomas downes  
            //
            backside_move1_from130.StartingPoint = FrontClockFace.one_thirty;
            backside_move1_from130.EndingPoint = EnumAll12Faces.F0130;

            backside_move2_from430.StartingPoint = FrontClockFace.four_thirty;
            backside_move2_from430.EndingPoint = EnumAll12Faces._1030_WNW;

            backside_move3_from730.StartingPoint = FrontClockFace.seven_thirty;
            backside_move3_from730.EndingPoint = EnumAll12Faces.F0730;

            backside_move4_from1030.StartingPoint = FrontClockFace.ten_thirty;
            backside_move4_from1030.EndingPoint = EnumAll12Faces.F0430;



        }




    }
}
