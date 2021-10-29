﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/12/2020 thomas 

namespace RubiksCube_2x2
{
    //
    //This is for the frontside of the Rubik's Cube. ---11/12/2020 thomas downes
    //
    namespace Front
    {
        class GreenOrangeWhite : RubiksPieceCorner
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
            public override System.Drawing.Color FaceColor1of3 { get { return Color.Lime; } } // Lime (Green)
            public override System.Drawing.Color FaceColor2of3 { get { return Color.Orange; } }
            public override System.Drawing.Color FaceColor3of3 { get { return Color.White; } }


            //Added 12/4/2020 thomas downes
            public override string GetColorAbbreviationXYZ()
            {
                //Added 12/4/2020 thomas downes
                return "GOW";
            }


            public GreenOrangeWhite(RubiksCubeOneSide par_parent = null) : base(par_parent)
            {
                //----public GreenOrangeWhite()
                //----public GreenOrangeWhite(RubiksCubeOneSide par_parent)
                //
                //  Clock position:
                //
                //          [.N.]   [.N.]
                //   [.W.] [10:30] [1:30]  [.E.]
                //   [.W.]  [ 7:30] [3:30]  [.E.]
                //           [.S.]   [.S.]
                //
                //   (The [. .] faces are _side_ faces.) 
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
                //base.FaceColor1of3 = Color.Lime; // Green (Lime). 
                //base.FaceColor2of3 = Color.Orange; // White;
                //base.FaceColor3of3 = Color.White; // Orange;

                LoadInitialState_NotInUse();

                // Added 6/j14/2021 td
                base.ParentSide = par_parent;

            }


            public GreenOrangeWhite(string par_strBriefDescription) //, ClassBackside par_parentSide)
            {
                //---public BlueOrangeYellow(string par_strBriefDescription
                //
                // Added 11/20/2020 thomas downes
                //
                // Example #1:
                //
                //     BOY/NE==F1:N_F2:E_F3:F  
                //
                //                     ignore: BYR/SE==F1:S_F2:E_F3:F  GRY/SW==F1:F_F2:W_F3:S  GYO/NW==F1:N_F2:F_F3:W
                //
                // Example #2:
                //
                //     BOY/SW==F1:S_F2:W_F3:F
                //
                //                     ignore: BYR/NE==F1:N_F2:E_F3:F  GRY/SE==F1:F_F2:E_F3:S  GYO/NW==F1:N_F2:F_F3:W
                //
                //     (F = Front Face) 
                //
                if (par_strBriefDescription.StartsWith("GOW") == false) 
                    throw new ArgumentOutOfRangeException("Brief string must begin with GOW.");

                //
                // Encapsulated 11/20/2020.
                //
                base.ParseBriefInputString_UpdatePosition(par_strBriefDescription);

                //Added 12/3/2020 thomas downes
                //_parentSide = par_parentSide;

            }


            public override void LoadInitialState_NotInUse()
            {
                base.FrontClockFacePosition = FrontClockFace.four_thirty(); // i.e. Bottom-Right, or SouthEast.

                //base.FaceColor1Position_NotInUse = FacePositionNSWE.E_side_of_front;
                //base.FaceColor2Position_NotInUse = FacePositionNSWE.S_side_of_front;
                //base.FaceColor3Position_NotInUse = FacePositionNSWE.FrontFacing;

                //
                //
                // More description, which may or may not be needed (helpful). 
                //
                //
                base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                base.WhichFaceIsS_of_front = EnumFaceNum.Face2;  // Orange.
                base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                base.WhichFaceIsE_of_front = EnumFaceNum.Face1;  // Green (Lime)

                base.WhichFaceIsFront = EnumFaceNum.Face3;  // White.

            }


            //public override void PaintFrontFace(Graphics par_graph, Point p_center_of_form,
            //            out Point p_pointNW, out Point p_pointSW,
            //            out Point p_pointNE, out Point p_pointSE)
            //{
            //    //throw new NotImplementedException();

            //    //
            //    // Added 11/11/2020 thomas downes  
            //    //
            //    base.PaintFrontFace_Base(par_graph, p_center_of_form,
            //              out p_pointNW, out p_pointSW,
            //              out p_pointNE, out p_pointSE);
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
            //        in Point par_pointNW, in Point par_pointSW,
            //        in Point par_pointNE, in Point par_pointSE)
            //{
            //    //
            //    // Added 11/12/2020 thomas downes
            //    //
            //    throw new NotImplementedException();
            //
            //}

            //public override void PaintSideFace_CounterClockwise(Graphics par_graphics,
            //    in Point par_pointNW, in Point par_pointSW,
            //    in Point par_pointNE, in Point par_pointSE)
            //{
            //    //
            //    // Added 11/12/2020 thomas downes
            //    //
            //    throw new NotImplementedException();
            //
            //}

            public override void Revolve_Clockwise90()
            {
                //
                // Added 11/12/2020 thomas downes
                //
                base.Revolve_Clockwise90_base();

            }

            public void RotateJustThisPiece_Clockwise()
            {
                //
                // Added 11/13/2020 thomas downes
                //
                //--EnumFaceNum temp = base.WhichFaceIsFront;
                //--base.WhichFaceIsFront = base.WhichFaceIsS_of_front;
                //--base.WhichFaceIsS_of_front = base.WhichFaceIsE_of_front;
                //--base.WhichFaceIsE_of_front = temp;

                //Added 12/23/2020 td
                base.Revolve_Clockwise90_base();

            }

            public override void ReorientPiece(FrontClockFace par_enum, Color par_frontfacecolor)
            {
                //
                // Added 11/14/2020 thomas downes
                //
                throw new NotImplementedException();

            }


            public override string ToString()
            {
                //
                // Added 1/02/2021 td
                //
                // Example #1:
                //
                //     GOW/NE==F1:N_F2:E_F3:F 
                //
                // Example #1:
                //
                //     GOW/SW==F1:S_F2:W_F3:F
                //
                //     (F = Front Face) 
                //
                return ("GOW/" + base.ToString());

            }


        }
    }
}
