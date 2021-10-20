
namespace RubiksCube_2x2
{
    partial class FormTestingUserControl
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
            this.godControl1 = new RubiksCube_2x2.GodControl();
            this.labelOriginalControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // godControl1
            // 
            this.godControl1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.godControl1.Location = new System.Drawing.Point(149, 76);
            this.godControl1.Name = "godControl1";
            this.godControl1.Size = new System.Drawing.Size(652, 310);
            this.godControl1.TabIndex = 0;
            // 
            // labelOriginalControl
            // 
            this.labelOriginalControl.AutoSize = true;
            this.labelOriginalControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginalControl.Location = new System.Drawing.Point(34, 13);
            this.labelOriginalControl.Name = "labelOriginalControl";
            this.labelOriginalControl.Size = new System.Drawing.Size(413, 46);
            this.labelOriginalControl.TabIndex = 1;
            this.labelOriginalControl.Text = "Original \"God\" Control";
            // 
            // FormTestingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1213, 750);
            this.Controls.Add(this.labelOriginalControl);
            this.Controls.Add(this.godControl1);
            this.Name = "FormTestingUserControl";
            this.Text = "FormTestingUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GodControl godControl1;
        private System.Windows.Forms.Label labelOriginalControl;
    }
}