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
        private RubiksCubeBothSides mod_cubeBothSides_Before;
        private RubiksCubeBothSides mod_cubeBothSides_After;

        public FormManeuvers(ManeuversList par_listManuevers, int par_indexOfManeuver)
        {
            InitializeComponent();

            //Added 12/8/2020 thomas downes
            //  mod_cubeWholeBothSides = new RubiksCubeBothSides();
            //[[[[[--mod_cubeBothSides_Before = new RubiksCubeBothSides();
            //[[[[[--mod_cubeBothSides_After = new RubiksCubeBothSides();
            mod_cubeBothSides_Before = new RubiksCubeBothSides(EnumColorIsHardcoded.True);
            mod_cubeBothSides_After = new RubiksCubeBothSides(EnumColorIsHardcoded.True);

            // Before the Maneuver & Repurcussions. 
            mod_cubeBothSides_Before.FrontSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_Before.BackSide.SetTemporaryTextMarkers_ClockPositions();

            // After the Manuever & Repurcussions.  
            mod_cubeBothSides_After.FrontSide.SetTemporaryTextMarkers_ClockPositions();
            mod_cubeBothSides_After.BackSide.SetTemporaryTextMarkers_ClockPositions();



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
            

        }

        private void panelFrontAfter_Paint(object sender, PaintEventArgs e)
        {
            //
            // Added 1/13/2021 thomas downes
            //
            mod_cubeBothSides_Before.FrontSide.SetTemporaryTextMarkers_ClockPositions();

            //Added 2/5/2021 thomas downes
            Point pointCenter = new Point(((Panel)sender).Width / 2, ((Panel)sender).Height / 2); 
            mod_cubeBothSides_After.FrontSide.PaintThisSide(e.Graphics, pointCenter);

        }

        private void panelBackAfter_Paint(object sender, PaintEventArgs e)
        {
            //Added 2/5/2021 thomas downes
            Point pointCenter = new Point(((Panel)sender).Width / 2, ((Panel)sender).Height / 2);
            mod_cubeBothSides_After.BackSide.PaintThisSide(e.Graphics, pointCenter);

        }

        private void panelBackBefore_Paint(object sender, PaintEventArgs e)
        {
            //Added 2/5/2021 thomas downes
            Point pointCenter = new Point(((Panel)sender).Width / 2, ((Panel)sender).Height / 2);
            mod_cubeBothSides_Before.BackSide.PaintThisSide(e.Graphics, pointCenter);

        }

        private void panelFrontBefore_Paint(object sender, PaintEventArgs e)
        {
            //Added 2/5/2021 thomas downes
            Point pointCenter = new Point(((Panel)sender).Width / 2, ((Panel)sender).Height / 2);
            mod_cubeBothSides_Before.FrontSide.PaintThisSide(e.Graphics, pointCenter);

        }
    }
}
