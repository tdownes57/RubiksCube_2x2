using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas downes

namespace RubiksCube_2x2
{
    abstract class RubikPieceCorner
    {
        //public System.Drawing.Color Color1of3;

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

        public abstract void Rotate_Clockwise90();
        //----public abstract void Rotate_Counterwise90();
        public abstract void ReorientPiece(FrontClockFace par_enum, Color par_frontfacecolor);

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
                default: return Color.Empty;
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
                default: return Color.Empty;
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
                default: return Color.Empty;

            }

        }


        public void PaintByGraphics(Graphics par_graphics, Point par_center_of_form)
        {
            //
            // Added 11/11/2020 thomas downes
            //
            Point point_NW; // = null;
            Point point_SW; // = null;
            Point point_NE; // = null;
            Point point_SE; // = null;

            //
            // Added 11/11/2020 thomas downes
            //
            PaintFrontFace_Base(par_graphics, par_center_of_form,
                out point_NW, out point_SW, out point_NE, out point_SE);

            //
            // Added 11/11/2020 thomas downes
            //
            PaintSideFace_ClockwiseFromFront(par_graphics, par_center_of_form,
                in point_NW, in point_SW, in point_NE, in point_SE);

            PaintSideFace_CounterClockwise(par_graphics, par_center_of_form,
                in point_NW, in point_SW, in point_NE, in point_SE);

        }

        public void PaintFrontFace_Base(Graphics par_graph, Point p_center_of_form,
                        out Point p_pointNW, out Point p_pointSW,
                        out Point p_pointNE, out Point p_pointSE)
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
            Brush a_brush = new SolidBrush(GetColorOfFrontFace());

            par_graph.FillRectangle(a_brush, frontFace);

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

            Brush a_brush = new SolidBrush(this.GetColorOfSideFace_ClockwiseFromFront());
            par_graphics.FillRectangle(a_brush, sideFace);

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

            Brush a_brush = new SolidBrush(this.GetColorOfSideFace_CounterClockwise());
            par_graphics.FillRectangle(a_brush, sideFace);

        }


        internal void Rotate_Clockwise90_base()
        {
            //
            // Added 11/12/2020 thomas downes
            //
            FrontClockFace new_position = FrontClockFace.unassigned;

            switch (this.FrontClockFacePosition)
            {
                case FrontClockFace.one_thirty: new_position = FrontClockFace.four_thirty; SimpleRotation_to430_from130(); break;
                case FrontClockFace.four_thirty: new_position = FrontClockFace.seven_thirty; SimpleRotation_to730_from430(); break;
                case FrontClockFace.seven_thirty: new_position = FrontClockFace.ten_thirty; SimpleRotation_to1030_from730(); break;
                case FrontClockFace.ten_thirty: new_position = FrontClockFace.one_thirty; SimpleRotation_to130_from1030(); break;
                default: break;
            }
            this.FrontClockFacePosition = new_position;

        }

        internal void SimpleRotation_to430_from130()
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

        internal void SimpleRotation_to730_from430()
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

        internal void SimpleRotation_to1030_from730()
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

        internal void SimpleRotation_to130_from1030()
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

        public void ReorientPiece_Complex(FrontClockFace par_clockPosition_Start, EnumAll12Faces par_enum)
        {
            //public virtual void ReorientPiece_Complex(EnumAll12Faces par_enum)
            //public void ReorientPiece_Complex(EnumFaceNum frontFaceColorNum_Start, EnumAll12Faces par_enum)
            //
            //Added 11/14/2020 thomas downes 
            //
            switch (par_enum)
            {
                case EnumAll12Faces.F0130: this.FrontClockFacePosition = FrontClockFace.one_thirty; break;
                case EnumAll12Faces._130_ENE: this.FrontClockFacePosition = FrontClockFace.one_thirty; break;
                case EnumAll12Faces._130_NNE: this.FrontClockFacePosition = FrontClockFace.one_thirty; break;

                case EnumAll12Faces.F0430: this.FrontClockFacePosition = FrontClockFace.four_thirty; break;
                case EnumAll12Faces._430_ESE: this.FrontClockFacePosition = FrontClockFace.four_thirty; break;
                case EnumAll12Faces._430_SSE: this.FrontClockFacePosition = FrontClockFace.four_thirty; break;

                case EnumAll12Faces.F0730: this.FrontClockFacePosition = FrontClockFace.seven_thirty; break;
                case EnumAll12Faces._730_SSW: this.FrontClockFacePosition = FrontClockFace.seven_thirty; break;
                case EnumAll12Faces._730_WSW: this.FrontClockFacePosition = FrontClockFace.seven_thirty; break;

                case EnumAll12Faces.F1030: this.FrontClockFacePosition = FrontClockFace.ten_thirty; break;
                case EnumAll12Faces._1030_NNW: this.FrontClockFacePosition = FrontClockFace.ten_thirty; break;
                case EnumAll12Faces._1030_WNW: this.FrontClockFacePosition = FrontClockFace.ten_thirty; break;

                default: throw new Exception("EnumAll12Faces par_enum value is not recognized.");
            }

            //EnumFaceNum frontFaceColorNum_Start = this.WhichFaceIsFront;
            //EnumFaceNum frontFaceColorNum_End = ??????;
            //this.ReorientPiece(this.FrontClockFacePosition, frontfaceColor);

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

    }
}
