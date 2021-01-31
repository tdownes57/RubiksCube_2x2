namespace RubiksCube_2x2
{
    partial class FormSolvingTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolvingTool));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelRotateSimpleClock = new System.Windows.Forms.Label();
            this.buttonRotateClockwise = new System.Windows.Forms.Button();
            this.buttonRotateCounter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFrontRotateBottomRight = new System.Windows.Forms.Button();
            this.labelComplexRotate2 = new System.Windows.Forms.Label();
            this.labelCountCRUndo = new System.Windows.Forms.Label();
            this.lblCntBacksideSimpleCCW = new System.Windows.Forms.Label();
            this.lblCntBacksideSimpleCW = new System.Windows.Forms.Label();
            this.buttonReplayAllRotation = new System.Windows.Forms.Button();
            this.buttonClearAllRotation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHowToMoveAPiece = new System.Windows.Forms.Label();
            this.linkRevertToStart = new System.Windows.Forms.LinkLabel();
            this.labelBriefSerialization = new System.Windows.Forms.Label();
            this.labelUniquenessIndex = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCntFrontsideRotateBtmRight = new System.Windows.Forms.Label();
            this.labelUVW_VWX_WXY_XYZ = new System.Windows.Forms.Label();
            this.comboGodlikePowers = new System.Windows.Forms.ComboBox();
            this.labelBOYwSideColorsEq1 = new System.Windows.Forms.Label();
            this.cmdSwitchFrontBottomPieces = new System.Windows.Forms.Button();
            this.buttonGetNoSQL = new System.Windows.Forms.Button();
            this.buttonLoadFromMongo = new System.Windows.Forms.Button();
            this.buttonSaveToMongo = new System.Windows.Forms.Button();
            this.labelBOYwSideColorsEq2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkEditManeuvers = new System.Windows.Forms.LinkLabel();
            this.linkShowSideSideView = new System.Windows.Forms.LinkLabel();
            this.panelFront = new System.Windows.Forms.Panel();
            this.labelCaptionFront = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.labelCaptionBack = new System.Windows.Forms.Label();
            this.panelSideRight = new System.Windows.Forms.Panel();
            this.labelCaptionLeftSide = new System.Windows.Forms.Label();
            this.panelFront.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panelSideRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 428);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1100, 16);
            this.progressBar1.TabIndex = 0;
            // 
            // labelRotateSimpleClock
            // 
            this.labelRotateSimpleClock.AutoSize = true;
            this.labelRotateSimpleClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotateSimpleClock.Location = new System.Drawing.Point(792, 452);
            this.labelRotateSimpleClock.Name = "labelRotateSimpleClock";
            this.labelRotateSimpleClock.Size = new System.Drawing.Size(343, 25);
            this.labelRotateSimpleClock.TabIndex = 1;
            this.labelRotateSimpleClock.Text = "Backside -- Rotate Simple Clock-Style";
            // 
            // buttonRotateClockwise
            // 
            this.buttonRotateClockwise.Location = new System.Drawing.Point(793, 492);
            this.buttonRotateClockwise.Name = "buttonRotateClockwise";
            this.buttonRotateClockwise.Size = new System.Drawing.Size(153, 36);
            this.buttonRotateClockwise.TabIndex = 2;
            this.buttonRotateClockwise.Text = "Clockwise (Back)";
            this.buttonRotateClockwise.UseVisualStyleBackColor = true;
            this.buttonRotateClockwise.Click += new System.EventHandler(this.buttonRotateClockwise_Click);
            // 
            // buttonRotateCounter
            // 
            this.buttonRotateCounter.Location = new System.Drawing.Point(793, 534);
            this.buttonRotateCounter.Name = "buttonRotateCounter";
            this.buttonRotateCounter.Size = new System.Drawing.Size(234, 36);
            this.buttonRotateCounter.TabIndex = 3;
            this.buttonRotateCounter.Text = "Counter-Clockwise (Back)";
            this.buttonRotateCounter.UseVisualStyleBackColor = true;
            this.buttonRotateCounter.Click += new System.EventHandler(this.buttonRotateCounter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Undo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnFrontRotateBottomRight
            // 
            this.btnFrontRotateBottomRight.Location = new System.Drawing.Point(50, 569);
            this.btnFrontRotateBottomRight.Name = "btnFrontRotateBottomRight";
            this.btnFrontRotateBottomRight.Size = new System.Drawing.Size(254, 36);
            this.btnFrontRotateBottomRight.TabIndex = 5;
            this.btnFrontRotateBottomRight.Text = "Rotate Bottom Right Piece (Front)";
            this.btnFrontRotateBottomRight.UseVisualStyleBackColor = true;
            this.btnFrontRotateBottomRight.Click += new System.EventHandler(this.buttonRotateComplex_Click);
            // 
            // labelComplexRotate2
            // 
            this.labelComplexRotate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplexRotate2.Location = new System.Drawing.Point(49, 481);
            this.labelComplexRotate2.Name = "labelComplexRotate2";
            this.labelComplexRotate2.Size = new System.Drawing.Size(707, 80);
            this.labelComplexRotate2.TabIndex = 4;
            this.labelComplexRotate2.Text = resources.GetString("labelComplexRotate2.Text");
            this.labelComplexRotate2.Click += new System.EventHandler(this.labelComplexRotate2_Click);
            // 
            // labelCountCRUndo
            // 
            this.labelCountCRUndo.AutoSize = true;
            this.labelCountCRUndo.Location = new System.Drawing.Point(575, 579);
            this.labelCountCRUndo.Name = "labelCountCRUndo";
            this.labelCountCRUndo.Size = new System.Drawing.Size(49, 17);
            this.labelCountCRUndo.TabIndex = 8;
            this.labelCountCRUndo.Text = "Count:";
            this.labelCountCRUndo.Visible = false;
            // 
            // lblCntBacksideSimpleCCW
            // 
            this.lblCntBacksideSimpleCCW.AutoSize = true;
            this.lblCntBacksideSimpleCCW.Location = new System.Drawing.Point(1042, 544);
            this.lblCntBacksideSimpleCCW.Name = "lblCntBacksideSimpleCCW";
            this.lblCntBacksideSimpleCCW.Size = new System.Drawing.Size(49, 17);
            this.lblCntBacksideSimpleCCW.TabIndex = 10;
            this.lblCntBacksideSimpleCCW.Text = "Count:";
            // 
            // lblCntBacksideSimpleCW
            // 
            this.lblCntBacksideSimpleCW.AutoSize = true;
            this.lblCntBacksideSimpleCW.Location = new System.Drawing.Point(952, 502);
            this.lblCntBacksideSimpleCW.Name = "lblCntBacksideSimpleCW";
            this.lblCntBacksideSimpleCW.Size = new System.Drawing.Size(49, 17);
            this.lblCntBacksideSimpleCW.TabIndex = 9;
            this.lblCntBacksideSimpleCW.Text = "Count:";
            // 
            // buttonReplayAllRotation
            // 
            this.buttonReplayAllRotation.Location = new System.Drawing.Point(1192, 531);
            this.buttonReplayAllRotation.Name = "buttonReplayAllRotation";
            this.buttonReplayAllRotation.Size = new System.Drawing.Size(191, 31);
            this.buttonReplayAllRotation.TabIndex = 11;
            this.buttonReplayAllRotation.Text = "Replay All Rotation";
            this.buttonReplayAllRotation.UseVisualStyleBackColor = true;
            this.buttonReplayAllRotation.Visible = false;
            // 
            // buttonClearAllRotation
            // 
            this.buttonClearAllRotation.Location = new System.Drawing.Point(1192, 565);
            this.buttonClearAllRotation.Name = "buttonClearAllRotation";
            this.buttonClearAllRotation.Size = new System.Drawing.Size(191, 31);
            this.buttonClearAllRotation.TabIndex = 12;
            this.buttonClearAllRotation.Text = "Clear All Rotation";
            this.buttonClearAllRotation.UseVisualStyleBackColor = true;
            this.buttonClearAllRotation.Visible = false;
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
            this.label4.Location = new System.Drawing.Point(1232, 304);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Complex Rules - Player Rotates One Front Piece";
            this.label1.Visible = false;
            // 
            // labelHowToMoveAPiece
            // 
            this.labelHowToMoveAPiece.AutoSize = true;
            this.labelHowToMoveAPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowToMoveAPiece.Location = new System.Drawing.Point(522, 48);
            this.labelHowToMoveAPiece.Name = "labelHowToMoveAPiece";
            this.labelHowToMoveAPiece.Size = new System.Drawing.Size(592, 25);
            this.labelHowToMoveAPiece.TabIndex = 18;
            this.labelHowToMoveAPiece.Tag = "You have selected a Rubik\'s piece.  Now drop it onto another piece.";
            this.labelHowToMoveAPiece.Text = "You have selected a Rubik\'s piece.  Now drop it onto another piece.";
            this.labelHowToMoveAPiece.Visible = false;
            // 
            // linkRevertToStart
            // 
            this.linkRevertToStart.AutoSize = true;
            this.linkRevertToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRevertToStart.Location = new System.Drawing.Point(794, 588);
            this.linkRevertToStart.Name = "linkRevertToStart";
            this.linkRevertToStart.Size = new System.Drawing.Size(220, 26);
            this.linkRevertToStart.TabIndex = 19;
            this.linkRevertToStart.TabStop = true;
            this.linkRevertToStart.Text = "Revert to Initial State.";
            this.linkRevertToStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRevertToStart_LinkClicked);
            // 
            // labelBriefSerialization
            // 
            this.labelBriefSerialization.AutoSize = true;
            this.labelBriefSerialization.Location = new System.Drawing.Point(310, 655);
            this.labelBriefSerialization.Name = "labelBriefSerialization";
            this.labelBriefSerialization.Size = new System.Drawing.Size(733, 17);
            this.labelBriefSerialization.TabIndex = 20;
            this.labelBriefSerialization.Text = "BOY/SW==F1:N_F2:E_F3:F  BYR/SE==F1:S_F2:E_F3:F  GRY/SW==F1:F_F2:W_F3:S  GYO/NW==F" +
    "1:N_F2:F_F3:W";
            // 
            // labelUniquenessIndex
            // 
            this.labelUniquenessIndex.AutoSize = true;
            this.labelUniquenessIndex.Location = new System.Drawing.Point(310, 628);
            this.labelUniquenessIndex.Name = "labelUniquenessIndex";
            this.labelUniquenessIndex.Size = new System.Drawing.Size(140, 17);
            this.labelUniquenessIndex.TabIndex = 21;
            this.labelUniquenessIndex.Text = "Uniqueness Index #1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Clockwise from BOY (Blue Orange Yellow):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCntFrontsideRotateBtmRight
            // 
            this.lblCntFrontsideRotateBtmRight.AutoSize = true;
            this.lblCntFrontsideRotateBtmRight.Location = new System.Drawing.Point(310, 579);
            this.lblCntFrontsideRotateBtmRight.Name = "lblCntFrontsideRotateBtmRight";
            this.lblCntFrontsideRotateBtmRight.Size = new System.Drawing.Size(49, 17);
            this.lblCntFrontsideRotateBtmRight.TabIndex = 7;
            this.lblCntFrontsideRotateBtmRight.Tag = "Count: ";
            this.lblCntFrontsideRotateBtmRight.Text = "Count:";
            // 
            // labelUVW_VWX_WXY_XYZ
            // 
            this.labelUVW_VWX_WXY_XYZ.AutoSize = true;
            this.labelUVW_VWX_WXY_XYZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUVW_VWX_WXY_XYZ.Location = new System.Drawing.Point(523, 392);
            this.labelUVW_VWX_WXY_XYZ.Name = "labelUVW_VWX_WXY_XYZ";
            this.labelUVW_VWX_WXY_XYZ.Size = new System.Drawing.Size(176, 20);
            this.labelUVW_VWX_WXY_XYZ.TabIndex = 23;
            this.labelUVW_VWX_WXY_XYZ.Tag = "BOY, BYR, GRY, GYO";
            this.labelUVW_VWX_WXY_XYZ.Text = "BOY, BYR, GRY, GYO";
            // 
            // comboGodlikePowers
            // 
            this.comboGodlikePowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGodlikePowers.FormattingEnabled = true;
            this.comboGodlikePowers.Items.AddRange(new object[] {
            "Manual Human Ops",
            "Godlike Operations"});
            this.comboGodlikePowers.Location = new System.Drawing.Point(225, 49);
            this.comboGodlikePowers.Name = "comboGodlikePowers";
            this.comboGodlikePowers.Size = new System.Drawing.Size(281, 24);
            this.comboGodlikePowers.TabIndex = 24;
            // 
            // labelBOYwSideColorsEq1
            // 
            this.labelBOYwSideColorsEq1.AutoSize = true;
            this.labelBOYwSideColorsEq1.Location = new System.Drawing.Point(851, 388);
            this.labelBOYwSideColorsEq1.Name = "labelBOYwSideColorsEq1";
            this.labelBOYwSideColorsEq1.Size = new System.Drawing.Size(269, 17);
            this.labelBOYwSideColorsEq1.TabIndex = 25;
            this.labelBOYwSideColorsEq1.Text = "Sides matching: BOY - BYR - GRY - GYO";
            // 
            // cmdSwitchFrontBottomPieces
            // 
            this.cmdSwitchFrontBottomPieces.Location = new System.Drawing.Point(50, 611);
            this.cmdSwitchFrontBottomPieces.Name = "cmdSwitchFrontBottomPieces";
            this.cmdSwitchFrontBottomPieces.Size = new System.Drawing.Size(254, 36);
            this.cmdSwitchFrontBottomPieces.TabIndex = 26;
            this.cmdSwitchFrontBottomPieces.Text = "Switch Bottom 2 Pieces (Front)";
            this.cmdSwitchFrontBottomPieces.UseVisualStyleBackColor = true;
            this.cmdSwitchFrontBottomPieces.Click += new System.EventHandler(this.cmdSwitchFrontBottomPieces_Click);
            // 
            // buttonGetNoSQL
            // 
            this.buttonGetNoSQL.Location = new System.Drawing.Point(22, 220);
            this.buttonGetNoSQL.Name = "buttonGetNoSQL";
            this.buttonGetNoSQL.Size = new System.Drawing.Size(153, 36);
            this.buttonGetNoSQL.TabIndex = 27;
            this.buttonGetNoSQL.Text = "Get NoSQL data";
            this.buttonGetNoSQL.UseVisualStyleBackColor = true;
            this.buttonGetNoSQL.Click += new System.EventHandler(this.buttonGetNoSQL_Click);
            // 
            // buttonLoadFromMongo
            // 
            this.buttonLoadFromMongo.Location = new System.Drawing.Point(21, 361);
            this.buttonLoadFromMongo.Name = "buttonLoadFromMongo";
            this.buttonLoadFromMongo.Size = new System.Drawing.Size(153, 51);
            this.buttonLoadFromMongo.TabIndex = 28;
            this.buttonLoadFromMongo.Text = "Load Cube from Mongo";
            this.buttonLoadFromMongo.UseVisualStyleBackColor = true;
            this.buttonLoadFromMongo.Click += new System.EventHandler(this.buttonLoadFromMongo_Click);
            // 
            // buttonSaveToMongo
            // 
            this.buttonSaveToMongo.Location = new System.Drawing.Point(21, 304);
            this.buttonSaveToMongo.Name = "buttonSaveToMongo";
            this.buttonSaveToMongo.Size = new System.Drawing.Size(153, 51);
            this.buttonSaveToMongo.TabIndex = 29;
            this.buttonSaveToMongo.Text = "Save Cube to Mongo";
            this.buttonSaveToMongo.UseVisualStyleBackColor = true;
            this.buttonSaveToMongo.Click += new System.EventHandler(this.buttonSaveToMongo_Click);
            // 
            // labelBOYwSideColorsEq2
            // 
            this.labelBOYwSideColorsEq2.AutoSize = true;
            this.labelBOYwSideColorsEq2.Location = new System.Drawing.Point(851, 408);
            this.labelBOYwSideColorsEq2.Name = "labelBOYwSideColorsEq2";
            this.labelBOYwSideColorsEq2.Size = new System.Drawing.Size(270, 17);
            this.labelBOYwSideColorsEq2.TabIndex = 30;
            this.labelBOYwSideColorsEq2.Text = "                     or BOY -  GYO - GRY - BYR";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1053, 611);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(295, 26);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bookmark backside positions";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Player Rotates One Front Piece"});
            this.comboBox1.Location = new System.Drawing.Point(50, 447);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(382, 33);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "Player Rotates One Front Piece";
            // 
            // linkEditManeuvers
            // 
            this.linkEditManeuvers.AutoSize = true;
            this.linkEditManeuvers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEditManeuvers.Location = new System.Drawing.Point(438, 446);
            this.linkEditManeuvers.Name = "linkEditManeuvers";
            this.linkEditManeuvers.Size = new System.Drawing.Size(163, 26);
            this.linkEditManeuvers.TabIndex = 33;
            this.linkEditManeuvers.TabStop = true;
            this.linkEditManeuvers.Text = "Edit Maneuvers";
            this.linkEditManeuvers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditManeuvers_LinkClicked);
            // 
            // linkShowSideSideView
            // 
            this.linkShowSideSideView.AutoSize = true;
            this.linkShowSideSideView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowSideSideView.Location = new System.Drawing.Point(589, 7);
            this.linkShowSideSideView.Name = "linkShowSideSideView";
            this.linkShowSideSideView.Size = new System.Drawing.Size(258, 24);
            this.linkShowSideSideView.TabIndex = 34;
            this.linkShowSideSideView.TabStop = true;
            this.linkShowSideSideView.Text = "Give Side-Side View of Cube.";
            this.linkShowSideSideView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowSideSideView_Click);
            // 
            // panelFront
            // 
            this.panelFront.BackColor = System.Drawing.Color.Gray;
            this.panelFront.Controls.Add(this.labelCaptionFront);
            this.panelFront.Location = new System.Drawing.Point(195, 85);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(326, 293);
            this.panelFront.TabIndex = 35;
            this.panelFront.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFront_Paint);
            this.panelFront.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            this.panelFront.MouseEnter += new System.EventHandler(this.Panel_Enter);
            this.panelFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // labelCaptionFront
            // 
            this.labelCaptionFront.AutoSize = true;
            this.labelCaptionFront.BackColor = System.Drawing.Color.Transparent;
            this.labelCaptionFront.ForeColor = System.Drawing.Color.White;
            this.labelCaptionFront.Location = new System.Drawing.Point(9, 8);
            this.labelCaptionFront.Name = "labelCaptionFront";
            this.labelCaptionFront.Size = new System.Drawing.Size(74, 17);
            this.labelCaptionFront.TabIndex = 0;
            this.labelCaptionFront.Text = "Front View";
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Silver;
            this.panelBack.Controls.Add(this.labelCaptionBack);
            this.panelBack.Location = new System.Drawing.Point(868, 85);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(318, 293);
            this.panelBack.TabIndex = 36;
            this.panelBack.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBack_Paint);
            this.panelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            this.panelBack.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.panelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // labelCaptionBack
            // 
            this.labelCaptionBack.AutoSize = true;
            this.labelCaptionBack.Location = new System.Drawing.Point(7, 8);
            this.labelCaptionBack.Name = "labelCaptionBack";
            this.labelCaptionBack.Size = new System.Drawing.Size(72, 17);
            this.labelCaptionBack.TabIndex = 1;
            this.labelCaptionBack.Text = "Back View";
            // 
            // panelSideRight
            // 
            this.panelSideRight.BackColor = System.Drawing.Color.Silver;
            this.panelSideRight.Controls.Add(this.labelCaptionLeftSide);
            this.panelSideRight.Location = new System.Drawing.Point(544, 85);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(318, 293);
            this.panelSideRight.TabIndex = 37;
            // 
            // labelCaptionLeftSide
            // 
            this.labelCaptionLeftSide.AutoSize = true;
            this.labelCaptionLeftSide.Location = new System.Drawing.Point(3, 8);
            this.labelCaptionLeftSide.Name = "labelCaptionLeftSide";
            this.labelCaptionLeftSide.Size = new System.Drawing.Size(107, 17);
            this.labelCaptionLeftSide.TabIndex = 1;
            this.labelCaptionLeftSide.Text = "Right-Side View";
            // 
            // FormSolvingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 691);
            this.Controls.Add(this.panelSideRight);
            this.Controls.Add(this.linkShowSideSideView);
            this.Controls.Add(this.linkEditManeuvers);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelBOYwSideColorsEq2);
            this.Controls.Add(this.buttonSaveToMongo);
            this.Controls.Add(this.buttonLoadFromMongo);
            this.Controls.Add(this.buttonGetNoSQL);
            this.Controls.Add(this.cmdSwitchFrontBottomPieces);
            this.Controls.Add(this.labelBOYwSideColorsEq1);
            this.Controls.Add(this.comboGodlikePowers);
            this.Controls.Add(this.labelUVW_VWX_WXY_XYZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelUniquenessIndex);
            this.Controls.Add(this.labelBriefSerialization);
            this.Controls.Add(this.linkRevertToStart);
            this.Controls.Add(this.labelHowToMoveAPiece);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearAllRotation);
            this.Controls.Add(this.buttonReplayAllRotation);
            this.Controls.Add(this.lblCntBacksideSimpleCCW);
            this.Controls.Add(this.lblCntBacksideSimpleCW);
            this.Controls.Add(this.labelCountCRUndo);
            this.Controls.Add(this.lblCntFrontsideRotateBtmRight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFrontRotateBottomRight);
            this.Controls.Add(this.labelComplexRotate2);
            this.Controls.Add(this.buttonRotateCounter);
            this.Controls.Add(this.buttonRotateClockwise);
            this.Controls.Add(this.labelRotateSimpleClock);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panelFront);
            this.Name = "FormSolvingTool";
            this.Text = "Rubik\'s Cube, Front Half of a 2x2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Enter += new System.EventHandler(this.Panel_Enter);
            this.panelFront.ResumeLayout(false);
            this.panelFront.PerformLayout();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelSideRight.ResumeLayout(false);
            this.panelSideRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelRotateSimpleClock;
        private System.Windows.Forms.Button buttonRotateClockwise;
        private System.Windows.Forms.Button buttonRotateCounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFrontRotateBottomRight;
        private System.Windows.Forms.Label labelComplexRotate2;
        private System.Windows.Forms.Label labelCountCRUndo;
        private System.Windows.Forms.Label lblCntBacksideSimpleCCW;
        private System.Windows.Forms.Label lblCntBacksideSimpleCW;
        private System.Windows.Forms.Button buttonReplayAllRotation;
        private System.Windows.Forms.Button buttonClearAllRotation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHowToMoveAPiece;
        private System.Windows.Forms.LinkLabel linkRevertToStart;
        private System.Windows.Forms.Label labelBriefSerialization;
        private System.Windows.Forms.Label labelUniquenessIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCntFrontsideRotateBtmRight;
        private System.Windows.Forms.Label labelUVW_VWX_WXY_XYZ;
        private System.Windows.Forms.ComboBox comboGodlikePowers;
        private System.Windows.Forms.Label labelBOYwSideColorsEq1;
        private System.Windows.Forms.Button cmdSwitchFrontBottomPieces;
        private System.Windows.Forms.Button buttonGetNoSQL;
        private System.Windows.Forms.Button buttonLoadFromMongo;
        private System.Windows.Forms.Button buttonSaveToMongo;
        private System.Windows.Forms.Label labelBOYwSideColorsEq2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkEditManeuvers;
        private System.Windows.Forms.LinkLabel linkShowSideSideView;
        private System.Windows.Forms.Panel panelFront;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label labelCaptionFront;
        private System.Windows.Forms.Label labelCaptionBack;
        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Label labelCaptionLeftSide;
    }
}

