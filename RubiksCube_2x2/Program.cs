using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubiksCube_2x2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSolvingTool());
            // Oct. 19 //Application.Run(new FormPickMode());

            const bool c_bTestingControls = true; 
            if (c_bTestingControls) Application.Run(new FormTestingUserControl());
            else Application.Run(new FormPickMode());
        }
    }
}
