using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RubiksCube_2x2.Maneuvers;  // Added 1/15/2021 thomass d.  

namespace RubiksCube_2x2
{
    public partial class FormManeuvers : Form
    {
        //Added 1/13/2021 thomas downes
        //--private RubiksCubeBothSides mod_cubeWholeBothSides;
        private RubiksCubeBothSides mod_cubeBothSides_FrontBefore_Static;
        private RubiksCubeBothSides mod_cubeBothSides_BackBefore_Static;

        private RubiksCubeBothSides mod_cubeBothSides_FrontAfter;
        private RubiksCubeBothSides mod_cubeBothSides_BackAfter; // Added 5/2/2021 thomas d.

        public FormManeuvers(ManeuversList par_listManuevers, int par_indexOfManeuver)
        {
            InitializeComponent();

            //Added 12/8/2020 thomas downes
            //  mod_cubeWholeBothSides = new RubiksCubeBothSides();
            //[[[[[--mod_cubeBothSides_Before = new RubiksCubeBothSides();
            //[[[[[--mod_cubeBothSides_After = new RubiksCubeBothSides();
            //---mod_cubeBothSides_Before = new RubiksCubeBothSides(EnumColorIsHardcoded.True);
            //---mod_cubeBothSides_After = new RubiksCubeBothSides(EnumColorIsHardcoded.True);
            mod_cubeBothSides_FrontBefore_Static = new RubiksCubeBothSides(EnumColorIsHardcoded.True);
            mod_cubeBothSides_BackBefore_Static = new RubiksCubeBothSides(EnumColorIsHardcoded.True);
            mod_cubeBothSides_FrontAfter = new RubiksCubeBothSides(EnumColorIsHardcoded.True);
            mod_cubeBothSides_BackAfter = new RubiksCubeBothSides(EnumColorIsHardcoded.True);

            // Before the Maneuver & Repurcussions. 
            mod_cubeBothSides_FrontBefore_Static.FrontSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_FrontBefore_Static.BackSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_BackBefore_Static.FrontSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_BackBefore_Static.BackSide.SetTemporaryTextMarkers_ClockPositions();

            // After the Manuever & Repurcussions.  
            mod_cubeBothSides_FrontAfter.FrontSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_FrontAfter.BackSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_BackAfter.FrontSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_BackAfter.BackSide.SetTemporaryTextMarkers_ClockPositions();

            // 4/30/2021 thomas downes
            //mod_cubeBothSides_After.FrontSide.

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Not in use.
        }

        private void FormRepurcussion_Load(object sender, EventArgs e)
        {
            //
            // Added 2/5/2021  
            //
            //------godControlFront.ThisCubeSide_Front = mod_cubeBothSides_After.FrontSide;
            godControlFrontAfter.ThisCubeSide_Deprecated = mod_cubeBothSides_FrontAfter.BackSide;
            godControlBackAfter.ThisCubeSide_Deprecated = mod_cubeBothSides_BackAfter.BackSide;

            // Added 4/30/2021  
            godControlFrontAfter.ThisCubeEntire = mod_cubeBothSides_FrontAfter;
            godControlBackAfter.ThisCubeEntire = mod_cubeBothSides_BackAfter;

        }

        private void panelFrontAfter_Paint(object sender, PaintEventArgs e)
        {
            //
            // Added 1/13/2021 thomas downes
            //
            mod_cubeBothSides_FrontBefore_Static.FrontSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_FrontAfter.FrontSide.SetTemporaryTextMarkers_ClockPositions();

            //Added 2/5/2021 thomas downes
            Point pointCenter = new Point(((Panel)sender).Width / 2, ((Panel)sender).Height / 2); 
            mod_cubeBothSides_FrontAfter.FrontSide.PaintThisSide(e.Graphics, pointCenter);

        }

        private void panelBackAfter_Paint(object sender, PaintEventArgs e)
        {
            //Added 2/5/2021 thomas downes
            Point pointCenter = new Point(((Panel)sender).Width / 2, ((Panel)sender).Height / 2);
            //mod_cubeBothSides_After.BackSide.PaintThisSide(e.Graphics, pointCenter);
            mod_cubeBothSides_BackAfter.BackSide.PaintThisSide(e.Graphics, pointCenter);

        }

