using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;    //Added 12/13/2020 thomas  downes
using System.Drawing;  //Added 1/28/2021 Thomas Downes  

namespace RubiksCube_2x2
{
    class RubiksCubeBothSides
    {
        //
        // Added 12/8/2020 thomas downes
        //
        Front.ClassFrontside mod_frontside;
        Back.ClassBackside mod_backside;


        private struct OrientationWork
        {
            public RubiksCubeOneSide MainSide;
            //public BackOrFront OtherSide;
            public RubikPieceCorner AdjacentPiece1;
            public RubikPieceCorner AdjacentPiece2;
            public RubiksCubeOneSide OtherSide;

            public bool SomeWorkIsNeeded;
            public int HowMany90degreeShiftsClockwise;
            public FrontClockFace piece1_originalPosition;
            public FrontClockFace piece2_originalPosition;
        }

        private OrientationWork mod_orientation = new OrientationWork(); 

        public RubiksCubeBothSides(Front.ClassFrontside par_frontside, Back.ClassBackside par_backside)
        {
            //
            // This is the initializer. (I forget the correct name!  Oh, "constructor".) 
            //
            // Added 12/8/2020 thomas downes
            //
            mod_backside = par_backside;
            mod_frontside = par_frontside;

        }


        public RubiksCubeBothSides()
        {
            //
            // Added 1/13/2021 thomas downes  
            //
            mod_frontside = new Front.ClassFrontside();
            mod_backside = new Back.ClassBackside();

        }


        public void SwitchBottomPieces_Front()
        {
            //
            // Added 12/9/2020 td 
            //
            if (false) mod_frontside.GodlikeSwitch(null, null);

            //var pieceSW = mod_frontside.GetPiece(FrontClockFace.seven_thirty);
            //var pieceSE = mod_frontside.GetPiece(FrontClockFace.four_thirty);
            //mod_frontside.GodlikeSwitch_BottomPieces(pieceSE, pieceSW);

            //
            // Major call!! 
            //
            mod_frontside.GodlikeSwitch_BottomPieces();

            //
            // Major call!! 
            //
            mod_backside.ComplexRules_AdjacentPairExchange();

            //
            // Feedback after work. 
            //
            //MessageBox.Show(mod_backside._pieceBOY.ToString());



        }


        public void OrientCube_Step1Rotate(RubikPieceCorner par_piece1, RubikPieceCorner par_piece2,
                                             bool par_bOrientPiecesToBottom, 
                                             RubiksCubeOneSide par_sideParentOfPieces,
                                             RubiksCubeOneSide par_sideOther)
        {
            //
            // Rotate the "Parent-of-Pieces" side clockwise (and the opposing side 
            //   counter-clockwise, effectively rotating the entire cube), so that 
            //   specified adjacent pieces are positioned at the bottom of the 
            //   cube (as its depicted graphically in the application window,
            //   i.e. toward the bottom of the main form of the application). 
            //
            // Added 12/8/2020 thomas downes
            //
            bool bPiecesAreAdjacent;
            bPiecesAreAdjacent = par_sideParentOfPieces.PiecesAreAdjacent(par_piece1, par_piece2);
            if (!bPiecesAreAdjacent) throw new ArgumentOutOfRangeException();

            mod_orientation.SomeWorkIsNeeded = false;  // Reinitialize. 
            mod_orientation.HowMany90degreeShiftsClockwise = 0;  // Reinitialize. 
            mod_orientation.MainSide = par_sideParentOfPieces;
            mod_orientation.OtherSide = par_sideOther;
            mod_orientation.piece1_originalPosition = par_piece1.FrontClockFacePosition;
            mod_orientation.piece2_originalPosition = par_piece2.FrontClockFacePosition;
            mod_orientation.AdjacentPiece1 = par_piece1;
            mod_orientation.AdjacentPiece2 = par_piece2;

            bool bKeepRotating = false;  
            bool bPiecesAreNowBottomSWSE;
            bPiecesAreNowBottomSWSE = par_sideParentOfPieces.PiecesAre_BottomSWSE(par_piece1, par_piece2);
            bKeepRotating = (!bPiecesAreNowBottomSWSE);

            //bool bKeepRotating;  
            if (bKeepRotating)
            {
                mod_orientation.SomeWorkIsNeeded = true;  
                do
                {
                    mod_orientation.HowMany90degreeShiftsClockwise++; 
                    par_sideParentOfPieces.Simple_Clockwise90();
                    //Rotate the opposite side in the opposite direction.  
                    par_sideOther.Simple_Counterwise90();

                    bPiecesAreNowBottomSWSE = par_sideParentOfPieces
                        .PiecesAre_BottomSWSE(par_piece1, par_piece2);
                    bKeepRotating = (!bPiecesAreNowBottomSWSE);

                    if (mod_orientation.HowMany90degreeShiftsClockwise > 3)
                    {
                        throw new IndexOutOfRangeException();
                    }

                } while (bKeepRotating);
            }

            //
            // Check that the number of rotations make sense. 
            //
            if (mod_orientation.HowMany90degreeShiftsClockwise > 3)
            {
                throw new IndexOutOfRangeException();
            }

        }


