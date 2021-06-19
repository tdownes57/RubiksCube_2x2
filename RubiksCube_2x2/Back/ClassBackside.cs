using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  //Added 11/13/2020 thomas downes
using System.Windows.Forms;  // Added 12/13/2020 td
using RubiksCube_2x2.Maneuvers;  // Added 1/16/2021 thomas downes

namespace RubiksCube_2x2
{
    namespace Back
    {
        //
        // Added 11/12/2020 thomas downes
        //

        class ClassBackside : RubiksCubeOneSide
        {
            public BlueOrangeYellow _pieceBOY;
            public BlueYellowRed _pieceBYR;
            public GreenRedYellow _pieceGRY;
            public GreenYellowOrange _pieceGYO;

            public ClassBackside(BlueOrangeYellow par_BOY,
                                    BlueYellowRed par_BYR,
                                    GreenRedYellow par_GRY,
                                    GreenYellowOrange par_GYO)
            {
                //
                // Added 11/12/2020 thomas downes
                //
                _pieceBOY = par_BOY;
                _pieceBYR = par_BYR;
                _pieceGRY = par_GRY;
                _pieceGYO = par_GYO;

                // Added 1/11/2021 thomas Downes
                base.Piece1 = _pieceBOY;
                base.Piece2 = _pieceBYR;
                base.Piece3 = _pieceGRY;
                base.Piece4 = _pieceGYO;

                // Added 4/02/2021 thomas Downes
                base.Piece1.FrontOrBackOfCube = EnumFrontOrBack.Back;
                base.Piece2.FrontOrBackOfCube = EnumFrontOrBack.Back;
                base.Piece3.FrontOrBackOfCube = EnumFrontOrBack.Back;
                base.Piece4.FrontOrBackOfCube = EnumFrontOrBack.Back;

                // Added 4/3/2021 thomas downes
                base.OriginalBack = true;
                base.OriginalFront = false;

            }


            public ClassBackside(string par_stringBriefToBeParsed)
            {
                //
                // Added 11/20/2020 thomas downes  
                //
                // Example #1:
                //
                //     BOY/NE==F1:N_F2:E_F3:F  BYR/SE==F1:S_F2:E_F3:F  GRY/SW==F1:F_F2:W_F3:S  GYO/NW==F1:N_F2:F_F3:W
                //
                // Example #2:
                //
                //     BOY/SW==F1:S_F2:W_F3:F  BYR/NE==F1:N_F2:E_F3:F  GRY/SE==F1:F_F2:E_F3:S  GYO/NW==F1:N_F2:F_F3:W
                //
                //     (F = Front Face) 
                //
                char[] separators = new char[] { ' ' };
                string[] parsedByFour = par_stringBriefToBeParsed.Split(separators, 4);

                // _pieceBOY = new BlueOrangeYellow(this, parsedByFour[0]);
                // _pieceBYR = new BlueYellowRed(this, parsedByFour[1]);
                // _pieceGRY = new GreenRedYellow(this, parsedByFour[2]);
                // _pieceGYO = new GreenYellowOrange(this, parsedByFour[3]);

                _pieceBOY = new BlueOrangeYellow(parsedByFour[0]);
                _pieceBYR = new BlueYellowRed(parsedByFour[1]);
                _pieceGRY = new GreenRedYellow(parsedByFour[2]);
                _pieceGYO = new GreenYellowOrange(parsedByFour[3]);

                //
                // Encapsulated 6/3/2021
                //
                CommonConstructorWork();


            }


            public ClassBackside(string par_briefDescription_BOY,
                string par_briefDescription_BYR,
                string par_briefDescription_GRY,
                string par_briefDescription_GYO)
            {
                //
                // Added 12/20/2020 thomas downes
                //
                var objBackside = ClassBacksideBrief.Deserialize(par_briefDescription_BOY, par_briefDescription_BYR,
                                                                 par_briefDescription_GRY, par_briefDescription_GYO);

                _pieceBOY = objBackside._pieceBOY;
                _pieceBYR = objBackside._pieceBYR;
                _pieceGRY = objBackside._pieceGRY;
                _pieceGYO = objBackside._pieceGYO;

                // Added 1/11/2021 thomas Downes
                //base.Piece1 = _pieceBOY;
                //base.Piece2 = _pieceBYR;
                //base.Piece3 = _pieceGRY;
                //base.Piece4 = _pieceGYO;

                //// Added 4/02/2021 thomas Downes
                //base.Piece1.FrontOrBackOfCube = EnumFrontOrBack.Back;
                //base.Piece2.FrontOrBackOfCube = EnumFrontOrBack.Back;
                //base.Piece3.FrontOrBackOfCube = EnumFrontOrBack.Back;
                //base.Piece4.FrontOrBackOfCube = EnumFrontOrBack.Back;

                //// Added 4/3/2021 thomas downes
                //base.OriginalBack = true;
                //base.OriginalFront = false;

                //
                // Encapsulated 6/3/2021 
                //
                CommonConstructorWork();


            }


