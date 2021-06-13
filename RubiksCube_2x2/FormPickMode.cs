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
    public partial class FormPickMode : Form
    {
        // added 6/13/2021 & 1/16/2021 td
        private Maneuvers.ManeuversList mod_listManeuvers = new Maneuvers.ManeuversList();

        public FormPickMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            // Addded 6/3/2021 Thomas Downes
            //
            var form_toShow = (new FormSolvingTool());
            form_toShow.Show();

        }

        private void buttonDesignManeuvers_Click(object sender, EventArgs e)
        {
            //
            // Addded 6/3/2021 Thomas Downes
            //
            //var form_toShow = (new FormManeuvers());
            //form_toShow.Show();

            // Added 1/21/2021  
            int intNumManeuvers = mod_listManeuvers.MyList.Count();
            if (0 == intNumManeuvers) mod_listManeuvers.Load_HardcodedItems();

            int intIndexOfManeuver = 0;  // (int)(this.comboBox1.SelectedIndex);
            var objFormToShow = new FormManeuvers(mod_listManeuvers, intIndexOfManeuver);
            objFormToShow.Show();


        }
    }
}
