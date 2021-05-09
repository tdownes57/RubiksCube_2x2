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
        class GreenRedYellow : RubiksPieceCorner
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
            public override System.Drawing.Color FaceColor1of3 { get { return Color.Lime; } }  // Lime = Green. 
            public override System.Drawing.Color FaceColor2of3 { get { return Color.Red; } }
            public override System.Drawing.Color FaceColor3of3 { get { return Color.Yellow; } }

            public GreenRedYellow()
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
                //base.FaceColor1of3 = Color.Lime; // Green. 
                //base.FaceColor2of3 = Color.Red;
                //base.FaceColor3of3 = Color.Yellow;

                //
                // Encapsulated 11/13/2020 td
                //
                if (EnumStaticClass.PiecesLoadTheirInitialState) LoadInitialState_NotInUse();


            }


            public GreenRedYellow(string par_strBriefDescription)
            {
                //
                // Added 11/20/2020 thomas downes
                //
                // Example #1:
                //
                //     GRY/NE==F1:N_F2:E_F3:F  
                //
                //                             ignore: BYR/SE==F1:S_F2:E_F3:F  GRY/SW==F1:F_F2:W_F3:S  GYO/NW==F1:N_F2:F_F3:W
                //
                // Example #2:
                //
                //     GRY/SW==F1:S_F2:W_F3:F
                //
                //                             ignore: BYR/NE==F1:N_F2:E_F3:F  GRY/SE==F1:F_F2:E_F3:S  GYO/NW==F1:N_F2:F_F3:W
                //
                //     (F = Front Face) 
                //
                if (par_strBriefDescription.StartsWith("GRY") == false) throw new ArgumentOutOfRangeException("Brief string must begin with GYR.");

                //
                // Encapsulated 11/20/2020.
                //
                base.ParseBriefInputString_UpdatePosition(par_strBriefDescription);

            }


            //Added 12/4/2020 thomas downes
            public override string GetColorAbbreviationXYZ()
            {
                //Added 12/4/2020 thomas downes
                return "GRY";
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
                base.FrontClockFacePosition = FrontClockFace.one_thirty;

                //base.FaceColor1Position_NotInUse = FacePositionNSWE.W_side_of_front;
                //base.FaceColor2Position_NotInUse = FacePositionNSWE.FrontFacing;
                //base.FaceColor3Position_NotInUse = FacePositionNSWE.S_side_of_front;

                //
                //
                // More description, which may or may not be needed (helpful). 
                //
                //
                base.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                base.WhichFaceIsE_of_front = EnumFaceNum.Face2;

                base.WhichFaceIsFront = EnumFaceNum.Face3;


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
            //        Rectangle frontFace = EnumStaticClass.GetRectangle_Front(p_center_of_form, base.FrontClockFacePosition);
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

                if (Color.Lime == par_frontfacecolor) base.WhichFaceIsFront = EnumFaceNum.Face1;
                else if (Color.Green == par_frontfacecolor) base.WhichFaceIsFront = EnumFaceNum.Face1;
                else if (Color.Red == par_frontfacecolor) base.WhichFaceIsFront = EnumFaceNum.Face2;
                else if (Color.Yellow == par_frontfacecolor) base.WhichFaceIsFront = EnumFaceNum.Face3;
                //Added 11/14/2020 td
                else throw new Exception("The color parameter is not recognized as one of the face colors of this piece.");


                //
                // Front Face is ___Green____
                //
                if (Color.Green == par_frontfacecolor
                    || Color.Lime == par_frontfacecolor
                    || Color.LimeGreen == par_frontfacecolor) // Green
                    switch (par_enum)
                    {
                        case (FrontClockFace.one_thirty):
                            base.WhichFaceIsN_of_front = EnumFaceNum.Face2;
                            base.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            break;

                        case (FrontClockFace.four_thirty):
                            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsE_of_front = EnumFaceNum.Face2;
                            base.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            break;

                        case (FrontClockFace.seven_thirty):
                            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsS_of_front = EnumFaceNum.Face2;
                            base.WhichFaceIsW_of_front = EnumFaceNum.Face3;
                            break;

                        case (FrontClockFace.ten_thirty):
                            base.WhichFaceIsN_of_front = EnumFaceNum.Face3;
                            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsW_of_front = EnumFaceNum.Face2;
                            break;

                    }


                //
                // Front Face is ___Red____
                //
                if (Color.Red == par_frontfacecolor) // Red 
                    switch (par_enum)
                    {
                        case (FrontClockFace.one_thirty):
                            base.WhichFaceIsN_of_front = EnumFaceNum.Face3;
                            base.WhichFaceIsE_of_front = EnumFaceNum.Face1;
                            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            break;

                        case (FrontClockFace.four_thirty):
                            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                            base.WhichFaceIsS_of_front = EnumFaceNum.Face1;
                            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            break;

                        case (FrontClockFace.seven_thirty):
                            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsS_of_front = EnumFaceNum.Face3;
                            base.WhichFaceIsW_of_front = EnumFaceNum.Face1;
                            break;

                        case (FrontClockFace.ten_thirty):
                            base.WhichFaceIsN_of_front = EnumFaceNum.Face1;
                            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsW_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
                            base.WhichFaceIsE_of_front = EnumFaceNum.Face3;
                            break;

                    }

                //
                // Take care of the side faces. 
                //
                if (Color.Green == par_frontfacecolor) base.ReorientPiece_FrontFaceIsFace1(par_enum);
                    // Lime = Green. 
                    if (Color.LimeGreen == par_frontfacecolor) base.ReorientPiece_FrontFaceIsFace1(par_enum);
                    if (Color.Lime == par_frontfacecolor) base.ReorientPiece_FrontFaceIsFace1(par_enum);
                if (Color.Red == par_frontfacecolor) base.ReorientPiece_FrontFaceIsFace2(par_enum);
                if (Color.Yellow == par_frontfacecolor) base.ReorientPiece_FrontFaceIsFace3(par_enum);


            }

            //public override void ReorientPiece_Complex(EnumAll12Faces par_enum)
            //{
            //    //
            //    // Added 11/15/2020 thomas downes
            //    //
            //    base.ReorientPiece_Complex(par_enum);
            //    throw new NotImplementedException("The side faces must be addressed.");
            //}

            public override string ToString()
            {
                //
                // Added 11/19/2020 td
                //
                // Example #1:
                //
                //     BOY/NE==F1:N_F2:E_F3:F 
                //
                // Example #1:
                //
                //     BOY/SW==F1:S_F2:W_F3:F
                //
                //     (F = Front Face) 
                //
                return ("GRY/" + base.ToString());

            }


            //public RubikPieceCorner NextPieceClockwise()
            //{
            //    //
            //    // Added 12/3/2020 Thomas Downes 
            //    //
            //    FrontClockFace enumBYR = _parentSide._pieceBYR.FrontClockFacePosition;
            //    FrontClockFace enumGRY = _parentSide._pieceGRY.FrontClockFacePosition;
            //    FrontClockFace enumGYO = _parentSide._pieceGYO.FrontClockFacePosition;
            //
            //    if (EnumStaticClass.AdjacentClockwise(this, _parentSide._pieceBYR)) return _parentSide._pieceBYR;
            //    if (EnumStaticClass.AdjacentClockwise(this, _parentSide._pieceGRY)) return _parentSide._pieceGRY;
            //    if (EnumStaticClass.AdjacentClockwise(this, _parentSide._pieceGYO)) return _parentSide._pieceGYO;
            //
            //    return null;
            //
            //}


        }
    }
}