        public void OrientCube_Step2Restore()
        {
            //
            // Reverse the steps performed by the procedure above, 
            //   called "OrientCube_Step1Rotate".
            //
            // Added 12/8/2020 thomas downes
            //
            bool bKeepRotating;
            int intNumRotates90Needed = mod_orientation.HowMany90degreeShiftsClockwise;

            if (mod_orientation.SomeWorkIsNeeded)
            {
                for (int intRotateIndex = 0; intRotateIndex < intNumRotates90Needed; intRotateIndex++)
                {
                    //Rotate the main side __counter-clockwise__ this time. 
                    mod_orientation.MainSide.Simple_Counterwise90();
                    //Rotate the opposite side in the opposite direction, __clockwise__ this time.  
                    mod_orientation.OtherSide.Simple_Clockwise90();
                }
            }       //--while (bKeepRotating);

        }

        
        public Back.ClassBackside BackSide
        {
            // Added 12/13/2020 thomas downes
            //
            //----1/2/2021---return mod_backside;  
            get
            {
                return mod_backside;
            }
            set
            {
                mod_backside = value; 
            }
        }


        public Front.ClassFrontside FrontSide
        {
            //
            // Added 1/02/2021 thomas downes
            //
            get
            {
                return mod_frontside;
            }
            set
            {
                mod_frontside = value;
            }
        }


        public void PaintThisCube_NotInUse(PaintEventArgs par_e, Form par_form, Panel par_panel = null, FormSolvingTool par_frmSolving = null)
        {
            //
            // Not in use.  See the following:  FormSolvingTool.private void Form1_Paint(object sender, PaintEventArgs e)
            //
            //var a_graphics = new System.Drawing.Graphics();  // e.Graphics;

            par_frmSolving.Form1_Paint(par_frmSolving, par_e);

        }

        public void PaintThisCube(System.Drawing.Graphics par_graphics, 
                                  System.Drawing.Point par_pointCenter_FRONT,
                                  System.Drawing.Point par_pointCenter_BACK)
        {
            //
             // Not in use.  See the following:  FormSolvingTool.private void Form1_Paint(object sender, PaintEventArgs e)  
            //
            //var a_graphics = new System.Drawing.Graphics();  // e.Graphics;

            mod_frontside.PaintThisSide(par_graphics, par_pointCenter_FRONT);
            mod_backside.PaintThisSide(par_graphics, par_pointCenter_BACK);

        }

        public void RefreshThisCube_NotInUse(Form par_form, Panel par_panel = null)
        {
            //
            // Not in use.  See the following:  
            //
            //    public void PaintThisCube
            //
        }


        public void Repaint(Form par_form, Point par_pointCenter_FRONT, Point par_pointCenter_BACK)
        {
            //
            // Added 1/28/2021 Thomas Downes  
            //
            //par_form.Refresh();
            var objGraphics = par_form.CreateGraphics();
            PaintThisCube(objGraphics, par_pointCenter_FRONT, par_pointCenter_BACK);

        }


