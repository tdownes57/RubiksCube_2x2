
namespace RubiksCube_2x2
{
    partial class FormPickMode
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
            this.buttonDesignManeuvers = new System.Windows.Forms.Button();
            this.buttonCompleteIterations = new System.Windows.Forms.Button();
            this.buttonVisualManual = new System.Windows.Forms.Button();
            this.labelMainHeading = new System.Windows.Forms.Label();
            this.panelFront = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonDesignManeuvers
            // 
            this.buttonDesignManeuvers.Location = new System.Drawing.Point(481, 155);
            this.buttonDesignManeuvers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDesignManeuvers.Name = "buttonDesignManeuvers";
            this.buttonDesignManeuvers.Size = new System.Drawing.Size(347, 69);
            this.buttonDesignManeuvers.TabIndex = 0;
            this.buttonDesignManeuvers.Text = "Design Maneuvers (Abstract Operations)";
            this.buttonDesignManeuvers.UseVisualStyleBackColor = true;
            this.buttonDesignManeuvers.Click += new System.EventHandler(this.buttonDesignManeuvers_Click);
            // 
            // buttonCompleteIterations
            // 
            this.buttonCompleteIterations.Location = new System.Drawing.Point(481, 242);
            this.buttonCompleteIterations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCompleteIterations.Name = "buttonCompleteIterations";
            this.buttonCompleteIterations.Size = new System.Drawing.Size(347, 69);
            this.buttonCompleteIterations.TabIndex = 1;
            this.buttonCompleteIterations.Text = "Map All Combinations (Graph Building)";
            this.buttonCompleteIterations.UseVisualStyleBackColor = true;
            // 
            // buttonVisualManual
            // 
            this.buttonVisualManual.Location = new System.Drawing.Point(481, 70);
            this.buttonVisualManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVisualManual.Name = "buttonVisualManual";
            this.buttonVisualManual.Size = new System.Drawing.Size(347, 69);
            this.buttonVisualManual.TabIndex = 2;
            this.buttonVisualManual.Text = "Visual-Manual Operations";
            this.buttonVisualManual.UseVisualStyleBackColor = true;
            this.buttonVisualManual.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMainHeading
            // 
            this.labelMainHeading.AutoSize = true;
            this.labelMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainHeading.Location = new System.Drawing.Point(45, 7);
            this.labelMainHeading.Name = "labelMainHeading";
            this.labelMainHeading.Size = new System.Drawing.Size(585, 39);
            this.labelMainHeading.TabIndex = 3;
            this.labelMainHeading.Text = "Solving the Rubiks Cube 2 x 2 Puzzle";
            // 
            // panelFront
            // 
            this.panelFront.BackColor = System.Drawing.Color.Gray;
            this.panelFront.BackgroundImage = global::RubiksCube_2x2.Properties.Resources.RubiksCube2x2_promo2;
            this.panelFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFront.Location = new System.Drawing.Point(12, 70);
            this.panelFront.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(413, 386);
            this.panelFront.TabIndex = 36;
            // 
            // FormPickMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.panelFront);
            this.Controls.Add(this.labelMainHeading);
            this.Controls.Add(this.buttonVisualManual);
            this.Controls.Add(this.buttonCompleteIterations);
            this.Controls.Add(this.buttonDesignManeuvers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPickMode";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDesignManeuvers;
        private System.Windows.Forms.Button buttonCompleteIterations;
        private System.Windows.Forms.Button buttonVisualManual;
        private System.Windows.Forms.Label labelMainHeading;
        private System.Windows.Forms.Panel panelFront;
    }
}