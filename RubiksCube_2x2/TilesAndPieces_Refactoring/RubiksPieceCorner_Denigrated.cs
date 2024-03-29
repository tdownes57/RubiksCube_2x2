﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas downes

namespace RubiksCube_2x2
{
    //abstract class RubikPieceCorner
    abstract class RubiksPieceCorner
    {
        //public System.Drawing.Color Color1of3;

        public string TemporaryTextMarker = "";  // E.g. "10:30".   Added 1/11/2021. 
        //public EnumFaceNum TemporaryTextMarker_WhichFace = EnumFaceNum.NotSpecified;  // E.g. "10:30".   Added 1/11/2021. 
        //public bool TemporaryTextMarker_IsNowNorth = false;  // E.g. "10:30".   Added 1/11/2021. 
        //public bool TemporaryTextMarker_IsSideEast = false;  // E.g. "10:30".   Added 1/11/2021. 
        //public bool TemporaryTextMarker_IsSideSouth = false;  // E.g. "10:30".   Added 1/11/2021. 
        //public bool TemporaryTextMarker_IsSideWest = false;  // E.g. "10:30".   Added 1/11/2021. 
        public Color TemporaryTextMarker_Color = Color.Black;  // Added 1/11/2021. 

        //internal BlueOrangeYellow mod_PieceBOY = new BlueOrangeYellow();
        //internal BlueYellowRed mod_PieceBYR = new BlueYellowRed();
        //internal GreenRedYellow mod_PieceGRY = new GreenRedYellow();
        //internal GreenYellowOrange mod_PieceGYO = new GreenYellowOrange();

        //
        // Colors must be expressed in partial-alphabetical order,
        //    i.e. as follows.
        //    
        //  Color #1 must be the lowest (closest to A)
        //    alphabetically: 
        //         blue, green, orange, red, yellow  
        //  (Face #1 is the face of the Rubik's piece which 
        //     corresponds to Color #1.)
        //
        //  Color #2 must be the color of the face which is 
        //     the first face from Face #1, when moving in a 
        //     clockwise direction. 
        //  (Face #2 is the face of the Rubik's piece which 
        //     corresponds to Color #2.)
        //     
        //  Color #3 must be the color of the face which is 
        //     the first face after Face #2, when moving in a 
        //     clockwise direction. 
        //  (Face #3 is the face of the Rubik's piece which 
        //     corresponds to Color #3.)
        //     
        //
        public abstract System.Drawing.Color FaceColor1of3 { get; }
        public abstract System.Drawing.Color FaceColor2of3 { get; }
        public abstract System.Drawing.Color FaceColor3of3 { get; }

        /// <summary>
        /// Added 11/13/2020 
        /// </summary>
        public abstract void LoadInitialState_NotInUse();

        //Added 2/5/2021 thomas downes
        //  This determines if the front face & sides are filled in with color 
        //  or not.  
        public bool FillFacesWithText = false;  // Default to False. 
        public bool FillFacesWithColor = true; // Default to True. 

        //
        //          [.N.]   [.N.]
        //   [.W.] [10:30] [1:30]  [.E.]
        //   [.W.]  [ 7:30] [3:30]  [.E.]
        //           [.S.]   [.S.]
        //
        // (The [._.] faces are _side_ faces, e.g. [.W.].) 
        //
        //  ----DIFFICULT & CONFUSING-----
        //  FrontClockFacePosition is where the piece appears on the Clock Dial (Face),
        //    ONLY FROM THE FRONT OR BACK PERSPECTIVE.  NOT FROM THE SIDEVIEW. 
        //    ----4/2/2021 Thomas C. Downes
        //
        public FrontClockFace FrontClockFacePosition;
        public FrontClockFace FrontClockFacePosition_Prior;

        // Added 4/2/2021 thomas downes
        public EnumFrontOrBack FrontOrBackOfCube;

        // Added 6/13/2021 thomas downes
        public bool GodControl_DrawWithEmphasis_JustMoved;
        public bool GodControl_DrawWithEmphasis_JustClicked;
        public RubiksCubeOneSide ParentSide;  /// <summary>
                                              /// This will help track the location of the corner piece, 
                                              /// i.e. which side of the Rubiks Cube (Whole) does it belong to. 
                                              /// </summary>
        public Color Color_GodControlEmphasis;  // Added 6/18/2021 Thomas Downes

        //public FacePositionNSWE FaceColor1Position_NotInUse;
        //public FacePositionNSWE FaceColor2Position_NotInUse;
        //public FacePositionNSWE FaceColor3Position_NotInUse;

        //
        //
        // More description, which may or may not be needed/helpful. 
        //
        //
        public EnumFaceNum WhichFaceIsFront;
        public EnumFaceNum WhichFaceIsN_of_front;
        public EnumFaceNum WhichFaceIsW_of_front;
        public EnumFaceNum WhichFaceIsE_of_front;
        public EnumFaceNum WhichFaceIsS_of_front;

        private const int _margin = 3;  // 2;  // 1; // 10;   // Added 11/12/2020 thomas downes
        private Rectangle _rectangleFrontFace; // Added 11/17/2020 thomas d. 
        private Rectangle _rectangleSideFace_CW; // Added 11/17/2020 thomas d. 
        private Rectangle _rectangleSideFace_CCW; // Added 11/17/2020 thomas d. 

        //----11/17/2020 thomas d---public abstract void Rotate_Counterwise90();
        public abstract void Revolve_Clockwise90();
        public abstract void ReorientPiece(FrontClockFace par_enum, Color par_frontfacecolor);

        //Added 12/4/2020 thomas downes
        public abstract string GetColorAbbreviationXYZ();

        public RubiksPieceCorner()
        {
            //
            // The current constructor, does _NOT_ requires a reference to the Parent side.
            //   ----6/13/2021 tcd
            //
            this.ParentSide = null;  // par_parent;

        }


        public RubiksPieceCorner(RubiksCubeOneSide par_parent)
        {
            //
            // The constructor, requires a reference to the Parent side.
            //   ----6/13/2021 tcd
            //
            this.ParentSide = par_parent;  

        }



        public Color GetColorOfFrontFace()
        {
            //
            // Added 11/11/2020 thomas downes
            //
            switch (WhichFaceIsFront)
            {
                case EnumFaceNum.Face1: return this.FaceColor1of3;
                case EnumFaceNum.Face2: return this.FaceColor2of3;
                case EnumFaceNum.Face3: return this.FaceColor3of3;
                case EnumFaceNum.NotSpecified:
                    throw new NotImplementedException("Front Face has not been specified.");
                default: return Color.Black;
            }

        }


        public Color GetColorOfSideFace_ClockwiseFromFront()
        {
            //
            // Added 11/12/2020 thomas downes
            //
            //----switch (this.FrontClockFacePosition)
            switch (this.FrontClockFacePosition.EnumValue())
            {
                case FrontClockFace_Enum.one_thirty: return ColorByFaceNumber(this.WhichFaceIsN_of_front);
                case FrontClockFace_Enum.four_thirty: return ColorByFaceNumber(this.WhichFaceIsE_of_front);
                case FrontClockFace_Enum.seven_thirty: return ColorByFaceNumber(this.WhichFaceIsS_of_front);
                case FrontClockFace_Enum.ten_thirty: return ColorByFaceNumber(this.WhichFaceIsW_of_front);
                default:
                    //----11/17/2020 thomas downes---return Color.Empty;
                    throw new NotImplementedException("Enum not specified. #1");
            }

        }


        public Color GetColorOfSideFace_CounterClockwise()
        {
            //
            // Added 11/12/2020 thomas downes
            //
            switch (this.FrontClockFacePosition.EnumValue())
            {
                case FrontClockFace_Enum.one_thirty: return ColorByFaceNumber(this.WhichFaceIsE_of_front);
                case FrontClockFace_Enum.four_thirty: return ColorByFaceNumber(this.WhichFaceIsS_of_front);
                case FrontClockFace_Enum.seven_thirty: return ColorByFaceNumber(this.WhichFaceIsW_of_front);
                case FrontClockFace_Enum.ten_thirty: return ColorByFaceNumber(this.WhichFaceIsN_of_front);
                default:
                    //----11/17/2020 thomas downes---return Color.Empty;
                    throw new NotImplementedException("Enum not specified. #2");
            }

        }


        private Color ColorByFaceNumber(EnumFaceNum par_enum)
        {
            //
            // Added 11/12/2020 thomas downes
            //
            switch (par_enum)
            {
                case (EnumFaceNum.Face1): return FaceColor1of3;
                case (EnumFaceNum.Face2): return FaceColor2of3;
                case (EnumFaceNum.Face3): return FaceColor3of3;
                default:
                    //----11/17/2020 thomas downes---return Color.Empty;
                    throw new NotImplementedException("Enum not specified. #3");

            }

        }


        public void PaintByGraphics(Graphics par_graphics, Point par_center_of_form)
        {
            //
            // Added 1/31/2021 thomas downes
            //
            this.PaintByGraphics_FrontFace(par_graphics, par_center_of_form);
            this.PaintByGraphics_SideFaces(par_graphics, par_center_of_form);

        }


        public void PaintByGraphics_FrontFace(Graphics par_graphics, Point par_center_of_form)
        {
            //
            // Added 1/11/2021 thomas downes
            //
            //  "JustFront"   ( EnumWhatToPaint.JustFront )
            //
            this.PaintByGraphics(par_graphics, par_center_of_form, EnumWhatToPaint.JustFront);

        }