            public ClassBackside()
            {
                //
                // Added 1/13/2021 thomas downes  
                //
                //_pieceBOY = new Back.BlueOrangeYellow(); base.Piece1 = _pieceBOY;
                //_pieceBYR = new Back.BlueYellowRed(); base.Piece2 = _pieceBYR;
                //_pieceGRY = new Back.GreenRedYellow(); base.Piece3 = _pieceGRY;
                //_pieceGYO = new Back.GreenYellowOrange(); base.Piece4 = _pieceGYO;

                //_pieceBOY = new Back.BlueOrangeYellow(this); base.Piece1 = _pieceBOY;
                //_pieceBYR = new Back.BlueYellowRed(this); base.Piece2 = _pieceBYR;
                //_pieceGRY = new Back.GreenRedYellow(this); base.Piece3 = _pieceGRY;
                //_pieceGYO = new Back.GreenYellowOrange(this); base.Piece4 = _pieceGYO;

                _pieceBOY = new Back.BlueOrangeYellow(); base.Piece1 = _pieceBOY;
                _pieceBYR = new Back.BlueYellowRed(); base.Piece2 = _pieceBYR;
                _pieceGRY = new Back.GreenRedYellow(); base.Piece3 = _pieceGRY;
                _pieceGYO = new Back.GreenYellowOrange(); base.Piece4 = _pieceGYO;

                // Added 1/11/2021 thomas Downes
                //base.Piece1 = _pieceBOY;
                //base.Piece2 = _pieceBYR;
                //base.Piece3 = _pieceGRY;
                //base.Piece4 = _pieceGYO;

                //// Added 4/02/2021 thomas Downes
                //base.Piece1.FrontOrBackOfCube = EnumFrontOrBack.Back;
                //base.Piece2.FrontOrBackOfCube = EnumFrontOrBack.Back;
                //base.Piece3.FrontOrBackOfCube = EnumFrontOrBack.Back;
                //base.Piece4.FrontOrBackOfCube = EnumFrontOrBack.Back;

                //// Added 4/3/2021 thomas downes
                //base.OriginalBack = true;
                //base.OriginalFront = false;

                //
                // Encapsulated 6/3/2021 
                //
                CommonConstructorWork();

            }


            private void CommonConstructorWork()
            {
                //
                // Copied & encapsulated 6/3/2021 thomas downes
                //

                // Added 1/11/2021 thomas Downes
                base.Piece1 = _pieceBOY;
                base.Piece2 = _pieceBYR;
                base.Piece3 = _pieceGRY;
                base.Piece4 = _pieceGYO;

                // Added 4/02/2021 thomas Downes
                base.Piece1.FrontOrBackOfCube = EnumFrontOrBack.Back;
                base.Piece2.FrontOrBackOfCube = EnumFrontOrBack.Back;
                base.Piece3.FrontOrBackOfCube = EnumFrontOrBack.Back;
                base.Piece4.FrontOrBackOfCube = EnumFrontOrBack.Back;

                // Added 4/3/2021 thomas downes
                base.OriginalBack = true;
                base.OriginalFront = false;

            }



            public override void LoadInitialPositions()
            {
                //throw new NotImplementedException();

                _pieceBOY.FrontClockFacePosition = FrontClockFace.ten_thirty;
                _pieceBOY.ReorientPiece_FrontFaceIsFace3(FrontClockFace.ten_thirty);

                _pieceBYR.FrontClockFacePosition = FrontClockFace.seven_thirty;
                _pieceBYR.ReorientPiece_FrontFaceIsFace3(FrontClockFace.seven_thirty);

                //throw new NotImplementedException();

                _pieceGRY.FrontClockFacePosition = FrontClockFace.four_thirty;
                _pieceGRY.ReorientPiece_FrontFaceIsFace2(FrontClockFace.four_thirty);

                _pieceGYO.FrontClockFacePosition = FrontClockFace.one_thirty;
                _pieceGYO.ReorientPiece_FrontFaceIsFace2(FrontClockFace.one_thirty);

            }


            public override void Simple_Clockwise90()
            {
                //
                // Added 11/12/2020 thomas downes
                //
                _pieceBOY.Revolve_Clockwise90();
                _pieceBYR.Revolve_Clockwise90();
                _pieceGRY.Revolve_Clockwise90();
                _pieceGYO.Revolve_Clockwise90();

            }


            public void ComplexRules_FrontPieceRotation()
            {
                //
                // Added 12/9/2020 Thomas Downes  
                //
                ComplexRevolution();

            }

            public void ComplexRules_AdjacentPairExchange()
            {
                //
                // Added 12/9/2020 Thomas Downes  
                //
                //ComplexPieceMove move1_from130; // = new ComplexPieceMove();
                //ComplexPieceMove move2_from430;
                //ComplexPieceMove move3_from730;
                //ComplexPieceMove move4_from1030;

                //Rules_AdjacentPairExchange.BuildBacksideRules();
                //move1_from130 = Rules_AdjacentPairExchange.backside_move1_from130;
                //move2_from430 = Rules_AdjacentPairExchange.backside_move2_from430;
                //move3_from730 = Rules_AdjacentPairExchange.backside_move3_from730;
                //move4_from1030 = Rules_AdjacentPairExchange.backside_move4_from1030;

                RubiksPieceCorner beforePiece430;  // For testing only. 
                RubiksPieceCorner beforePiece1030;   // For testing only. 
                FrontClockFace test_position430_Before;
                FrontClockFace test_position430_After;
                FrontClockFace test_position1030_Before;
                FrontClockFace test_position1030_After;

                //
                // Testing, before. 
                //
                beforePiece430 = this.GetPiece(FrontClockFace.four_thirty);
                beforePiece1030 = this.GetPiece(FrontClockFace.ten_thirty);

                test_position430_Before = beforePiece430.FrontClockFacePosition;
                test_position1030_Before = beforePiece1030.FrontClockFacePosition;

                //
                // Do the work!!  
                //
                var complex_rules = Rules_AdjacentPairExchange.GetBacksideRules();
                base.ComplexRules_Perform(complex_rules);

                //
                // Testing, after. 
                //
                test_position430_After = beforePiece430.FrontClockFacePosition;
                test_position1030_After = beforePiece1030.FrontClockFacePosition;

                bool boolNoChange430 = (test_position430_Before == test_position430_After);
                bool boolNoChange1030 = (test_position1030_Before == test_position1030_After);

                //if (boolNoChange430) MessageBox.Show("The backside piece at 4:30 has not moved.");
                //if (boolNoChange1030) MessageBox.Show("The backside piece at 10:30 has not moved.");

            }


