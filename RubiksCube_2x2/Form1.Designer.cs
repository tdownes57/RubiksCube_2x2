namespace RubiksCube_2x2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelRotateSimpleClock = new System.Windows.Forms.Label();
            this.buttonRotateClockwise = new System.Windows.Forms.Button();
            this.buttonRotateCounter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountCR = new System.Windows.Forms.Label();
            this.labelCountCRUndo = new System.Windows.Forms.Label();
            this.labelSimpleCCW = new System.Windows.Forms.Label();
            this.labelCountSimpleCW = new System.Windows.Forms.Label();
            this.buttonReplayAllRotation = new System.Windows.Forms.Button();
            this.buttonClearAllRotation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 324);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(919, 36);
            this.progressBar1.TabIndex = 0;
            // 
            // labelRotateSimpleClock
            // 
            this.labelRotateSimpleClock.AutoSize = true;
            this.labelRotateSimpleClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotateSimpleClock.Location = new System.Drawing.Point(556, 382);
            this.labelRotateSimpleClock.Name = "labelRotateSimpleClock";
            this.labelRotateSimpleClock.Size = new System.Drawing.Size(239, 25);
            this.labelRotateSimpleClock.TabIndex = 1;
            this.labelRotateSimpleClock.Text = "Rotate Simple Clock-Style";
            // 
            // buttonRotateClockwise
            // 
            this.buttonRotateClockwise.Location = new System.Drawing.Point(557, 422);
            this.buttonRotateClockwise.Name = "buttonRotateClockwise";
            this.buttonRotateClockwise.Size = new System.Drawing.Size(153, 36);
            this.buttonRotateClockwise.TabIndex = 2;
            this.buttonRotateClockwise.Text = "Clockwise";
            this.buttonRotateClockwise.UseVisualStyleBackColor = true;
            // 
            // buttonRotateCounter
            // 
            this.buttonRotateCounter.Location = new System.Drawing.Point(557, 464);
            this.buttonRotateCounter.Name = "buttonRotateCounter";
            this.buttonRotateCounter.Size = new System.Drawing.Size(234, 36);
            this.buttonRotateCounter.TabIndex = 3;
            this.buttonRotateCounter.Text = "Counter-Clockwise";
            this.buttonRotateCounter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Undo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Complex Rules";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rotate Complex Rules";
            // 
            // labelCountCR
            // 
            this.labelCountCR.AutoSize = true;
            this.labelCountCR.Location = new System.Drawing.Point(204, 432);
            this.labelCountCR.Name = "labelCountCR";
            this.labelCountCR.Size = new System.Drawing.Size(49, 17);
            this.labelCountCR.TabIndex = 7;
            this.labelCountCR.Text = "Count:";
            // 
            // labelCountCRUndo
            // 
            this.labelCountCRUndo.AutoSize = true;
            this.labelCountCRUndo.Location = new System.Drawing.Point(294, 474);
            this.labelCountCRUndo.Name = "labelCountCRUndo";
            this.labelCountCRUndo.Size = new System.Drawing.Size(49, 17);
            this.labelCountCRUndo.TabIndex = 8;
            this.labelCountCRUndo.Text = "Count:";
            // 
            // labelSimpleCCW
            // 
            this.labelSimpleCCW.AutoSize = true;
            this.labelSimpleCCW.Location = new System.Drawing.Point(806, 474);
            this.labelSimpleCCW.Name = "labelSimpleCCW";
            this.labelSimpleCCW.Size = new System.Drawing.Size(49, 17);
            this.labelSimpleCCW.TabIndex = 10;
            this.labelSimpleCCW.Text = "Count:";
            // 
            // labelCountSimpleCW
            // 
            this.labelCountSimpleCW.AutoSize = true;
            this.labelCountSimpleCW.Location = new System.Drawing.Point(716, 432);
            this.labelCountSimpleCW.Name = "labelCountSimpleCW";
            this.labelCountSimpleCW.Size = new System.Drawing.Size(49, 17);
            this.labelCountSimpleCW.TabIndex = 9;
            this.labelCountSimpleCW.Text = "Count:";
            // 
            // buttonReplayAllRotation
            // 
            this.buttonReplayAllRotation.Location = new System.Drawing.Point(198, 523);
            this.buttonReplayAllRotation.Name = "buttonReplayAllRotation";
            this.buttonReplayAllRotation.Size = new System.Drawing.Size(191, 31);
            this.buttonReplayAllRotation.TabIndex = 11;
            this.buttonReplayAllRotation.Text = "Replay All Rotation";
            this.buttonReplayAllRotation.UseVisualStyleBackColor = true;
            // 
            // buttonClearAllRotation
            // 
            this.buttonClearAllRotation.Location = new System.Drawing.Point(416, 523);
            this.buttonClearAllRotation.Name = "buttonClearAllRotation";
            this.buttonClearAllRotation.Size = new System.Drawing.Size(191, 31);
            this.buttonClearAllRotation.TabIndex = 12;
            this.buttonClearAllRotation.Text = "Clear All Rotation";
            this.buttonClearAllRotation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = " We are studying the front half of a 2x2 Rubik\'s Cube:   (The [. .] faces are _si" +
    "de_ faces.)    ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 153);
            this.label3.TabIndex = 14;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(761, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 153);
            this.label4.TabIndex = 16;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(753, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(582, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = " We are studying the front half of a 2x2 Rubik\'s Cube:   (The [. .] faces are _si" +
    "de_ faces.)    ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearAllRotation);
            this.Controls.Add(this.buttonReplayAllRotation);
            this.Controls.Add(this.labelSimpleCCW);
            this.Controls.Add(this.labelCountSimpleCW);
            this.Controls.Add(this.labelCountCRUndo);
            this.Controls.Add(this.labelCountCR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRotateCounter);
            this.Controls.Add(this.buttonRotateClockwise);
            this.Controls.Add(this.labelRotateSimpleClock);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Rubik\'s Cube, Front Half of a 2x2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelRotateSimpleClock;
        private System.Windows.Forms.Button buttonRotateClockwise;
        private System.Windows.Forms.Button buttonRotateCounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCountCR;
        private System.Windows.Forms.Label labelCountCRUndo;
        private System.Windows.Forms.Label labelSimpleCCW;
        private System.Windows.Forms.Label labelCountSimpleCW;
        private System.Windows.Forms.Button buttonReplayAllRotation;
        private System.Windows.Forms.Button buttonClearAllRotation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