        public void PaintByGraphics_SideFaces(Graphics par_graphics, Point par_center_of_form)
        {
            //
            // Added 1/11/2021 thomas downes
            //
            //  "JustSides"   ( EnumWhatToPaint.JustSides )
            //
            this.PaintByGraphics(par_graphics, par_center_of_form, EnumWhatToPaint.JustSides);

        }

        public void PaintByGraphics(Graphics par_graphics, Point par_center_of_form,
                          EnumWhatToPaint par_FrontOrSides)
        {
            //
            // Added 11/11/2020 thomas downes
            //
            Point point_NW; // = null;
            Point point_SW; // = null;
            Point point_NE; // = null;
            Point point_SE; // = null;

            //Added 11/17/2020 thomas downes
            bool boolPaintTheFront = true;
            boolPaintTheFront = (par_FrontOrSides != EnumWhatToPaint.JustSides);

            //
            // Added 11/11/2020 thomas downes
            //
            if (par_FrontOrSides != EnumWhatToPaint.JustSides)
            {
                boolPaintTheFront = true;

                PaintFrontFace_Base(par_graphics, par_center_of_form,
                     out point_NW, out point_SW, out point_NE, out point_SE,
                     boolPaintTheFront);
            }

            //
            // Added 11/11/2020 thomas downes
            //
            if (par_FrontOrSides != EnumWhatToPaint.JustFront)
            {
                //
                // Step 1 of 2:  Get the larger "front" rectangle (vs. the side rectangles). 
                //
                boolPaintTheFront = false;
                PaintFrontFace_Base(par_graphics, par_center_of_form,
                     out point_NW, out point_SW, out point_NE, out point_SE, boolPaintTheFront);

                //
                // Step 2 of 2.  Paint the sides. 
                //
                PaintSideFace_ClockwiseFromFront(par_graphics, par_center_of_form,
                                in point_NW, in point_SW, in point_NE, in point_SE);

                PaintSideFace_CounterClockwise(par_graphics, par_center_of_form,
                    in point_NW, in point_SW, in point_NE, in point_SE);
            }

        }

        public void PaintFrontFace_Base(Graphics par_graph, Point p_center_of_form,
                        out Point p_pointNW, out Point p_pointSW,
                        out Point p_pointNE, out Point p_pointSE,
                        bool p_boolDoPaintTheFront = true)
        {
            //----throw new NotImplementedException();

            //
            // Added 11/11/2020 thomas downes  
            //
            //Rectangle frontFace = EnumStaticClass.GetRectangle_Front(p_center_of_form, base.FrontClockFacePosition);
            Rectangle frontFace = EnumStaticClass.GetRectangle_Front(p_center_of_form, this.FrontClockFacePosition, _margin);

            //Added 11/17/2020 thomas d.
            _rectangleFrontFace = frontFace;

            p_pointNW = new Point(frontFace.X, frontFace.Y);
            p_pointSW = new Point(frontFace.X, frontFace.Y + frontFace.Height);
            p_pointNE = new Point(frontFace.X + frontFace.Width, frontFace.Y);
            p_pointSE = new Point(frontFace.X + frontFace.Width, frontFace.Y + frontFace.Height);

            //Brush a_brush = new SolidBrush(base.GetColorOfFrontFace());
            //Brush a_brush = new SolidBrush(GetColorOfFrontFace());

            //See below.//Color color_OfFrontFace = GetColorOfFrontFace();
            //See below.//Brush a_brush = new SolidBrush(color_OfFrontFace);

            //Added 1/11/2021 Thomas Downes
            //bool bTextMarkerIsStillInFront = (this.TemporaryTextMarker_WhichFace == WhichFaceIsFront);
            bool bTextMarkerIsStillInFront = (this.TemporaryTextMarker_Color == Color_OfFrontFace());
            bool bHasTemporaryTextMarker = (this.TemporaryTextMarker != "") && (bTextMarkerIsStillInFront);

            if (bHasTemporaryTextMarker && p_boolDoPaintTheFront)
            {
                //
                // Added 6/13/2021 Thomas downes
                //
                if (this.GodControl_DrawWithEmphasis_JustMoved)
                {
                    // Added 6/13/2021 Thomas Downes
                    //Brush a_brush = new SolidBrush(Color.LightCyan);
                    //Brush a_brush = new SolidBrush(this.ParentSide.Color_DrawWithEmphasis_Current());
                    Brush a_brush = new SolidBrush(this.Color_GodControlEmphasis);
                    par_graph.FillRectangle(a_brush, frontFace);
                }
                if (this.GodControl_DrawWithEmphasis_JustClicked)
                {
                    // Added 6/13/2021 Thomas Downes
                    //Brush a_brush = new SolidBrush(Color.LightCyan);
                    //Brush a_brush = new SolidBrush(this.ParentSide.Color_DrawWithEmphasis_Next());
                    Brush a_brush = new SolidBrush(this.Color_GodControlEmphasis);
                    par_graph.FillRectangle(a_brush, frontFace);
                }

                //
                // Added 1/11/2021 
                //
                Brush a_brush_black = new SolidBrush(Color.Black);
                //----par_graph.DrawString(this.TemporaryTextMarker, new Font("Comic Sans MS", 13), a_brush_black, 0, 0);
                par_graph.DrawString(this.TemporaryTextMarker, new Font("Comic Sans MS", 13), 
                    a_brush_black, frontFace.X, frontFace.Y);

                // Added 4/12/2021 td
                Pen a_pen_black = new Pen(Color.Black);
                par_graph.DrawRectangle(a_pen_black, frontFace);

            }

            else if (p_boolDoPaintTheFront)
            {
                //
                // We are _not_ merely populating the "out" parameters.
                //   We _do_ in fact want to paint the front face. 
                //
                Color color_OfFrontFace = GetColorOfFrontFace();
                Brush a_brush = new SolidBrush(color_OfFrontFace);
                par_graph.FillRectangle(a_brush, frontFace);
            }

        }


        public void PaintByGraphics_IfVisible(Graphics par_graphics, Point par_center_of_form,
               EnumPrimaryView par_enumView, out Exception par_error)
        {
            //
            // Added 1/31/2021 thomas downes
            //
            par_error = null;
            bool bMaybeNotYetReady = false;
            bool bFarSoPerhapsNotVisible = false;

            if (par_enumView == EnumPrimaryView.Right)
            {
                //
                // The pieces in the 7:30 & 10:30 positions won't be painted. 
                //
                //---if (this.FrontClockFacePosition == FrontClockFace.ten_thirty) return;
                //--if (this.FrontClockFacePosition == FrontClockFace_Enum.seven_thirty) return;
                //--++if (this.FrontClockFacePosition == FrontClockFace.ten_thirty) bFarSoPerhapsNotVisible = true;
                //--++if (this.FrontClockFacePosition == FrontClockFace_Enum.seven_thirty) bFarSoPerhapsNotVisible = true;
                if (this.FrontClockFacePosition.Equals(FrontClockFace.ten_thirty)) bFarSoPerhapsNotVisible = true;
                if (this.FrontClockFacePosition.Equals(FrontClockFace.seven_thirty)) bFarSoPerhapsNotVisible = true;

                //Check to see if the piece is "ready" to be painted. 
                bMaybeNotYetReady = (this.WhichFaceIsE_of_front == EnumFaceNum.NotSpecified);
                //---if (boolNotYetReady) return;  

            }

            else if (par_enumView == EnumPrimaryView.Left)
            {
                //
                // The pieces in the 1:30 & 4:30 positions won't be painted. 
                //
                //---if (this.FrontClockFacePosition == FrontClockFace.one_thirty()) return;
                //--if (this.FrontClockFacePosition == FrontClockFace.four_thirty()) return;
                //if (this.FrontClockFacePosition == FrontClockFace.one_thirty()) bFarSoPerhapsNotVisible = true;
                //if (this.FrontClockFacePosition == FrontClockFace.four_thirty()) bFarSoPerhapsNotVisible = true;
                if (this.FrontClockFacePosition.Equals(FrontClockFace.one_thirty)) bFarSoPerhapsNotVisible = true;
                if (this.FrontClockFacePosition.Equals(FrontClockFace.four_thirty)) bFarSoPerhapsNotVisible = true;
                  
                //Check to see if the piece is "ready" to be painted. 
                //bool boolNotYetReady;
                bMaybeNotYetReady = (this.WhichFaceIsW_of_front == EnumFaceNum.NotSpecified);
                //if (boolNotYetReady) return;

            }

            //
            // Major call!!!  Finally. 
            //
            if (bFarSoPerhapsNotVisible)
            {
                // Should we paint this piece???
                PaintByGraphics(par_graphics, par_center_of_form, par_enumView, out par_error);
            }
            else if (bMaybeNotYetReady)
            {
                // Should we paint this piece???
                PaintByGraphics(par_graphics, par_center_of_form, par_enumView, out par_error);
            }
            else PaintByGraphics(par_graphics, par_center_of_form, par_enumView, out par_error);

            return;

        }

