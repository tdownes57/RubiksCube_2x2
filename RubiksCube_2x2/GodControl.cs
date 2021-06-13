using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubiksCube_2x2
{
    public partial class GodControl : UserControl
    {
        //
        // Added 4/30/2021 thoimas downes
        //
        //internal RubiksCubeOneSide ThisCubeSide;
        //private RubiksCubeOneSide mod_cubeBackside;
        //private RubiksCubeOneSide mod_cubeFrontside_NotInUse;
        private Back.ClassBackside mod_cubeBackside;
        private Front.ClassFrontside mod_cubeFrontside_NotInUse;
        private RubiksCubeBothSides mod_cubeWholeBothSides;
        internal Panel panelFront_NotInUse;

        internal RubiksCubeOneSide ThisCubeSide_Deprecated
        {
            get 
            {
                // Added 4/30/2021 
                return mod_cubeBackside;
            }
            set
            {
                // Added 4/30/2021 
                //mod_cubeBackside = value;
                //mod_cubeBackside = (Back.ClassBackside)value;

                mod_cubeBackside = (value as Back.ClassBackside);
                //Just in case we've been passed a FrontSide!!
                if (mod_cubeBackside == null) mod_cubeFrontside_NotInUse = (value as Front.ClassFrontside);

            }
        }

        internal RubiksCubeBothSides ThisCubeEntire
        {
            get
            {
                // Added 4/30/2021 
                return mod_cubeWholeBothSides;
            }
            set
            {
                // Added 4/30/2021 
                mod_cubeWholeBothSides = value;

                //Added 5/2/2021 Thomas Downes  
                mod_cubeFrontside_NotInUse = value.FrontSide;

            }
        }


        //-----internal Panel panelFront_NotInUse;
        //internal Panel panelBack;

        //Added 11/17/2020 thomas downes
        private Cursor _customCursorRing = null;
        private Cursor _customCursorPlus = null;
        private RubiksPieceCorner _rubiksPiece_Dragged = null;
        private RubiksPieceCorner _rubiksPiece_Replaced = null;

        //Added 4/30/2021 thomas downes
        private Point center_point_form_FRONT; // = new Point(this.Width / 2, this.Height / 2);
        private Point center_point_form_BACK; // Added 4/30/2021 & 11/12/2020 td
        private bool _bClickedBackside;  // Added 4/30/2021
        // Not in use.  //
        private bool _bClickedFrontside_NotInUse;  // Added 4/30/2021

        public GodControl()
        {
            InitializeComponent();
        }

        private bool CheckForGodlikeBehavior_MovePiece()
        {
            //
            // Added 4/30/2021 thoms downes
            //
            return true; 
        }
        private bool CheckForGodlikeBehavior_RotatePiece()
        {
            //
            // Added 4/30/2021 thoms downes
            //
            return true;
        }

        private void GodControl_Load(object sender, EventArgs e)
        {
            //
            // Added 4/30/2021 thomas downes
            //
        }

        private void GodControl_MouseEnter(object sender, EventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes
            //
            //this.Cursor
            //
            //  C# Winforms - change cursor icon of mouse
            //  https://stackoverflow.com/questions/2902327/c-sharp-winforms-change-cursor-icon-of-mouse
            //  https://stackoverflow.com/questions/432379/set-custom-cursor-from-resource-file
            //  https://www.youtube.com/watch?v=mTuVpfsPX1k
            //  https://convertico.com/
            //
            //
            //I have the answer for a picturebox
            //
            //    Picturebox1.cursor = new cursor(Properties.Resources.CURSOR NAME.GetHicon());
            //
            //this.Cursor = new Cursor(Properties.Resources.custom_cursor_tcd2);

            //var ms_stream = new System.IO.MemoryStream(Properties.Resources.custom_cursor_tcd2);  // (My.Resources.Cursor1)
            ////this.Cursor = new Cursor(ms_stream);
            //((Panel)sender).Cursor = new Cursor(ms_stream);


        }

        private void GodControl_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void GodControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAnySide_MouseMove(object sender, MouseEventArgs e)
        {
            //
            // Added 4/30/2021 and 11/17/2020 thomas downes 
            //
            Point currentLocation = new Point(e.X, e.Y);

            RubiksPieceCorner whichPiece = null;

            //
            // Back Side 
            //
            if (whichPiece == null)
            {
                //if (sender == this.panelBack_NotInUse) // Added 1/29/2021 thomas downes
                //whichPiece = mod_cubeBackside.WhichPieceHasMouseHover(currentLocation);

                //if (this.ThisCubeSide_Deprecated == null)
                //{
                //    MessageBox.Show("Not sure which cube side you are on.  Front, maybe??");
                //    return;
                //}
                //whichPiece = this.ThisCubeSide.WhichPieceHasMouseHover(currentLocation);
                if (mod_cubeBackside != null)
                    whichPiece = mod_cubeBackside.WhichPieceHasMouseHover(currentLocation);

            }

            //
            // Front Side
            //
            //Added 12/6/2020 thomas downes
            //if (whichPiece == null)
            //{
            //    //Added 12/6/2020 thomas downes
            //    if (sender == panelFront_NotInUse) // Added 1/29/2021 thomas downes
            //       // whichPiece = mod_cubeFrontside.WhichPieceHasMouseHover(currentLocation);
            //       whichPiece = this.ThisCubeSide.WhichPieceHasMouseHover(currentLocation);

            //    //Added 12/6/2020 thomas downes
            //    if (false && whichPiece != null)
            //        MessageBox.Show("You have placed the mouse over the front side of the Rubik's Cube.");
            //}

            //
            // Take a look at whether or not we have identified a clicked piece. 
            //
            if (whichPiece == null)
            {
                if (_rubiksPiece_Dragged == null)
                {
                    //this.Cursor = Cursors.Default;
                    ((Panel)sender).Cursor = Cursors.Default;
                }
            }
            else
            {
                if (_rubiksPiece_Dragged != null)
                {
                    //
                    // We are dragging a piece. Don't modify the cursor. 
                    //
                }
                else
                {
                    //
                    // Let's apply the Ring cursor, "ring_cursor" (formerly "transparent2").  
                    //
                    if (_customCursorRing == null)
                    {
                        //var ms = new System.IO.MemoryStream(Properties.Resources.custom_cursor_tcd2);  // (My.Resources.Cursor1)
                        //var ms = new System.IO.MemoryStream(Properties.Resources.transparent2);  // (My.Resources.Cursor1)
                        var ms_stream = new System.IO.MemoryStream(Properties.Resources.ring_cursor);  // (My.Resources.Cursor1)
                        _customCursorRing = new Cursor(ms_stream);
                    }

                    //this.Cursor = new Cursor(ms);
                    //this.Cursor = _customCursorRing;
                    ((Panel)sender).Cursor = _customCursorRing;

                }
            }


        }

        private void panelAnySide_Paint(object sender, PaintEventArgs e)
        {
            //
            // Added 4/30/2021 and 1/28/2021 thomas downes
            //
            var panel_sender = (Panel)sender;
            //----mod_cubeWholeBothSides.FrontSide.Repaint(panel_sender);
            //mod_cubeWholeBothSides.FrontSide.Repaint(panel_sender, false);

            //if (mod_cubeWholeBothSides.FrontSide == null)
            //if (this.ThisCubeSide == null)
            //{
            //    //
            //    // It's a good bet that the Pivot Perspective Button has been pressed,
            //    //    so the current "FrontSide" is not the original FrontSide.  The 
            //    //    FrontSide_GenericCubeSide may be a former side view. 
            //    //    ----4/1/2021 Thomas Downes
            //    //
            //    mod_cubeWholeBothSides.FrontSide_GenericCubeSide.Repaint(panel_sender, false);
            //    // Added 4/2/2021 thomas downes
            //    labelOriginalFrontF.Visible = mod_cubeWholeBothSides.FrontSide_GenericCubeSide.OriginalFront;
            //    labelOriginalBackF.Visible = mod_cubeWholeBothSides.FrontSide_GenericCubeSide.OriginalBack;
            //}
            //else
            //{
            //     mod_cubeWholeBothSides.FrontSide.Repaint(panel_sender, false);

            center_point_form_FRONT = new Point(this.Width / 3, 1 * this.Height / 3);
            center_point_form_BACK = new Point(this.Width * 2 / 3, 1 * this.Height / 3);

            //if (this.ThisCubeSide != null)
            //this.ThisCubeSide.Repaint(panel_sender, false);

            if (mod_cubeBackside != null)
                mod_cubeBackside.Repaint(panel_sender, false);

            // Added 4/2/2021 thomas downes
            //labelOriginalFrontF.Visible = mod_cubeWholeBothSides.FrontSide.OriginalFront;
            //labelOriginalBackF.Visible = mod_cubeWholeBothSides.FrontSide.OriginalBack;

            // Added 5/6/2021
            if (mod_cubeBackside != null)
            {
                labelPanelHeight.Text = "Panel Height = " + mod_cubeBackside.Output_PanelHeight.ToString();
                labelPanelWidth.Text = "Panel Width = " + mod_cubeBackside.Output_PanelWidth.ToString();

                labelCenterX.Text = "Center X = " + mod_cubeBackside.Output_CenterX.ToString();
                labelCenterY.Text = "Center Y = " + mod_cubeBackside.Output_CenterY.ToString();
            }

        }

        private void panelAnySide_MouseEnter(object sender, EventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes
            //
            //this.Cursor
            //
            //  C# Winforms - change cursor icon of mouse
            //  https://stackoverflow.com/questions/2902327/c-sharp-winforms-change-cursor-icon-of-mouse
            //  https://stackoverflow.com/questions/432379/set-custom-cursor-from-resource-file
            //  https://www.youtube.com/watch?v=mTuVpfsPX1k
            //  https://convertico.com/
            //
            //
            //I have the answer for a picturebox
            //
            //    Picturebox1.cursor = new cursor(Properties.Resources.CURSOR NAME.GetHicon());
            //
            //this.Cursor = new Cursor(Properties.Resources.custom_cursor_tcd2);

            var ms_stream = new System.IO.MemoryStream(Properties.Resources.custom_cursor_tcd2);  // (My.Resources.Cursor1)
            //this.Cursor = new Cursor(ms_stream);
            ((Panel)sender).Cursor = new Cursor(ms_stream);


        }

        private void panelAnySide_MouseClick(object sender, MouseEventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes  
            //
            bool bClickedFrontside_NotInUse = false;  // _bClickedFrontside; //  false;
            bool bClickedBackside = false;  // _bClickedBackside;  // false;
            bool bAllowGodlikeOperations = true;  //  (1 == comboGodlikePowers.SelectedIndex);

            //Added 1/29/2021
            if (false == bAllowGodlikeOperations)
            {
                labelHowToMoveAPiece.Text = "You have not specified godlike operations.";
                labelHowToMoveAPiece.ForeColor = Color.Red;
                labelHowToMoveAPiece.Visible = true;
                return;
            }


            RubiksPieceCorner piece_clicked = null;

            //Front Side
            //  Check the Front Side for a clicked piece. 
            //
            //if (piece_clicked == null)
            //{
            //    //if (sender == panelBack_NotInUse) // Added 1/29/2021 thomas downes
            //    if (sender == panelBack) // Added 1/29/2021 thomas downes
            //            piece_clicked = mod_cubeBackside.WhichPieceIsClicked(e.X, e.Y);
            //    if (piece_clicked != null) bClickedFrontside_NotInUse = true;
            //}

            // Sloan says, look here, there's a bug!!!
            // AccessibleDefaultActionDescription ----- 

            //Back Side
            //  Check the Back Side for a clicked piece.
            //
            if (piece_clicked == null)
            {
                //if (sender == panelBack) // Added 1/29/2021 thomas downes
                if (sender == panelBack) // Added 1/29/2021 thomas downes
                        piece_clicked = mod_cubeBackside.WhichPieceIsClicked(e.X, e.Y);
                if (piece_clicked != null) bClickedBackside = true;
            }

            if (piece_clicked == null)
            {
                //
                // Clean up time!!   Then exit Sub.
                //
                _rubiksPiece_Dragged = null;
                _rubiksPiece_Replaced = null;
                this.Cursor = Cursors.Default;
                labelHowToMoveAPiece.Visible = false;

                //Added 11/17/2020 thomas d.
                //CheckIfSideFaceWasClicked(e.X, e.Y);
                CheckIfSideFaceWasClicked(e.X, e.Y, (Panel)sender);

                //Added 12/6/2020 thomas downes
                _bClickedFrontside_NotInUse = bClickedFrontside_NotInUse;
                //_bClickedBackside = bClickedBackside;

                return;
            }

            else if (piece_clicked != null)
            {
                if (_rubiksPiece_Dragged != null)
                {
                    //
                    //   Step 2 of 2 -- Replace.
                    //
                    //   We are pretty much done with the drag-and-replace process. 
                    //
                    this.Cursor = Cursors.Default;
                    _rubiksPiece_Replaced = piece_clicked;

                    // Added 11/17/2020 thomas downes
                    if (bAllowGodlikeOperations) // Conditioned 12/7/2020 td
                    {
                        //
                        // Allow the pieces to be moved without any consequence to the 
                        //    arrangement of pieces on the opposide side of the cube. 
                        //
                        // Condition added 12/06/2020 thomas downes
                        RubiksCubeOneSide cubeSide = null;

                        //if (bClickedFrontside) cubeSide = mod_cubeFrontside;
                        //if (bClickedBackside) cubeSide = mod_cubeBackside;
                        //if (bClickedSide) cubeSide = this.ThisCubeSide;
                        if (bClickedBackside) cubeSide = mod_cubeBackside;

                        cubeSide.GodlikeSwitch_Piece(_rubiksPiece_Dragged, _rubiksPiece_Replaced);

                        // Added 6/13/2021 thomas downes
                        cubeSide.Remove_DrawWithEmphasis();
                        _rubiksPiece_Dragged.DrawWithEmphasis_JustMoved = true;

                        // Condition (& function call) added 12/06/2020 thomas downes
                        //if (bClickedFrontside) mod_cubeFrontside
                        //    .GodlikeSwitch(_rubiksPiece_Dragged, _rubiksPiece_Replaced);
                    }
                    else
                    {
                        //
                        // Allow only adjacent pieces to be swapped. 
                        //
                        bool bPiecesAreAdjacent_Front = (bClickedFrontside_NotInUse
                            && mod_cubeFrontside_NotInUse.AdjacentPieces(_rubiksPiece_Dragged, _rubiksPiece_Replaced));
                        bool bPiecesAreAdjacent_Back = (bClickedBackside
                            && mod_cubeBackside.AdjacentPieces(_rubiksPiece_Dragged, _rubiksPiece_Replaced));

                        bool bAdjacentPieces = (bPiecesAreAdjacent_Front || bPiecesAreAdjacent_Back);

                        if (bAdjacentPieces)
                        {
                            // Added 12/7/2020 td
                            MessageBox.Show("Great, the pieces are adjacent.  Okay to effect the consequences to the other side?");

                            //Added 12/9/2020 thomas downes  
                            if (bClickedFrontside_NotInUse)
                                mod_cubeWholeBothSides.OrientCube_Step1Rotate(_rubiksPiece_Dragged,
                                 _rubiksPiece_Replaced, true,
                                 mod_cubeFrontside_NotInUse, mod_cubeBackside);
                            if (bClickedBackside)
                                mod_cubeWholeBothSides.OrientCube_Step1Rotate(_rubiksPiece_Dragged,
                                 _rubiksPiece_Replaced, true,
                                 mod_cubeBackside, mod_cubeFrontside_NotInUse);

                            mod_cubeWholeBothSides.SwitchBottomPieces_Front();
                            mod_cubeWholeBothSides.OrientCube_Step2Restore();

                        }
                        else
                        {
                            // Added 12/7/2020 td
                            MessageBox.Show("The pieces are not adjacent, and Godlike operartions are turned off.  Please reconsider.");

                        }


                    }


                    //
                    // Clean up time!!
                    //
                    _rubiksPiece_Dragged = null;
                    _rubiksPiece_Replaced = null;
                    labelHowToMoveAPiece.Visible = false;
                    this.Cursor = Cursors.Default;
                    //----this.Refresh();
                    panelBack.Refresh();  // Added 3/31/2021 td
                    panelBack.Refresh();  // Added 3/31/2021 td
                    //panelSideLeft.Refresh();     // Added 3/31/2021 td
                    //panelSideRight.Refresh();    // Added 3/31/2021 td

                    // Added 12/4/2020 td
                    //labelUVW_VWX_WXY_XYZ.Text = mod_cubeBackside.BOY_etc_Clockwise();
                    //Added 12/6/2020 td
                    _bClickedBackside = false;
                    _bClickedFrontside_NotInUse = false;

                    //Added 12/1/2020 thomas
                    bool bPriorValue = false;
                    if (mod_cubeBackside.PiecesAreCorrectlyOrdered(out bPriorValue))
                    {
                        // Added 12/01/2020 thomas downes
                        if (bPriorValue == false) //Let's not keep hitting the user over the head with this message. 
                        {
                            MessageBox.Show("All the pieces of the backside are correctly placed in relation with each other-- BOY, BYR, GRY, GOY.",
                                "Pieces in correct order",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    if (CheckForGodlikeBehavior_MovePiece())
                    {
                        _rubiksPiece_Dragged = piece_clicked;
                        if (_customCursorPlus == null)
                        {
                            //var ms = new System.IO.MemoryStream(Properties.Resources.transparent2);  // (My.Resources.Cursor1)
                            var ms = new System.IO.MemoryStream(Properties.Resources.plussign_cursor);  // (My.Resources.Cursor1)
                            _customCursorPlus = new Cursor(ms);
                        }

                        //this.Cursor = _customCursorPlus;
                        ((Panel)sender).Cursor = _customCursorPlus;
                        labelHowToMoveAPiece.Visible = true;
                        labelHowToMoveAPiece.ForeColor = Color.Black;  // Added 1/29/2021 td 
                        labelHowToMoveAPiece.Text = labelHowToMoveAPiece.Tag.ToString();  //Added 1/29/2021
                    }
                }

                // Added 12/4/2020 td
                //Moved up, to a condition.//labelUVW_VWX_WXY_XYZ.Text = mod_RotateBackside.BOY_etc_Clockwise();

            }

        }


        private void CheckIfSideFaceWasClicked(int e_X, int e_Y, Panel par_panel)  // (object sender, MouseEventArgs e)
        {
            //---private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
            //
            // Added 11/17/2020 thomas downes
            //
            RubiksPieceCorner piece_clicked = null; // = mod_RotateBackside.WhichPiece_SideFaceClicked(e_X, e_Y);

            //Added 12/05/2020 thomas downes 
            //---if (null == piece_clicked)
            if (null == piece_clicked)
                if (par_panel == panelFront_NotInUse)
                    piece_clicked = mod_cubeFrontside_NotInUse.WhichPiece_SideFaceClicked(e_X, e_Y);

            //Conditioned 12/05/2020 thomas downes 
            if (null == piece_clicked)
                if (par_panel == panelBack)
                    piece_clicked = mod_cubeBackside.WhichPiece_SideFaceClicked(e_X, e_Y);

            //if (piece_clicked != null && _rubiksPiece_Dragged != null)
            if (_rubiksPiece_Dragged != null)
            {
                //
                // The user has double-clicked, but seems to be in the 
                //    middle of a select-then-drop process.  
                //
                // This is confusing behavior by the user. 
                //
                // Let's "punish" the user by reverting to an earlier state of things. 
                //
                // Clean up time!!   Then exit Sub.
                //
                _rubiksPiece_Dragged = null;
                _rubiksPiece_Replaced = null;
                this.Cursor = Cursors.Default;
                labelHowToMoveAPiece.Visible = false;
                _bClickedFrontside_NotInUse = false;  //Added 12/6/2020 thomas downes
                _bClickedBackside = false;  //Added 12/6/2020 thomas downes
                return;
            }

            if (piece_clicked != null)
            {
                //
                // Rotate the piece clockwise.  
                //
                // First, check with the user if he or she wants to 
                //   perform a godlike behavior. 
                //
                if (true) // CheckForGodlikeBehavior_RotateInPlace())
                {
                    //piece_clicked.RotateInPlace_Clockwise120();
                    piece_clicked.RotateInPlace_PivotPiece120degrees();
                    this.Refresh();
                }

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
