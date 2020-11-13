using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas 

namespace RubiksCube_2x2
{
    //
    //This is for the frontside of the Rubik's Cube.---11/12/2020 thomas downes
    //
    namespace Front
    {
        class GreenRedWhite : RubikPieceCorner
        {
            public GreenRedWhite()
            {
                //
                // Clock position:
                //
                //           [.N.]   [.N.]
                //   [.W.]  [10:30] [1:30]  [.E.]
                //   [.W.]  [ 7:30] [3:30]  [.E.]
                //           [.S.]   [.S.]
                //
                // (The [. .] faces are _side_ faces.) 
                //
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

                base.FaceColor1of3 = Color.Lime; // Green. 
                base.FaceColor2of3 = Color.White; // Red;
                base.FaceColor3of3 = Color.Red;   // White;

                base.FrontFacePosition = FrontClockFace.one_thirty; // Top-Right, or NorthEast.

                base.FaceColor1Position = FacePositionNSWE.E_side_of_front;
                base.FaceColor2Position = FacePositionNSWE.FrontFacing;
                base.FaceColor3Position = FacePositionNSWE.N_side_of_front;

                //
                //
                // More description, which may or may not be needed (helpful). 
                //
                //
                base.WhichFaceIsN_of_front = EnumFaceNum.Face3;  // Red.
                base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                base.WhichFaceIsE_of_front = EnumFaceNum.Face1; // Green. 

                base.WhichFaceIsFront = EnumFaceNum.Face2; // White.


            }


            //    public override void PaintFrontFace(Graphics par_graph, Point p_center_of_form,
            //out Point p_pointNW, out Point p_pointSW,
            //out Point p_pointNE, out Point p_pointSE)
            //    {
            //        throw new NotImplementedException();
            //
            //        //
            //        // Added 11/11/2020 thomas downes  
            //        //
            //        Rectangle frontFace = EnumStaticClass.GetRectangle_Front(p_center_of_form, base.FrontFacePosition);
            //
            //        p_pointNW = new Point(frontFace.X, frontFace.Y);
            //        p_pointSW = new Point(frontFace.X, frontFace.Y + frontFace.Height);
            //        p_pointNE = new Point(frontFace.X + frontFace.Width, frontFace.Y);
            //        p_pointSE = new Point(frontFace.X + frontFace.Width, frontFace.Y + frontFace.Height);
            //
            //        Brush a_brush = new SolidBrush(base.GetColorOfFrontFace());
            //
            //        par_graph.FillRectangle(a_brush, frontFace);
            //
            //
            //    }


            //    public override void PaintSideFace_ClockwiseFromFront(Graphics par_graphics,
            //     in Point par_pointNW, in Point par_pointSW,
            //     in Point par_pointNE, in Point par_pointSE)
            //    {
            //        //
            //        // Added 11/12/2020 thomas downes
            //        //
            //        throw new NotImplementedException();
            //
            //    }
            //
            //    public override void PaintSideFace_CounterClockwise(Graphics par_graphics,
            //        in Point par_pointNW, in Point par_pointSW,
            //        in Point par_pointNE, in Point par_pointSE)
            //    {
            //        //
            //        // Added 11/12/2020 thomas downes
            //        //
            //        throw new NotImplementedException();
            //
            //    }

            public override void Rotate_Clockwise90()
            {
                //
                // Added 11/12/2020 thomas downes
                //

            }

        }
    }
}