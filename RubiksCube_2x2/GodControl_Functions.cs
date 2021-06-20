using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 6/19/2021 thomas d. 
using System.Windows.Forms;   // Added 6/19/2021 thomas d. 

namespace RubiksCube_2x2
{
    partial class GodControl
    {
        //
        // Added 6/19/2021 thomas downes
        //
        private void Process_MouseClick(object sender, MouseEventArgs e)
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
            RubiksFaceTile tile_clicked = null;  // Added 6/18/2021 td 

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
                                         //piece_clicked = mod_cubeBackside.WhichPieceIsClicked(e.X, e.Y);
                    //piece_clicked = mod_cubeBackside.WhichPieceIsClicked_FaceTile(e.X, e.Y,
                    //    ref tile_clicked);
                    tile_clicked = mod_cubeBackside.WhichFaceTileIsClicked(e.X, e.Y);

                piece_clicked = tile_clicked.ThisCorner;  

                //----if (piece_clicked != null)
                if (tile_clicked != null)
                {
                    bClickedBackside = true;

                    // Added 6/13/2021 thomas downes
                    mod_cubeBackside.Remove_DrawWithEmphasis();
                    piece_clicked.GodControl_DrawWithEmphasis_JustClicked = true;
                    panelBack.Refresh();  // Added 3/31/2021 td

                }
            }

            if (piece_clicked == null)
            {
                //
                // Clean up time!!   Then exit Sub.
                //
                //_rubiksPiece_Dragged = null;
                //_rubiksPiece_Replaced = null;
                _rubiksTile_Dragged = null;
                _rubiksTile_Replaced = null;
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
                //----if (_rubiksPiece_Dragged != null)
                if (_rubiksTile_Dragged != null)
                {
                    //
                    //   Step 2 of 2 -- Replace.
                    //
                    //   We are pretty much done with the drag-and-replace process. 
                    //
                    this.Cursor = Cursors.Default;
                    //_rubiksPiece_Replaced = piece_clicked;
                    _rubiksTile_Replaced = piece_clicked;

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
                        _rubiksPiece_Dragged.GodControl_DrawWithEmphasis_JustMoved = true;
                        piece_clicked.GodControl_DrawWithEmphasis_JustClicked = true;  // Added 6/18/2021 td

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
                    //panelBack.Refresh();  // Added 3/31/2021 td
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

                        // Added 6/13/2021 thomas downes
                        //mod_cubeBackside.Remove_DrawWithEmphasis();
                        //_rubiksPiece_Dragged.DrawWithEmphasis_JustClicked = true;

                    }
                }

                // Added 12/4/2020 td
                //Moved up, to a condition.//labelUVW_VWX_WXY_XYZ.Text = mod_RotateBackside.BOY_etc_Clockwise();

            }

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // GodControl
        //    // 
        //    this.Name = "GodControl";
        //    this.Load += new System.EventHandler(this.GodControl_Load);
        //    this.ResumeLayout(false);

        //}

        //private void GodControl_Load(object sender, EventArgs e)
        //{
        //
        //}
    }
}
