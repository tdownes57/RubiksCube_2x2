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

        class BlueYellowRed : RubikPieceCorner
        {
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
            public override System.Drawing.Color FaceColor1of3 { get { return Color.Blue; } }
            public override System.Drawing.Color FaceColor2of3 { get { return Color.Yellow; } }
            public override System.Drawing.Color FaceColor3of3 { get { return Color.Red; } }

            public BlueYellowRed()
            {
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
                //base.FaceColor1of3 = Color.Blue; // Green. 
                //base.FaceColor2of3 = Color.Yellow;
                //base.FaceColor3of3 = Color.Red;

                //
                // Encapsulated 11/13/2020 td
                //
                if (EnumStaticClass.PiecesLoadTheirInitialState) LoadInitialState_NotInUse();


            }


            public BlueYellowRed(string par_strBriefDescription)
            {
                //
                // Added 11/20/2020 thomas downes
                //
                // Example #1:
                //
                //     BYR/NE==F1:N_F2:E_F3:F  
                //
                // Example #2:
                //
                //     BYR/SW==F1:S_F2:W_F3:F
                //
                //     (F = Front Face) 
                //
                if (par_strBriefDescription.StartsWith("BYR") == false) throw new ArgumentOutOfRangeException("Brief string must begin with BYR.");

                //
                // Encapsulated 11/20/2020.
                //
                base.ParseBriefInputString(par_strBriefDescription);

            }


            public override void LoadInitialState_NotInUse()
            {
                //
                // Encapsulated 11/13/2020 td
                //

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
                // Clock position 10:30 pm 
                base.FrontClockFacePosition = FrontClockFace.ten_thirty;

                //base.FaceColor1Position_NotInUse  = FacePositionNSWE.N_side_of_front;
                //base.FaceColor2Position_NotInUse = FacePositionNSWE.FrontFacing;
                //base.FaceColor3Position_NotInUse = FacePositionNSWE.W_side_of_front;

                //
                //
                // More description, which may or may not be needed. 
                //
                //
                base.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                base.WhichFaceIsW_of_front = EnumFaceNum.Face3;
                base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;

                base.WhichFaceIsFront = EnumFaceNum.Face2;




            }


            //public override void PaintFrontFace(Graphics par_graph, Point p_center_of_form,
            //    out Point p_pointNW, out Point p_pointSW,
            //    out Point p_pointNE, out Point p_pointSE)
            //{
            //    //----throw new NotImplementedException();
            //
            //    //
            //    // Added 11/11/2020 thomas downes  
            //    //
            //    base.PaintFrontFace_Base(par_graph, p_center_of_form,
            //     out p_pointNW, out p_pointSW,
            //     out p_pointNE, out p_pointSE);
            //
            //    //Rectangle frontFace = EnumStaticClass.GetRectangle_Front(p_center_of_form, base.FrontClockFacePosition);
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
            //                 base.FrontClockFacePosition,
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
            //                 base.FrontClockFacePosition,
            //                   in par_pointNW, in par_pointSW,
            //                   in par_pointNE, in par_pointSE);
            //
            //    Brush a_brush = new SolidBrush(base.GetColorOfSideFace_CounterClockwise());
            //    par_graphics.FillRectangle(a_brush, sideFace);
            //
            //}

            public override void Revolve_Clockwise90() 
            {
                //
                // Added 11/12/2020 thomas downes
                //
                base.Revolve_Clockwise90_base();


            }

            public override void ReorientPiece(FrontClockFace par_enum, Color par_frontfacecolor)
            {
                //
                // Added 11/14/2020 thomas downes
                //
                //throw new NotImplementedException();

                base.FrontClockFacePosition = par_enum;

                //switch (par_frontfacecolor.ToArgb())
                //{
                //    case Color.Blue.ToArgb():  base.WhichFaceIsFront = EnumFaceNum.Face1; break;
                //}

                if (Color.Blue == par_frontfacecolor) base.WhichFaceIsFront = EnumFaceNum.Face1;
                else if (Color.Yellow == par_frontfacecolor) base.WhichFaceIsFront = EnumFaceNum.Face2;
                else if (Color.Red == par_frontfacecolor) base.WhichFaceIsFront = EnumFaceNum.Face3;
                //Added 11/14/2020 td
                else throw new Exception("The color parameter is not recognized as one of the face colors of this piece.");


                //
                // Take care of the side faces. 
                //
                if (Color.Blue == par_frontfacecolor) base.ReorientPiece_FrontFaceIsFace1(par_enum);
                if (Color.Yellow == par_frontfacecolor) base.ReorientPiece_FrontFaceIsFace2(par_enum);
                if (Color.Red == par_frontfacecolor) base.ReorientPiece_FrontFaceIsFace3(par_enum);


                ////
                //// Front Face is ___Blue____
                ////
                //if (Color.Blue == par_frontfacecolor) // Blue
                //    switch (par_enum)
                //    {
                //        case (FrontClockFace.one_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.Face2;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            break;

                //        case (FrontClockFace.four_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.Face2;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            break;

                //        case (FrontClockFace.seven_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.Face2;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.Face3;
                //            break;

                //        case (FrontClockFace.ten_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.Face3;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.Face2;
                //            break;

                //    }


                ////
                //// Front Face is ___Yellow____
                ////
                //if (Color.Yellow == par_frontfacecolor) // Yellow 
                //    switch (par_enum)
                //    {
                //        case (FrontClockFace.one_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.Face3;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.Face1;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            break;

                //        case (FrontClockFace.four_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.Face1;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            break;

                //        case (FrontClockFace.seven_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.Face1;
                //            break;

                //        case (FrontClockFace.ten_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                //            break;

                //    }


                ////
                //// Front Face is ___Red____
                ////
                //if (Color.Red == par_frontfacecolor)  // Red
                //    switch (par_enum)
                //    {
                //        case (FrontClockFace.one_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.Face2;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            break;

                //        case (FrontClockFace.four_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.Face1;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.Face2;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            break;

                //        case (FrontClockFace.seven_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.Face1;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.Face2;
                //            break;

                //        case (FrontClockFace.ten_thirty):
                //            base.WhichFaceIsN_of_front = EnumFaceNum.Face2;
                //            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                //            base.WhichFaceIsE_of_front = EnumFaceNum.Face1;
                //            break;

                //    }


            }

            //public override void ReorientPiece_Complex(EnumAll12Faces par_enum)
            //{
            //    //
            //    // Added 11/15/2020 thomas downes
            //    //
            //    base.ReorientPiece_Complex(par_enum);
            //    throw new NotImplementedException("The side faces must be addressed.");
            //}




        }
    }
}
