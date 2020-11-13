using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas 

namespace RubiksCube_2x2
{
    //
    //This is for the backside of the Rubik's Cube.
    //
    namespace Back
    {
        class BlueOrangeYellow : RubikPieceCorner
        {
            public BlueOrangeYellow()
            {
                base.FaceColor1of3 = Color.Blue; // Green. 
                base.FaceColor2of3 = Color.Orange;
                base.FaceColor3of3 = Color.Yellow;

                //
                // Clock position:
                //
                //          [.N.]   [.N.]
                //   [.W.] [10:30] [1:30]  [.E.]
                //   [.W.] [ 7:30] [3:30]  [.E.]
                //           [.S.]   [.S.]
                //
                // (The [. .] faces are _side_ faces.) 
                //
                base.FrontFacePosition = FrontClockFace.seven_thirty;  // [ 7:30]  in   [.W.] [ 7:30] [3:30]  [.E.] 

                base.FaceColor1Position = FacePositionNSWE.W_side_of_front;
                base.FaceColor2Position = FacePositionNSWE.FrontFacing;
                base.FaceColor3Position = FacePositionNSWE.S_side_of_front;

                //
                //
                // More description, which may or may not be needed (helpful). 
                //
                //
                base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                base.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                //----base.WhichFaceIsW_of_front = EnumFaceNum.Face2;
                base.WhichFaceIsW_of_front = EnumFaceNum.Face1;
                base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;

                base.WhichFaceIsFront = EnumFaceNum.Face2;

            }


            //public override void PaintFrontFace(Graphics par_graph, Point p_center_of_form, 
            //            out Point p_pointNW, out Point p_pointSW, 
            //            out Point p_pointNE, out Point p_pointSE)
            //{
            //    //
            //    // Added 11/11/2020 thomas downes  
            //    //
            //    base.PaintFrontFace_Base(par_graph, p_center_of_form,
            //                 out p_pointNW, out p_pointSW,
            //                 out p_pointNE, out p_pointSE);
            //
            //    //Rectangle frontFace = EnumStaticClass.GetRectangle_Front(p_center_of_form, base.FrontFacePosition);
            //
            //    //p_pointNW = new Point(frontFace.X, frontFace.Y);
            //    //p_pointSW = new Point(frontFace.X, frontFace.Y + frontFace.Height);
            //    //p_pointNE = new Point(frontFace.X + frontFace.Width, frontFace.Y);
            //    //p_pointSE = new Point(frontFace.X + frontFace.Width, frontFace.Y + frontFace.Height);
            //
            //    //Brush a_brush = new SolidBrush(base.GetColorOfFrontFace());
            //
            //    //par_graph.FillRectangle(a_brush, frontFace);
            //
            //}


            //public override void PaintSideFace_ClockwiseFromFront(Graphics par_graphics,
            //       Point p_center_of_form,
            //       in Point par_pointNW, in Point par_pointSW,
            //       in Point par_pointNE, in Point par_pointSE)
            //{
            //    //
            //    // Added 11/12/2020 thomas downes
            //    //
            //    Rectangle sideFace = EnumStaticClass.GetRectangle_Side_ClockwiseFromFront(p_center_of_form,
            //                 base.FrontFacePosition,
            //                   in par_pointNW, in par_pointSW,
            //                   in par_pointNE, in par_pointSE);
            //
            //    Brush a_brush = new SolidBrush(base.GetColorOfSideFace_ClockwiseFromFront());
            //    par_graphics.FillRectangle(a_brush, sideFace);
            //
            //}

            //public override void PaintSideFace_CounterClockwise(Graphics par_graphics,
            //       Point p_center_of_form,
            //    in Point par_pointNW, in Point par_pointSW,
            //    in Point par_pointNE, in Point par_pointSE)
            //{
            //    //
            //    // Added 11/12/2020 thomas downes
            //    //
            //    Rectangle sideFace = EnumStaticClass.GetRectangle_Side_CounterClockwise(p_center_of_form,
            //                 base.FrontFacePosition,
            //                   in par_pointNW, in par_pointSW,
            //                   in par_pointNE, in par_pointSE);
            //
            //    Brush a_brush = new SolidBrush(base.GetColorOfSideFace_CounterClockwise());
            //    par_graphics.FillRectangle(a_brush, sideFace);
            //
            //}


        }
    }
}