            public override void ComplexRevolution()
            {
                //
                // Added 11/13/2020 thomas downes
                //
                FrontClockFace temp = _pieceBOY.FrontClockFacePosition;
                //_pieceBOY.FrontClockFacePosition = _pieceBYR.FrontClockFacePosition;
                //_pieceBYR.FrontClockFacePosition = _pieceGRY.FrontClockFacePosition;
                //_pieceGRY.FrontClockFacePosition = _pieceGYO.FrontClockFacePosition;
                //_pieceGYO.FrontClockFacePosition = temp;

                //_pieceBOY.ReorientPiece(_pieceBYR.FrontClockFacePosition, Color.Orange);
                //_pieceBYR.ReorientPiece( _pieceGRY.FrontClockFacePosition, Color.Yellow);
                //_pieceGRY.ReorientPiece(_pieceGYO.FrontClockFacePosition, Color.Lime);
                //_pieceGYO.ReorientPiece(temp, Color.Yellow);

                const bool c_boolEncapsulateRulesInStaticClass = true;

                ComplexPieceMove move1_from130; // = new ComplexPieceMove();
                ComplexPieceMove move2_from430;
                ComplexPieceMove move3_from730;
                ComplexPieceMove move4_from1030;
                ComplexPieceMove move5_Clockwise90;

                if (c_boolEncapsulateRulesInStaticClass)
                {
                    //
                    // New way, encapsulation of rules into a static class.
                    //      ----Added 11/15/2020 thomas
                    //
                    Rules_FrontPieceRotation.BuildComplexRotationRules();
                    move1_from130 = Rules_FrontPieceRotation.move1_from130;
                    move2_from430 = Rules_FrontPieceRotation.move2_from430;
                    move3_from730 = Rules_FrontPieceRotation.move3_from730;
                    move4_from1030 = Rules_FrontPieceRotation.move4_from1030;
                    //Added 11/18/2020 thomas downes
                    move5_Clockwise90 = Rules_FrontPieceRotation.move5_clockwise90;

                }
                else
                {
                    //
                    // Old way, without encapsulation of rules. 
                    //
                    move1_from130.StartingPoint = FrontClockFace.one_thirty;
                    move1_from130.EndingPoint = EnumAll12Faces.F0430;

                    move2_from430.StartingPoint = FrontClockFace.four_thirty;
                    move2_from430.EndingPoint = EnumAll12Faces._730_SSW;

                    move3_from730.StartingPoint = FrontClockFace.seven_thirty;
                    move3_from730.EndingPoint = EnumAll12Faces._1030_NNW;

                    move4_from1030.StartingPoint = FrontClockFace.ten_thirty;
                    //move4.StartingPoint = FrontClockFace.ten_thirty;
                    move4_from1030.EndingPoint = EnumAll12Faces._130_ENE;
                }


                //
                // Implementing the movements described above, as follows: 
                //
                RubiksPieceCorner piece_starting_at_130 = GetPieceAtPosition(FrontClockFace.one_thirty);
                RubiksPieceCorner piece_starting_at_430 = GetPieceAtPosition(FrontClockFace.four_thirty);
                RubiksPieceCorner piece_starting_at_730 = GetPieceAtPosition(FrontClockFace.seven_thirty);
                RubiksPieceCorner piece_starting_at_1030 = GetPieceAtPosition(FrontClockFace.ten_thirty);

                //piece_starting_at_130.ReorientPiece_Complex(move1.EndingPoint);
                //piece_starting_at_430.ReorientPiece_Complex(move2.EndingPoint);
                //piece_starting_at_730.ReorientPiece_Complex(move3.EndingPoint);
                //piece_starting_at_1030.ReorientPiece_Complex(move4.EndingPoint);

                //piece_starting_at_130.ReorientPiece_Complex(piece_starting_at_130.WhichFaceIsFront, move1.EndingPoint);
                //piece_starting_at_430.ReorientPiece_Complex(piece_starting_at_430.WhichFaceIsFront, move2.EndingPoint);
                //piece_starting_at_730.ReorientPiece_Complex(piece_starting_at_730.WhichFaceIsFront, move3.EndingPoint);
                //piece_starting_at_1030.ReorientPiece_Complex(piece_starting_at_1030.WhichFaceIsFront, move4.EndingPoint);

                const bool c_boolEncapsulateRuleImplementation = true;  // false;

                if (c_boolEncapsulateRuleImplementation)
                {
                    //
                    //First, set the clock position of the piece.   
                    //    ----11/18/2020 thomas downes
                    //
                    const bool c_boolOnlySetClockPosition = true;
                    piece_starting_at_130.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint, c_boolOnlySetClockPosition);
                    piece_starting_at_430.ReorientPiece_Complex(move2_from430.StartingPoint, move2_from430.EndingPoint, c_boolOnlySetClockPosition);
                    piece_starting_at_730.ReorientPiece_Complex(move3_from730.StartingPoint, move3_from730.EndingPoint, c_boolOnlySetClockPosition);
                    piece_starting_at_1030.ReorientPiece_Complex(move4_from1030.StartingPoint, move4_from1030.EndingPoint, c_boolOnlySetClockPosition);

                    //
                    // Use the static class, ComplexRulesEngine.  
                    //
                    // Move #1 of 5. 
                    //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
                    ComplexRulesEngine0130.this_piece_startsAt_130 = piece_starting_at_130;
                    ComplexRulesEngine0130.this_complex_move = move1_from130;
                    ComplexRulesEngine0130.FrontFace_130_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

                    // Move #2 of 5. 
                    //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
                    ComplexRulesEngine0430.this_piece_startsAt_430 = piece_starting_at_430;
                    ComplexRulesEngine0430.this_complex_move = move2_from430;
                    ComplexRulesEngine0430.FrontFace_430_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

                    // Move #3 of 5. 
                    //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
                    ComplexRulesEngine0730.this_piece_startsAt_730 = piece_starting_at_730;
                    ComplexRulesEngine0730.this_complex_move = move3_from730;
                    ComplexRulesEngine0730.FrontFace_730_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

                    // Move #4 of 5. 
                    //ComplexRulesEngine.FrontFace_1030_ReorientTo(move1_from130.StartingPoint, move1_from130.EndingPoint);
                    ComplexRulesEngine1030.this_piece_startsAt_1030 = piece_starting_at_1030;
                    ComplexRulesEngine1030.this_complex_move = move4_from1030;
                    ComplexRulesEngine1030.FrontFace_1030_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

                    //
                    // Move #5 of 5.    ----11/18/2020 thomas d. 
                    //
                    if (move5_Clockwise90.ClockwiseRevolution90_Deprecated)
                    {
                        // Added 11/18/2020 td 
                        piece_starting_at_130.Revolve_Clockwise90();
                        piece_starting_at_430.Revolve_Clockwise90();
                        piece_starting_at_730.Revolve_Clockwise90();
                        piece_starting_at_1030.Revolve_Clockwise90();

                    }

                    //
                    // Debugging!!!!!
                    //
                    // As a check, let's count the number of side faces with valid colors. 
                    //
                    //
                    int intCountValidSidefaces = 0;
                    //Check the enumerated value.
                    Func<EnumFaceNum, bool> isValidFace = enumFN =>
                       (enumFN == EnumFaceNum.Face1 || enumFN == EnumFaceNum.Face2 || enumFN == EnumFaceNum.Face3);

                    if (isValidFace(_pieceBOY.WhichFaceIsN_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceBOY.WhichFaceIsE_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceBOY.WhichFaceIsS_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceBOY.WhichFaceIsW_of_front)) intCountValidSidefaces++;

                    if (isValidFace(_pieceBYR.WhichFaceIsN_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceBYR.WhichFaceIsE_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceBYR.WhichFaceIsS_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceBYR.WhichFaceIsW_of_front)) intCountValidSidefaces++;

                    if (isValidFace(_pieceGRY.WhichFaceIsN_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceGRY.WhichFaceIsE_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceGRY.WhichFaceIsS_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceGRY.WhichFaceIsW_of_front)) intCountValidSidefaces++;

                    if (isValidFace(_pieceGYO.WhichFaceIsN_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceGYO.WhichFaceIsE_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceGYO.WhichFaceIsS_of_front)) intCountValidSidefaces++;
                    if (isValidFace(_pieceGYO.WhichFaceIsW_of_front)) intCountValidSidefaces++;

                    //The count should be 8. 
                    if (8 != intCountValidSidefaces) throw new NotImplementedException();

                    //
                    // More checks. 
                    //
                    if (_pieceBOY.FrontClockFacePosition == FrontClockFace.ten_thirty)
                    {
                        if (_pieceBOY.WhichFaceIsW_of_front == EnumFaceNum.NotApplicable_DifferentPiece)
                        {
                            throw new NotImplementedException();
                        }
                    }


                }
                else
                {
                    piece_starting_at_130.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
                    piece_starting_at_430.ReorientPiece_Complex(move2_from430.StartingPoint, move2_from430.EndingPoint);
                    piece_starting_at_730.ReorientPiece_Complex(move3_from730.StartingPoint, move3_from730.EndingPoint);
                    piece_starting_at_1030.ReorientPiece_Complex(move4_from1030.StartingPoint, move4_from1030.EndingPoint);
                }

            }