        public void PaintByGraphics(Graphics par_graphics, Point par_center_of_form,
                       EnumPrimaryView par_enumView, out Exception par_error)
        {
            //
            // Added 1/31/2021 thomas downes
            //
            par_error = null;

            if (par_enumView == EnumPrimaryView.Front)
            {
                PaintByGraphics(par_graphics, par_center_of_form);
            }
            else if (par_enumView == EnumPrimaryView.Back)
            {
                PaintByGraphics(par_graphics, par_center_of_form);
            }

            else if (par_enumView == EnumPrimaryView.Right)
            {
                //
                // Paint the piece, but from a 90-degre (profile) perspective rather than a head-on view. 
                //
                //var a_temp = new RubikPieceCorner(par_enumView);
                var a_temp = new SideViews.RubikPieceSideView(this, par_enumView);
                a_temp.PaintByGraphics(par_graphics, par_center_of_form);

            }
            else if (par_enumView == EnumPrimaryView.Left)
            {
                //
                // Paint the piece, but from a 90-degre (profile) perspective rather than a head-on view. 
                //
                //var a_temp = new RubikPieceCorner(par_enumView);
                var a_temp = new SideViews.RubikPieceSideView(this, par_enumView);
                a_temp.PaintByGraphics(par_graphics, par_center_of_form);

            }
            else if (par_enumView == EnumPrimaryView.Unassigned)
            {
                //
                // Paint the piece, but from a 90-degre (profile) perspective rather than a head-on view. 
                //
                throw new NotImplementedException();  //Added 1/31/2021 thomas d. 

            }


        }

        //public abstract void PaintFrontFace(Graphics par_graphics, Point par_center_of_form,
        //    out Point par_pointNW, out Point par_pointSW, 
        //    out Point par_pointNE, out Point par_pointSE);

        //public abstract void PaintSideFace_ClockwiseFromFront(Graphics par_graphics,
        //       Point p_center_of_form,
        //    in Point par_pointNW, in Point par_pointSW,
        //    in Point par_pointNE, in Point par_pointSE);

        //public abstract void PaintSideFace_CounterClockwise(Graphics par_graphics,
        //       Point p_center_of_form,
        //    in Point par_pointNW, in Point par_pointSW,
        //    in Point par_pointNE, in Point par_pointSE);

        public void PaintSideFace_ClockwiseFromFront(Graphics par_graphics,
                Point p_center_of_form,
                in Point par_pointNW, in Point par_pointSW,
                in Point par_pointNE, in Point par_pointSE)
        {
            //
            // Added 11/12/2020 thomas downes
            //
            Rectangle sideFace = EnumStaticClass.GetRectangle_Side_ClockwiseFromFront(p_center_of_form,
                         this.FrontClockFacePosition, _margin,
                           in par_pointNW, in par_pointSW,
                           in par_pointNE, in par_pointSE);

            //----Brush a_brush = new SolidBrush(this.GetColorOfSideFace_ClockwiseFromFront());
            Color color_ofSideFace = this.GetColorOfSideFace_ClockwiseFromFront();
            Brush a_brush = new SolidBrush(color_ofSideFace);
            Pen a_pen = new System.Drawing.Pen(color_ofSideFace);

            //Added 1/11/2021 Thomas Downes
            //bool bTextMarkerIsClockwiseFromFront = (this.TemporaryTextMarker_IsClockwiseFromFront());
            bool bTextMarkerIsClockwiseFromFront = (this.TemporaryTextMarker_Color == color_ofSideFace);

            //---bool bHasTemporaryTextMarker = (this.TemporaryTextMarker != "") && (bTextMarkerIsClockwiseFromFront);
            bool bHasTemporaryTextMarker_Piece = (this.TemporaryTextMarker != ""); // && (bTextMarkerIsClockwiseFromFront);
            bool bHasTemporaryTextMarker_Side = (this.TemporaryTextMarker != "") && (bTextMarkerIsClockwiseFromFront);

            //---if (bHasTemporaryTextMarker)
            if (bHasTemporaryTextMarker_Side)
            {
                //
                // Added 1/11/2021.   E.g. put "4:30" to indicate that the prior front face
                //   has moved to one of the sides. 
                //
                par_graphics.DrawString(this.TemporaryTextMarker,
                                        new Font("Comic Sans MS", 11),
                                        a_brush, sideFace.X, sideFace.Y);   // a_brush, 0, 0);
                par_graphics.DrawRectangle(a_pen, sideFace);  // Added 4/10/2021

            }
            else if (bHasTemporaryTextMarker_Piece)
            {
                //
                // Added 4/10/2021.  Don't fill the rectangle. 
                //
                par_graphics.DrawRectangle(a_pen, sideFace);

            }
            else
            {
                //
                // Fill the side face (a smaller square, to the side of the larger front face (square)).
                //
                par_graphics.FillRectangle(a_brush, sideFace);
            }

            //Administrative.
            _rectangleSideFace_CW = sideFace;

            //Draw the outline.
            Pen outlinePen = new Pen(Color.DarkGray);
            par_graphics.DrawRectangle(outlinePen, sideFace);

        }

        public void PaintSideFace_CounterClockwise(Graphics par_graphics,
               Point p_center_of_form,
            in Point par_pointNW, in Point par_pointSW,
            in Point par_pointNE, in Point par_pointSE)
        {
            //
            // Added 11/12/2020 thomas downes
            //
            Rectangle sideFace = EnumStaticClass.GetRectangle_Side_CounterClockwise(p_center_of_form,
                         this.FrontClockFacePosition, _margin,
                           in par_pointNW, in par_pointSW,
                           in par_pointNE, in par_pointSE);

            // Jan. 11 //Brush a_brush = new SolidBrush(this.GetColorOfSideFace_CounterClockwise());
            Color color_ofSideFace = this.GetColorOfSideFace_CounterClockwise();
            Brush a_brush = new SolidBrush(color_ofSideFace);

            // Added 4/12/2021 Thomas Downes
            Pen a_drawingPen = new Pen(color_ofSideFace);

            //Added 1/11/2021 Thomas Downes
            bool bTextMarkerIsThisFace = (this.TemporaryTextMarker_Color == color_ofSideFace);
            //--April 10---bool bHasTemporaryTextMarker = (this.TemporaryTextMarker != "") && (bTextMarkerIsThisFace);
            bool bHasTemporaryTextMarker_Piece = (this.TemporaryTextMarker != ""); // && (bTextMarkerIsThisFace);
            bool bHasTemporaryTextMarker_Face = (this.TemporaryTextMarker != "") && (bTextMarkerIsThisFace);

            if (bHasTemporaryTextMarker_Face)
            {
                // Added 4/12/2021 Thomas DOWNES
                par_graphics.DrawRectangle(a_drawingPen, sideFace);
                par_graphics.DrawString(this.TemporaryTextMarker,
                        new Font("Comic Sans MS", 11),
                                        a_brush, sideFace.X, sideFace.Y);   // a_brush, 0, 0);

            }
            if (bHasTemporaryTextMarker_Piece)
            {
                // Added 4/12/2021 Thomas DOWNES
                par_graphics.DrawRectangle(a_drawingPen, sideFace);

            }
            else
            {
                par_graphics.FillRectangle(a_brush, sideFace);
            }

            //Administrative.
            _rectangleSideFace_CCW = sideFace;
        }


        internal void Revolve_Clockwise90_base()
        {
            //
            // Added 11/12/2020 thomas downes
            //
            //FrontClockFace new_position = FrontClockFace.unassigned;
            FrontClockFace new_position = new FrontClockFace(FrontClockFace_Enum.unassigned);

            //switch (this.FrontClockFacePosition)
            switch (this.FrontClockFacePosition.EnumValue())
            {
                case FrontClockFace_Enum.one_thirty: new_position = FrontClockFace.four_thirty_obj; SimpleRevolution_to430_from130(); break;
                case FrontClockFace_Enum.four_thirty: new_position = FrontClockFace.seven_thirty_obj; SimpleRevolution_to730_from430(); break;
                case FrontClockFace_Enum.seven_thirty: new_position = FrontClockFace.ten_thirty_obj; SimpleRevolution_to1030_from730(); break;
                case FrontClockFace_Enum.ten_thirty: new_position = FrontClockFace.one_thirty_obj; SimpleRevolution_to130_from1030(); break;
                default: break;
            }
            this.FrontClockFacePosition = new_position;

        }

        internal void SimpleRevolution_to430_from130()
        {
            //
            // Added 11/13/2020 thomas downes
            //
            EnumFaceNum tempFaceNum_N;
            EnumFaceNum tempFaceNum_S;
            EnumFaceNum tempFaceNum_W;
            EnumFaceNum tempFaceNum_E;

            tempFaceNum_N = this.WhichFaceIsN_of_front;
            tempFaceNum_S = this.WhichFaceIsS_of_front;
            tempFaceNum_W = this.WhichFaceIsW_of_front;
            tempFaceNum_E = this.WhichFaceIsE_of_front;

            this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsS_of_front = tempFaceNum_E;
            this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsE_of_front = tempFaceNum_N;

        }

        internal void SimpleRevolution_to730_from430()
        {
            //
            // Added 11/13/2020 thomas downes
            //
            EnumFaceNum tempFaceNum_N;
            EnumFaceNum tempFaceNum_S;
            EnumFaceNum tempFaceNum_W;
            EnumFaceNum tempFaceNum_E;

            tempFaceNum_N = this.WhichFaceIsN_of_front;
            tempFaceNum_S = this.WhichFaceIsS_of_front;
            tempFaceNum_W = this.WhichFaceIsW_of_front;
            tempFaceNum_E = this.WhichFaceIsE_of_front;

            this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsS_of_front = tempFaceNum_E;
            this.WhichFaceIsW_of_front = tempFaceNum_S;
            this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;

        }

