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
    public partial class FormRepurcussion : Form
    {
        //Added 1/13/2021 thomas downes
        private RubiksCubeBothSides mod_cubeWholeBothSides;

        public FormRepurcussion()
        {
            InitializeComponent();

            //Added 12/8/2020 thomas downes
            mod_cubeWholeBothSides = new RubiksCubeBothSides();


    }

    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormRepurcussion_Load(object sender, EventArgs e)
        {

        }
    }
}
