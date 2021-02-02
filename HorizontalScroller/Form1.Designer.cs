
namespace HorizontalScroller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.linkLabel4ccw = new System.Windows.Forms.LinkLabel();
            this.linkLabel4cw = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel3ccw = new System.Windows.Forms.LinkLabel();
            this.linkLabel3cw = new System.Windows.Forms.LinkLabel();
            this.linkLabel2ccw = new System.Windows.Forms.LinkLabel();
            this.linkLabel2cw = new System.Windows.Forms.LinkLabel();
            this.linkLabel1ccw = new System.Windows.Forms.LinkLabel();
            this.linkLabel1cw = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.timerScrollBreak = new System.Windows.Forms.Timer(this.components);
            this.groupFrameRate = new System.Windows.Forms.GroupBox();
            this.radioButton2ps = new System.Windows.Forms.RadioButton();
            this.radioButton3ps = new System.Windows.Forms.RadioButton();
            this.radioButton6ps = new System.Windows.Forms.RadioButton();
            this.timer2ps = new System.Windows.Forms.Timer(this.components);
            this.timer3ps = new System.Windows.Forms.Timer(this.components);
            this.timer6ps = new System.Windows.Forms.Timer(this.components);
            this.numericPixelsJump = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton20ps = new System.Windows.Forms.RadioButton();
            this.timer20ps = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton50ps = new System.Windows.Forms.RadioButton();
            this.timer50ps = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.groupFrameRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPixelsJump)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelMain.Controls.Add(this.linkLabel4ccw);
            this.panelMain.Controls.Add(this.linkLabel4cw);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.linkLabel3ccw);
            this.panelMain.Controls.Add(this.linkLabel3cw);
            this.panelMain.Controls.Add(this.linkLabel2ccw);
            this.panelMain.Controls.Add(this.linkLabel2cw);
            this.panelMain.Controls.Add(this.linkLabel1ccw);
            this.panelMain.Controls.Add(this.linkLabel1cw);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Location = new System.Drawing.Point(27, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1031, 214);
            this.panelMain.TabIndex = 0;
            // 
            // linkLabel4ccw
            // 
            this.linkLabel4ccw.AutoSize = true;
            this.linkLabel4ccw.Location = new System.Drawing.Point(900, 176);
            this.linkLabel4ccw.Name = "linkLabel4ccw";
            this.linkLabel4ccw.Size = new System.Drawing.Size(85, 17);
            this.linkLabel4ccw.TabIndex = 11;
            this.linkLabel4ccw.TabStop = true;
            this.linkLabel4ccw.Text = "Rotate CCW";
            // 
            // linkLabel4cw
            // 
            this.linkLabel4cw.AutoSize = true;
            this.linkLabel4cw.Location = new System.Drawing.Point(786, 175);
            this.linkLabel4cw.Name = "linkLabel4cw";
            this.linkLabel4cw.Size = new System.Drawing.Size(76, 17);
            this.linkLabel4cw.TabIndex = 10;
            this.linkLabel4cw.TabStop = true;
            this.linkLabel4cw.Text = "Rotate CW";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(787, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 152);
            this.panel4.TabIndex = 9;
            // 
            // linkLabel3ccw
            // 
            this.linkLabel3ccw.AutoSize = true;
            this.linkLabel3ccw.Location = new System.Drawing.Point(662, 176);
            this.linkLabel3ccw.Name = "linkLabel3ccw";
            this.linkLabel3ccw.Size = new System.Drawing.Size(85, 17);
            this.linkLabel3ccw.TabIndex = 8;
            this.linkLabel3ccw.TabStop = true;
            this.linkLabel3ccw.Text = "Rotate CCW";
            // 
            // linkLabel3cw
            // 
            this.linkLabel3cw.AutoSize = true;
            this.linkLabel3cw.Location = new System.Drawing.Point(548, 175);
            this.linkLabel3cw.Name = "linkLabel3cw";
            this.linkLabel3cw.Size = new System.Drawing.Size(76, 17);
            this.linkLabel3cw.TabIndex = 7;
            this.linkLabel3cw.TabStop = true;
            this.linkLabel3cw.Text = "Rotate CW";
            // 
            // linkLabel2ccw
            // 
            this.linkLabel2ccw.AutoSize = true;
            this.linkLabel2ccw.Location = new System.Drawing.Point(426, 176);
            this.linkLabel2ccw.Name = "linkLabel2ccw";
            this.linkLabel2ccw.Size = new System.Drawing.Size(85, 17);
            this.linkLabel2ccw.TabIndex = 6;
            this.linkLabel2ccw.TabStop = true;
            this.linkLabel2ccw.Text = "Rotate CCW";
            // 
            // linkLabel2cw
            // 
            this.linkLabel2cw.AutoSize = true;
            this.linkLabel2cw.Location = new System.Drawing.Point(312, 175);
            this.linkLabel2cw.Name = "linkLabel2cw";
            this.linkLabel2cw.Size = new System.Drawing.Size(76, 17);
            this.linkLabel2cw.TabIndex = 5;
            this.linkLabel2cw.TabStop = true;
            this.linkLabel2cw.Text = "Rotate CW";
            // 
            // linkLabel1ccw
            // 
            this.linkLabel1ccw.AutoSize = true;
            this.linkLabel1ccw.Location = new System.Drawing.Point(174, 175);
            this.linkLabel1ccw.Name = "linkLabel1ccw";
            this.linkLabel1ccw.Size = new System.Drawing.Size(85, 17);
            this.linkLabel1ccw.TabIndex = 4;
            this.linkLabel1ccw.TabStop = true;
            this.linkLabel1ccw.Text = "Rotate CCW";
            this.linkLabel1ccw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1cw
            // 
            this.linkLabel1cw.AutoSize = true;
            this.linkLabel1cw.Location = new System.Drawing.Point(60, 174);
            this.linkLabel1cw.Name = "linkLabel1cw";
            this.linkLabel1cw.Size = new System.Drawing.Size(76, 17);
            this.linkLabel1cw.TabIndex = 3;
            this.linkLabel1cw.TabStop = true;
            this.linkLabel1cw.Text = "Rotate CW";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(303, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 152);
            this.panel2.TabIndex = 1;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(291, 263);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(246, 40);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "<<< Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseDown);
            this.buttonLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseUp);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(555, 263);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(246, 40);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = "Right >>>>";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseDown);
            this.buttonRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseUp);
            // 
            // timerScrollBreak
            // 
            this.timerScrollBreak.Interval = 1000;
            this.timerScrollBreak.Tick += new System.EventHandler(this.timerScrollBreak_Tick);
            // 
            // groupFrameRate
            // 
            this.groupFrameRate.Controls.Add(this.radioButton50ps);
            this.groupFrameRate.Controls.Add(this.radioButton20ps);
            this.groupFrameRate.Controls.Add(this.label1);
            this.groupFrameRate.Controls.Add(this.numericPixelsJump);
            this.groupFrameRate.Controls.Add(this.radioButton6ps);
            this.groupFrameRate.Controls.Add(this.radioButton3ps);
            this.groupFrameRate.Controls.Add(this.radioButton2ps);
            this.groupFrameRate.Location = new System.Drawing.Point(110, 319);
            this.groupFrameRate.Name = "groupFrameRate";
            this.groupFrameRate.Size = new System.Drawing.Size(764, 86);
            this.groupFrameRate.TabIndex = 3;
            this.groupFrameRate.TabStop = false;
            this.groupFrameRate.Text = "Frame Rate";
            // 
            // radioButton2ps
            // 
            this.radioButton2ps.AutoSize = true;
            this.radioButton2ps.Location = new System.Drawing.Point(32, 28);
            this.radioButton2ps.Name = "radioButton2ps";
            this.radioButton2ps.Size = new System.Drawing.Size(112, 21);
            this.radioButton2ps.TabIndex = 0;
            this.radioButton2ps.TabStop = true;
            this.radioButton2ps.Text = "2 per second";
            this.radioButton2ps.UseVisualStyleBackColor = true;
            // 
            // radioButton3ps
            // 
            this.radioButton3ps.AutoSize = true;
            this.radioButton3ps.Location = new System.Drawing.Point(181, 28);
            this.radioButton3ps.Name = "radioButton3ps";
            this.radioButton3ps.Size = new System.Drawing.Size(112, 21);
            this.radioButton3ps.TabIndex = 1;
            this.radioButton3ps.TabStop = true;
            this.radioButton3ps.Text = "3 per second";
            this.radioButton3ps.UseVisualStyleBackColor = true;
            // 
            // radioButton6ps
            // 
            this.radioButton6ps.AutoSize = true;
            this.radioButton6ps.Location = new System.Drawing.Point(315, 28);
            this.radioButton6ps.Name = "radioButton6ps";
            this.radioButton6ps.Size = new System.Drawing.Size(112, 21);
            this.radioButton6ps.TabIndex = 2;
            this.radioButton6ps.TabStop = true;
            this.radioButton6ps.Text = "6 per second";
            this.radioButton6ps.UseVisualStyleBackColor = true;
            this.radioButton6ps.CheckedChanged += new System.EventHandler(this.radioButton6ps_CheckedChanged);
            // 
            // timer2ps
            // 
            this.timer2ps.Interval = 500;
            this.timer2ps.Tick += new System.EventHandler(this.timer2ps_Tick);
            // 
            // timer3ps
            // 
            this.timer3ps.Interval = 333;
            this.timer3ps.Tick += new System.EventHandler(this.timer3ps_Tick);
            // 
            // timer6ps
            // 
            this.timer6ps.Interval = 165;
            this.timer6ps.Tick += new System.EventHandler(this.timer6ps_Tick);
            // 
            // numericPixelsJump
            // 
            this.numericPixelsJump.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericPixelsJump.Location = new System.Drawing.Point(633, 21);
            this.numericPixelsJump.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericPixelsJump.Name = "numericPixelsJump";
            this.numericPixelsJump.Size = new System.Drawing.Size(93, 22);
            this.numericPixelsJump.TabIndex = 3;
            this.numericPixelsJump.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericPixelsJump.ValueChanged += new System.EventHandler(this.numericPixelsJump_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pixels to Jump / Frame";
            // 
            // radioButton20ps
            // 
            this.radioButton20ps.AutoSize = true;
            this.radioButton20ps.Location = new System.Drawing.Point(79, 55);
            this.radioButton20ps.Name = "radioButton20ps";
            this.radioButton20ps.Size = new System.Drawing.Size(120, 21);
            this.radioButton20ps.TabIndex = 5;
            this.radioButton20ps.TabStop = true;
            this.radioButton20ps.Text = "20 per second";
            this.radioButton20ps.UseVisualStyleBackColor = true;
            // 
            // timer20ps
            // 
            this.timer20ps.Interval = 50;
            this.timer20ps.Tick += new System.EventHandler(this.timer20ps_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.BackgroundImage = global::HorizontalScroller.Properties.Resources.blue_star;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(549, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 152);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(54, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 152);
            this.panel1.TabIndex = 0;
            // 
            // radioButton50ps
            // 
            this.radioButton50ps.AutoSize = true;
            this.radioButton50ps.Location = new System.Drawing.Point(270, 55);
            this.radioButton50ps.Name = "radioButton50ps";
            this.radioButton50ps.Size = new System.Drawing.Size(120, 21);
            this.radioButton50ps.TabIndex = 6;
            this.radioButton50ps.TabStop = true;
            this.radioButton50ps.Text = "50 per second";
            this.radioButton50ps.UseVisualStyleBackColor = true;
            // 
            // timer50ps
            // 
            this.timer50ps.Interval = 20;
            this.timer50ps.Tick += new System.EventHandler(this.timer50ps_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.groupFrameRate);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupFrameRate.ResumeLayout(false);
            this.groupFrameRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPixelsJump)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.LinkLabel linkLabel1ccw;
        private System.Windows.Forms.LinkLabel linkLabel1cw;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel4ccw;
        private System.Windows.Forms.LinkLabel linkLabel4cw;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel3ccw;
        private System.Windows.Forms.LinkLabel linkLabel3cw;
        private System.Windows.Forms.LinkLabel linkLabel2ccw;
        private System.Windows.Forms.LinkLabel linkLabel2cw;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Timer timerScrollBreak;
        private System.Windows.Forms.GroupBox groupFrameRate;
        private System.Windows.Forms.RadioButton radioButton6ps;
        private System.Windows.Forms.RadioButton radioButton3ps;
        private System.Windows.Forms.RadioButton radioButton2ps;
        private System.Windows.Forms.Timer timer2ps;
        private System.Windows.Forms.Timer timer3ps;
        private System.Windows.Forms.Timer timer6ps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPixelsJump;
        private System.Windows.Forms.RadioButton radioButton20ps;
        private System.Windows.Forms.Timer timer20ps;
        private System.Windows.Forms.RadioButton radioButton50ps;
        private System.Windows.Forms.Timer timer50ps;
    }
}

