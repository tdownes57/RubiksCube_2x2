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
                _pieceGRY.ReorientPiece_FrontFaceIsFace3(FrontClockFace.four_thirty);

                _pieceGYO.FrontClockFacePosition = FrontClockFace.one_thirty;
                _pieceGYO.ReorientPiece_FrontFaceIsFace3(FrontClockFace.one_thirty);

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

                _pieceBOY.ReorientPiece(_pieceBYR.FrontClockFacePosition, Color.Orange);
                _pieceBYR.ReorientPiece( _pieceGRY.FrontClockFacePosition, Color.Yellow);
                _pieceGRY.ReorientPiece(_pieceGYO.FrontClockFacePosition, Color.Lime);
                _pieceGYO.ReorientPiece(temp, Color.Yellow);

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