        internal void SimpleRevolution_to1030_from730()
        {
            //
            // Added 11/13/2020 thomas downes
            //
            EnumFaceNum tempFaceNum_N;
            EnumFaceNum tempFaceNum_S;
            EnumFaceNum tempFaceNum_W;
            EnumFaceNum tempFaceNum_E;

            tempFaceNum_N = this.WhichFaceIsN_of_front;
            tempFaceNum_S = this.WhichFaceIsS_of_front;
            tempFaceNum_W = this.WhichFaceIsW_of_front;
            tempFaceNum_E = this.WhichFaceIsE_of_front;

            this.WhichFaceIsN_of_front = tempFaceNum_W;
            this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsW_of_front = tempFaceNum_S;
            this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;

        }

        internal void SimpleRevolution_to130_from1030()
        {
            //
            // Added 11/13/2020 thomas downes
            //
            EnumFaceNum tempFaceNum_N;
            EnumFaceNum tempFaceNum_S;
            EnumFaceNum tempFaceNum_W;
            EnumFaceNum tempFaceNum_E;

            tempFaceNum_N = this.WhichFaceIsN_of_front;
            tempFaceNum_S = this.WhichFaceIsS_of_front;
            tempFaceNum_W = this.WhichFaceIsW_of_front;
            tempFaceNum_E = this.WhichFaceIsE_of_front;

            this.WhichFaceIsN_of_front = tempFaceNum_W;
            this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsE_of_front = tempFaceNum_N;

        }



        internal void ReorientPiece_FrontFaceIsFace1(FrontClockFace par_clock)  // par_enum)
        {
            //---internal void ReorientPiece_FrontFaceIsFace1(FrontClockFace_enum par_enum)  // par_enum)
            //
            //Added 8/21/2023 thomas downes
            //
            ReorientPiece_FrontFaceIsFace1(par_clock.EnumValue());

        }


        internal void ReorientPiece_FrontFaceIsFace1(FrontClockFace_Enum par_enum)  // par_enum)
        {
            //
            //Added 11/14/2020 thomas downes
            //
            //Added 11/15/2020 thomas downes
            this.WhichFaceIsFront = EnumFaceNum.Face1;

            //
            //Determine the two(2) side faces. 
            //
            //----switch (par_enum)
            // Aug2023  switch (par_clock.EnumValue())
            switch (par_enum)
            {
                case (FrontClockFace_Enum.one_thirty):
                    //  1:30 
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace_Enum.four_thirty):
                    //  4:30 
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace_Enum.seven_thirty):
                    //  7:30 
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face3;
                    break;

                case (FrontClockFace_Enum.ten_thirty):
                    //  10:30 
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face2;
                    break;

