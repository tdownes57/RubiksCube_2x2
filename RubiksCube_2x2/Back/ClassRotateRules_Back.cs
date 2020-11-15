using System;
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

        class ClassRotateRules_Back : BackOrFront
        {
            BlueOrangeYellow _pieceBOY;
            BlueYellowRed _pieceBYR;
            GreenRedYellow _pieceGRY;
            GreenYellowOrange _pieceGYO; 

            public ClassRotateRules_Back(BlueOrangeYellow par_BOY, 
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
                _pieceBOY.Rotate_Clockwise90();
                _pieceBYR.Rotate_Clockwise90();
                _pieceGRY.Rotate_Clockwise90();
                _pieceGYO.Rotate_Clockwise90();

            }

            public override void ComplexRotation()
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

                ComplexPieceMove move1; // = new ComplexPieceMove();
                ComplexPieceMove move2;
                ComplexPieceMove move3;
                ComplexPieceMove move4;

                move1.StartingPoint = FrontClockFace.one_thirty;
                move1.EndingPoint = EnumAll12Faces.F0730;

                move2.StartingPoint = FrontClockFace.four_thirty;
                move2.EndingPoint = EnumAll12Faces._1030_WNW;

                move3.StartingPoint = FrontClockFace.seven_thirty;
                move3.EndingPoint = EnumAll12Faces._130_ENE;

                move4.StartingPoint = FrontClockFace.ten_thirty;
                //move4.StartingPoint = FrontClockFace.ten_thirty;
                move4.EndingPoint = EnumAll12Faces._430_SSE;

                //
                // Implementing the movements described above, as follows: 
                //
                RubikPieceCorner piece_starting_at_130 = GetPieceAtPosition(FrontClockFace.one_thirty);
                RubikPieceCorner piece_starting_at_430 = GetPieceAtPosition(FrontClockFace.four_thirty);
                RubikPieceCorner piece_starting_at_730 = GetPieceAtPosition(FrontClockFace.seven_thirty);
                RubikPieceCorner piece_starting_at_1030 = GetPieceAtPosition(FrontClockFace.ten_thirty);

                piece_starting_at_130.ReorientPiece_Complex(move1.EndingPoint);
                piece_starting_at_430.ReorientPiece_Complex(move2.EndingPoint);
                piece_starting_at_730.ReorientPiece_Complex(move3.EndingPoint);
                piece_starting_at_1030.ReorientPiece_Complex(move4.EndingPoint);


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

        }
    }
}
