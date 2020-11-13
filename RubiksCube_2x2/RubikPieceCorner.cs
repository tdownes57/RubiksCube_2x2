using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas downes

namespace RubiksCube_2x2
{
    abstract class RubikPieceCorner {
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
        public System.Drawing.Color FaceColor1of3;
        public System.Drawing.Color FaceColor2of3;
        public System.Drawing.Color FaceColor3of3;

        //
        //          [.N.]   [.N.]
        //   [.W.] [10:30] [1:30]  [.E.]
        //   [.W.]  [ 7:30] [3:30]  [.E.]
        //           [.S.]   [.S.]
        //
        // (The [. .] faces are _side_ faces.) 
        //
        public FrontClockFace FrontFacePosition;

        public FacePositionNSWE FaceColor1Position;
        public FacePositionNSWE FaceColor2Position;
        public FacePositionNSWE FaceColor3Position;

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

        public Color GetColorOfFrontFace()
        {
            //
            // Added 11/11/2020 thomas downes
            //
            switch (WhichFaceIsFront) {
                case EnumFaceNum.Face1: return this.FaceColor1of3;
                case EnumFaceNum.Face2: return this.FaceColor2of3;
                case EnumFaceNum.Face3: return this.FaceColor3of3;
                default: return Color.Black; 
            }

        }


        public Color GetColorOfSideFace_ClockwiseFromFront()
        {
            //
            // Added 11/12/2020 thomas downes
            //
            switch (this.FrontFacePosition)
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
            switch (this.FrontFacePosition)
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
            switch(par_enum)
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
            //Rectangle frontFace = EnumStaticClass.GetRectangle_Front(p_center_of_form, base.FrontFacePosition);
            Rectangle frontFace = EnumStaticClass.GetRectangle_Front(p_center_of_form, FrontFacePosition, _margin);

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
                         this.FrontFacePosition, _margin,
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
                         this.FrontFacePosition, _margin, 
                           in par_pointNW, in par_pointSW,
                           in par_pointNE, in par_pointSE);

            Brush a_brush = new SolidBrush(this.GetColorOfSideFace_CounterClockwise());
            par_graphics.FillRectangle(a_brush, sideFace);

        }


    }
}