            private RubiksPieceCorner GetPieceAtPosition(FrontClockFace par_enum)
            {
                //
                // Added 11/14/2020 thomas downes   
                //
                if (_pieceBOY.FrontClockFacePosition == par_enum) return _pieceBOY;
                else if (_pieceBYR.FrontClockFacePosition == par_enum) return _pieceBYR;
                else if (_pieceGRY.FrontClockFacePosition == par_enum) return _pieceGRY;
                else if (_pieceGYO.FrontClockFacePosition == par_enum) return _pieceGYO;
                else return null;

            }


            public override void Simple_Counterwise90()
            {
                //
                // Added 11/12/2020 thomas downes
                //


            }

            //Added 11/13/2020 thomas downes
            public override bool SideIsASolidColor()
            {
                //
                // Added 11/13/2020 thomas downes
                //
                Color colorOfSide = _pieceBOY.GetColorOfFrontFace();

                return (colorOfSide == _pieceBYR.GetColorOfFrontFace()) &&
                       (colorOfSide == _pieceGRY.GetColorOfFrontFace()) &&
                       (colorOfSide == _pieceGYO.GetColorOfFrontFace());

            }


            //Added 1/07/2021 thomas downes
            public bool SideIsASolidColor_AndSidesMatch()
            {
                //
                // Added 1/07/2021 thomas downes
                //
                bool bSideIsASolidColor = SideIsASolidColor();
                bool bSidesMatch = false;



                // Added 1/7/2021 Thomas Downes
                return (bSideIsASolidColor && bSidesMatch);

            }


            //Added 11/17/2020 thomas downes
            //
            public override RubiksPieceCorner WhichPieceIsClicked(Point par_point)
            {
                //
                // Added 11/17/2020 thomas downes
                //
                return WhichPieceHasMouseHover(par_point);

            }

            //Added 11/17/2020 thomas downes
            //
            public RubiksPieceCorner WhichPieceIsClicked(int par_pointX, int par_pointY)
            {
                //
                // Added 11/17/2020 thomas downes
                //
                return WhichPieceHasMouseHover(new Point(par_pointX, par_pointY));

            }


