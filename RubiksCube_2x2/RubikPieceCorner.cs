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
            PaintFrontFace(par_graphics, par_center_of_form, 
                out point_NW, out point_SW, out point_NE, out point_SE);

            //
            // Added 11/11/2020 thomas downes
            //
            PaintSideFace_ClockwiseFromFront(par_graphics, 
                in point_NW, in point_SW, in point_NE, in point_SE);
            PaintSideFace_CounterClockwise(par_graphics,
                in point_NW, in point_SW, in point_NE, in point_SE);

        }

        public abstract void PaintFrontFace(Graphics par_graphics, Point par_center_of_form,
            out Point par_pointNW, out Point par_pointSW, 
            out Point par_pointNE, out Point par_pointSE);

        public abstract void PaintSideFace_ClockwiseFromFront(Graphics par_graphics, 
            in Point par_pointNW, in Point par_pointSW,
            in Point par_pointNE, in Point par_pointSE);

        public abstract void PaintSideFace_CounterClockwise(Graphics par_graphics,
            in Point par_pointNW, in Point par_pointSW,
            in Point par_pointNE, in Point par_pointSE);

    }
}
