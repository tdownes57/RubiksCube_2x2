using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorizontalScroller
{
    public partial class Form1 : Form
    {
        //
         // Added 2/1/2021 td
        //
        private PanelAndLinksList mod_listPanels = new PanelAndLinksList();
        private bool mod_IgnoreButtonEvents = false;

        public Form1()
        {
            InitializeComponent();

            //
            // Added 2/1/2021 td 
            //
            mod_listPanels.AddToList(panel1, linkLabel1cw, linkLabel1ccw);
            mod_listPanels.AddToList(panel2, linkLabel2cw, linkLabel2ccw);
            mod_listPanels.AddToList(panel3, linkLabel3cw, linkLabel3ccw);
            mod_listPanels.AddToList(panel4, linkLabel4cw, linkLabel4ccw);
            //mod_listPanels.AddToList(panel5, linkLabel1cw, linkLabel1ccw);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonLeft_MouseDown(object sender, MouseEventArgs e)
        {
            //
            // Allow the user to press down to create animated scrolling.
            //
            if (mod_IgnoreButtonEvents) return;

        }

        private void buttonRight_MouseDown(object sender, MouseEventArgs e)
        {
            //
            // Allow the user to press down to create animated scrolling.
            //
            if (mod_IgnoreButtonEvents) return;


        }

        private void timerScrollBreak_Tick(object sender, EventArgs e)
        {
            //
            // Added 2/1/2021  
            //
            mod_IgnoreButtonEvents = false; // Reset to default.
            buttonLeft.Enabled = true;
            buttonRight.Enabled = true;

        }
    }
}