            //Added 6/18/2021 thomas downes
            //
            public RubiksPieceCorner WhichPieceIsClicked_FaceTile(int par_pointX, int par_pointY, ref RubiksFaceTile output_tile)
            {
                //
                // Added 11/17/2020 thomas downes
                //
                //return WhichPieceHasMouseHover(new Point(par_pointX, par_pointY), ref par_tile);

                var new_point_from_param = new Point(par_pointX, par_pointY);

                const bool c_boolHardWay = false;

                if (c_boolHardWay)
                {
                    //
                    // -----Obselete code-----
                    //
                    // The following code is obselete. 
                    //
                    var new_tile = new RubiksFaceTile();
                    new_tile.Enum_FacePositionNSWE = EnumFacePositionNSWE.FrontFacing;
                    if (_pieceBOY.FrontFaceWasClicked(new_point_from_param)) new_tile.ThisCorner = _pieceBOY;
                    if (_pieceBYR.FrontFaceWasClicked(new_point_from_param)) new_tile.ThisCorner = _pieceBYR; //new_tile.Enum_FaceNum = EnumFaceNum.Face1; }
                    if (_pieceGRY.FrontFaceWasClicked(new_point_from_param)) new_tile.ThisCorner = _pieceGRY; //new_tile.Enum_FaceNum = EnumFaceNum.Face1; }
                    if (_pieceGYO.FrontFaceWasClicked(new_point_from_param)) new_tile.ThisCorner = _pieceGYO; //new_tile.Enum_FaceNum = EnumFaceNum.Face1; }
                    //return null
                    output_tile = new_tile;  // Added 6/18/2021 td

                    //Let's check to see if perhaps a Side Face was clicked. ----5/6/2021 Thomas Downes
                    return WhichPiece_SideFaceClicked(new_point_from_param.X, new_point_from_param.Y);
                }
                else
                {
                    //
                    // Smarter code. 
                    //
                    RubiksFaceTile new_tile = null;
                    if (new_tile == null) new_tile = this.Piece1.WhichTileWasClicked(new_point_from_param);
                    if (new_tile == null) new_tile = this.Piece2.WhichTileWasClicked(new_point_from_param);
                    if (new_tile == null) new_tile = this.Piece3.WhichTileWasClicked(new_point_from_param);
                    if (new_tile == null) new_tile = this.Piece4.WhichTileWasClicked(new_point_from_param);
                    output_tile = new_tile;
                    return new_tile.ThisCorner;
                }

            }


            //Added 11/17/2020 thomas downes
            //
            public override RubiksPieceCorner WhichPieceHasMouseHover(Point par_point)
            {
                //
                //Added 11/17/2020 thomas downes
                //
                //return null;

                if (_pieceBOY.FrontFaceWasClicked(par_point)) return _pieceBOY;
                if (_pieceBYR.FrontFaceWasClicked(par_point)) return _pieceBYR;
                if (_pieceGRY.FrontFaceWasClicked(par_point)) return _pieceGRY;
                if (_pieceGYO.FrontFaceWasClicked(par_point)) return _pieceGYO;
                //return null;

                //Let's check to see if perhaps a Side Face was clicked. ----5/6/2021 Thomas Downes
                return WhichPiece_SideFaceClicked(par_point.X, par_point.Y);

            }

            //Added 11/17/2020 thomas downes
            //
            public RubiksPieceCorner WhichPiece_SideFaceClicked(int par_pointX, int par_pointY)
            {
                //
                // Added 11/17/2020 thomas downes
                //
                Point par_point = new Point(par_pointX, par_pointY);

                if (_pieceBOY.SideFaceWasClicked(par_point)) return _pieceBOY;
                if (_pieceBYR.SideFaceWasClicked(par_point)) return _pieceBYR;
                if (_pieceGRY.SideFaceWasClicked(par_point)) return _pieceGRY;
                if (_pieceGYO.SideFaceWasClicked(par_point)) return _pieceGYO;
                return null;

            }


            public void GodlikeSwitch_BottomPieces()
            {
                //
                // Added 12/9/2020 thomas downes
                //
                // Using o'clock times, for the 2x2 front-facing pieces: 
                //
                //       [10:30] [1:30]   
                //       [ 7:30] [4:30]   
                //
                //   Using the points of the compass, for the front-facing pieces: 
                //
                //       [ NW ] [ NE ]  
                //       [ SW ] [ SE ]   
                //
                RubiksPieceCorner pieceSW = this.GetPiece(FrontClockFace.seven_thirty);
                RubiksPieceCorner pieceSE = this.GetPiece(FrontClockFace.four_thirty);

                GodlikeSwitch_Piece(pieceSW, pieceSE);

            }


            public override void GodlikeSwitch_Tile(RubiksFaceTile par_dragged, RubiksFaceTile par_replaced)
            {
                //
                // Added 5/12/2021 thomas downes
                //
                //  www ww,w,,,,,w,w,w,w,,
                throw new NotImplementedException();

            }


            public override void GodlikeSwitch_Piece(RubiksPieceCorner par_dragged, RubiksPieceCorner par_replaced)
            {
                //
                // Added 11/17/2020 thomas downes
                //
                base.GodlikeSwitch_Base(par_dragged, par_replaced);

                //FrontClockFace clock_dragged = par_dragged.FrontClockFacePosition;
                //FrontClockFace clock_replaced = par_replaced.FrontClockFacePosition;
                //FrontClockFace tempClock = FrontClockFace.unassigned;
                //FrontClockFace targetClock = FrontClockFace.unassigned;

                ////
                //// Position the dragged piece. 
                ////
                //targetClock = clock_replaced; // We will place the selected/dragged piece at the Replaced position.
                //do
                //{
                //    par_dragged.Revolve_Clockwise90();
                //    tempClock = par_dragged.FrontClockFacePosition;
                //} while (tempClock != targetClock);

                ////
                //// Position the replaced piece. 
                ////
                //targetClock = clock_dragged; // We will place the selected/dragged piece at the Replaced position.
                //do
                //{
                //    par_replaced.Revolve_Clockwise90();
                //    tempClock = par_replaced.FrontClockFacePosition;
                //} while (tempClock != targetClock);

            }


            //public override void GodlikeSwitch(RubiksFaceTile par_dragged, RubiksFaceTile par_replaced)
            //{
            //    //
            //    // Added 5/9/2021 thomas downes
            //    //
            //    base.GodlikeSwitch_Base(par_dragged, par_replaced);

            //}


                public string Brief_BOY ()
            {
                //Added 11/19/2020 thomas downes
                //
                // Example #1:
                //
                //     BOY/NE=F1:N_F2:E_F3:F 
                //
                // Example #1:
                //
                //     BOY/SW=F1:S_F2:W_F3:F
                //
                //     (F = Front Face) 
                //
                return _pieceBOY.ToString();
            }