                default:
                    throw new Exception("Par_enum value is not recognized. #1 of 3");
            }

        }


        internal void ReorientPiece_FrontFaceIsFace2(FrontClockFace par_clock)  // par_enum)
        {
            //---internal void ReorientPiece_FrontFaceIsFace1(FrontClockFace_enum par_enum)  // par_enum)
            //
            //Added 8/21/2023 thomas downes
            //
            ReorientPiece_FrontFaceIsFace2(par_clock.EnumValue());

        }


        /// <summary>
        /// What does this do? 
        /// </summary>
        /// <param name="par_clock"></param>
        /// <exception cref="Exception"></exception>
        internal void ReorientPiece_FrontFaceIsFace2(FrontClockFace_Enum par_clock) //  par_enum)
        {
            //
            //Added 11/14/2020 thomas downes
            //
            //Added 11/15/2020 thomas downes
            this.WhichFaceIsFront = EnumFaceNum.Face2;

            //
            //Determine the two(2) side faces. 
            //
            //#1 Aug2023  switch (par_enum)
            //#2 Aug2023  switch (par_clock.EnumValue()) //---enum)
            switch (par_clock) //Aug 2023
            {
                case (FrontClockFace_Enum.one_thirty):
                    // 1:30 
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace_Enum.four_thirty):
                    // 4:30  
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace_Enum.seven_thirty):
                    // 7:30 
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face1;
                    break;

                case (FrontClockFace_Enum.ten_thirty):
                    // 10:30... 
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face3;
                    break;

                default:
                    throw new Exception("Par_enum value is not recognized. #2 of 3");
            }

        }


        internal void ReorientPiece_FrontFaceIsFace3(FrontClockFace par_clockFace)  // par_enum)
        {
            //
            //Added 8/20/2023 thomas downes
            //
            ReorientPiece_FrontFaceIsFace3(par_clockFace.EnumValue());

        }


        internal void ReorientPiece_FrontFaceIsFace3(FrontClockFace_Enum par_enum)  // par_enum)
        {
            //
            //Added 11/14/2020 thomas downes
            //
            //Added 11/15/2020 thomas downes
            this.WhichFaceIsFront = EnumFaceNum.Face3;

            //
            //Determine the two(2) side faces. 
            //
            //Aug 2023 switch (par_clock.EnumValue())  //  (par_enum)
            switch (par_enum)  //  (par_enum)
            {
                case (FrontClockFace_Enum.one_thirty):
                    // The current piece being oriented is the 1:30 face, top-right. 
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace_Enum.four_thirty):
                    // The current piece being oriented is the 4:30 face, bottom-right. 
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace_Enum.seven_thirty):
                    // The current piece being oriented is the 7:30 face, bottom-left. 
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face2;
                    break;

                case (FrontClockFace_Enum.ten_thirty):
                    // The current piece being oriented is the 10:30 face, top-left. 
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face1;
                    break;

                default:
                    throw new Exception("Par_enum value is not recognized. #3 of 3");
            }

        }

        public void ReorientPiece_Complex(FrontClockFace par_clockPosition_Start, EnumAll12Faces par_enum,
                                            bool p_boolOnlySetClockPosition = false)
        {
            //public virtual void ReorientPiece_Complex(EnumAll12Faces par_enum)
            //public void ReorientPiece_Complex(EnumFaceNum frontFaceColorNum_Start, EnumAll12Faces par_enum)
            //

            //Added 11/18/2020 thomas downes
            //   Save the prior position of the piece. 
            //
            this.FrontClockFacePosition_Prior = this.FrontClockFacePosition;

            //Added 11/14/2020 thomas downes 
            //
            switch (par_enum)
            {
                //
                // The piece has moved to the 1:30 position, upper-right / northeast. 
                //
                case EnumAll12Faces.F0130: this.FrontClockFacePosition = FrontClockFace.one_thirty_obj; break;
                case EnumAll12Faces._130_ENE: this.FrontClockFacePosition = FrontClockFace.one_thirty_obj; break;
                case EnumAll12Faces._130_NNE: this.FrontClockFacePosition = FrontClockFace.one_thirty_obj; break;

                //
                // The piece has moved to the 4:30 position, lower-right / southeast. 
                //
                case EnumAll12Faces.F0430: this.FrontClockFacePosition = FrontClockFace.four_thirty_obj; break;
                case EnumAll12Faces._430_ESE: this.FrontClockFacePosition = FrontClockFace.four_thirty_obj; break;
                case EnumAll12Faces._430_SSE: this.FrontClockFacePosition = FrontClockFace.four_thirty_obj; break;

                //
                // The piece has moved to the 7:30 position, lower-left / southwest. 
                //
                case EnumAll12Faces.F0730: this.FrontClockFacePosition = FrontClockFace.seven_thirty_obj; break;
                case EnumAll12Faces._730_SSW: this.FrontClockFacePosition = FrontClockFace.seven_thirty_obj; break;
                case EnumAll12Faces._730_WSW: this.FrontClockFacePosition = FrontClockFace.seven_thirty_obj; break;

                //
                // The piece has moved to the 10:30 position, upper-left / northwest. 
                //
                case EnumAll12Faces.F1030: this.FrontClockFacePosition = FrontClockFace.ten_thirty_obj; break;
                case EnumAll12Faces._1030_NNW: this.FrontClockFacePosition = FrontClockFace.ten_thirty_obj; break;
                case EnumAll12Faces._1030_WNW: this.FrontClockFacePosition = FrontClockFace.ten_thirty_obj; break;

                default: throw new Exception("EnumAll12Faces par_enum value is not recognized.");
            }

            //EnumFaceNum frontFaceColorNum_Start = this.WhichFaceIsFront;
            //EnumFaceNum frontFaceColorNum_End = ??????;
            //this.ReorientPiece(this.FrontClockFacePosition, frontfaceColor);

            if (p_boolOnlySetClockPosition == false)  //Added 11/18/2020 thomas downes
            {
                //switch (par_clockPosition_Start)
                switch (par_clockPosition_Start.EnumValue())
                {
                    //case FrontClockFace.ten_thirty: ReorientPiece_Complex_From1030(par_enum); break;
                    //case FrontClockFace.one_thirty(): ReorientPiece_Complex_From130(par_enum); break;
                    case FrontClockFace_Enum.ten_thirty: FrontFace_1030_ReorientTo(par_enum); break;
                    case FrontClockFace_Enum.one_thirty: FrontFace_130_ReorientTo(par_enum); break;

                    case FrontClockFace_Enum.four_thirty: ReorientPiece_Complex_From430(par_enum); break;
                    case FrontClockFace_Enum.seven_thirty: ReorientPiece_Complex_From730(par_enum); break;
                    default:
                        throw new Exception("Parameter par_clockPosition_Start is not specified.");
                }
            }

        }


        public void RotateInPlace_PivotPiece120degrees()
        {
            //
            //  Added 11/17/2020 thomas downes   
            //
            EnumFaceNum tempFaceNum_N = EnumFaceNum.NotSpecified;
            EnumFaceNum tempFaceNum_E = EnumFaceNum.NotSpecified;
            EnumFaceNum tempFaceNum_S = EnumFaceNum.NotSpecified;
            EnumFaceNum tempFaceNum_W = EnumFaceNum.NotSpecified;

            //Check the enumerated value.
            Func<EnumFaceNum, bool> isValid = enumFN =>
               (enumFN == EnumFaceNum.Face1 || enumFN == EnumFaceNum.Face2 || enumFN == EnumFaceNum.Face3);

            //
            // Step 1 of 4.  If applicable, switch the North (& Front) & East faces. 
            //
            tempFaceNum_N = this.WhichFaceIsN_of_front;
            if (isValid(tempFaceNum_N))
            {
                if (isValid(this.WhichFaceIsE_of_front))
                {
                    this.WhichFaceIsN_of_front = this.WhichFaceIsFront;
                    this.WhichFaceIsFront = this.WhichFaceIsE_of_front;
                    this.WhichFaceIsE_of_front = tempFaceNum_N;
                    return;
                }
            }

            //
            //  Step 2 of 4.  If applicable, switch the East (& Front) & South faces. 
            //
            tempFaceNum_E = this.WhichFaceIsE_of_front;
            if (isValid(tempFaceNum_E))
            {
                if (isValid(this.WhichFaceIsS_of_front))
                {
                    this.WhichFaceIsE_of_front = this.WhichFaceIsFront;
                    this.WhichFaceIsFront = this.WhichFaceIsS_of_front;
                    this.WhichFaceIsS_of_front = tempFaceNum_E;
                    return;
                }
            }

            //
            //  Step 3 of 4.  If applicable, switch the South & West (& Front) faces. 
            //
            tempFaceNum_S = this.WhichFaceIsS_of_front;
            if (isValid(tempFaceNum_S))
            {
                if (isValid(this.WhichFaceIsW_of_front))
                {
                    this.WhichFaceIsS_of_front = this.WhichFaceIsFront;
                    this.WhichFaceIsFront = this.WhichFaceIsW_of_front;
                    this.WhichFaceIsW_of_front = tempFaceNum_S;
                    return;
                }
            }

            //
            //  Step 4 of 4.  If applicable, switch the West & North faces. 
            //
            tempFaceNum_W = this.WhichFaceIsW_of_front;
            if (isValid(tempFaceNum_W))
            {
                if (isValid(this.WhichFaceIsN_of_front))
                {
                    this.WhichFaceIsW_of_front = this.WhichFaceIsFront;
                    this.WhichFaceIsFront = this.WhichFaceIsN_of_front;
                    this.WhichFaceIsN_of_front = tempFaceNum_W;
                    return;
                }
            }

        }


        // Added 6/18/2021 td 
        public RubiksFaceTile_Struct WhichTileWasClicked(Point par_point)
        {
            //
            // Added 6/18/2021 Thomas Downes 
            //
            var new_tile = new RubiksFaceTile_Struct(this);
            bool bFrontFace = FrontFaceWasClicked(par_point);

            if (bFrontFace) new_tile.Enum_FacePositionNSWE = EnumFacePositionNSWE.FrontFacing;
            if (bFrontFace) new_tile.Enum_CubeRotation = EnumCubeRotation_NorthPole.None_MainFace;  // No rotation. 
            if (bFrontFace) new_tile.Enum_Color = this.GetColorOfFrontFace();
            if (bFrontFace) return new_tile;

            //EnumFacePositionNSWE enum_sideface = EnumFacePositionNSWE.NotSpecified;  
            //bool bSideFace = SideFaceWasCli   QAASQ23Wcked(par_point, ref enum_sideface);
            //if (bSideFace) new_tile.Enum_FacePositionNSWE = ref enum_sideface;
            EnumCubeRotation_NorthPole enum_rotation = EnumCubeRotation_NorthPole.Unassigned;
            bool bSideFace = SideFaceWasClicked(par_point, ref enum_rotation);
            if (bSideFace) new_tile.Enum_CubeRotation = enum_rotation;
            if (bSideFace) new_tile.Enum_Color = (enum_rotation == EnumCubeRotation_NorthPole.Clockwise ?
                                                  this.GetColorOfSideFace_ClockwiseFromFront() :
                                                  this.GetColorOfSideFace_CounterClockwise());
            if (bSideFace) new_tile.Enum_FacePositionNSWE = GetFacePositionOfColor(new_tile.Enum_Color);
            if (bSideFace) return new_tile;

            //
            // It's definitely possible, perhaps even probable, that nothing associated
            //    with this RubiksPieceCorner was clicked.  Return the null pointer.
            //
            return null;

        }


        //Added 11/17/2020 thomas downes
        //
        //public abstract EnumAll12Faces WhichSideIsClicked(Point par_point);

        public bool FrontFaceWasClicked(Point par_point)
        {
            //
            //Added 11/17/2020 thomas downes
            //
            //return null;

            if (par_point.X < _rectangleFrontFace.X + _rectangleFrontFace.Width)
                if (par_point.X > _rectangleFrontFace.X)
                    if (par_point.Y < _rectangleFrontFace.Y + _rectangleFrontFace.Height)
                        if (par_point.Y > _rectangleFrontFace.Y)
                            return true;

            return false;

        }


        public bool SideFaceWasClicked(Point par_point)
        {
            //
            //Added 11/17/2020 thomas downes
            //
            //return null;

            //
            //Step 1 of 2:  Check Side Face #CW (Clockwise from front-face).  
            //
            if (par_point.X < _rectangleSideFace_CW.X + _rectangleSideFace_CW.Width)
                if (par_point.X > _rectangleSideFace_CW.X)
                    if (par_point.Y < _rectangleSideFace_CW.Y + _rectangleSideFace_CW.Height)
                        if (par_point.Y > _rectangleSideFace_CW.Y)
                            return true;

            //
            //Step 2 of 2:  Check Side Face #CCW (Counter-Clockwise from front-face).  
            //
            if (par_point.X < _rectangleSideFace_CCW.X + _rectangleSideFace_CCW.Width)
                if (par_point.X > _rectangleSideFace_CCW.X)
                    if (par_point.Y < _rectangleSideFace_CCW.Y + _rectangleSideFace_CCW.Height)
                        if (par_point.Y > _rectangleSideFace_CCW.Y)
                            return true;

            return false;

        }


        public bool SideFaceWasClicked(Point par_point, ref EnumCubeRotation_NorthPole par_enum)
        {
            //
            //Added 11/17/2020 thomas downes 
            //
            //return null;

            //
            //Step 1 of 2:  Check Side Face #CW (Clockwise from front-face).  
            //
            if (par_point.X < _rectangleSideFace_CW.X + _rectangleSideFace_CW.Width)
                if (par_point.X > _rectangleSideFace_CW.X)
                    if (par_point.Y < _rectangleSideFace_CW.Y + _rectangleSideFace_CW.Height)
                        if (par_point.Y > _rectangleSideFace_CW.Y) // return true; 
                        {
                            par_enum = EnumCubeRotation_NorthPole.Clockwise;
                            return true;
                        }

            //
            //Step 2 of 2:  Check Side Face #CCW (Counter-Clockwise from front-face).  
            //
            if (par_point.X < _rectangleSideFace_CCW.X + _rectangleSideFace_CCW.Width)
                if (par_point.X > _rectangleSideFace_CCW.X)
                    if (par_point.Y < _rectangleSideFace_CCW.Y + _rectangleSideFace_CCW.Height)
                        if (par_point.Y > _rectangleSideFace_CCW.Y) //---return true;
                            {
                                par_enum = EnumCubeRotation_NorthPole.Counterclock;
                                return true;
                            }

            return false;

        }


        #region NotYetEncapsulated

        public void FrontFace_1030_ReorientTo(EnumAll12Faces par_enum)
        {
            //
            // Added 11/15/2020 thomas downes
            //

            //This will take care of determining the o'clock position
            //  of the piece.  
            //this.ReorientPiece_Complex(par_enum);

            //throw new NotImplementedException("The side faces must be addressed.");

            EnumFaceNum start_whichIsFront = this.WhichFaceIsFront;
            EnumFaceNum start_whichIsNorth = this.WhichFaceIsN_of_front;
            EnumFaceNum start_whichIsEast = this.WhichFaceIsE_of_front;
            EnumFaceNum start_whichIsSouth = this.WhichFaceIsS_of_front;
            EnumFaceNum start_whichIsWest = this.WhichFaceIsW_of_front;
            //Added 11/15/2020 thomas downes
            EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

            switch (par_enum)
            {
                //
                // The top-left piece (10:30) is now moved to the upper-right corner (130). 
                //
                case EnumAll12Faces.F0130:
                    this.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this.WhichFaceIsN_of_front = start_whichIsWest;
                    this.WhichFaceIsE_of_front = start_whichIsNorth;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_NNE:
                    this.WhichFaceIsFront = start_whichIsNorth;
                    this.WhichFaceIsN_of_front = start_whichIsFront;
                    this.WhichFaceIsE_of_front = start_whichIsWest;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_ENE:
                    this.WhichFaceIsFront = start_whichIsWest;
                    this.WhichFaceIsN_of_front = start_whichIsNorth;  // No change.
                    this.WhichFaceIsE_of_front = start_whichIsFront;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The top-left piece (10:30) is now moved to the bottom-right corner.  
                //
                case EnumAll12Faces.F0430:
                    this.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = start_whichIsWest;
                    this.WhichFaceIsS_of_front = start_whichIsNorth;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_ESE:
                    this.WhichFaceIsFront = start_whichIsNorth;
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = start_whichIsFront;
                    this.WhichFaceIsS_of_front = start_whichIsWest;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_SSE:
                    this.WhichFaceIsFront = start_whichIsWest;
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = start_whichIsNorth;
                    this.WhichFaceIsS_of_front = start_whichIsFront;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The top-left (10:30) piece is now in the bottom-left corner.  
                //
                case EnumAll12Faces.F0730:
                    this.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = start_whichIsWest;
                    this.WhichFaceIsW_of_front = start_whichIsNorth;
                    break;

                case EnumAll12Faces._730_SSW:
                    this.WhichFaceIsFront = start_whichIsNorth;
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = start_whichIsFront;
                    this.WhichFaceIsW_of_front = start_whichIsWest;
                    break;

                case EnumAll12Faces._730_WSW:
                    this.WhichFaceIsFront = start_whichIsWest;
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = start_whichIsNorth;
                    this.WhichFaceIsW_of_front = start_whichIsFront;
                    break;


                //
                // The top-left piece is now in the top-left corner.... not likely!!?? 
                //
                case EnumAll12Faces.F1030: break; // No change !!!

                case EnumAll12Faces._1030_WNW:
                    this.WhichFaceIsFront = start_whichIsNorth;
                    this.WhichFaceIsN_of_front = start_whichIsWest;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = start_whichIsFront;
                    break;

                case EnumAll12Faces._1030_NNW:
                    this.WhichFaceIsFront = start_whichIsWest;
                    this.WhichFaceIsN_of_front = start_whichIsFront;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = start_whichIsNorth;
                    break;


            }

        }


        public void FrontFace_130_ReorientTo(EnumAll12Faces par_enum)
        {
            //
            // Added 11/15/2020 thomas downes
            //
            //throw new NotImplementedException();
            EnumFaceNum start_whichIsFront = this.WhichFaceIsFront;
            EnumFaceNum start_whichIsNorth = this.WhichFaceIsN_of_front;
            EnumFaceNum start_whichIsEast = this.WhichFaceIsE_of_front;
            EnumFaceNum start_whichIsSouth = this.WhichFaceIsS_of_front;
            EnumFaceNum start_whichIsWest = this.WhichFaceIsW_of_front;
            //Added 11/15/2020 thomas downes
            EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

            //
            //We have to specify the new side-faces. 
            //
            switch (par_enum)
            {
                //
                // The top-right piece (1:30) is now moved to the upper-right corner (130). 
                //
                case EnumAll12Faces.F0130: break; // No change !!!

                case EnumAll12Faces._130_NNE:
                    this.WhichFaceIsFront = start_whichIsEast;
                    this.WhichFaceIsN_of_front = start_whichIsFront;
                    this.WhichFaceIsE_of_front = start_whichIsNorth;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._130_ENE:
                    this.WhichFaceIsFront = start_whichIsNorth;
                    this.WhichFaceIsN_of_front = start_whichIsEast;  // No change.
                    this.WhichFaceIsE_of_front = start_whichIsFront;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The top-right piece (1:30) is now moved to the bottom-right corner.  
                //
                case EnumAll12Faces.F0430:
                    this.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = start_whichIsNorth;
                    this.WhichFaceIsS_of_front = start_whichIsEast;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_ESE:
                    this.WhichFaceIsFront = start_whichIsEast;
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = start_whichIsFront;
                    this.WhichFaceIsS_of_front = start_whichIsNorth;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case EnumAll12Faces._430_SSE:
                    this.WhichFaceIsFront = start_whichIsNorth;
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = start_whichIsEast;
                    this.WhichFaceIsS_of_front = start_whichIsFront;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;


                //
                // The top-left (1:30) piece is now in the bottom-left corner.  
                //
                case EnumAll12Faces.F0730:
                    this.WhichFaceIsFront = start_whichIsFront;  // i.e. !!! no change !!!
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = start_whichIsNorth;
                    this.WhichFaceIsW_of_front = start_whichIsEast;
                    break;

                case EnumAll12Faces._730_SSW:
                    this.WhichFaceIsFront = start_whichIsEast;
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = start_whichIsFront;
                    this.WhichFaceIsW_of_front = start_whichIsNorth;
                    break;

                case EnumAll12Faces._730_WSW:
                    this.WhichFaceIsFront = start_whichIsNorth;
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = start_whichIsEast;
                    this.WhichFaceIsW_of_front = start_whichIsFront;
                    break;


                //
                // The top-right (1:30 pm) piece is now in the top-left corner. 
                //
                case EnumAll12Faces.F1030:
                    this.WhichFaceIsFront = start_whichIsFront;
                    this.WhichFaceIsN_of_front = start_whichIsEast;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = start_whichIsNorth;
                    break;

                case EnumAll12Faces._1030_WNW:
                    this.WhichFaceIsFront = start_whichIsEast;
                    this.WhichFaceIsN_of_front = start_whichIsNorth;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = start_whichIsFront;
                    break;

                case EnumAll12Faces._1030_NNW:
                    this.WhichFaceIsFront = start_whichIsWest;
                    this.WhichFaceIsN_of_front = start_whichIsNorth;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = start_whichIsEast;
                    break;

            }
        }


        public void ReorientPiece_Complex_From430(EnumAll12Faces par_enum)
        {
            //
            // Added 11/15/2020 thomas downes
            //
            //throw new NotImplementedException();
            EnumFaceNum start_whichIsFront = this.WhichFaceIsFront;
            EnumFaceNum start_whichIsNorth = this.WhichFaceIsN_of_front;
            EnumFaceNum start_whichIsEast = this.WhichFaceIsE_of_front;
            EnumFaceNum start_whichIsSouth = this.WhichFaceIsS_of_front;
            EnumFaceNum start_whichIsWest = this.WhichFaceIsW_of_front;
            //Added 11/15/2020 thomas downes
            EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;




        }

        public void ReorientPiece_Complex_From730(EnumAll12Faces par_enum)
        {
            //
            // Added 11/15/2020 thomas downes
            //
            //throw new NotImplementedException();
            EnumFaceNum start_whichIsFront = this.WhichFaceIsFront;
            EnumFaceNum start_whichIsNorth = this.WhichFaceIsN_of_front;
            EnumFaceNum start_whichIsEast = this.WhichFaceIsE_of_front;
            EnumFaceNum start_whichIsSouth = this.WhichFaceIsS_of_front;
            EnumFaceNum start_whichIsWest = this.WhichFaceIsW_of_front;
            //Added 11/15/2020 thomas downes
            EnumFaceNum start_whichIs_NotSpecified = EnumFaceNum.NotSpecified;

        }

        #endregion


        //
        // Added 11/20/2020 thomas downes  
        //
        public override string ToString()
        {
            //return base.ToString();

            //
            // Added 11/19/2020 td
            //
            // Example #1:
            //
            //     NE==F1:N_F2:E_F3:F 
            //
            // Example #1:
            //
            //     SW==F1:S_F2:W_F3:F
            //
            //     (F = Front Face) 
            //
            string strOutput = "";
            string strNE_SE_SW_NW = "";
            string strDirectionF1 = "";
            string strDirectionF2 = "";
            string strDirectionF3 = "";

            switch (this.FrontClockFacePosition.EnumValue())
            {
                //
                // Added 11/20/2020 thomas downes
                //
                case (FrontClockFace_Enum.one_thirty): strNE_SE_SW_NW = "NE"; break;
                case (FrontClockFace_Enum.four_thirty): strNE_SE_SW_NW = "SE"; break;
                case (FrontClockFace_Enum.seven_thirty): strNE_SE_SW_NW = "SW"; break;
                case (FrontClockFace_Enum.ten_thirty): strNE_SE_SW_NW = "NW"; break;
                default:
                    strNE_SE_SW_NW = "__";
                    throw new NotImplementedException("");
            }

            //
            // Partial output. 
            //
            //---strOutput = strNE_SE_SW_NW + "==";

            // Face #1
            strDirectionF1 = "F1:";  // + this.FaceColor1of3
            if (EnumFaceNum.Face1 == this.WhichFaceIsFront) strDirectionF1 += "F";  // F = Front 
            if (EnumFaceNum.Face1 == this.WhichFaceIsN_of_front) strDirectionF1 += "N"; // N = North 
            if (EnumFaceNum.Face1 == this.WhichFaceIsE_of_front) strDirectionF1 += "E";
            if (EnumFaceNum.Face1 == this.WhichFaceIsS_of_front) strDirectionF1 += "S";
            if (EnumFaceNum.Face1 == this.WhichFaceIsW_of_front) strDirectionF1 += "W";

            // Face #2
            strDirectionF2 = "F2:";  // + this.FaceColor1of3
            if (EnumFaceNum.Face2 == this.WhichFaceIsFront) strDirectionF2 += "F";  // F = Front 
            if (EnumFaceNum.Face2 == this.WhichFaceIsN_of_front) strDirectionF2 += "N"; // N = North 
            if (EnumFaceNum.Face2 == this.WhichFaceIsE_of_front) strDirectionF2 += "E";
            if (EnumFaceNum.Face2 == this.WhichFaceIsS_of_front) strDirectionF2 += "S";
            if (EnumFaceNum.Face2 == this.WhichFaceIsW_of_front) strDirectionF2 += "W";

            // Face #3
            strDirectionF3 = "F3:";  // + this.FaceColor1of3
            if (EnumFaceNum.Face3 == this.WhichFaceIsFront) strDirectionF3 += "F";  // F = Front 
            if (EnumFaceNum.Face3 == this.WhichFaceIsN_of_front) strDirectionF3 += "N"; // N = North 
            if (EnumFaceNum.Face3 == this.WhichFaceIsE_of_front) strDirectionF3 += "E";
            if (EnumFaceNum.Face3 == this.WhichFaceIsS_of_front) strDirectionF3 += "S";
            if (EnumFaceNum.Face3 == this.WhichFaceIsW_of_front) strDirectionF3 += "W";

            //
            // Return the output string. 
            //
            // Example #1:
            //
            //     NE==F1:N_F2:E_F3:F 
            //
            // Example #1:
            //
            //     SW==F1:S_F2:W_F3:F
            //
            //     (F = Front Face) 
            //
            strOutput = (strNE_SE_SW_NW + "==" +
                strDirectionF1 + "_" + strDirectionF2 + "_" + strDirectionF3);

            return strOutput;
        }

        public void ParseBriefInputString_UpdatePosition(string par_strBriefDescription)
        {
            //
            // Step #1:  Parse the input string into two(2) parts.  
            //
            string[] separator1 = new string[] { "==" };
            string[] parsed_array_step1 = par_strBriefDescription.Split(separator1, StringSplitOptions.RemoveEmptyEntries);

            //
            //Examples:  BOY/SW, BYR/NE, GRY/NW, GYO/SE   
            //
            string strColorsAndClockPosition = parsed_array_step1[0];
            string strZZZ_slash = strColorsAndClockPosition.Substring(0, "ZZZ/".Length);
            string strNE_SE_SW_NW = strColorsAndClockPosition.Substring("ZZZ/".Length, 2);

            //
            // Step #2:  Parse the 90-degree revolutionary position on the front face of the Rubik's Cube
            //
            switch (strNE_SE_SW_NW)
            {
                case ("NE"): this.FrontClockFacePosition = FrontClockFace.one_thirty_obj; break;
                case ("SE"): this.FrontClockFacePosition = FrontClockFace.four_thirty_obj; break;
                case ("SW"): this.FrontClockFacePosition = FrontClockFace.seven_thirty_obj; break;
                case ("NW"): this.FrontClockFacePosition = FrontClockFace.ten_thirty_obj; break;
                default: throw new NotImplementedException("Should be NE or SE or SW or NW.");
            }

            //
            // Step # 3: Parse the 120-degree rotation of the piece, about the corner
            //            (vs. position on the front face of the Rubik's Cube).
            //
            // Example #1:
            //
            //     F1:N_F2:E_F3:F  
            //
            // Example #2:
            //
            //     F1:S_F2:W_F3:F
            //
            //     (F = Front Face) 
            //
            string strFaceDeterminations = parsed_array_step1[1];

            char[] separator_underscore = new char[] { '_' };
            string[] parsed_array_step3 = strFaceDeterminations.Split(separator_underscore, StringSplitOptions.RemoveEmptyEntries);

            //Check that the string array has three(3) items, 
            //  corresponding to three(3) faces. ---11/20/2020 td
            if (parsed_array_step3.Length != 3)
                throw new NotImplementedException("There must be three substrings, F1:_, F2:_, and F3:_.");

            if (parsed_array_step3[0].StartsWith("F1") == false) throw new NotImplementedException("The 1st substring must start with F1.");
            if (parsed_array_step3[1].StartsWith("F2") == false) throw new NotImplementedException("The 2nd substring must start with F2.");
            if (parsed_array_step3[2].StartsWith("F3") == false) throw new NotImplementedException("The 3rd substring must start with F3.");

            //Set default values. 
            this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;

            //Face #1 of 3
            string strFace1_NESW = parsed_array_step3[1 - 1].Substring("F1:".Length);
            if (strFace1_NESW == "N") this.WhichFaceIsN_of_front = EnumFaceNum.Face1;
            if (strFace1_NESW == "E") this.WhichFaceIsE_of_front = EnumFaceNum.Face1;
            if (strFace1_NESW == "S") this.WhichFaceIsS_of_front = EnumFaceNum.Face1;
            if (strFace1_NESW == "W") this.WhichFaceIsW_of_front = EnumFaceNum.Face1;
            if (strFace1_NESW == "F") this.WhichFaceIsFront = EnumFaceNum.Face1;  // F = Front face. 

            //Face #2 of 3
            string strFace2_NESW = parsed_array_step3[2 - 1].Substring("F2:".Length);
            if (strFace2_NESW == "N") this.WhichFaceIsN_of_front = EnumFaceNum.Face2;
            if (strFace2_NESW == "E") this.WhichFaceIsE_of_front = EnumFaceNum.Face2;
            if (strFace2_NESW == "S") this.WhichFaceIsS_of_front = EnumFaceNum.Face2;
            if (strFace2_NESW == "W") this.WhichFaceIsW_of_front = EnumFaceNum.Face2;
            if (strFace2_NESW == "F") this.WhichFaceIsFront = EnumFaceNum.Face2;  // F = Front face. 

            string strFace3_NESW = parsed_array_step3[3 - 1].Substring("F1:".Length);
            if (strFace3_NESW == "N") this.WhichFaceIsN_of_front = EnumFaceNum.Face3;
            if (strFace3_NESW == "E") this.WhichFaceIsE_of_front = EnumFaceNum.Face3;
            if (strFace3_NESW == "S") this.WhichFaceIsS_of_front = EnumFaceNum.Face3;
            if (strFace3_NESW == "W") this.WhichFaceIsW_of_front = EnumFaceNum.Face3;
            if (strFace3_NESW == "F") this.WhichFaceIsFront = EnumFaceNum.Face3;  // F = Front face. 

        }


        public RubiksPieceCorner NextPieceClockwise(Back.ClassBackside par_backSide)
        {
            //
            // Added 12/3/2020 Thomas Downes 
            //
            FrontClockFace enumBYR = par_backSide._pieceBYR.FrontClockFacePosition;
            FrontClockFace enumGRY = par_backSide._pieceGRY.FrontClockFacePosition;
            FrontClockFace enumGYO = par_backSide._pieceGYO.FrontClockFacePosition;

            if (EnumStaticClass.AdjacentClockwise(this, par_backSide._pieceBYR)) return par_backSide._pieceBYR;
            if (EnumStaticClass.AdjacentClockwise(this, par_backSide._pieceGRY)) return par_backSide._pieceGRY;
            if (EnumStaticClass.AdjacentClockwise(this, par_backSide._pieceGYO)) return par_backSide._pieceGYO;

            return null;

        }


        public void Set_FrontFacePosition(FrontClockFace_Enum par_enum)
        {
            // Added 8/21/2023 
            FrontClockFacePosition.SetFrontClockPosition(par_enum);

        }

        public void SetTemporaryTextMarker_ClockPosition()
        {
            //
            // Added 1/11/2021 thomas downes
            //
            this.FillFacesWithText = true;  // Added 2/5/2021 td 
            this.FillFacesWithColor = false;  // Added 2/5/2021 td 

            //if (this.FrontClockFacePosition == FrontClockFace.four_thirty) this.TemporaryTextMarker = "4:30";
            //if (this.FrontClockFacePosition == FrontClockFace.one_thirty) this.TemporaryTextMarker = "1:30";
            //if (this.FrontClockFacePosition == FrontClockFace.ten_thirty) this.TemporaryTextMarker = "10:30";
            //if (this.FrontClockFacePosition == FrontClockFace_Enum.seven_thirty) this.TemporaryTextMarker = "7:30";

            if (this.FrontClockFacePosition.Equals(FrontClockFace.four_thirty)) this.TemporaryTextMarker = "4:30";
            if (this.FrontClockFacePosition.Equals(FrontClockFace.one_thirty)) this.TemporaryTextMarker = "1:30";
            if (this.FrontClockFacePosition.Equals(FrontClockFace.ten_thirty)) this.TemporaryTextMarker = "10:30";
            if (this.FrontClockFacePosition.Equals(FrontClockFace_Enum.seven_thirty)) this.TemporaryTextMarker = "7:30";

            //Added 1/11/2021
            //
            const bool c_boolCleanColon30 = false;  // true; 
            if (c_boolCleanColon30)
            {
                // Remove the ":30" from the text.  --1/11/2021 thomas downes
                this.TemporaryTextMarker = this.TemporaryTextMarker.Replace(":30", "");
            }

            //Indicate that the front face has the textual marker.  
            //this.TemporaryTextMarker_WhichFace = WhichFaceIsFront;
            Color color_OfFrontFace = Color.Black;
            if (this.WhichFaceIsFront == EnumFaceNum.Face1) color_OfFrontFace = this.FaceColor1of3;
            if (this.WhichFaceIsFront == EnumFaceNum.Face2) color_OfFrontFace = this.FaceColor2of3;
            if (this.WhichFaceIsFront == EnumFaceNum.Face3) color_OfFrontFace = this.FaceColor3of3;
            this.TemporaryTextMarker_Color = color_OfFrontFace;

        }


        public bool TemporaryTextMarker_IsClockwiseFromFront()
        {
            //
            // Added 1/11/2021
            //
            //   This corresponds to:
            //       PaintSideFace_ClockwiseFromFront
            //
            throw new NotImplementedException();

        }

        public bool TemporaryTextMarker_IsCounterCWFromFront()
        {
            //
            // Added 1/11/2021
            //
            //   This corresponds to:
            //        PaintSideFace_CounterClockwise
            //
            throw new NotImplementedException();

            //SetTemporaryTextMarker_ClockPosition();

        }


        public void ClearTemporaryTextMarker_ClockPosition()
        {
            //
            // Added 2/5/2021 thomas downes
            //
            this.FillFacesWithText = false;  // Added 2/5/2021 td 
            this.FillFacesWithColor = true;  // Added 2/5/2021 td 

            this.TemporaryTextMarker = "";  // Remove the string. 



        }


        public Color Color_OfFrontFace()
        {
            //
            // Added 2/14/2021 Thomas C. Downes 
            //
            Color colorFace1 = this.FaceColor1of3;
            Color colorFace2 = this.FaceColor2of3;
            Color colorFace3 = this.FaceColor3of3;

            if (EnumFaceNum.Face1 == this.WhichFaceIsFront) return colorFace1;
            if (EnumFaceNum.Face2 == this.WhichFaceIsFront) return colorFace2;
            if (EnumFaceNum.Face3 == this.WhichFaceIsFront) return colorFace3;

            // Added 2/14/2021 thomas downes
            throw new NotImplementedException();

        }


        public void PivotPerspective_BackOrFrontToSide(EnumCubeRotation_NorthPole par_enumRotation)
        {
            //
            // Added 4/2/2021 Thomas Downes  
            //
            //  ----DIFFICULT & CONFUSING-----
            //  FrontClockFacePosition is where the piece appears on the Clock Dial (Face),
            //    ONLY FROM THE FRONT OR BACK PERSPECTIVE.  NOT FROM THE SIDEVIEW. 
            //    ----4/2/2021 Thomas C. Downes
            //
            var temp_WhichFaceIsFront = this.WhichFaceIsFront;

            //Added 4/2/2021 td
            EnumLeftOrRight temp_FrontClock_LeftOrRight = EnumLeftOrRight.Unassigned;

            //if (this.FrontClockFacePosition == FrontClockFace.one_thirty) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Right;
            //if (this.FrontClockFacePosition == FrontClockFace.four_thirty) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Right;
            //if (this.FrontClockFacePosition == FrontClockFace.seven_thirty) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Left;
            //if (this.FrontClockFacePosition == FrontClockFace.ten_thirty) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Left;

            if (this.FrontClockFacePosition.Equals(FrontClockFace.one_thirty)) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Right;
            if (this.FrontClockFacePosition.Equals(FrontClockFace.four_thirty)) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Right;
            if (this.FrontClockFacePosition.Equals(FrontClockFace.seven_thirty)) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Left;
            if (this.FrontClockFacePosition.Equals(FrontClockFace.ten_thirty)) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Left;

            bool boolSide_Left = (temp_FrontClock_LeftOrRight == EnumLeftOrRight.Left);
            bool boolSide_Right = (temp_FrontClock_LeftOrRight == EnumLeftOrRight.Right);

            //
            // Part 1 of 2. Account for right-hand positions (4:30 & 1:30). 
            //
            if (boolSide_Right)
            {
                //--if (this.FrontClockFacePosition == FrontClockFace.one_thirty()) this.FrontClockFacePosition = FrontClockFace.ten_thirty;
                //--if (this.FrontClockFacePosition == FrontClockFace.four_thirty()) this.FrontClockFacePosition = FrontClockFace_Enum.seven_thirty;
                if (this.FrontClockFacePosition.Equals(FrontClockFace.one_thirty)) this.FrontClockFacePosition = FrontClockFace.ten_thirty_obj;
                if (this.FrontClockFacePosition.Equals(FrontClockFace.four_thirty)) this.FrontClockFacePosition = FrontClockFace.seven_thirty_obj;

                //Almost forgot the following....
                this.WhichFaceIsFront = this.WhichFaceIsE_of_front;
                this.WhichFaceIsW_of_front = temp_WhichFaceIsFront;
                this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;

            }

            //
            // Part 2 of 2. Account for left-hand positions (10:30 & 7:30).  
            //
            if (boolSide_Left)
            {
                //==if (this.FrontClockFacePosition == FrontClockFace_Enum.seven_thirty) this.FrontClockFacePosition = FrontClockFace.four_thirty();
                //==if (this.FrontClockFacePosition == FrontClockFace.ten_thirty) this.FrontClockFacePosition = FrontClockFace.one_thirty();

                if (this.FrontClockFacePosition.Equals(FrontClockFace.seven_thirty)) 
                    this.FrontClockFacePosition = FrontClockFace.four_thirty_obj;
                if (this.FrontClockFacePosition.Equals(FrontClockFace.ten_thirty)) 
                    this.FrontClockFacePosition = FrontClockFace.one_thirty_obj;

                //Almost forgot the following....
                this.WhichFaceIsFront = this.WhichFaceIsW_of_front;
                this.WhichFaceIsE_of_front = temp_WhichFaceIsFront;
                this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            }

            //
            // Last step, toggle the property EnumFrontOrBackOfCube.
            //
            bool bClockwise = (par_enumRotation == EnumCubeRotation_NorthPole.Clockwise);
            bool bCounterclock = (par_enumRotation == EnumCubeRotation_NorthPole.Counterclock);
            EnumStaticClass.SwitchFrontAndBack_IfNeeded(this, bClockwise, bCounterclock);


        }


        public EnumFacePositionNSWE GetFacePositionOfColor(Color par_colorOfTile)
        {
            //
            // Added 7/21/2021 Thomas DOWNES
            //
            bool bFrontFaceHasSpecifiedColor = false;
            //bool bMatches_SideFace_Clockwise = false;
            //bool bMatches_SideFace_Counterwise = false;

            bFrontFaceHasSpecifiedColor = (par_colorOfTile == GetColorOfFrontFace());
            if (bFrontFaceHasSpecifiedColor) return EnumFacePositionNSWE.FrontFacing;

            //bMatches_SideFace_Clockwise = (par_colorOfFace == GetColorOfSideFace_ClockwiseFromFront());
            //bMatches_SideFace_Counterwise = (par_colorOfFace == GetColorOfSideFace_CounterClockwise());

            //if (bMatches_SideFace_Clockwise)
            //{
            //    var eastFace = this.WhichFaceIsE_of_front;
            //}

            //EnumFaceNum faceNum_North = this.WhichFaceIsN_of_front;
            //EnumFaceNum faceNum_South = this.WhichFaceIsS_of_front;
            //EnumFaceNum faceNum_East = this.WhichFaceIsE_of_front;
            //EnumFaceNum faceNum_West = this.WhichFaceIsW_of_front;

            //bool boolMatchesTile1of3 = (this.FaceColor1of3 == par_colorOfTile);
            //bool boolMatchesTile2of3 = (this.FaceColor2of3 == par_colorOfTile);
            //bool boolMatchesTile3of3 = (this.FaceColor2of3 == par_colorOfTile);

            EnumFaceNum enum_faceNumWithColor = (this.FaceColor1of3 == par_colorOfTile ? EnumFaceNum.Face1 :
                                                  (this.FaceColor2of3 == par_colorOfTile ? EnumFaceNum.Face2 :
                                                    (this.FaceColor3of3 == par_colorOfTile ? EnumFaceNum.Face3 :
                                                      EnumFaceNum.NotApplicable_DifferentPiece)));

            EnumFacePositionNSWE enum_facePosition = 
                (this.WhichFaceIsN_of_front == enum_faceNumWithColor ? EnumFacePositionNSWE.N_side_of_front :
                (this.WhichFaceIsS_of_front == enum_faceNumWithColor ? EnumFacePositionNSWE.S_side_of_front :
                (this.WhichFaceIsE_of_front == enum_faceNumWithColor ? EnumFacePositionNSWE.E_side_of_front :
                (this.WhichFaceIsW_of_front == enum_faceNumWithColor ? EnumFacePositionNSWE.W_side_of_front :
                                                      EnumFacePositionNSWE.NotSpecified))));

            return enum_facePosition;

        }


        public string GetSerialization_Maneuver()
        {
            //
            // Added 10/11/2021 Thomas Downes 
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
            //    //  ---10/11/2021 thomas c. downes
            //
            //if (false  +++++ =====) 
            return this.TemporaryTextMarker;

        }


    }
}
