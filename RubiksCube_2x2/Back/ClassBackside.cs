﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  //Added 11/13/2020 thomas downes

namespace RubiksCube_2x2
{
    namespace Back
    {
        //
        // Added 11/12/2020 thomas downes
        //

        class ClassBackside : BackOrFront
        {
            BlueOrangeYellow _pieceBOY;
            BlueYellowRed _pieceBYR;
            GreenRedYellow _pieceGRY;
            GreenYellowOrange _pieceGYO;

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
                    ComplexRules.BuildComplexRotationRules();
                    move1_from130 = ComplexRules.move1_from130;
                    move2_from430 = ComplexRules.move2_from430;
                    move3_from730 = ComplexRules.move3_from730;
                    move4_from1030 = ComplexRules.move4_from1030;
                    //Added 11/18/2020 thomas downes
                    move5_Clockwise90 = ComplexRules.move5_clockwise90;

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
                RubikPieceCorner piece_starting_at_130 = GetPieceAtPosition(FrontClockFace.one_thirty);
                RubikPieceCorner piece_starting_at_430 = GetPieceAtPosition(FrontClockFace.four_thirty);
                RubikPieceCorner piece_starting_at_730 = GetPieceAtPosition(FrontClockFace.seven_thirty);
                RubikPieceCorner piece_starting_at_1030 = GetPieceAtPosition(FrontClockFace.ten_thirty);

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

                    // Move #5 of 5.    ----11/18/2020 thomas d. 
                    if (move5_Clockwise90.ClockwiseRevolution90)
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

            private RubikPieceCorner GetPieceAtPosition(FrontClockFace par_enum)
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

            //Added 11/17/2020 thomas downes
            //
            public override RubikPieceCorner WhichPieceIsClicked(Point par_point)
            {
                //
                // Added 11/17/2020 thomas downes
                //
                return WhichPieceHasMouseHover(par_point);

            }

            //Added 11/17/2020 thomas downes
            //
            public RubikPieceCorner WhichPieceIsClicked(int par_pointX, int par_pointY)
            {
                //
                // Added 11/17/2020 thomas downes
                //
                return WhichPieceHasMouseHover(new Point(par_pointX, par_pointY));

            }

            //Added 11/17/2020 thomas downes
            //
            public override RubikPieceCorner WhichPieceHasMouseHover(Point par_point)
            {
                //
                //Added 11/17/2020 thomas downes
                //
                //return null;

                if (_pieceBOY.FrontFaceWasClicked(par_point)) return _pieceBOY;
                if (_pieceBYR.FrontFaceWasClicked(par_point)) return _pieceBYR;
                if (_pieceGRY.FrontFaceWasClicked(par_point)) return _pieceGRY;
                if (_pieceGYO.FrontFaceWasClicked(par_point)) return _pieceGYO;
                return null;

            }

            //Added 11/17/2020 thomas downes
            //
            public RubikPieceCorner WhichPiece_SideFaceClicked(int par_pointX, int par_pointY)
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


            public void GodlikeSwitch(RubikPieceCorner par_dragged, RubikPieceCorner par_replaced)
            {
                //
                // Added 11/17/2020 thomas downes
                //
                FrontClockFace clock_dragged = par_dragged.FrontClockFacePosition;
                FrontClockFace clock_replaced = par_replaced.FrontClockFacePosition;
                FrontClockFace tempClock = FrontClockFace.unassigned;
                FrontClockFace targetClock = FrontClockFace.unassigned;

                //
                // Position the dragged piece. 
                //
                targetClock = clock_replaced; // We will place the selected/dragged piece at the Replaced position.
                do
                {
                    par_dragged.Revolve_Clockwise90();
                    tempClock = par_dragged.FrontClockFacePosition;
                } while (tempClock != targetClock);

                //
                // Position the replaced piece. 
                //
                targetClock = clock_dragged; // We will place the selected/dragged piece at the Replaced position.
                do
                {
                    par_replaced.Revolve_Clockwise90();
                    tempClock = par_replaced.FrontClockFacePosition;
                } while (tempClock != targetClock);

            }


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


        }
    }
}