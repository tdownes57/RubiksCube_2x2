
namespace RubiksCube_2x2
{
    partial class GodControl
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
            this.panelBack = new System.Windows.Forms.Panel();
            this.labelHowToMoveAPiece = new System.Windows.Forms.Label();
            this.labelPanelWidth = new System.Windows.Forms.Label();
            this.labelPanelHeight = new System.Windows.Forms.Label();
            this.labelCenterX = new System.Windows.Forms.Label();
            this.labelCenterY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBack.BackColor = System.Drawing.Color.Gray;
            this.panelBack.Location = new System.Drawing.Point(0, 31);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(312, 260);
            this.panelBack.TabIndex = 36;
            this.panelBack.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnySide_Paint);
            this.panelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelAnySide_MouseClick);
            this.panelBack.MouseEnter += new System.EventHandler(this.panelAnySide_MouseEnter);
            this.panelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAnySide_MouseMove);
            // 
            // labelHowToMoveAPiece
            // 
            this.labelHowToMoveAPiece.AutoSize = true;
            this.labelHowToMoveAPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelHowToMoveAPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowToMoveAPiece.Location = new System.Drawing.Point(3, 3);
            this.labelHowToMoveAPiece.Name = "labelHowToMoveAPiece";
            this.labelHowToMoveAPiece.Size = new System.Drawing.Size(592, 25);
            this.labelHowToMoveAPiece.TabIndex = 37;
            this.labelHowToMoveAPiece.Tag = "You have selected a Rubik\'s piece.  Now drop it onto another piece.";
            this.labelHowToMoveAPiece.Text = "You have selected a Rubik\'s piece.  Now drop it onto another piece.";
            this.labelHowToMoveAPiece.Visible = false;
            // 
            // labelPanelWidth
            // 
            this.labelPanelWidth.AutoSize = true;
            this.labelPanelWidth.Location = new System.Drawing.Point(319, 33);
            this.labelPanelWidth.Name = "labelPanelWidth";
            this.labelPanelWidth.Size = new System.Drawing.Size(46, 17);
            this.labelPanelWidth.TabIndex = 38;
            this.labelPanelWidth.Text = "label1";
            this.labelPanelWidth.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPanelHeight
            // 
            this.labelPanelHeight.AutoSize = true;
            this.labelPanelHeight.Location = new System.Drawing.Point(318, 59);
            this.labelPanelHeight.Name = "labelPanelHeight";
            this.labelPanelHeight.Size = new System.Drawing.Size(46, 17);
            this.labelPanelHeight.TabIndex = 39;
            this.labelPanelHeight.Text = "label2";
            // 
            // labelCenterX
            // 
            this.labelCenterX.AutoSize = true;
            this.labelCenterX.Location = new System.Drawing.Point(319, 85);
            this.labelCenterX.Name = "labelCenterX";
            this.labelCenterX.Size = new System.Drawing.Size(46, 17);
            this.labelCenterX.TabIndex = 40;
            this.labelCenterX.Text = "label3";
            // 
            // labelCenterY
            // 
            this.labelCenterY.AutoSize = true;
            this.labelCenterY.Location = new System.Drawing.Point(319, 111);
            this.labelCenterY.Name = "labelCenterY";
            this.labelCenterY.Size = new System.Drawing.Size(46, 17);
            this.labelCenterY.TabIndex = 41;
            this.labelCenterY.Text = "label4";
            // 
            // GodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCenterY);
            this.Controls.Add(this.labelCenterX);
            this.Controls.Add(this.labelPanelHeight);
            this.Controls.Add(this.labelPanelWidth);
            this.Controls.Add(this.labelHowToMoveAPiece);
            this.Controls.Add(this.panelBack);
            this.Name = "GodControl";
            this.Size = new System.Drawing.Size(602, 306);
            this.Load += new System.EventHandler(this.GodControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GodControl_Paint);
            this.MouseEnter += new System.EventHandler(this.GodControl_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GodControl_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label labelHowToMoveAPiece;
        private System.Windows.Forms.Label labelPanelWidth;
        private System.Windows.Forms.Label labelPanelHeight;
        private System.Windows.Forms.Label labelCenterX;
        private System.Windows.Forms.Label labelCenterY;
    }
}
