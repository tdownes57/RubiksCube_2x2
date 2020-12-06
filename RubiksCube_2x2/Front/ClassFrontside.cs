using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  //Added 11/13/2020 thomas downes

namespace RubiksCube_2x2
{
    namespace Front
    {
        //
        // Added 11/13/2020 thomas downes
        //

        class ClassFrontside : BackOrFront    // class ClassRotateRules_Front : BackOrFront
        {
            BlueWhiteOrange _pieceBWO;
            BlueRedWhite _pieceBRW;
            GreenWhiteRed _pieceGWR;
            GreenOrangeWhite _pieceGOW; 

            public ClassFrontside(BlueWhiteOrange par_BWO, 
                                    BlueRedWhite par_BRW,
                                    GreenWhiteRed par_GWR,
                                    GreenOrangeWhite par_GOW)
            {
                //---class ClassRotateRules_Front : BackOrFront
                //
                // Added 11/12/2020 thomas downes
                //
                _pieceBWO = par_BWO;
                _pieceBRW = par_BRW;
                _pieceGOW = par_GOW;
                _pieceGWR = par_GWR;

            }

            public override void LoadInitialPositions()
            {
                //throw new NotImplementedException();

                _pieceBWO.FrontClockFacePosition = FrontClockFace.seven_thirty;
                _pieceBWO.ReorientPiece_FrontFaceIsFace2(FrontClockFace.seven_thirty);

                _pieceBRW.FrontClockFacePosition = FrontClockFace.ten_thirty;
                _pieceBRW.ReorientPiece_FrontFaceIsFace3(FrontClockFace.ten_thirty);

                _pieceGOW.FrontClockFacePosition = FrontClockFace.four_thirty;
                _pieceGOW.ReorientPiece_FrontFaceIsFace3(FrontClockFace.four_thirty);

                _pieceGWR.FrontClockFacePosition = FrontClockFace.one_thirty;
                _pieceGWR.ReorientPiece_FrontFaceIsFace2(FrontClockFace.one_thirty);

                //throw new NotImplementedException();


            }

            public override void Simple_Clockwise90()
            {
                //
                // Added 11/12/2020 thomas downes
                //
                _pieceBWO.Revolve_Clockwise90();
                _pieceBRW.Revolve_Clockwise90();
                _pieceGWR.Revolve_Clockwise90();
                _pieceGOW.Revolve_Clockwise90();
                 
            }

            public override void ComplexRevolution()
            {
                //
                // Added 11/13/2020 thomas downes
                //
                //EnumFaceNum temp = _pieceGOW.WhichFaceIsFront; 
                //_pieceGOW.WhichFaceIsFront = _pieceGOW.WhichFaceIsS_of_front;
                //_pieceGOW.WhichFaceIsS_of_front = _pieceGOW.WhichFaceIsE_of_front;
                //_pieceGOW.WhichFaceIsE_of_front = temp;
                _pieceGOW.RotateJustThisPiece_Clockwise();

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
                Color colorOfSide = _pieceBWO.GetColorOfFrontFace();

                return (colorOfSide == _pieceBRW.GetColorOfFrontFace()) &&
                       (colorOfSide == _pieceGWR.GetColorOfFrontFace()) &&
                       (colorOfSide == _pieceGOW.GetColorOfFrontFace());

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

            //Added 12/06/2020 thomas downes
            //
            public override RubikPieceCorner WhichPieceHasMouseHover(Point par_point)
            {
                //
                //Added 12/06/2020 thomas downes
                //
                //return null;

                if (_pieceBRW.FrontFaceWasClicked(par_point)) return _pieceBRW;
                if (_pieceBWO.FrontFaceWasClicked(par_point)) return _pieceBWO;
                if (_pieceGOW.FrontFaceWasClicked(par_point)) return _pieceGOW;
                if (_pieceGWR.FrontFaceWasClicked(par_point)) return _pieceGWR;
                return null;

            }


            //Added 12/06/2020 thomas downes
            //
            public RubikPieceCorner WhichPiece_SideFaceClicked(int par_pointX, int par_pointY)
            {
                //
                // Added 12/06/2020 thomas downes
                //
                Point par_point = new Point(par_pointX, par_pointY);

                if (_pieceBRW.SideFaceWasClicked(par_point)) return _pieceBRW;
                if (_pieceBWO.SideFaceWasClicked(par_point)) return _pieceBWO;
                if (_pieceGOW.SideFaceWasClicked(par_point)) return _pieceGOW;
                if (_pieceGWR.SideFaceWasClicked(par_point)) return _pieceGWR;
                return null;

            }



        }
    }
}
