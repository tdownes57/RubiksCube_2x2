using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // added 11/11/2020  

namespace RubiksCube_2x2
{
    public static class FaceSize
    {
        public const int Front_Half_wdth = 30;
        public const int Front_Half_hght = 30;

        public const int Side_Half_wdth_HORI = 20; // 30;
        public const int Side_Half_wdth_VERT = 20;

        public const int Side_Half_hght_VERT = 20;
        public const int Side_Half_hght_HORI = 20;  // 30;

    }


    //
    //          [.N.]   [.N.]
    //   [.W.] [10:30] [1:30]  [.E.]
    //   [.W.]  [ 7:30] [3:30]  [.E.]
    //           [.S.]   [.S.]
    // (The [. .] faces are _side_ faces.) 
    //
    public enum FrontClockFace_Enum { unassigned, one_thirty, four_thirty, seven_thirty, ten_thirty};


    //Added 1/23/2021 thomas downes
    public enum EnumLeftOrRight { Unassigned, Left, Right };

    //Added 4/02/2021 thomas downes
    public enum EnumFrontOrBack { Unassigned, Front, Back };
    //public enum EnumCubeRotation_NorthPole { Unassigned, Clockwise, Counterclock };
    public enum EnumCubeRotation_NorthPole { Unassigned, Clockwise, Counterclock, None_MainFace };


    //Added 1/28/2021 thomas downes
    //
    //   "Primary View" means "The Side (Front, Back, Left, or Right) which is temporarily viewed as Front View." 
    //
    public enum EnumPrimaryView { Unassigned, Left, Right, Front, Back };

    // Added 2/5/2021 thomas downes
    public enum EnumColorIsHardcoded { Undetermined, True, False };

    //
    // A 2x2 Rubik's Cube:   (The [. .] faces are _side_ faces.)  
    //
    //            [.N.]   [.N.]
    //     [.W.] [front] [front]  [.E.]
    //     [.W.] [front] [front]  [.E.]
    //            [.S.]   [.S.]
    //
    //
    //          [.N.]   [.N.]
    //   [.W.] [10:30] [1:30]  [.E.]
    //   [.W.]  [ 7:30] [3:30]  [.E.]
    //           [.S.]   [.S.]
    //
    public enum EnumFacePositionNSWE { NotSpecified, FrontFacing, N_side_of_front, S_side_of_front, E_side_of_front, W_side_of_front };

    public enum EnumFaceNum { NotSpecified, NotApplicable_DifferentPiece, Face1, Face2, Face3 };

    //Added 11/17/2020 thomas downes.
    public enum EnumWhatToPaint { NotSpecified, FrontAndSides, JustFront, JustSides }

    // Added 11/14/2020 thomas downes 
    // Original code moved to Maneuvers\_Definitions.cs on 10/6/2021 td
    public enum EnumAll12Faces_BACKUP { NotSpecified, 
                   F0130, F0430, F0730, F1030, 
                    _130_NNE, _130_ENE, 
                    _430_ESE, _430_SSE, 
                    _730_SSW, _730_WSW, 
                    _1030_WNW, _1030_NNW }

    // Added 11/14/2020 thomas downes 
    // Original code moved to Maneuvers\_Definitions.cs on 10/6/2021 td
    public struct ComplexPieceMove_DEPRECATED
    {
        public FrontClockFace StartingPoint;
        public EnumAll12Faces EndingPoint;
        //Added 11/18/2020 thomas downes
        public bool ClockwiseRevolution90_Deprecated;
        //public bool FrontFaceMovement; //Added 12/9/2020 td
        public bool NothingHappens;  // Added 1/13/2021 thomas downes
    }

    // Added 12/09/2020 thomas downes 
    // Original code moved to Maneuvers\_Definitions.cs on 10/6/2021 td
    public struct ComplexPieceMoves_Five_DEPRECATED
    {
        public ComplexPieceMove_DEPRECATED move1_from130; // = new ComplexPieceMove();
        public ComplexPieceMove_DEPRECATED move2_from430;
        public ComplexPieceMove_DEPRECATED move3_from730;
        public ComplexPieceMove_DEPRECATED move4_from1030;
        public bool move5_Clockwise90;
    }


    public class EnumStaticClass
    {
        //
        // Added 11/14/2020 thomas downes
        //
        public const bool PiecesLoadTheirInitialState = true;  // 4 April 2021 // false;  // true; 
        public const bool Sides_BackOrFront_LoadInitialState = true; 

