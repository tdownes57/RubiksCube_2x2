
namespace RubiksCube_2x2.GraphBuilding
{
    partial class FormGraphBuilder
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
            this.listBoxAvailableMans = new System.Windows.Forms.ListBox();
            this.listBoxSelectedMans = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // listBoxAvailableMans
            // 
            this.listBoxAvailableMans.FormattingEnabled = true;
            this.listBoxAvailableMans.Location = new System.Drawing.Point(37, 68);
            this.listBoxAvailableMans.Name = "listBoxAvailableMans";
            this.listBoxAvailableMans.Size = new System.Drawing.Size(257, 173);
            this.listBoxAvailableMans.TabIndex = 0;
            // 
            // listBoxSelectedMans
            // 
            this.listBoxSelectedMans.FormattingEnabled = true;
            this.listBoxSelectedMans.Location = new System.Drawing.Point(482, 68);
            this.listBoxSelectedMans.Name = "listBoxSelectedMans";
            this.listBoxSelectedMans.Size = new System.Drawing.Size(257, 173);
            this.listBoxSelectedMans.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ">>>>>>>>>>>>>>>>>>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "<<<<<<<<<<<<<<<<<<<<<";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available Maneuvers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selected Maneuvers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = " Build Solution Graph";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 296);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(684, 25);
            this.progressBar1.TabIndex = 7;
            // 
            // FormGraphBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSelectedMans);
            this.Controls.Add(this.listBoxAvailableMans);
            this.Name = "FormGraphBuilder";
            this.Text = "FormGraphBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableMans;
        private System.Windows.Forms.ListBox listBoxSelectedMans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}