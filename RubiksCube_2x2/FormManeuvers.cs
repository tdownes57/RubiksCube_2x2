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
    public partial class FormManeuvers : Form
    {
        //Added 1/13/2021 thomas downes
        //--private RubiksCubeBothSides mod_cubeWholeBothSides;
        private RubiksCubeBothSides mod_cubeBothSides_Before;
        private RubiksCubeBothSides mod_cubeBothSides_After;

        public FormManeuvers(ManueversList par_listManuevers, int par_indexOfManeuver)
        {
            InitializeComponent();

            //Added 12/8/2020 thomas downes
            //mod_cubeWholeBothSides = new RubiksCubeBothSides();
            mod_cubeBothSides_Before = new RubiksCubeBothSides();
            mod_cubeBothSides_After = new RubiksCubeBothSides();

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

        }

        private void panelFrontAfter_Paint(object sender, PaintEventArgs e)
        {
            //
            // Added 1/13/2021 thomas downes
            //
            mod_cubeBothSides_Before.FrontSide.SetTemporaryTextMarkers_ClockPositions()

        }

        private void panelBackAfter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBackBefore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFrontBefore_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
