using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;    //Added 12/13/2020 thomas downes

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




    }
}