            public string Brief_BYR()
            {
                //Added 11/19/2020 thomas downes
                //
                // Example #1:
                //
                //      BYR/NE=F1:N_F2:E_F3:F
                //
                // Example #1:
                //
                //      BYR/SW=F1:W_F2:S_F3:F  
                //
                //     (F = Front Face) 
                //
                return _pieceBYR.ToString();
            }

            public string Brief_GRY()
            {
                //Added 11/19/2020 thomas downes
                //
                // Example #1:
                //
                //      GRY/SE=F1:F_F2:E_F3:S 
                //
                // Example #1:
                //
                //      GRY/SW=F1:F_F2:W_F3:S 
                //
                //     (F = Front Face) 
                //
                return _pieceGRY.ToString();
            }

            public string Brief_GYO()
            {
                //Added 11/19/2020 thomas downes
                //
                // Example #1:
                //
                //     GYO/NW=F1:N_F2:F_F3:W
                //
                // Example #1:
                //
                //     GYO/SE=F1:S_F2:F_F3:E
                //
                //     (F = Front Face) 
                //
                return _pieceGYO.ToString();
            }


            public override string ToString()
            {
                //
                // Added 11/20/2020 thomas downes
                //
                //return base.ToString();

                string strBriefDescription = (new Back.ClassBacksideBrief(this)).PositionsBrief;

                return strBriefDescription; 

            }

            private bool _bPriorFunctionValue_NotInUse; //Deprecated,   Not in use. 1/9/21 Added 12/1/2020 td 
            private bool _bPriorFunctionValue_PiecesCorrectlyOrdered; //Added 1/09/2021 td 

            public bool IsSolved()
            {
                //
                // Added 6/3/2021 thomas downes  
                //
                //Added 12/1/2020 thomas
                bool bPriorValue = false; //Added 12/1/2020 thomas
                bool bCorrectlyOrdered = (this.PiecesAreCorrectlyOrdered(out bPriorValue));

                //
                // Added 6/10/2021 Thomas Downes
                //
                Color color_Piece1 = base.Piece1.GetColorOfFrontFace();
                Color color_Piece2 = base.Piece2.GetColorOfFrontFace();
                Color color_Piece3 = base.Piece3.GetColorOfFrontFace();
                Color color_Piece4 = base.Piece4.GetColorOfFrontFace();

                bool bAllFrontFaceColorsMatch =
                    (color_Piece1 == color_Piece2) &&
                    (color_Piece2 == color_Piece3) &&
                    (color_Piece3 == color_Piece4);

                bool boolIsSolved = (bCorrectlyOrdered && bAllFrontFaceColorsMatch);
                return boolIsSolved;

            }


            public bool PiecesAreCorrectlyOrdered(out bool par_priorOutput)
            {
                //
                //  Added 12/01/2020 thomas  
                //
                bool priorOutput_BOY_BYR = false;
                bool bPiecesInOrder_BOY_BYR = PiecesAreCorrectlyOrdered_BOY_BYR(out priorOutput_BOY_BYR);

                //bool priorOutput_BOY_GYO = false;
                bool bPiecesInOrder_BOY_GYO = PiecesAreCorrectlyOrdered_BOY_GYO(); // out priorOutput_BOY_GYO);

                //par_priorOutput = priorOutput_BOY_BYR;
                bool bOutputValue;
                bOutputValue = (bPiecesInOrder_BOY_BYR && bPiecesInOrder_BOY_GYO);
                //return bOutputValue;   // (bPiecesInOrder_BOY_BYR && bPiecesInOrder_BOY_GYO);

                //return (boolean1 && boolean2);
                bool bNewOutputValue = bOutputValue; // (boolean1 && boolean2);
                par_priorOutput = _bPriorFunctionValue_PiecesCorrectlyOrdered;
                _bPriorFunctionValue_PiecesCorrectlyOrdered = bNewOutputValue;
                return bNewOutputValue;

            }

            public bool PiecesAreCorrectlyOrdered_BOY_BYR(out bool par_priorOutput)
            {
                //
                //  Added 12/01/2020 thomas  
                //
                //     BOY - BYR - GRY - GYO    
                //

                //bool bPieceBOY_nextTo_BYR;
                //bool bPieceBOY_nextTo_GYO;

                //bool bPieceBYR_nextTo_GRY;
                //bool bPieceBYR_nextTo_BOY;  // Redundant, perhaps. 

                //bool bPieceGYO_nextTo_GRY;
                //bool bPieceGYO_nextTo_BOY;  // Redundant, perhaps. 

                //bool bPieceGRY_nextTo_GYO;  // Redundant, perhaps. 
                //bool bPieceGRY_nextTo_BYR;  // Redundant, perhaps. 

                bool bPieceBOY_nextClockwiseFrom_BYR = PieceBOY_nextClockwiseFrom_BYR();
                bool bPieceBYR_nextClockwiseFrom_GRY = PieceBYR_nextClockwiseFrom_GRY();
                bool bPieceGRY_nextClockwiseFrom_GYO = PieceGRY_nextClockwiseFrom_GYO();
                bool bPieceGYO_nextClockwiseFrom_BOY = PieceGYO_nextClockwiseFrom_BOY();

                bool boolean1 = (bPieceBOY_nextClockwiseFrom_BYR && bPieceBYR_nextClockwiseFrom_GRY);
                bool boolean2 = (bPieceGRY_nextClockwiseFrom_GYO && bPieceGYO_nextClockwiseFrom_BOY);

                //return (boolean1 && boolean2);
                bool bNewOutputValue = (boolean1 && boolean2);
                par_priorOutput = _bPriorFunctionValue_NotInUse;
                _bPriorFunctionValue_NotInUse = bNewOutputValue;
                return bNewOutputValue; 

            }

