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

        class ClassFrontside : RubiksCubeOneSide    // class ClassRotateRules_Front : BackOrFront
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

                // Added 1/11/2021 thomas Downes
                base.Piece1 = _pieceBRW;
                base.Piece2 = _pieceBWO;
                base.Piece3 = _pieceGOW;
                base.Piece4 = _pieceGWR;  

            }


            public ClassFrontside(string par_brief_BRW,
                        string par_brief_BWO,
                        string par_brief_GOW,
                        string par_brief_GWR)
            {
                //---class ClassRotateRules_Front : BackOrFront
                //
                // Added 12/20/2020 thomas downes
                //
                var objFrontside = ClassFrontsideBrief.Deserialize(par_brief_BRW, par_brief_BWO, par_brief_GOW, par_brief_GWR);

                _pieceBRW = objFrontside._pieceBRW;
                _pieceBWO = objFrontside._pieceBWO;
                _pieceGOW = objFrontside._pieceGOW;
                _pieceGWR = objFrontside._pieceGWR;

                // Added 1/11/2021 thomas Downes
                base.Piece1 = _pieceBRW;
                base.Piece2 = _pieceBWO;
                base.Piece3 = _pieceGOW;
                base.Piece4 = _pieceGWR;

            }


            public ClassFrontside()
            {
                //
                // Added 1/13/2021 thomas downes  
                //
                _pieceBRW = new Front.BlueRedWhite();   base.Piece1 = _pieceBRW;
                _pieceBWO = new Front.BlueWhiteOrange(); base.Piece2 = _pieceBWO;
                _pieceGOW = new Front.GreenOrangeWhite(); base.Piece3 = _pieceGOW;
                _pieceGWR = new Front.GreenWhiteRed(); base.Piece4 = _pieceGWR;

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

                //---_pieceGOW.RotateJustThisPiece_Clockwise();

                // 1/4/2021 //_pieceBRW.Revolve_Clockwise90();
                // 1/4/2021 //_pieceBWO.Revolve_Clockwise90();
                // 1/4/2021 //_pieceGOW.Revolve_Clockwise90();
                // 1/4/2021 //_pieceGWR.Revolve_Clockwise90();

                //
                // Added 1/4/2021
                //
                var bottomRight = this.GetPiece(FrontClockFace.four_thirty);
                bottomRight.RotateInPlace_PivotPiece120degrees();

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

            //
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
                RubikPieceCorner pieceSW = this.GetPiece(FrontClockFace.seven_thirty);
                RubikPieceCorner pieceSE = this.GetPiece(FrontClockFace.four_thirty);

                GodlikeSwitch(pieceSW, pieceSE);

            }


            public override void GodlikeSwitch(RubikPieceCorner par_dragged, RubikPieceCorner par_replaced)
            {
                //
                // Added 12/06/2020 thomas downes
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


            public override RubikPieceCorner GetPiece(FrontClockFace par_enum)
            {
                //
                // Added 12/9/2020 thomas d. 
                //
                if (par_enum == _pieceBRW.FrontClockFacePosition) return _pieceBRW;
                if (par_enum == _pieceBWO.FrontClockFacePosition) return _pieceBWO;
                if (par_enum == _pieceGOW.FrontClockFacePosition) return _pieceGOW;
                if (par_enum == _pieceGWR.FrontClockFacePosition) return _pieceGWR;
                throw new ArgumentOutOfRangeException(); //return null; 

            }

            public bool AdjacentPieces(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
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


            public override bool PiecesAreAdjacent(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
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


            public override bool PiecesAreAdjacent_Clockwise(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
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


            public override bool PiecesAre_BottomSWSE(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
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
            }


            public override bool PiecesBelongToThisSide(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2)
            {
                //
                // Added 12/8/2020 Thomas Downes 
                //
                //throw new NotImplementedException();

                bool bPiece1_okay;
                bool bPiece2_okay;

                bPiece1_okay = (par_piece1 == _pieceBRW || par_piece1 == _pieceBWO ||
                     par_piece1 == _pieceGOW || par_piece1 == _pieceGWR);

                bPiece2_okay = (par_piece2 == _pieceBRW || par_piece2 == _pieceBWO ||
                     par_piece2 == _pieceGOW || par_piece2 == _pieceGWR);

                return (bPiece1_okay && bPiece2_okay);

            }


            public override string ToString()
            {
                //
                // Added 11/20/2020 thomas downes
                //
                //return base.ToString();

                //string strBriefDescription = (new Back.ClassBacksideBrief(this)).PositionsBrief;
                string strBriefDescription = (new Front.ClassFrontsideBrief(this)).PositionsBrief;

                return strBriefDescription;

            }


            public string Brief_BRW()
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
                return _pieceBRW.ToString();
            }

            public string Brief_BWO()
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
                return _pieceBWO.ToString();
            }

            public string Brief_GOW()
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
                return _pieceGOW.ToString();
            }

            public string Brief_GWR()
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
                return _pieceGWR.ToString();
            }


            public void PaintThisSide(System.Drawing.Graphics par_graphics, Point par_pointCenter)
            {
                //
                // Not in use.  See the following:    FormSolvingTool.Form1_Paint(object sender, PaintEventArgs e)
                //
                //var a_graphics = new System.Drawing.Graphics();  // e.Graphics;

                base.PaintThisSide_Base(par_graphics, par_pointCenter,
                            this._pieceBRW, this._pieceBWO,
                            this._pieceGOW, this._pieceGWR);
                ////
                //// Step 1 of 2.  Paint the front faces.  (vs. sides) 
                ////
                ////   (Code copied from FormSolvingTool.Form1_Paint_FRONT(PaintEventArgs e), 1/11/2021.)
                ////
                //this._pieceBRW.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                //this._pieceBWO.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                //this._pieceGOW.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                //this._pieceGWR.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);

                ////
                //// Step 2 of 2.  Paint the side faces.  
                ////
                ////   (Code copied from FormSolvingTool.Form1_Paint_FRONT(PaintEventArgs e), 1/11/2021.)
                ////
                //this._pieceBRW.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                //this._pieceBWO.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                //this._pieceGOW.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                //this._pieceGWR.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);

            }





        }
    }
}
