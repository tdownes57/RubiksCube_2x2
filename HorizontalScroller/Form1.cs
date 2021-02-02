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
        private bool mod_bGoingLeft = false;
        private int mod_iPixelsJump = 20;

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
            mod_bGoingLeft = true;
            if (mod_IgnoreButtonEvents) return;
            Animation_Start();
        }

        private void Animation_Start()
        {
            //
            // Added 2/1/2021 td
            //
            if (radioButton2ps.Checked) timer2ps.Enabled = true;
            else if (radioButton3ps.Checked) timer3ps.Enabled = true;
            else if (radioButton6ps.Checked) timer6ps.Enabled = true;
            else if (radioButton20ps.Checked) timer20ps.Enabled = true;
            else if (radioButton50ps.Checked) timer50ps.Enabled = true;
            else throw new NotImplementedException("We don't have a timer for the desired frame rate.");

        }

        private void Animation_Stop() 
        {
            //
            //Encapsulated 2/1/2021 
            //
            timer2ps.Enabled = false;
            timer3ps.Enabled = false;
            timer6ps.Enabled = false;
            timer20ps.Enabled = false;
            timer50ps.Enabled = false;

            mod_bGoingLeft = false;  // Reinitialize.

        }

        private void buttonRight_MouseDown(object sender, MouseEventArgs e)
        {
            //
            // Allow the user to press down to create animated scrolling.
            //
            mod_bGoingLeft = false;
            if (mod_IgnoreButtonEvents) return;

            //
            // Added 2/1/2021 td
            //
            //if (radioButton2ps.Checked) timer2ps.Enabled = true;
            //if (radioButton3ps.Checked) timer3ps.Enabled = true;
            //if (radioButton6ps.Checked) timer6ps.Enabled = true;
            //StartTheAnimation();
            Animation_Start(); 

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

        private void buttonLeft_Click(object sender, EventArgs e)
        {

        }

        //private void timer2ps_Tick(object sender, EventArgs e)
        //{
        //    //Added 2/1/2021
        //    AdvanceFrame();
        //    panelMain.Refresh();

        //}


        //private void timer3ps_Tick(object sender, EventArgs e)
        //{
        //    //Added 2/1/2021
        //    AdvanceFrame();
        //    panelMain.Refresh();

        //}

        //private void timer6ps_Tick(object sender, EventArgs e)
        //{
        //    //Added 2/1/2021
        //    AdvanceFrame();
        //    panelMain.Refresh();

        //}



        private void AdvanceFrame()
        {
            //Added 2/1/2021
            if (mod_bGoingLeft) mod_listPanels.PositionLeft_Subtract(mod_iPixelsJump);
            else mod_listPanels.PositionLeft_Add(mod_iPixelsJump);

        }


        private void numericPixelsJump_ValueChanged(object sender, EventArgs e)
        {
            // Added 2/1/2021 Thomas Downes 
            mod_iPixelsJump = (int)((NumericUpDown)sender).Value;
        }


        private void radioButton6ps_CheckedChanged(object sender, EventArgs e)
        {
            //Added 2/1/2021
            //AdvanceFrame();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Added 2/1/2021 td  
            radioButton6ps.Checked = true;

        }

        private void buttonRight_MouseUp(object sender, MouseEventArgs e)
        {
            //
            // Added 2/1/2021 td
            //
            timer2ps.Enabled = false;
            timer3ps.Enabled = false;
            timer6ps.Enabled = false;
            timer20ps.Enabled = false;
            timer50ps.Enabled = false;

            // Encapsulated. 
            Animation_Stop(); 

            //
            //  User must take a short break. 
            //
            buttonLeft.Enabled = false;  // Disable.
            buttonRight.Enabled = false;   // Disable.
            mod_IgnoreButtonEvents = true;     // Take a short break.
            timerScrollBreak.Enabled = true;    // Take a short break.

        }

        private void buttonLeft_MouseUp(object sender, MouseEventArgs e)
        {
            //
            // Added 2/1/2021 td
            //
            timer2ps.Enabled = false;
            timer3ps.Enabled = false;
            timer6ps.Enabled = false;
            timer20ps.Enabled = false;
            timer50ps.Enabled = false;

            // Encapsulated. 
            Animation_Stop();

            mod_bGoingLeft = false;  // Reinitialize.

            //
            //  User must take a short break. 
            //
            buttonLeft.Enabled = false;  // Disable.
            buttonRight.Enabled = false;  // Disable.
            mod_IgnoreButtonEvents = true;       // Take a short break.
            timerScrollBreak.Enabled = true;   // Take a short break.

        }


        private void timer2ps_Tick(object sender, EventArgs e)
        {
            //Added 2/1/2021
            AdvanceFrame();
            panelMain.Refresh();

        }


        private void timer3ps_Tick(object sender, EventArgs e)
        {
            //Added 2/1/2021
            AdvanceFrame();
            panelMain.Refresh();

        }

        private void timer6ps_Tick(object sender, EventArgs e)
        {
            //Added 2/1/2021
            AdvanceFrame();
            panelMain.Refresh();

        }


        private void timer20ps_Tick(object sender, EventArgs e)
        {
            //Added 2/1/2021
            AdvanceFrame();
            panelMain.Refresh();

        }

        private void timer50ps_Tick(object sender, EventArgs e)
        {
            //Added 2/1/2021
            AdvanceFrame();
            panelMain.Refresh();

        }
    }
}