            public bool PiecesAreCorrectlyOrdered_BOY_GYO() // (out bool par_bPriorOutput)
            {
                //
                //  Added 1/08/2021 thomas  
                //
                //     BOY - GYO - GRY - BYR      
                //
                bool b1PieceBOY_nextClockwiseFrom_GYO = PieceBOY_nextClockwiseFrom_GYO();
                bool b2PieceGYO_nextClockwiseFrom_GRY = PieceGYO_nextClockwiseFrom_GRY();
                bool b3PieceGRY_nextClockwiseFrom_BYR = PieceGRY_nextClockwiseFrom_BYR();
                bool b4PieceBYR_nextClockwiseFrom_BOY = PieceBYR_nextClockwiseFrom_BOY();

                bool boolean1_and2 = (b1PieceBOY_nextClockwiseFrom_GYO && b2PieceGYO_nextClockwiseFrom_GRY);
                bool boolean3_and4 = (b3PieceGRY_nextClockwiseFrom_BYR && b4PieceBYR_nextClockwiseFrom_BOY);

                //return (boolean1 && boolean2);
                bool bNewOutputValue = (boolean1_and2 && boolean3_and4);
                //par_priorOutput = _bPriorFunctionValue;
                //_bPriorFunctionValue = bNewOutputValue;
                return bNewOutputValue;

            }


            private bool PieceBOY_nextClockwiseFrom_BYR()
            {
                //---private bool PieceBOY_nextTo_BYR()
                //
                // Added 12/1/2020 thomas downes
                //
                return EnumStaticClass.AdjacentClockwise(_pieceBYR, _pieceBOY);

            }


            private bool PieceGYO_nextClockwiseFrom_BOY()
            {
                //
                // Added 12/1/2020 thomas downes
                //
                return EnumStaticClass.AdjacentClockwise(_pieceBOY, _pieceGYO);

            }


            private bool PieceGRY_nextClockwiseFrom_GYO()
            {
                //
                // Added 12/1/2020 thomas downes
                //
                return EnumStaticClass.AdjacentClockwise(_pieceGYO, _pieceGRY);  

            }


            private bool PieceBYR_nextClockwiseFrom_GRY()
            {
                //
                // Added 12/1/2020 thomas downes
                //
                return EnumStaticClass.AdjacentClockwise(_pieceGRY, _pieceBYR);
            }

            private bool PieceBOY_nextClockwiseFrom_GYO()
            {
                //
                // Added 1/08/2021 thomas downes
                //
                return EnumStaticClass.AdjacentClockwise(_pieceGYO, _pieceBOY);
            }

            private bool PieceGYO_nextClockwiseFrom_GRY()
            {
                //
                // Added 1/08/2021 thomas downes
                //
                return EnumStaticClass.AdjacentClockwise(_pieceGRY, _pieceGYO);
            }

            private bool PieceGRY_nextClockwiseFrom_BYR()
            {
                //
                // Added 1/08/2021 thomas downes
                //
                return EnumStaticClass.AdjacentClockwise(_pieceBYR, _pieceGRY);
            }

            private bool PieceBYR_nextClockwiseFrom_BOY()
            {
                //
                // Added 1/08/2021 thomas downes
                //
                return EnumStaticClass.AdjacentClockwise(_pieceBOY, _pieceBYR);
            }



            public string BOY_etc_Clockwise()
            {
                //
                // Added 12/4/2020 thomas downes  
                //
                string strOutput = "BOY, ";

                RubiksPieceCorner piece1 = _pieceBOY;
                RubiksPieceCorner piece2 = _pieceBOY.NextPieceClockwise(this);
                RubiksPieceCorner piece3 = piece2.NextPieceClockwise(this);
                RubiksPieceCorner piece4 = piece3.NextPieceClockwise(this);

                strOutput += piece2.GetColorAbbreviationXYZ() + ", ";
                strOutput += piece3.GetColorAbbreviationXYZ() + ", ";
                strOutput += piece4.GetColorAbbreviationXYZ();

                return strOutput;

            }


            public bool AdjacentPieces(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2)
            {
                //
                // Added 12/07/2020 thomas downes
                //
                bool bAdjacentClockwise_1_2 = EnumStaticClass.AdjacentClockwise(par_piece1, par_piece2);
                bool bAdjacentClockwise_2_1 = EnumStaticClass.AdjacentClockwise(par_piece2, par_piece1);

                bool bEitherWay = (bAdjacentClockwise_1_2 || bAdjacentClockwise_2_1);
                return bEitherWay;

            }


            //public bool AdjacentPieces(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
            //{
            //    //
            //    // Added 12/07/2020 thomas downes
            //    //
            //    bool bPiecesAreRecognized = PiecesBelongToThisSide(par_piece1, par_piece2);
            //    if (!bPiecesAreRecognized) throw new ArgumentOutOfRangeException();
            //
            //    bool bAdjacentClockwise_1_2 = EnumStaticClass.AdjacentClockwise(par_piece1, par_piece2);
            //    bool bAdjacentClockwise_2_1 = EnumStaticClass.AdjacentClockwise(par_piece2, par_piece1);
            //
            //    bool bEitherWay = (bAdjacentClockwise_1_2 || bAdjacentClockwise_2_1);
            //    return bEitherWay;
            //
            //}


            public override bool PiecesAreAdjacent(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2)
            {
                //
                // Added 12/07/2020 thomas downes
                //
                bool bPiecesAreRecognized = PiecesBelongToThisSide(par_piece1, par_piece2);
                if (!bPiecesAreRecognized) throw new ArgumentOutOfRangeException();

                bool bAdjacentClockwise_1_2 = EnumStaticClass.AdjacentClockwise(par_piece1, par_piece2);
                bool bAdjacentClockwise_2_1 = EnumStaticClass.AdjacentClockwise(par_piece2, par_piece1);

                bool bEitherWay = (bAdjacentClockwise_1_2 || bAdjacentClockwise_2_1);
                return bEitherWay;

            }