        private void panelBackBefore_Paint(object sender, PaintEventArgs e)
        {
            //Added 2/5/2021 thomas downes
            Point pointCenter = new Point(((Panel)sender).Width / 2, ((Panel)sender).Height / 2);
            mod_cubeBothSides_BackBefore_Static.BackSide.PaintThisSide(e.Graphics, pointCenter);

        }

        private void panelFrontBefore_Paint(object sender, PaintEventArgs e)
        {
            //Added 2/5/2021 thomas downes
            Point pointCenter = new Point(((Panel)sender).Width / 2, ((Panel)sender).Height / 2);
            mod_cubeBothSides_FrontBefore_Static.FrontSide.PaintThisSide(e.Graphics, pointCenter);

        }

        private void panelFrontBefore_MouseClick(object sender, MouseEventArgs e)
        {
            //
            // Added 4/30/2021 thomas downes
            //
            //MessageBox.Show("Please focus on the \"After\" boxes, not the Before boxes.", "",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void panelFrontBefore_MouseDown(object sender, MouseEventArgs e)
        {
            //
            // Added 4/30/2021 thomas downes
            //
            MessageBox.Show("Please focus on the \"After\" boxes, not the Before boxes.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panelBackBefore_MouseDown(object sender, MouseEventArgs e)
        {
            //
            // Added 4/30/2021 thomas downes
            //
            MessageBox.Show("Please focus on the \"After\" boxes, not the Before boxes.", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panelFrontAfter_MouseEnter(object sender, EventArgs e)
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

        private void panelBackAfter_MouseEnter(object sender, EventArgs e)
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

        private void panelFrontAfter_MouseMove(object sender, MouseEventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes 
            //
            //Point currentLocation = new Point(e.X, e.Y);

            //RubikPieceCorner whichPiece = null;

            ////
            //// Back Side 
            ////
            //if (whichPiece == null)
            //{
            //    if (sender == panelBack) // Added 1/29/2021 thomas downes
            //        whichPiece = mod_cubeBackside.WhichPieceHasMouseHover(currentLocation);
            //}

            ////
            //// Front Side
            ////
            ////Added 12/6/2020 thomas downes
            //if (whichPiece == null)
            //{
            //    //Added 12/6/2020 thomas downes
            //    if (sender == panelFront) // Added 1/29/2021 thomas downes
            //        whichPiece = mod_cubeFrontside.WhichPieceHasMouseHover(currentLocation);

            //    //Added 12/6/2020 thomas downes
            //    if (false && whichPiece != null)
            //        MessageBox.Show("You have placed the mouse over the front side of the Rubik's Cube.");
            //}

            ////
            //// Take a look at whether or not we have identified a clicked piece. 
            ////
            //if (whichPiece == null)
            //{
            //    if (_rubiksPiece_Dragged == null)
            //    {
            //        //this.Cursor = Cursors.Default;
            //        ((Panel)sender).Cursor = Cursors.Default;
            //    }
            //}
            //else
            //{
            //    if (_rubiksPiece_Dragged != null)
            //    {
            //        //
            //        // We are dragging a piece. Don't modify the cursor. 
            //        //
            //    }
            //    else
            //    {
            //        //
            //        // Let's apply the Ring cursor, "ring_cursor" (formerly "transparent2").  
            //        //
            //        if (_customCursorRing == null)
            //        {
            //            //var ms = new System.IO.MemoryStream(Properties.Resources.custom_cursor_tcd2);  // (My.Resources.Cursor1)
            //            //var ms = new System.IO.MemoryStream(Properties.Resources.transparent2);  // (My.Resources.Cursor1)
            //            var ms_stream = new System.IO.MemoryStream(Properties.Resources.ring_cursor);  // (My.Resources.Cursor1)
            //            _customCursorRing = new Cursor(ms_stream);
            //        }
            //        //this.Cursor = new Cursor(ms);
            //        //this.Cursor = _customCursorRing;
            //        ((Panel)sender).Cursor = _customCursorRing;

            //    }
            //}

        }

        private void FormManeuvers_Resize(object sender, EventArgs e)
        {
            // Added 5/2/2021 thomas downes
            godControlBackAfter.Refresh();
            godControlFrontAfter.Refresh(); 

        }
    }
}
