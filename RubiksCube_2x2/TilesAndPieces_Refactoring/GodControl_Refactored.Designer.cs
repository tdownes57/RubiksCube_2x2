
namespace RubiksCube_2x2.TilesAndPieces_Refactoring
{
    partial class GodControl_Refactored
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkboxRotateCW = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCenterY = new System.Windows.Forms.Label();
            this.labelCenterX = new System.Windows.Forms.Label();
            this.labelPanelHeight = new System.Windows.Forms.Label();
            this.labelPanelWidth = new System.Windows.Forms.Label();
            this.labelHowToMoveAPiece = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkboxRotateCW
            // 
            this.checkboxRotateCW.AutoSize = true;
            this.checkboxRotateCW.Location = new System.Drawing.Point(321, 134);
            this.checkboxRotateCW.Name = "checkboxRotateCW";
            this.checkboxRotateCW.Size = new System.Drawing.Size(211, 21);
            this.checkboxRotateCW.TabIndex = 50;
            this.checkboxRotateCW.Text = "Rotate clockwise 90 degrees";
            this.checkboxRotateCW.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(325, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 94);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // labelCenterY
            // 
            this.labelCenterY.AutoSize = true;
            this.labelCenterY.Location = new System.Drawing.Point(322, 106);
            this.labelCenterY.Name = "labelCenterY";
            this.labelCenterY.Size = new System.Drawing.Size(46, 17);
            this.labelCenterY.TabIndex = 49;
            this.labelCenterY.Text = "label4";
            // 
            // labelCenterX
            // 
            this.labelCenterX.AutoSize = true;
            this.labelCenterX.Location = new System.Drawing.Point(322, 80);
            this.labelCenterX.Name = "labelCenterX";
            this.labelCenterX.Size = new System.Drawing.Size(46, 17);
            this.labelCenterX.TabIndex = 48;
            this.labelCenterX.Text = "label3";
            // 
            // labelPanelHeight
            // 
            this.labelPanelHeight.AutoSize = true;
            this.labelPanelHeight.Location = new System.Drawing.Point(321, 54);
            this.labelPanelHeight.Name = "labelPanelHeight";
            this.labelPanelHeight.Size = new System.Drawing.Size(46, 17);
            this.labelPanelHeight.TabIndex = 47;
            this.labelPanelHeight.Text = "label2";
            // 
            // labelPanelWidth
            // 
            this.labelPanelWidth.AutoSize = true;
            this.labelPanelWidth.Location = new System.Drawing.Point(322, 28);
            this.labelPanelWidth.Name = "labelPanelWidth";
            this.labelPanelWidth.Size = new System.Drawing.Size(46, 17);
            this.labelPanelWidth.TabIndex = 46;
            this.labelPanelWidth.Text = "label1";
            // 
            // labelHowToMoveAPiece
            // 
            this.labelHowToMoveAPiece.AutoSize = true;
            this.labelHowToMoveAPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelHowToMoveAPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowToMoveAPiece.Location = new System.Drawing.Point(6, -2);
            this.labelHowToMoveAPiece.Name = "labelHowToMoveAPiece";
            this.labelHowToMoveAPiece.Size = new System.Drawing.Size(592, 25);
            this.labelHowToMoveAPiece.TabIndex = 45;
            this.labelHowToMoveAPiece.Tag = "You have selected a Rubik\'s piece.  Now drop it onto another piece.";
            this.labelHowToMoveAPiece.Text = "You have selected a Rubik\'s piece.  Now drop it onto another piece.";
            this.labelHowToMoveAPiece.Visible = false;
            // 
            // panelBack
            // 
            this.panelBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBack.BackColor = System.Drawing.Color.Gray;
            this.panelBack.Location = new System.Drawing.Point(3, 26);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(312, 259);
            this.panelBack.TabIndex = 44;
            // 
            // GodControl_Refactored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkboxRotateCW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCenterY);
            this.Controls.Add(this.labelCenterX);
            this.Controls.Add(this.labelPanelHeight);
            this.Controls.Add(this.labelPanelWidth);
            this.Controls.Add(this.labelHowToMoveAPiece);
            this.Controls.Add(this.panelBack);
            this.Name = "GodControl_Refactored";
            this.Size = new System.Drawing.Size(630, 301);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxRotateCW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCenterY;
        private System.Windows.Forms.Label labelCenterX;
        private System.Windows.Forms.Label labelPanelHeight;
        private System.Windows.Forms.Label labelPanelWidth;
        private System.Windows.Forms.Label labelHowToMoveAPiece;
        private System.Windows.Forms.Panel panelBack;
    }
}
