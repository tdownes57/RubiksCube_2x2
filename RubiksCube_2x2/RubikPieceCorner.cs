using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas downes

namespace RubiksCube_2x2
{
    //abstract class RubikPieceCorner
    abstract class RubikPieceCorner
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

        //
        //          [.N.]   [.N.]
        //   [.W.] [10:30] [1:30]  [.E.]
        //   [.W.]  [ 7:30] [3:30]  [.E.]
        //           [.S.]   [.S.]
        //
        // (The [. .] faces are _side_ faces.) 
        //
        public FrontClockFace FrontClockFacePosition;
        public FrontClockFace FrontClockFacePosition_Prior;

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
            switch (this.FrontClockFacePosition)
            {
                case FrontClockFace.one_thirty: return ColorByFaceNumber(this.WhichFaceIsN_of_front);
                case FrontClockFace.four_thirty: return ColorByFaceNumber(this.WhichFaceIsE_of_front);
                case FrontClockFace.seven_thirty: return ColorByFaceNumber(this.WhichFaceIsS_of_front);
                case FrontClockFace.ten_thirty: return ColorByFaceNumber(this.WhichFaceIsW_of_front);
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
            switch (this.FrontClockFacePosition)
            {
                case FrontClockFace.one_thirty: return ColorByFaceNumber(this.WhichFaceIsE_of_front);
                case FrontClockFace.four_thirty: return ColorByFaceNumber(this.WhichFaceIsS_of_front);
                case FrontClockFace.seven_thirty: return ColorByFaceNumber(this.WhichFaceIsW_of_front);
                case FrontClockFace.ten_thirty: return ColorByFaceNumber(this.WhichFaceIsN_of_front);
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
            Color color_OfFrontFace = GetColorOfFrontFace();
            Brush a_brush = new SolidBrush(color_OfFrontFace);

            //Added 1/11/2021 Thomas Downes
            //bool bTextMarkerIsStillInFront = (this.TemporaryTextMarker_WhichFace == WhichFaceIsFront);
            bool bTextMarkerIsStillInFront = (this.TemporaryTextMarker_Color == color_OfFrontFace);
            bool bHasTemporaryTextMarker = (this.TemporaryTextMarker != "") && (bTextMarkerIsStillInFront);

            if (bHasTemporaryTextMarker && p_boolDoPaintTheFront)
            {
                //
                // Added 1/11/2021 
                //
                par_graph.DrawString(this.TemporaryTextMarker, new Font("Comic Sans MS", 13), a_brush, 0, 0);

            }

            else if (p_boolDoPaintTheFront)
            {
                //
                // We are _not_ merely populating the "out" parameters.
                //   We _do_ in fact want to paint the front face. 
                //
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
                //--if (this.FrontClockFacePosition == FrontClockFace.seven_thirty) return;
                if (this.FrontClockFacePosition == FrontClockFace.ten_thirty) bFarSoPerhapsNotVisible = true;
                if (this.FrontClockFacePosition == FrontClockFace.seven_thirty) bFarSoPerhapsNotVisible = true;

                //Check to see if the piece is "ready" to be painted. 
                bMaybeNotYetReady = (this.WhichFaceIsE_of_front == EnumFaceNum.NotSpecified);
                //---if (boolNotYetReady) return;  

            }

            else if (par_enumView == EnumPrimaryView.Left)
            {
                //
                // The pieces in the 1:30 & 4:30 positions won't be painted. 
                //
                //---if (this.FrontClockFacePosition == FrontClockFace.one_thirty) return;
                //--if (this.FrontClockFacePosition == FrontClockFace.four_thirty) return;
                if (this.FrontClockFacePosition == FrontClockFace.one_thirty) bFarSoPerhapsNotVisible = true;
                if (this.FrontClockFacePosition == FrontClockFace.four_thirty) bFarSoPerhapsNotVisible = true;

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

            //Added 1/11/2021 Thomas Downes
            //bool bTextMarkerIsClockwiseFromFront = (this.TemporaryTextMarker_IsClockwiseFromFront());
            bool bTextMarkerIsClockwiseFromFront = (this.TemporaryTextMarker_Color == color_ofSideFace);
            bool bHasTemporaryTextMarker = (this.TemporaryTextMarker != "") && (bTextMarkerIsClockwiseFromFront);

            if (bHasTemporaryTextMarker)
            {
                //
                // Added 1/11/2021.   E.g. put "4:30" to indicate that the prior front face
                //   has moved to one of the sides. 
                //
                par_graphics.DrawString(this.TemporaryTextMarker, 
                    new Font("Comic Sans MS", 11),
                    a_brush, 0, 0);

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

            //Added 1/11/2021 Thomas Downes
            bool bTextMarkerIsThisFace = (this.TemporaryTextMarker_Color == color_ofSideFace);
            bool bHasTemporaryTextMarker = (this.TemporaryTextMarker != "") && (bTextMarkerIsThisFace);

            if (bHasTemporaryTextMarker)
            {

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
            FrontClockFace new_position = FrontClockFace.unassigned;

            switch (this.FrontClockFacePosition)
            {
                case FrontClockFace.one_thirty: new_position = FrontClockFace.four_thirty; SimpleRevolution_to430_from130(); break;
                case FrontClockFace.four_thirty: new_position = FrontClockFace.seven_thirty; SimpleRevolution_to730_from430(); break;
                case FrontClockFace.seven_thirty: new_position = FrontClockFace.ten_thirty; SimpleRevolution_to1030_from730(); break;
                case FrontClockFace.ten_thirty: new_position = FrontClockFace.one_thirty; SimpleRevolution_to130_from1030(); break;
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


        internal void ReorientPiece_FrontFaceIsFace1(FrontClockFace par_enum)
        {
            //
            //Added 11/14/2020 thomas downes
            //
            //Added 11/15/2020 thomas downes
            this.WhichFaceIsFront = EnumFaceNum.Face1;

            //
            //Determine the two(2) side faces. 
            //
            switch (par_enum)
            {
                case (FrontClockFace.one_thirty):
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace.four_thirty):
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace.seven_thirty):
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face3;
                    break;

                case (FrontClockFace.ten_thirty):
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face2;
                    break;

                default:
                    throw new Exception("Par_enum value is not recognized. #1 of 3");
            }

        }


        internal void ReorientPiece_FrontFaceIsFace2(FrontClockFace par_enum)
        {
            //
            //Added 11/14/2020 thomas downes
            //
            //Added 11/15/2020 thomas downes
            this.WhichFaceIsFront = EnumFaceNum.Face2;

            //
            //Determine the two(2) side faces. 
            //
            switch (par_enum)
            {
                case (FrontClockFace.one_thirty):
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace.four_thirty):
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace.seven_thirty):
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face1;
                    break;

                case (FrontClockFace.ten_thirty):
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face3;
                    break;

                default:
                    throw new Exception("Par_enum value is not recognized. #2 of 3");
            }

        }


        internal void ReorientPiece_FrontFaceIsFace3(FrontClockFace par_enum)
        {
            //
            //Added 11/14/2020 thomas downes
            //
            //Added 11/15/2020 thomas downes
            this.WhichFaceIsFront = EnumFaceNum.Face3;

            //
            //Determine the two(2) side faces. 
            //
            switch (par_enum)
            {
                case (FrontClockFace.one_thirty):
                    // The current piece being oriented is the 1:30 face, top-right. 
                    this.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace.four_thirty):
                    // The current piece being oriented is the 4:30 face, bottom-right. 
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face2;
                    this.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    break;

                case (FrontClockFace.seven_thirty):
                    // The current piece being oriented is the 7:30 face, bottom-left. 
                    this.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                    this.WhichFaceIsS_of_front = EnumFaceNum.Face1;
                    this.WhichFaceIsW_of_front = EnumFaceNum.Face2;
                    break;

                case (FrontClockFace.ten_thirty):
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
                case EnumAll12Faces.F0130: this.FrontClockFacePosition = FrontClockFace.one_thirty; break;
                case EnumAll12Faces._130_ENE: this.FrontClockFacePosition = FrontClockFace.one_thirty; break;
                case EnumAll12Faces._130_NNE: this.FrontClockFacePosition = FrontClockFace.one_thirty; break;

                //
                // The piece has moved to the 4:30 position, lower-right / southeast. 
                //
                case EnumAll12Faces.F0430: this.FrontClockFacePosition = FrontClockFace.four_thirty; break;
                case EnumAll12Faces._430_ESE: this.FrontClockFacePosition = FrontClockFace.four_thirty; break;
                case EnumAll12Faces._430_SSE: this.FrontClockFacePosition = FrontClockFace.four_thirty; break;

                //
                // The piece has moved to the 7:30 position, lower-left / southwest. 
                //
                case EnumAll12Faces.F0730: this.FrontClockFacePosition = FrontClockFace.seven_thirty; break;
                case EnumAll12Faces._730_SSW: this.FrontClockFacePosition = FrontClockFace.seven_thirty; break;
                case EnumAll12Faces._730_WSW: this.FrontClockFacePosition = FrontClockFace.seven_thirty; break;

                //
                // The piece has moved to the 10:30 position, upper-left / northwest. 
                //
                case EnumAll12Faces.F1030: this.FrontClockFacePosition = FrontClockFace.ten_thirty; break;
                case EnumAll12Faces._1030_NNW: this.FrontClockFacePosition = FrontClockFace.ten_thirty; break;
                case EnumAll12Faces._1030_WNW: this.FrontClockFacePosition = FrontClockFace.ten_thirty; break;

                default: throw new Exception("EnumAll12Faces par_enum value is not recognized.");
            }

            //EnumFaceNum frontFaceColorNum_Start = this.WhichFaceIsFront;
            //EnumFaceNum frontFaceColorNum_End = ??????;
            //this.ReorientPiece(this.FrontClockFacePosition, frontfaceColor);

            if (p_boolOnlySetClockPosition == false)  //Added 11/18/2020 thomas downes
            {
                switch (par_clockPosition_Start)
                {
                    //case FrontClockFace.ten_thirty: ReorientPiece_Complex_From1030(par_enum); break;
                    //case FrontClockFace.one_thirty: ReorientPiece_Complex_From130(par_enum); break;
                    case FrontClockFace.ten_thirty: FrontFace_1030_ReorientTo(par_enum); break;
                    case FrontClockFace.one_thirty: FrontFace_130_ReorientTo(par_enum); break;

                    case FrontClockFace.four_thirty: ReorientPiece_Complex_From430(par_enum); break;
                    case FrontClockFace.seven_thirty: ReorientPiece_Complex_From730(par_enum); break;
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

            switch (this.FrontClockFacePosition)
            {
                //
                // Added 11/20/2020 thomas downes
                //
                case (FrontClockFace.one_thirty): strNE_SE_SW_NW = "NE"; break;
                case (FrontClockFace.four_thirty): strNE_SE_SW_NW = "SE"; break;
                case (FrontClockFace.seven_thirty): strNE_SE_SW_NW = "SW"; break; 
                case (FrontClockFace.ten_thirty): strNE_SE_SW_NW = "NW"; break;
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
                case ("NE"): this.FrontClockFacePosition = FrontClockFace.one_thirty; break;
                case ("SE"): this.FrontClockFacePosition = FrontClockFace.four_thirty; break;
                case ("SW"): this.FrontClockFacePosition = FrontClockFace.seven_thirty; break;
                case ("NW"): this.FrontClockFacePosition = FrontClockFace.ten_thirty; break;
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


        public RubikPieceCorner NextPieceClockwise(Back.ClassBackside par_backSide)
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


        public void SetTemporaryTextMarker_ClockPosition()
        {
            //
            // Added 1/11/2021 thomas downes
            //
            if (this.FrontClockFacePosition == FrontClockFace.four_thirty) this.TemporaryTextMarker = "4:30";
            if (this.FrontClockFacePosition == FrontClockFace.one_thirty) this.TemporaryTextMarker = "1:30";
            if (this.FrontClockFacePosition == FrontClockFace.ten_thirty) this.TemporaryTextMarker = "10:30";
            if (this.FrontClockFacePosition == FrontClockFace.seven_thirty) this.TemporaryTextMarker = "7:30";

            //Added 1/11/2021
            //
            const bool c_boolCleanColon30 = true; 
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

        }


    }
}
