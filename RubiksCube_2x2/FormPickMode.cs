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
    }
}
