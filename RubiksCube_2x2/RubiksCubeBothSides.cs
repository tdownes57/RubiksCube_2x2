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
        //---Front.ClassFrontside mod_mainside_front;
        //---Back.ClassBackside mod_mainside_back;
        RubiksCubeOneSide mod_mainside_front;  // This might be instantiated as an object of a child class Front.ClassFrontside.
        RubiksCubeOneSide mod_mainside_back;   // This might be instantiated as an object of a child class.  Back.ClassBackside 

        //Added 4/1/2021 thomas downes
        //   Save a back-up copy of the original Front & Back,
        //   in case they are needed after a Pivot Perspective
        //   has taken place. 
        //   ----4/1/2021 thomas downes
        Front.ClassFrontside mod_mainside_front_original;
        Back.ClassBackside mod_mainside_back_original;

        private struct OrientationWork
        {
            public RubiksCubeOneSide MainSide;
            //public BackOrFront OtherSide;
            public RubiksPieceCorner AdjacentPiece1;
            public RubiksPieceCorner AdjacentPiece2;
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
            mod_mainside_back = par_backside;
            mod_mainside_front = par_frontside;

            // Added 4/1/2021 thomas downes
            //   Save a backup copy of the reference, in case a
            //   Pivot-Perspective operation takes place.
            //
            mod_mainside_back_original = par_backside;
            mod_mainside_front_original = par_frontside;

        }


        public RubiksCubeBothSides()
        {
            //
            // Added 1/13/2021 thomas downes  
            //
            mod_mainside_front = new Front.ClassFrontside();
            mod_mainside_back = new Back.ClassBackside();

            // Added 4/1/2021 thomas downes
            //   Save a backup copy of the reference, in case a
            //   Pivot-Perspective operation takes place.
            //
            mod_mainside_back_original = (mod_mainside_back as Back.ClassBackside);
            mod_mainside_front_original = (mod_mainside_front as Front.ClassFrontside);

        }


        public RubiksCubeBothSides(EnumColorIsHardcoded par_enum)
        {
            //
            // Added 2/05/2021 thomas downes  
            //
            if (par_enum == EnumColorIsHardcoded.True)
            {
                mod_mainside_front = new Front.ClassFrontside();
                mod_mainside_back = new Back.ClassBackside();
            }
            else
            {
                //
                // Colors of the pieces are _NOT_ hard-coded.  
                //
                mod_mainside_front = new SideViews.ClassSideViewSide(this, EnumLeftOrRight.Unassigned);
                mod_mainside_back = new SideViews.ClassSideViewSide(this, EnumLeftOrRight.Unassigned);
            }

            // Added 4/1/2021 thomas downes
            //   Save a backup copy of the reference, in case a
            //   Pivot-Perspective operation takes place.
            //
            mod_mainside_back_original = (mod_mainside_back as Back.ClassBackside);
            mod_mainside_front_original = (mod_mainside_front as Front.ClassFrontside);

        }


        public void SwitchBottomPieces_Front()
        {
            //
            // Added 12/9/2020 td 
            //
            //if (false) mod_mainside_front.GodlikeSwitch(null, null);
            if (false) mod_mainside_front.GodlikeSwitch_Piece(null, null);

            //var pieceSW = mod_frontside.GetPiece(FrontClockFace.seven_thirty);
            //var pieceSE = mod_frontside.GetPiece(FrontClockFace.four_thirty);
            //mod_frontside.GodlikeSwitch_BottomPieces(pieceSE, pieceSW);

            //
            // Major call!! 
            //
            //----mod_mainside_front.GodlikeSwitch_BottomPieces();
            if (mod_mainside_front is Front.ClassFrontside) // Added 2/5/2021 thomas downes 
            {
                (mod_mainside_front as Front.ClassFrontside).GodlikeSwitch_BottomPieces();
            }

            //
            // Major call!! 
            //
            //----mod_mainside_back.ComplexRules_AdjacentPairExchange();
            if (mod_mainside_back is Back.ClassBackside) // Added 2/5/2021 thomas downes 
            {
                (mod_mainside_back as Back.ClassBackside).ComplexRules_AdjacentPairExchange();
            }

            //
            // Feedback after work. 
            //
            //MessageBox.Show(mod_backside._pieceBOY.ToString());



        }


        public void OrientCube_Step1Rotate(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2,
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
                //----return mod_mainside_back;
                //---return (mod_mainside_back as Back.ClassBackside);

                var temp_back = (mod_mainside_back as Back.ClassBackside);

                //Added 4/1/2021 thomas downes
                //if (temp_back == null) System.Diagnostics.Debugger.Break();
                //if (temp_back == null) throw new NotImplementedException("Maybe I should rethink the Pivot Perspective routine.");

                return temp_back;

            }
            set
            {
                mod_mainside_back = value; 
            }
        }


        public RubiksCubeOneSide BackSide_GenericCubeSide
        {
            //
            // Added 4/01/2021 thomas downes
            //
            // If (mod_mainside_back as Back.ClassBackSide) is Nothing (null), then
            //    it's a good bet that the Pivot Perspective Button has been pressed,
            //    so the current "BackSide" is not the original BackSide.  The 
            //    BackSide_GenericCubeSide may be a former side view. 
            //    ----4/1/2021 Thomas Downes
            // 
            get
            {
                return mod_mainside_back;

            }
            set
            {
                mod_mainside_back = value;
            }
        }


        public SideViews.ClassSideViewSide SideViewRight
        {
            //
            // Added 1/31/2021 thomas downes
            //
            get
            {
                return mod_sideview_right;
            }
            set
            {
                mod_sideview_right = value;
            }
        }


        public SideViews.ClassSideViewSide SideViewLeft
        {
            //
            // Added 3/31/2021 thomas downes
            //
            get
            {
                return mod_sideview_left;
            }
            set
            {
                mod_sideview_left = value;
            }
        }


        public Front.ClassFrontside FrontSide
        {
            //
            // Added 1/02/2021 thomas downes
            //
            get
            {
                //---return mod_mainside_front;
                //----return (mod_mainside_front as RubiksCubeOneSide );
                //---if (mod_mainside_front is RubiksCubeOneSide) return (Front.ClassFrontside)mod_mainside_front;

                return (mod_mainside_front as Front.ClassFrontside);

            }
            set
            {
                mod_mainside_front = value;
            }
        }


        public RubiksCubeOneSide FrontSide_GenericCubeSide
        {
            //
            // Added 4/01/2021 thomas downes
            //
            // If (mod_mainside_front as Front.ClassFrontSide) is Nothing (null), then
            //    it's a good bet that the Pivot Perspective Button has been pressed,
            //    so the current "FrontSide" is not the original FrontSide.  The 
            //    FrontSide_GenericCubeSide may be a former side view. 
            //    ----4/1/2021 Thomas Downes
            // 
            get
            {
                return mod_mainside_front;

            }
            set
            {
                mod_mainside_front = value;
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

            // Added 2/5/2021 thomas downes
            bool bHardCodedColors = (mod_mainside_front is Front.ClassFrontside);

            //mod_mainside_Front.PaintThisSide(par_graphics, par_pointCenter_FRONT);
            //mod_mainside_back.PaintThisSide(par_graphics, par_pointCenter_BACK);
            if (bHardCodedColors)
            {
                //mod_mainside_Front.PaintThisSide(par_graphics, par_pointCenter_FRONT);
                //mod_mainside_back.PaintThisSide(par_graphics, par_pointCenter_BACK);
                (mod_mainside_front as Front.ClassFrontside).PaintThisSide(par_graphics, par_pointCenter_FRONT);
                (mod_mainside_back as Back.ClassBackside).PaintThisSide(par_graphics, par_pointCenter_BACK);
            }
            else
            {
                // Added 2/5/2021 thomas downes
                mod_mainside_front.PaintThisSide_Base(par_graphics, par_pointCenter_FRONT);
                mod_mainside_back.PaintThisSide_Base(par_graphics, par_pointCenter_BACK);
            }


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
            mod_mainside_front.PaintThisSide_Base(graphicsFront, pointCenter_Front);

            // 2 of 2. Paint the back side. 
            Point pointCenter_Back = new Point(par_panelBackside.Width / 2, par_panelBackside.Height / 2);
            mod_mainside_back.PaintThisSide_Base(graphicsBack, pointCenter_Back);

        }


        // Added 1/28/2021 thomas downes
        SideViews.ClassSideViewSide mod_sideview_left;     // Added 1/28/2021 thomas downes
        SideViews.ClassSideViewSide mod_sideview_right;    // Added 1/28/2021 thomas downes
        SideViews.ClassSideViewSide mod_sideview_front_NotInUse;     // Added 1/28/2021 thomas downes
        SideViews.ClassSideViewSide mod_sideview_back_NotInUse;    // Added 1/28/2021 thomas downes

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
            mod_sideview_left = new SideViews.ClassSideViewSide(this, EnumLeftOrRight.Left);
            mod_sideview_right = new SideViews.ClassSideViewSide(this, EnumLeftOrRight.Right);

        }


        public void PivotPerspective_Left()
        {
            //
            // Added 4/1/2021 Thomas Downes  
            //
            //var temp_side_front = mod_sideview_front;
            var temp_side_front = this.mod_mainside_front; //  mod_sideview_front;
            //var temp_side_back = mod_sideview_back;
            var temp_side_back = this.mod_mainside_back; //  mod_sideview_front;
            var temp_side_left = this.mod_sideview_left;
            var temp_side_right = this.mod_sideview_right;

            //Added 4/3/2021 thomas downes
            bool bOriginalFront_temp_front = this.mod_mainside_front.OriginalFront;
            bool bOriginalFront_temp_back = this.mod_mainside_back.OriginalFront;
            bool bOriginalFront_temp_left = this.mod_sideview_left.OriginalFront;
            bool bOriginalFront_temp_right = this.mod_sideview_right.OriginalFront;

            // Added 4/3/2021 Thomas Downes  
            const bool c_boolDoublecheckF1 = true;
            if (c_boolDoublecheckF1)
            {
                // Added 4/3/2021 Thomas Downes  
                int intAddBooleanValuesF1 =
                       (Convert.ToInt32(bOriginalFront_temp_back) +
                        Convert.ToInt32(bOriginalFront_temp_front) +
                        Convert.ToInt32(bOriginalFront_temp_left) +
                        Convert.ToInt32(bOriginalFront_temp_right));
                if (intAddBooleanValuesF1 != 1) throw new Exception(String.Format("There should be one(1) Original Back Side, _NOT_ {0}.", intAddBooleanValuesF1));

            }

            //Added 4/3/2021 thomas downes
            bool bOriginalBack_temp_front = this.mod_mainside_front.OriginalBack;
            bool bOriginalBack_temp_back = this.mod_mainside_back.OriginalBack;
            bool bOriginalBack_temp_left = this.mod_sideview_left.OriginalBack;
            bool bOriginalBack_temp_right = this.mod_sideview_right.OriginalBack;

            // Added 4/3/2021 Thomas Downes  
            const bool c_boolDoublecheckB1 = true;
            if (c_boolDoublecheckB1)
            {
                // Added 4/3/2021 Thomas Downes  
                int intAddBooleanValuesB1 =
                       (Convert.ToInt32(bOriginalBack_temp_back) +
                        Convert.ToInt32(bOriginalBack_temp_front) +
                        Convert.ToInt32(bOriginalBack_temp_left) +
                        Convert.ToInt32(bOriginalBack_temp_right));
                if (intAddBooleanValuesB1 != 1) throw new Exception(String.Format("There should be one(1) Original Back Side, _NOT_ {0}.", intAddBooleanValuesB1));

            }


            if (mod_mainside_front == null) System.Diagnostics.Debugger.Break();
            if (mod_mainside_back == null) System.Diagnostics.Debugger.Break();

            // Added 4/1/2021 thomas downes
            if (mod_sideview_left == null) System.Diagnostics.Debugger.Break();
            if (mod_sideview_right == null) System.Diagnostics.Debugger.Break();

            //mod_sideview_left = mod_mainside_front;
            //mod_sideview_left = new SideViews.ClassSideViewSide(mod_mainside_front, EnumLeftOrRight.Left);
            //mod_sideview_left = new SideViews.ClassSideViewSide(temp_side_back, EnumLeftOrRight.Left, true);
            mod_sideview_left = new SideViews.ClassSideViewSide(temp_side_back, EnumLeftOrRight.Left, true, 
                EnumCubeRotation_NorthPole.Counterclock);

            //mod_mainside_front = mod_sideview_right;
            mod_mainside_front = temp_side_left;
            //mod_sideview_right = mod_mainside_back;
            //mod_sideview_right = new SideViews.ClassSideViewSide(mod_mainside_back, EnumLeftOrRight.Right);
            //mod_sideview_right = new SideViews.ClassSideViewSide(temp_side_front, EnumLeftOrRight.Right, true);
            mod_sideview_right = new SideViews.ClassSideViewSide(temp_side_front, EnumLeftOrRight.Right, true, 
                EnumCubeRotation_NorthPole.Counterclock);

            //mod_mainside_back = temp_side; 
            //mod_mainside_back = new Back.ClassBackside(temp_side);
            mod_mainside_back = temp_side_right;

            //Added 4/2/2021 thomas downes
            //if (temp_side_front.OriginalFront) { mod_sideview_right.OriginalFront = true; /* Next, clear the True value.*/ temp_side_front.OriginalFront = false; }
            //else if (temp_side_back.OriginalFront) { mod_sideview_left.OriginalFront = true; /* Next, clear the True value.*/ temp_side_back.OriginalFront = false; }
            //else if (temp_side_left.OriginalFront) { mod_mainside_front.OriginalFront = true; /* Next, clear the True value.*/ temp_side_left.OriginalFront = false; }
            //else if (temp_side_right.OriginalFront) { mod_mainside_back.OriginalFront = true; /* Next, clear the True value.*/ temp_side_right.OriginalFront = false; }

            //Added 4/3/2021 thomas downes
            //
            // Part 1 of 2: Frontside (Original Front) 
            //
            // Which side was the Frontside originally, i.e. before the user started pressing the Pivot Perspective buttons?
            //
            mod_mainside_front.OriginalFront = false;   // First, clear any True values. 
            mod_mainside_back.OriginalFront = false;   // First, clear any True values. 
            mod_sideview_left.OriginalFront = false;   // First, clear any True values. 
            mod_sideview_right.OriginalFront = false;   // First, clear any True values. 
            if (bOriginalFront_temp_front) { mod_sideview_right.OriginalFront = true;    }
            else if (bOriginalFront_temp_back) { mod_sideview_left.OriginalFront = true;    }
            else if (bOriginalFront_temp_left) { mod_mainside_front.OriginalFront = true;   }
            else if (bOriginalFront_temp_right) { mod_mainside_back.OriginalFront = true;   }

            // Added 4/3/2021 Thomas Downes  
            const bool c_boolDoublecheckF = true;
            if (c_boolDoublecheckF)
            {
                // Added 4/3/2021 Thomas Downes  
                int intAddBooleanValuesF =
                       (Convert.ToInt32(mod_mainside_front.OriginalFront) +
                        Convert.ToInt32(mod_mainside_back.OriginalFront) +
                        Convert.ToInt32(mod_sideview_left.OriginalFront) +
                        Convert.ToInt32(mod_sideview_right.OriginalFront)) ;
                //if (intAddBooleanValues != 1) throw new Exception("There should be one Front Side.");
                if (intAddBooleanValuesF != 1) throw new Exception(String.Format("There should be one(1) Original Front Side, _NOT_ {0}.", intAddBooleanValuesF));

            }

            //Added 4/3/2021 thomas downes
            //
            // Part 2 of 2: Backside (Orginal Back)  
            //
            // Which side was the Backside originally, i.e. before the user started pressing the Pivot Perspective buttons?
            //
            mod_mainside_front.OriginalBack = false;   // First, clear any True values. 
            mod_mainside_back.OriginalBack = false;   // First, clear any True values. 
            mod_sideview_left.OriginalBack = false;   // First, clear any True values. 
            mod_sideview_right.OriginalBack = false;   // First, clear any True values. 
            if (bOriginalBack_temp_front) { mod_sideview_right.OriginalBack = true; }
            else if (bOriginalBack_temp_back) { mod_sideview_left.OriginalBack = true; }
            else if (bOriginalBack_temp_left) { mod_mainside_front.OriginalBack = true; }
            else if (bOriginalBack_temp_right) { mod_mainside_back.OriginalBack = true; }

            // Added 4/3/2021 Thomas Downes  
            const bool c_boolDoublecheckB2 = true;
            if (c_boolDoublecheckB2)
            {
                // Added 4/3/2021 Thomas Downes  
                int intAddBooleanValuesB2 =
                       (Convert.ToInt32(mod_mainside_front.OriginalBack) +
                        Convert.ToInt32(mod_mainside_back.OriginalBack) +
                        Convert.ToInt32(mod_sideview_left.OriginalBack) +
                        Convert.ToInt32(mod_sideview_right.OriginalBack));
                if (intAddBooleanValuesB2 != 1) throw new Exception(String.Format("There should be one(1) Original Back Side, _NOT_ {0}.", intAddBooleanValuesB2));

            }


        }


        public void PivotPerspective_Right()
        {
            //
            // Added 4/1/2021 Thomas Downes  
            //
            //var temp_side = mod_sideview_right;
            //var temp_side_front = mod_sideview_front;
            var temp_side_front = this.mod_mainside_front; //  mod_sideview_front;
            //var temp_side_back = mod_sideview_back;
            var temp_side_back = this.mod_mainside_back; //  mod_sideview_front;
            var temp_side_left = this.mod_sideview_left;
            var temp_side_right = this.mod_sideview_right;

            if (mod_mainside_front == null) System.Diagnostics.Debugger.Break();
            if (mod_mainside_back == null) System.Diagnostics.Debugger.Break();

            // Added 4/1/2021 thomas downes
            if (mod_sideview_left == null) System.Diagnostics.Debugger.Break();
            if (mod_sideview_right == null) System.Diagnostics.Debugger.Break();

            //mod_sideview_right = mod_mainside_front;
            //---mod_sideview_right = new SideViews.ClassSideViewSide(mode_mainside_front, EnumLeftOrRight.Right);
            mod_sideview_right = new SideViews.ClassSideViewSide(temp_side_back, EnumLeftOrRight.Right, true,
                EnumCubeRotation_NorthPole.Clockwise);

            //mod_mainside_front = mod_sideview_left;
            mod_mainside_front = temp_side_right;
            //mod_sideview_left = mod_mainside_back;
            //mod_sideview_left = new SideViews.ClassSideViewSide(mod_mainside_back, EnumLeftOrRight.Left);
            mod_sideview_left = new SideViews.ClassSideViewSide(temp_side_front, EnumLeftOrRight.Left, true,
                EnumCubeRotation_NorthPole.Clockwise);

            //mod_mainside_back = temp_side;
            mod_mainside_back = temp_side_left;

            //Added 4/2/2021 thomas downes
            if (temp_side_front.OriginalFront) { mod_sideview_left.OriginalFront = true; temp_side_front.OriginalFront = false; }
            else if (temp_side_back.OriginalFront) { mod_sideview_right.OriginalFront = true; temp_side_back.OriginalFront = false; }
            else if (temp_side_left.OriginalFront) { mod_mainside_back.OriginalFront = true; temp_side_left.OriginalFront = false; }
            else if (temp_side_right.OriginalFront) { mod_mainside_front.OriginalFront = true; temp_side_right.OriginalFront = false; }

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
                    //---mod_mainside_front.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);
                    mod_mainside_front.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);

                    // 2 of 2. Paint the back side. 
                    //---mod_mainside_back.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    mod_mainside_back.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    break;


                case EnumPrimaryView.Back:
                    //
                    // The Backside View
                    //
                    // 1 of 2. Paint the backside onto the "primary view front side" panel. 
                    //---mod_mainside_back.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);
                    mod_mainside_back.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);

                    // 2 of 2. Paint the frontside onto the "primary view back side" panel. 
                    //---mod_mainside_front.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    mod_mainside_front.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    break;


                case EnumPrimaryView.Left:
                    //
                    // The Left-Side View 
                    //
                    RefreshSideViews();  //Important!!  

                    // 1 of 2. Paint the Left Side onto the "primary view front side" panel. 
                    //----mod_sideview_left.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);
                    //mod_sideview_left.PaintThisSide_Base(graphicsViewable, pointCenter_ViewableFront, par_enum);

                    // 2 of 2. Paint the Right Side onto the "primary view back side" panel.
                    //----mod_sideview_right.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    //mod_sideview_right.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack, par_enum);
                    //break;
                    throw new NotImplementedException();

                case EnumPrimaryView.Right:
                    //
                    // The Right-Side View 
                    //
                    RefreshSideViews();  //Important!!  

                    // 1 of 2. Paint the Right Side onto the "primary view front side" panel. 
                    //----mod_sideview_right.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront);
                    //mod_sideview_right.PaintThisSide_Base(graphicsViewableFront, pointCenter_ViewableFront, par_enum);

                    // 2 of 2. Paint the Left Side onto the "primary view back side" panel. 
                    //----mod_sideview_left.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack);
                    //mod_sideview_left.PaintThisSide_Base(graphicsViewableBack, pointCenter_ViewableBack, par_enum);
                    //break;
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException("This enum value has not been specified.");

            }

        }


        public void Repaint(Panel par_panelViewableFront, Panel par_panelViewableBackside, 
                            Panel par_panelViewableRight)
        {
            //
            // Added 1/31/2021 Thomas Downes  
            //
            this.Repaint(par_panelViewableFront, par_panelViewableBackside, EnumPrimaryView.Front);

            //
            // Side Views. 
            //
            RefreshSideViews();
            //----mod_sideview_right.Repaint(par_panelViewableRight);
            mod_sideview_right.Repaint(par_panelViewableRight, true, EnumPrimaryView.Right);

        }


        public void Repaint(Panel par_panelViewableFront, Panel par_panelViewableBackside,
                    Panel par_panelViewableRight, Panel par_panelViewableLeft)
        {
            //
            // Added 3/31/2021 Thomas Downes  
            //
            this.Repaint(par_panelViewableFront, par_panelViewableBackside, EnumPrimaryView.Front);

            //
            // Side Views. 
            //
            RefreshSideViews();
             
            mod_sideview_right.Repaint(par_panelViewableRight, true, EnumPrimaryView.Right);
            mod_sideview_left.Repaint(par_panelViewableLeft, true, EnumPrimaryView.Left);

        }


    }

}
