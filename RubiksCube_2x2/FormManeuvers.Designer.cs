﻿
namespace RubiksCube_2x2
{
    partial class FormManeuvers
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFrontBefore = new System.Windows.Forms.Panel();
            this.panelBackBefore = new System.Windows.Forms.Panel();
            this.godControlBackAfter = new RubiksCube_2x2.GodControl();
            this.godControlFrontAfter = new RubiksCube_2x2.GodControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dropdownManeuvers = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelBeforeZ = new System.Windows.Forms.Panel();
            this.labelManeuverID = new System.Windows.Forms.Label();
            this.groupboxSerialization = new System.Windows.Forms.GroupBox();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupboxSerialization.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Cornsilk;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.00101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.99899F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFrontBefore, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelBackBefore, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.godControlBackAfter, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.godControlFrontAfter, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(993, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Back Side - After   (May be edited)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Back Side - Before  (__Static__)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Front Side - After  (May be edited)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Front Side - Before (__Static__)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "After  (a.k.a. Repurcussion)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Before (a.k.a. Maneuver)";
            // 
            // panelFrontBefore
            // 
            this.panelFrontBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFrontBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrontBefore.Location = new System.Drawing.Point(3, 65);
            this.panelFrontBefore.Name = "panelFrontBefore";
            this.panelFrontBefore.Size = new System.Drawing.Size(421, 313);
            this.panelFrontBefore.TabIndex = 5;
            this.panelFrontBefore.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFrontBefore_Paint);
            this.panelFrontBefore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelFrontBefore_MouseClick);
            this.panelFrontBefore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFrontBefore_MouseDown);
            // 
            // panelBackBefore
            // 
            this.panelBackBefore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackBefore.Location = new System.Drawing.Point(3, 404);
            this.panelBackBefore.Name = "panelBackBefore";
            this.panelBackBefore.Size = new System.Drawing.Size(421, 314);
            this.panelBackBefore.TabIndex = 7;
            this.panelBackBefore.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackBefore_Paint);
            this.panelBackBefore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBackBefore_MouseDown);
            // 
            // godControlBackAfter
            // 
            this.godControlBackAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.godControlBackAfter.Location = new System.Drawing.Point(430, 404);
            this.godControlBackAfter.Name = "godControlBackAfter";
            this.godControlBackAfter.Size = new System.Drawing.Size(534, 314);
            this.godControlBackAfter.TabIndex = 8;
            // 
            // godControlFrontAfter
            // 
            this.godControlFrontAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.godControlFrontAfter.Location = new System.Drawing.Point(430, 65);
            this.godControlFrontAfter.Name = "godControlFrontAfter";
            this.godControlFrontAfter.Size = new System.Drawing.Size(534, 313);
            this.godControlFrontAfter.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description of Maneuver";
            // 
            // textboxDescription
            // 
            this.textboxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxDescription.Location = new System.Drawing.Point(509, 60);
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(1172, 22);
            this.textboxDescription.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(1087, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(124, 39);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1225, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 39);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "New -- Save && Create New Maneuver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(783, 33);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(298, 22);
            this.textboxName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name of Maneuver";
            // 
            // dropdownManeuvers
            // 
            this.dropdownManeuvers.FormattingEnabled = true;
            this.dropdownManeuvers.Location = new System.Drawing.Point(348, 2);
            this.dropdownManeuvers.Name = "dropdownManeuvers";
            this.dropdownManeuvers.Size = new System.Drawing.Size(308, 24);
            this.dropdownManeuvers.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Select Maneuver";
            // 
            // panelBeforeZ
            // 
            this.panelBeforeZ.BackgroundImage = global::RubiksCube_2x2.Properties.Resources.manuever_1030;
            this.panelBeforeZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBeforeZ.Location = new System.Drawing.Point(1087, 237);
            this.panelBeforeZ.Name = "panelBeforeZ";
            this.panelBeforeZ.Size = new System.Drawing.Size(377, 270);
            this.panelBeforeZ.TabIndex = 10;
            // 
            // labelManeuverID
            // 
            this.labelManeuverID.AutoSize = true;
            this.labelManeuverID.Location = new System.Drawing.Point(345, 38);
            this.labelManeuverID.Name = "labelManeuverID";
            this.labelManeuverID.Size = new System.Drawing.Size(116, 17);
            this.labelManeuverID.TabIndex = 11;
            this.labelManeuverID.Text = "ID # of maneuver";
            // 
            // groupboxSerialization
            // 
            this.groupboxSerialization.Controls.Add(this.buttonDeserialize);
            this.groupboxSerialization.Controls.Add(this.buttonSerialize);
            this.groupboxSerialization.Controls.Add(this.textBox1);
            this.groupboxSerialization.Location = new System.Drawing.Point(1087, 574);
            this.groupboxSerialization.Name = "groupboxSerialization";
            this.groupboxSerialization.Size = new System.Drawing.Size(377, 253);
            this.groupboxSerialization.TabIndex = 12;
            this.groupboxSerialization.TabStop = false;
            this.groupboxSerialization.Text = "Serialization";
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Enabled = false;
            this.buttonDeserialize.Location = new System.Drawing.Point(20, 143);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(298, 39);
            this.buttonDeserialize.TabIndex = 10;
            this.buttonDeserialize.Text = "Implement Text Edit (Deserialize)";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(20, 65);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(298, 39);
            this.buttonSerialize.TabIndex = 9;
            this.buttonSerialize.Text = "Serialize from Graphic";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 22);
            this.textBox1.TabIndex = 8;
            // 
            // FormManeuvers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 842);
            this.Controls.Add(this.groupboxSerialization);
            this.Controls.Add(this.labelManeuverID);
            this.Controls.Add(this.panelBeforeZ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dropdownManeuvers);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormManeuvers";
            this.Text = "After";
            this.Load += new System.EventHandler(this.FormRepurcussion_Load);
            this.Resize += new System.EventHandler(this.FormManeuvers_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupboxSerialization.ResumeLayout(false);
            this.groupboxSerialization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelFrontBefore;
        private System.Windows.Forms.Panel panelBackBefore;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dropdownManeuvers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelBeforeZ;
        private GodControl godControlBackAfter;
        private GodControl godControlFrontAfter;
        private System.Windows.Forms.Label labelManeuverID;
        private System.Windows.Forms.GroupBox groupboxSerialization;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.TextBox textBox1;
    }
}