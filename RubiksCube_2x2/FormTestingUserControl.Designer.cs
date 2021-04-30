
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
            this.SuspendLayout();
            // 
            // godControl1
            // 
            this.godControl1.Location = new System.Drawing.Point(65, 47);
            this.godControl1.Name = "godControl1";
            this.godControl1.Size = new System.Drawing.Size(1114, 664);
            this.godControl1.TabIndex = 0;
            // 
            // FormTestingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 750);
            this.Controls.Add(this.godControl1);
            this.Name = "FormTestingUserControl";
            this.Text = "FormTestingUserControl";
            this.ResumeLayout(false);

        }

        #endregion

        private GodControl godControl1;
    }
}