        public void Repaint(Panel par_panelFront, Panel par_panelBackside)
        {
            //
            // Added 1/28/2021 Thomas Downes  
            //
            //par_form.Refresh();
            var graphicsFront = par_panelFront.CreateGraphics();
            var graphicsBack = par_panelBackside.CreateGraphics();

            // 1 of 2. Paint the front side. 
            Point pointCenter_Front = new Point(par_panelFront.Width / 2, par_panelFront.Height / 2);
            mod_frontside.PaintThisSide_Base(graphicsFront, pointCenter_Front);

            // 2 of 2. Paint the back side. 
            Point pointCenter_Back = new Point(par_panelBackside.Width / 2, par_panelBackside.Height / 2);
            mod_backside.PaintThisSide_Base(graphicsBack, pointCenter_Back);

        }


        // Added 1/28/2021 thomas downes
        SideViews.ClassSideViewSide mod_leftside;     // Added 1/28/2021 thomas downes
        SideViews.ClassSideViewSide mod_rightside;    // Added 1/28/2021 thomas downes

        public void RefreshSideViews()   //public ClassSideViewsCube(RubiksCubeBothSides par_cube, EnumLeftOrRight par_enum)
        {
            //-----public ClassSideViewsCube (RubiksCubeBothSides par_cube, EnumLeftOrRight par_enum)
            //
            // Added 1/23/2021 Thomas Downes
            //
            // mod_leftside = new ClassSideViewSide(this, par_enum);
            // if (par_enum == EnumLeftOrRight.Left) mod_back = new ClassSideViewSide(par_cube, EnumLeftOrRight.Right);
            // if (par_enum == EnumLeftOrRight.Right) mod_back = new ClassSideViewSide(par_cube, EnumLeftOrRight.Left);

            //
            // Added 1/28/2021 thomas downes 
            //
            mod_leftside = new SideViews.ClassSideViewSide(this, EnumLeftOrRight.Left);
            mod_rightside = new SideViews.ClassSideViewSide(this, EnumLeftOrRight.Right);

        }


        public void Repaint(Panel par_panelViewableFront, Panel par_panelViewableBackside, EnumPrimaryView par_enum)
        {
            //
            // Added 1/28/2021 Thomas Downes  
            //
            //par_form.Refresh();
            var graphicsViewableFront = par_panelViewableFront.CreateGraphics();
            var graphicsViewableBack = par_panelViewableBackside.CreateGraphics();

            Point pointCenter_ViewableFront; // = null;
            Point pointCenter_ViewableBack; // = null;

            pointCenter_ViewableFront = new Point(par_panelViewableFront.Width / 2,
                                    par_panelViewableFront.Height / 2);
            pointCenter_ViewableBack = new Point(par_panelViewableBackside.Width / 2,
                                                 par_panelViewableBackside.Height / 2);

            switch (par_enum) {

                case EnumPrimaryView.Front: 
                    //
                    // The Default View 
                    //
                    // 1 of 2. Paint the front side. 
                    mod_frontside.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);

                    // 2 of 2. Paint the back side. 
                    mod_backside.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    break;


                case EnumPrimaryView.Back:
                    //
                    // The Backside View
                    //
                    // 1 of 2. Paint the backside onto the "primary view front side" panel. 
                    mod_backside.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);

                    // 2 of 2. Paint the frontside onto the "primary view back side" panel. 
                    mod_frontside.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    break;


                case EnumPrimaryView.Left:
                    //
                    // The Left-Side View 
                    //
                    RefreshSideViews();  //Important!!  

                    // 1 of 2. Paint the Left Side onto the "primary view front side" panel. 
                    mod_leftside.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);

                    // 2 of 2. Paint the Right Side onto the "primary view back side" panel.
                    mod_rightside.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    break;


                case EnumPrimaryView.Right:
                    //
                    // The Right-Side View 
                    //
                    RefreshSideViews();  //Important!!  

                    // 1 of 2. Paint the Right Side onto the "primary view front side" panel. 
                    mod_rightside.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);

                    // 2 of 2. Paint the Left Side onto the "primary view back side" panel. 
                    mod_leftside.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    break;

                default:
                    throw new NotImplementedException("This enum value has not been specified.");

            }

        }



    }
}