        public static Rectangle GetRectangle_Front(Point p_centerOfForm, FrontClockFace p_face_position, int p_margin)
        {
            //
            // Added 11/11/2020 Thomas Downes  
            //
            //
            // Define the rectange which will represent one of four(4) front single-color rectangles. 
            //
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);
            Point center_point_form = p_centerOfForm;

            //const int mod_face_half_wdth = 30;
            //const int mod_face_half_hght = 30;

            //switch (p_face_position) // (par_FrontFace)
            switch (p_face_position.EnumValue()) // (par_FrontFace)
            {
                case FrontClockFace_Enum.one_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X + FaceSize.Front_Half_wdth + p_margin,
                                                  center_point_form.Y - FaceSize.Front_Half_hght);
                    //---return GetRectangle_byCenter(center_point_rect, 25, 25);
                    return GetRectangle_byCenter(center_point_rect, 
                                                    FaceSize.Front_Half_wdth, 
                                                    FaceSize.Front_Half_hght);

                case FrontClockFace_Enum.four_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X + FaceSize.Front_Half_wdth + p_margin,
                                                  center_point_form.Y + FaceSize.Front_Half_hght + p_margin);
                    //---return GetRectangle_byCenter(center_point_rect, 25, 25);
                    return GetRectangle_byCenter(center_point_rect, 
                                                    FaceSize.Front_Half_wdth, 
                                                    FaceSize.Front_Half_hght);