            public override bool PiecesAreAdjacent_Clockwise(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2)
            {
                //
                // Added 12/07/2020 thomas downes
                //
                bool bPiecesAreRecognized = PiecesBelongToThisSide(par_piece1, par_piece2);
                if (!bPiecesAreRecognized) throw new ArgumentOutOfRangeException();

                bool bAdjacentClockwise_1_2 = EnumStaticClass.AdjacentClockwise(par_piece1, par_piece2);
                //----bool bAdjacentClockwise_2_1 = EnumStaticClass.AdjacentClockwise(par_piece2, par_piece1);

                //---bool bEitherWay = (bAdjacentClockwise_1_2 || bAdjacentClockwise_2_1);
                //---return bEitherWay;

                return bAdjacentClockwise_1_2;

            }


            public override bool PiecesAre_BottomSWSE(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2)
            {
                //
                // Added 12/8/2020 Thomas Downes 
                //
                //throw new NotImplementedException();
                bool bPiecesAreRecognized = PiecesBelongToThisSide(par_piece1, par_piece2);
                if (!bPiecesAreRecognized) throw new ArgumentOutOfRangeException();

                bool bOutputValue; 
                bOutputValue = base.PiecesAre_BottomSWSE_Base(par_piece1, par_piece2);
                return bOutputValue;

                //FrontClockFace position1 = par_piece1.FrontClockFacePosition;
                //FrontClockFace position2 = par_piece2.FrontClockFacePosition;

                //bool bPosition1_SW = (position1 == FrontClockFace.seven_thirty);
                //bool bPosition1_SE = (position1 == FrontClockFace.four_thirty);
                //bool bPosition2_SW = (position2 == FrontClockFace.seven_thirty);
                //bool bPosition2_SE = (position2 == FrontClockFace.four_thirty);

                //bool b_1SW_2SE = (bPosition1_SW && bPosition2_SE);
                //bool b_1SE_2SW = (bPosition1_SE && bPosition2_SW);

                //bool bOutputValue = (b_1SE_2SW || b_1SW_2SE);
                //return bOutputValue; 

            }


            public override bool PiecesBelongToThisSide(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2)
            {
                //
                // Added 12/8/2020 Thomas Downes 
                //
                //throw new NotImplementedException();

                bool bPiece1_okay;
                bool bPiece2_okay;

                bPiece1_okay = (par_piece1 == _pieceBOY || par_piece1 == _pieceBYR ||
                     par_piece1 == _pieceGRY || par_piece1 == _pieceGYO);

                bPiece2_okay = (par_piece2 == _pieceBOY || par_piece2 == _pieceBYR ||
                     par_piece2 == _pieceGRY || par_piece2 == _pieceGYO);

                return (bPiece1_okay && bPiece2_okay);

            }


            public override RubiksPieceCorner GetPiece(FrontClockFace par_enum)
            {
                //
                // Added 12/9/2020 thomas d. 
                //
                if (par_enum == _pieceBOY.FrontClockFacePosition) return _pieceBOY;
                if (par_enum == _pieceBYR.FrontClockFacePosition) return _pieceBYR;
                if (par_enum == _pieceGRY.FrontClockFacePosition) return _pieceGRY;
                if (par_enum == _pieceGYO.FrontClockFacePosition) return _pieceGYO;
                throw new ArgumentOutOfRangeException(); //return null; 

            }


            public void ParseBriefs_UpdatePositions(string par_strBriefDescriptionBOY, 
                                                  string par_strBriefDescriptionBYR, 
                                                  string par_strBriefDescriptionGRY,
                                                  string par_strBriefDescriptionGYO)
            {
                //
                // Added 12/20/2020 thomas downes
                //
                _pieceBOY.ParseBriefInputString_UpdatePosition(par_strBriefDescriptionBOY);
                _pieceBYR.ParseBriefInputString_UpdatePosition(par_strBriefDescriptionBYR);
                _pieceGRY.ParseBriefInputString_UpdatePosition(par_strBriefDescriptionGRY);
                _pieceGYO.ParseBriefInputString_UpdatePosition(par_strBriefDescriptionGYO);

            }


            public void PaintThisSide_NotInUse()
            {
                //
                // Not in use.  See the following:  
                //
            }

            public void RefreshThisSide_NotInUse()
            {
                //
                // Not in use.  See the following:  
                //
            }

            public void PaintThisSide_NotInUse(PaintEventArgs par_e, Form par_form, Panel par_panel = null, FormSolvingTool par_frmSolving = null)
            {
                //
                // Not in use.  See the following:  FormSolvingTool.private void Form1_Paint(object sender, PaintEventArgs e)
                //
                //var a_graphics = new System.Drawing.Graphics();  // e.Graphics;

                par_frmSolving.Form1_Paint(par_frmSolving, par_e);

            }


            public void PaintThisSide(System.Drawing.Graphics par_graphics, Point par_pointCenter)
            {
                //
                // Not in use.  See the following:    FormSolvingTool.private void Form1_Paint(object sender, PaintEventArgs e)
                //
                //var a_graphics = new System.Drawing.Graphics();  // e.Graphics;

                base.PaintThisSide_Base(par_graphics, par_pointCenter,
                        this._pieceBOY, this._pieceBYR,
                        this._pieceGRY, this._pieceGYO, 
                        EnumPrimaryView.Back);

                ////
                //// Step 1 of 2.  Paint the front faces.  (vs. sides) 
                ////
                ////   (Code copied from FormSolvingTool.Form1_Paint_BACK(PaintEventArgs e), 1/11/2021.)
                ////
                //this._pieceBOY.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                //this._pieceBYR.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                //this._pieceGRY.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                //this._pieceGYO.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);

                ////
                //// Step 2 of 2.  Paint the side faces.  
                ////
                ////   (Code copied from FormSolvingTool.Form1_Paint_BACK(PaintEventArgs e), 1/11/2021.)
                ////
                //this._pieceBOY.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                //this._pieceBYR.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                //this._pieceGRY.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                //this._pieceGYO.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);

            }


        }
    }
}
