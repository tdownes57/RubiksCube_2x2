using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RubiksCube_2x2; // Added 10/11/2021 thomas downes 

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
            backside_move1_from130.StartingPoint = FrontClockFace.one_thirty();
            backside_move1_from130.EndingPoint = EnumAll12Faces.F0130;

            backside_move2_from430.StartingPoint = FrontClockFace.four_thirty();
            backside_move2_from430.EndingPoint = EnumAll12Faces._1030_WNW;

            backside_move3_from730.StartingPoint = FrontClockFace_Enum.seven_thirty;
            backside_move3_from730.EndingPoint = EnumAll12Faces.F0730;

            backside_move4_from1030.StartingPoint = FrontClockFace.ten_thirty;
            backside_move4_from1030.EndingPoint = EnumAll12Faces.F0430;

        }


        //  10-11-2021 td // public static ComplexPieceMoves_Five GetBacksideRules()
        public static ComplexPieceMoves_OneSide GetBacksideRules()
        {
            //
            // Added 12/5/2020 thomas downes  
            //
            BuildBacksideRules();

            //----var new_rules = new ComplexPieceMoves_Five();
            var new_rules = new ComplexPieceMoves_OneSide();

            new_rules.move1_from130 = backside_move1_from130;
            new_rules.move2_from430 = backside_move2_from430;
            new_rules.move3_from730 = backside_move3_from730;
            new_rules.move4_from1030 = backside_move4_from1030;
            new_rules.move5_Clockwise90 = false;

            return new_rules; 

        }


    }
}