                case FrontClockFace_Enum.seven_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X - FaceSize.Front_Half_wdth,
                                                  center_point_form.Y + FaceSize.Front_Half_hght + p_margin);
                    //---return GetRectangle_byCenter(center_point_rect, 25, 25);
                    return GetRectangle_byCenter(center_point_rect, 
                                                    FaceSize.Front_Half_wdth, 
                                                    FaceSize.Front_Half_hght);

                case FrontClockFace_Enum.ten_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X - FaceSize.Front_Half_wdth,
                                                  center_point_form.Y - FaceSize.Front_Half_hght);
                    //---return GetRectangle_byCenter(center_point_rect, 25, 25);
                    return GetRectangle_byCenter(center_point_rect, 
                                                    FaceSize.Front_Half_wdth, 
                                                    FaceSize.Front_Half_hght);

                //
                // Not likely to be used: 
                //
                default: return new Rectangle(0, 0, 100, 100);
            }

        }


        private static Rectangle GetRectangle_byCenter(Point par_center, int half_width, int half_hght)
        {
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            //Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);

            return new Rectangle(par_center.X - half_width, par_center.Y - half_hght,
                2 * half_width, 2 * half_hght);

        }


        public static Rectangle GetRectangle_Side_ClockwiseFromFront(Point p_centerOfForm,
                          FrontClockFace p_face_position, int par_margin, 
                          in Point par_pointNW, in Point par_pointSW,
                          in Point par_pointNE, in Point par_pointSE)
        {
            //
            // Added 11/12/2020 Thomas Downes  
            //
            //
            // Define the rectange which will represent one of eight(8) side single-color rectangles. 
            //
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            //Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);
            Point center_point_form = p_centerOfForm;
            Point corner_point;

            //const int mod_face_half_wdth = 30;
            //const int mod_face_half_hght = 30;

            //switch (p_face_position) // (par_FrontFace)
            switch (p_face_position.EnumValue()) // (par_FrontFace)
            {
                case FrontClockFace_Enum.one_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    //center_point_rect = new Point(center_point_form.X + FaceSize.Front_Half_wdth,
                    //                              center_point_form.Y - FaceSize.Front_Half_hght);
                    //return GetRectangle_byBottomLeft(par_pointNW, 20, 25);
                    corner_point = par_pointNE;
                    //---return GetRectangle_byBottomRight(corner_point, par_margin, 20, 25);
                    return GetRectangle_byBottomRight(corner_point, par_margin, 
                               FaceSize.Side_Half_wdth_VERT * 2,
                               FaceSize.Side_Half_hght_VERT * 2);

                case FrontClockFace_Enum.four_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    //center_point_rect = new Point(center_point_form.X + FaceSize.Front_Half_wdth,
                    //                              center_point_form.Y + FaceSize.Front_Half_hght);
                    //return GetRectangle_byCenter(center_point_rect, 25, 25);
                    //return GetRectangle_byTopLeft(par_pointNE, 25, 20);
                    corner_point = par_pointSE;
                    //--return GetRectangle_byBottomLeft(corner_point, par_margin, 20, 25);
                    return GetRectangle_byBottomLeft(corner_point, par_margin,
                               FaceSize.Side_Half_wdth_HORI * 2,
                               FaceSize.Side_Half_hght_HORI * 2);

                case FrontClockFace_Enum.seven_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    //center_point_rect = new Point(center_point_form.X - FaceSize.Front_Half_wdth,
                    //                              center_point_form.Y + FaceSize.Front_Half_hght);
                    //return GetRectangle_byCenter(center_point_rect, 25, 25);
                    //return GetRectangle_byTopRight(par_pointSE, 20, 25);
                    corner_point = par_pointSW;
                    //---return GetRectangle_byTopLeft(corner_point, par_margin, 20, 25);
                    return GetRectangle_byTopLeft(corner_point, par_margin,
                               FaceSize.Side_Half_wdth_VERT * 2,
                               FaceSize.Side_Half_hght_VERT * 2);

                case FrontClockFace_Enum.ten_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    //center_point_rect = new Point(center_point_form.X - FaceSize.Front_Half_wdth,
                    //                              center_point_form.Y - FaceSize.Front_Half_hght);
                    //return GetRectangle_byCenter(center_point_rect, 25, 25);
                    //return GetRectangle_byBottomRight(par_pointSW, 20, 25);
                    corner_point = par_pointNW;
                    //---return GetRectangle_byTopRight(corner_point, par_margin, 20, 25);
                    return GetRectangle_byTopRight(corner_point, par_margin,
                               FaceSize.Side_Half_wdth_HORI * 2,
                               FaceSize.Side_Half_hght_HORI * 2);

                //
                // Not likely to be used: 
                //
                default: return new Rectangle(0, 0, 100, 100);
            }
        }


        public static Rectangle GetRectangle_Side_CounterClockwise(Point p_centerOfForm,
                  FrontClockFace p_face_position, int par_margin,
                  in Point par_pointNW, in Point par_pointSW,
                  in Point par_pointNE, in Point par_pointSE)
        {
            //
            // Added 11/12/2020 Thomas Downes  
            //
            //
            // Define the rectange which will represent one of eight(8) side single-color rectangles. 
            //
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            //Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);
            Point center_point_form = p_centerOfForm;
            Point corner_point;

            //switch (p_face_position) // (par_FrontFace)
            switch (p_face_position.EnumValue()) // (par_FrontFace)
            {
                case FrontClockFace_Enum.one_thirty:
                    corner_point = par_pointNE;
                    //--return GetRectangle_byTopLeft(corner_point, par_margin, 25, 20);
                    return GetRectangle_byTopLeft(corner_point, par_margin,
                               FaceSize.Side_Half_wdth_HORI * 2,
                               FaceSize.Side_Half_hght_HORI * 2);

                case FrontClockFace_Enum.four_thirty:
                    corner_point = par_pointSE;
                    //--return GetRectangle_byTopRight(corner_point, par_margin, 20, 25);
                    return GetRectangle_byTopRight(corner_point, par_margin,
                               FaceSize.Side_Half_wdth_VERT * 2,
                               FaceSize.Side_Half_hght_VERT * 2);

                case FrontClockFace_Enum.seven_thirty:
                    corner_point = par_pointSW;
                    //--return GetRectangle_byBottomRight(corner_point, par_margin, 25, 20);
                    return GetRectangle_byBottomRight(corner_point, par_margin,
                               FaceSize.Side_Half_wdth_HORI * 2,
                               FaceSize.Side_Half_hght_HORI * 2);

                case FrontClockFace_Enum.ten_thirty:
                    corner_point = par_pointNW;
                    //--return GetRectangle_byBottomLeft(corner_point, par_margin, 20, 25);
                    return GetRectangle_byBottomLeft(corner_point, par_margin,
                               FaceSize.Side_Half_wdth_VERT * 2,
                               FaceSize.Side_Half_hght_VERT * 2);

                //
                // Not likely to be used: 
                //
                default: return new Rectangle(0, 0, 100, 100);
            }
        }


        private static Rectangle GetRectangle_byBottomRight(Point par_point, int par_margin, int par_width, int par_height)
        {
            //
            // Added 11/12/2020 thomas downes  
            //
            return new Rectangle(par_point.X - par_width - par_margin, par_point.Y - par_height, par_width, par_height);
        }

        private static Rectangle GetRectangle_byBottomLeft(Point par_point, int par_margin, int par_width, int par_height)
        {
            //
            // Added 11/12/2020 thomas downes  
            //
            return new Rectangle(par_point.X + par_margin, par_point.Y - par_height, par_width, par_height);
        }

        private static Rectangle GetRectangle_byTopLeft(Point par_point, int par_margin, int par_width, int par_height)
        {
            //
            // Added 11/12/2020 thomas downes  
            //
            return new Rectangle(par_point.X + par_margin, par_point.Y, par_width, par_height);
        }

        private static Rectangle GetRectangle_byTopRight(Point par_point, int par_margin, int par_width, int par_height)
        {
            //
            // Added 11/12/2020 thomas downes  
            //
            return new Rectangle(par_point.X - par_width - par_margin, par_point.Y + par_margin, par_width, par_height);
        }


        internal static bool AdjacentClockwise(RubiksPieceCorner p_PieceFirst, RubiksPieceCorner p_PieceNext)
        {
            //
            // Added 12/1/2020 
            //
            if (p_PieceFirst == p_PieceNext) return false; 

            return AdjacentClockwise(p_PieceFirst.FrontClockFacePosition,
                                     p_PieceNext.FrontClockFacePosition);

        }


        public static bool AdjacentClockwise(FrontClockFace p_ClockFirst, FrontClockFace p_ClockNext)
        {
            //
            // Added 12/1/2020 thomas d. 
            //
            switch (p_ClockFirst)
            {
                case FrontClockFace.one_thirty:
                    if (p_ClockNext == FrontClockFace.four_thirty) return true;
                    break;

                case FrontClockFace.four_thirty:
                    if (p_ClockNext == FrontClockFace.seven_thirty) return true;
                    break;

                case FrontClockFace.seven_thirty:
                    if (p_ClockNext == FrontClockFace.ten_thirty) return true;
                    break;

                case FrontClockFace.ten_thirty:
                    if (p_ClockNext == FrontClockFace.one_thirty) return true;
                    break;

                default:
                    //return false;
                    throw new NotImplementedException(); 
            }

            return false;

        }


        internal static void SwitchFrontAndBack_IfNeeded(RubiksPieceCorner par_piece, bool p_bClockwise, bool p_bCounterclock)
        {
            //
            // Added 4/2/2021 thomas downes
            //
            //Added 4/2/2021 td
            EnumLeftOrRight temp_FrontClock_LeftOrRight = EnumLeftOrRight.Unassigned;

            if (par_piece.FrontClockFacePosition == FrontClockFace.one_thirty) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Right;
            if (par_piece.FrontClockFacePosition == FrontClockFace.four_thirty) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Right;
            if (par_piece.FrontClockFacePosition == FrontClockFace.seven_thirty) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Left;
            if (par_piece.FrontClockFacePosition == FrontClockFace.ten_thirty) temp_FrontClock_LeftOrRight = EnumLeftOrRight.Left;

            bool bSide_Left = (temp_FrontClock_LeftOrRight == EnumLeftOrRight.Left);
            bool bSide_Right = (temp_FrontClock_LeftOrRight == EnumLeftOrRight.Right);

            if (bSide_Right && p_bCounterclock)
            {
                SwitchFrontAndBack(par_piece);
            }

            if (bSide_Left && p_bClockwise)
            {
                SwitchFrontAndBack(par_piece);
            }


        }


        private static void SwitchFrontAndBack(RubiksPieceCorner par_piece)
        {
            //
            // Added 4/2/2021 thomas downes
            //
            if (par_piece.FrontOrBackOfCube == EnumFrontOrBack.Back) par_piece.FrontOrBackOfCube = EnumFrontOrBack.Front;
            if (par_piece.FrontOrBackOfCube == EnumFrontOrBack.Front) par_piece.FrontOrBackOfCube = EnumFrontOrBack.Back;

        }


        public static FrontClockFace NextPositionClockwise(FrontClockFace p_Clock)
        {
            //
            // Added 10/12/2021 thomas d. 
            //
            switch (p_Clock)
            {
                case FrontClockFace.one_thirty:
                    //if (p_ClockNext == FrontClockFace.four_thirty) return true;
                    //break;
                    return FrontClockFace.four_thirty;

                case FrontClockFace.four_thirty:
                    //if (p_ClockNext == FrontClockFace.seven_thirty) return true;
                    //break;
                    return FrontClockFace.seven_thirty;

                case FrontClockFace.seven_thirty:
                    //if (p_ClockNext == FrontClockFace.ten_thirty) return true;
                    //break;
                    return FrontClockFace.ten_thirty;

                case FrontClockFace.ten_thirty:
                    //if (p_ClockNext == FrontClockFace.one_thirty) return true;
                    //break;
                    return FrontClockFace.one_thirty;

                default:
                    //return false;
                    throw new NotImplementedException();
            }

            return false;

        }




    }
}
