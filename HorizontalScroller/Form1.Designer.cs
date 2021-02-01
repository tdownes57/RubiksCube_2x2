
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.timerScrollBreak = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
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
            this.panel4.BackgroundImage = global::HorizontalScroller.Properties.Resources._1959;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.BackgroundImage = global::HorizontalScroller.Properties.Resources._1959;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(549, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 152);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BackgroundImage = global::HorizontalScroller.Properties.Resources._1959;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(303, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 152);
            this.panel2.TabIndex = 1;
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
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(291, 263);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(246, 40);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "<<< Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseDown);
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
            // 
            // timerScrollBreak
            // 
            this.timerScrollBreak.Interval = 2000;
            this.timerScrollBreak.Tick += new System.EventHandler(this.timerScrollBreak_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
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
    }
}

