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
            this.components = new System.ComponentModel.Container();
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
            this.labelOriginalBackF = new System.Windows.Forms.Label();
            this.labelOriginalFrontF = new System.Windows.Forms.Label();
            this.labelCaptionFront = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.labelOriginalBackB = new System.Windows.Forms.Label();
            this.labelOriginalFrontB = new System.Windows.Forms.Label();
            this.labelCaptionBack = new System.Windows.Forms.Label();
            this.panelSideRight = new System.Windows.Forms.Panel();
            this.labelOriginalBackR = new System.Windows.Forms.Label();
            this.labelOriginalFrontR = new System.Windows.Forms.Label();
            this.labelCaptionRightSide = new System.Windows.Forms.Label();
            this.panelSideLeft = new System.Windows.Forms.Panel();
            this.labelOriginalBackL = new System.Windows.Forms.Label();
            this.labelOriginalFrontL = new System.Windows.Forms.Label();
            this.labelCaptionLeftSide = new System.Windows.Forms.Label();
            this.labelMajorRotateCubeLeft = new System.Windows.Forms.Label();
            this.labelMajorRotateCubeRight = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkUseAllAbstractObjects = new System.Windows.Forms.CheckBox();
            this.panelFront.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panelSideRight.SuspendLayout();
            this.panelSideLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 348);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(825, 13);
            this.progressBar1.TabIndex = 0;
            // 
            // labelRotateSimpleClock
            // 
            this.labelRotateSimpleClock.AutoSize = true;
            this.labelRotateSimpleClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRotateSimpleClock.Location = new System.Drawing.Point(594, 367);
            this.labelRotateSimpleClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotateSimpleClock.Name = "labelRotateSimpleClock";
            this.labelRotateSimpleClock.Size = new System.Drawing.Size(276, 20);
            this.labelRotateSimpleClock.TabIndex = 1;
            this.labelRotateSimpleClock.Text = "Backside -- Rotate Simple Clock-Style";
            // 
            // buttonRotateClockwise
            // 
            this.buttonRotateClockwise.Location = new System.Drawing.Point(595, 400);
            this.buttonRotateClockwise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateClockwise.Name = "buttonRotateClockwise";
            this.buttonRotateClockwise.Size = new System.Drawing.Size(115, 29);
            this.buttonRotateClockwise.TabIndex = 2;
            this.buttonRotateClockwise.Text = "Clockwise (Back)";
            this.buttonRotateClockwise.UseVisualStyleBackColor = true;
            this.buttonRotateClockwise.Click += new System.EventHandler(this.buttonRotateClockwise_Click);
            // 
            // buttonRotateCounter
            // 
            this.buttonRotateCounter.Location = new System.Drawing.Point(595, 434);
            this.buttonRotateCounter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRotateCounter.Name = "buttonRotateCounter";
            this.buttonRotateCounter.Size = new System.Drawing.Size(176, 29);
            this.buttonRotateCounter.TabIndex = 3;
            this.buttonRotateCounter.Text = "Counter-Clockwise (Back)";
            this.buttonRotateCounter.UseVisualStyleBackColor = true;
            this.buttonRotateCounter.Click += new System.EventHandler(this.buttonRotateCounter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Undo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btnFrontRotateBottomRight
            // 
            this.btnFrontRotateBottomRight.Location = new System.Drawing.Point(38, 462);
            this.btnFrontRotateBottomRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFrontRotateBottomRight.Name = "btnFrontRotateBottomRight";
            this.btnFrontRotateBottomRight.Size = new System.Drawing.Size(190, 29);
            this.btnFrontRotateBottomRight.TabIndex = 5;
            this.btnFrontRotateBottomRight.Text = "Rotate Bottom Right Piece (Front)";
            this.btnFrontRotateBottomRight.UseVisualStyleBackColor = true;
            this.btnFrontRotateBottomRight.Click += new System.EventHandler(this.buttonRotateComplex_Click);
            // 
            // labelComplexRotate2
            // 
            this.labelComplexRotate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplexRotate2.Location = new System.Drawing.Point(37, 391);
            this.labelComplexRotate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComplexRotate2.Name = "labelComplexRotate2";
            this.labelComplexRotate2.Size = new System.Drawing.Size(530, 65);
            this.labelComplexRotate2.TabIndex = 4;
            this.labelComplexRotate2.Text = resources.GetString("labelComplexRotate2.Text");
            this.labelComplexRotate2.Click += new System.EventHandler(this.labelComplexRotate2_Click);
            // 
            // labelCountCRUndo
            // 
            this.labelCountCRUndo.AutoSize = true;
            this.labelCountCRUndo.Location = new System.Drawing.Point(431, 470);
            this.labelCountCRUndo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountCRUndo.Name = "labelCountCRUndo";
            this.labelCountCRUndo.Size = new System.Drawing.Size(38, 13);
            this.labelCountCRUndo.TabIndex = 8;
            this.labelCountCRUndo.Text = "Count:";
            this.labelCountCRUndo.Visible = false;
            // 
            // lblCntBacksideSimpleCCW
            // 
            this.lblCntBacksideSimpleCCW.AutoSize = true;
            this.lblCntBacksideSimpleCCW.Location = new System.Drawing.Point(782, 442);
            this.lblCntBacksideSimpleCCW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCntBacksideSimpleCCW.Name = "lblCntBacksideSimpleCCW";
            this.lblCntBacksideSimpleCCW.Size = new System.Drawing.Size(38, 13);
            this.lblCntBacksideSimpleCCW.TabIndex = 10;
            this.lblCntBacksideSimpleCCW.Text = "Count:";
            // 
            // lblCntBacksideSimpleCW
            // 
            this.lblCntBacksideSimpleCW.AutoSize = true;
            this.lblCntBacksideSimpleCW.Location = new System.Drawing.Point(714, 408);
            this.lblCntBacksideSimpleCW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCntBacksideSimpleCW.Name = "lblCntBacksideSimpleCW";
            this.lblCntBacksideSimpleCW.Size = new System.Drawing.Size(38, 13);
            this.lblCntBacksideSimpleCW.TabIndex = 9;
            this.lblCntBacksideSimpleCW.Text = "Count:";
            // 
            // buttonReplayAllRotation
            // 
            this.buttonReplayAllRotation.Location = new System.Drawing.Point(894, 431);
            this.buttonReplayAllRotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReplayAllRotation.Name = "buttonReplayAllRotation";
            this.buttonReplayAllRotation.Size = new System.Drawing.Size(143, 25);
            this.buttonReplayAllRotation.TabIndex = 11;
            this.buttonReplayAllRotation.Text = "Replay All Rotation";
            this.buttonReplayAllRotation.UseVisualStyleBackColor = true;
            this.buttonReplayAllRotation.Visible = false;
            // 
            // buttonClearAllRotation
            // 
            this.buttonClearAllRotation.Location = new System.Drawing.Point(894, 459);
            this.buttonClearAllRotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClearAllRotation.Name = "buttonClearAllRotation";
            this.buttonClearAllRotation.Size = new System.Drawing.Size(143, 25);
            this.buttonClearAllRotation.TabIndex = 12;
            this.buttonClearAllRotation.Text = "Clear All Rotation";
            this.buttonClearAllRotation.UseVisualStyleBackColor = true;
            this.buttonClearAllRotation.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = " We are studying the front half of a 2x2 Rubik\'s Cube:   (The [. .] faces are _si" +
    "de_ faces.)    ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 117);
            this.label3.TabIndex = 14;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1055, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 117);
            this.label4.TabIndex = 16;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(565, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = " We are studying the front half of a 2x2 Rubik\'s Cube:   (The [. .] faces are _si" +
    "de_ faces.)    ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 363);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Complex Rules - Player Rotates One Front Piece";
            this.label1.Visible = false;
            // 
            // labelHowToMoveAPiece
            // 
            this.labelHowToMoveAPiece.AutoSize = true;
            this.labelHowToMoveAPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowToMoveAPiece.Location = new System.Drawing.Point(392, 39);
            this.labelHowToMoveAPiece.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHowToMoveAPiece.Name = "labelHowToMoveAPiece";
            this.labelHowToMoveAPiece.Size = new System.Drawing.Size(483, 20);
            this.labelHowToMoveAPiece.TabIndex = 18;
            this.labelHowToMoveAPiece.Tag = "You have selected a Rubik\'s piece.  Now drop it onto another piece.";
            this.labelHowToMoveAPiece.Text = "You have selected a Rubik\'s piece.  Now drop it onto another piece.";
            this.labelHowToMoveAPiece.Visible = false;
            // 
            // linkRevertToStart
            // 
            this.linkRevertToStart.AutoSize = true;
            this.linkRevertToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRevertToStart.Location = new System.Drawing.Point(596, 478);
            this.linkRevertToStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRevertToStart.Name = "linkRevertToStart";
            this.linkRevertToStart.Size = new System.Drawing.Size(181, 22);
            this.linkRevertToStart.TabIndex = 19;
            this.linkRevertToStart.TabStop = true;
            this.linkRevertToStart.Text = "Revert to Initial State.";
            this.linkRevertToStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRevertToStart_LinkClicked);
            // 
            // labelBriefSerialization
            // 
            this.labelBriefSerialization.AutoSize = true;
            this.labelBriefSerialization.Location = new System.Drawing.Point(232, 532);
            this.labelBriefSerialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBriefSerialization.Name = "labelBriefSerialization";
            this.labelBriefSerialization.Size = new System.Drawing.Size(570, 13);
            this.labelBriefSerialization.TabIndex = 20;
            this.labelBriefSerialization.Text = "BOY/SW==F1:N_F2:E_F3:F  BYR/SE==F1:S_F2:E_F3:F  GRY/SW==F1:F_F2:W_F3:S  GYO/NW==F" +
    "1:N_F2:F_F3:W";
            // 
            // labelUniquenessIndex
            // 
            this.labelUniquenessIndex.AutoSize = true;
            this.labelUniquenessIndex.Location = new System.Drawing.Point(232, 510);
            this.labelUniquenessIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUniquenessIndex.Name = "labelUniquenessIndex";
            this.labelUniquenessIndex.Size = new System.Drawing.Size(108, 13);
            this.labelUniquenessIndex.TabIndex = 21;
            this.labelUniquenessIndex.Text = "Uniqueness Index #1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Clockwise from BOY (Blue Orange Yellow):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCntFrontsideRotateBtmRight
            // 
            this.lblCntFrontsideRotateBtmRight.AutoSize = true;
            this.lblCntFrontsideRotateBtmRight.Location = new System.Drawing.Point(232, 470);
            this.lblCntFrontsideRotateBtmRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCntFrontsideRotateBtmRight.Name = "lblCntFrontsideRotateBtmRight";
            this.lblCntFrontsideRotateBtmRight.Size = new System.Drawing.Size(38, 13);
            this.lblCntFrontsideRotateBtmRight.TabIndex = 7;
            this.lblCntFrontsideRotateBtmRight.Tag = "Count: ";
            this.lblCntFrontsideRotateBtmRight.Text = "Count:";
            // 
            // labelUVW_VWX_WXY_XYZ
            // 
            this.labelUVW_VWX_WXY_XYZ.AutoSize = true;
            this.labelUVW_VWX_WXY_XYZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUVW_VWX_WXY_XYZ.Location = new System.Drawing.Point(392, 318);
            this.labelUVW_VWX_WXY_XYZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUVW_VWX_WXY_XYZ.Name = "labelUVW_VWX_WXY_XYZ";
            this.labelUVW_VWX_WXY_XYZ.Size = new System.Drawing.Size(150, 17);
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
            this.comboGodlikePowers.Location = new System.Drawing.Point(169, 40);
            this.comboGodlikePowers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboGodlikePowers.Name = "comboGodlikePowers";
            this.comboGodlikePowers.Size = new System.Drawing.Size(212, 21);
            this.comboGodlikePowers.TabIndex = 24;
            // 
            // labelBOYwSideColorsEq1
            // 
            this.labelBOYwSideColorsEq1.AutoSize = true;
            this.labelBOYwSideColorsEq1.Location = new System.Drawing.Point(638, 315);
            this.labelBOYwSideColorsEq1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBOYwSideColorsEq1.Name = "labelBOYwSideColorsEq1";
            this.labelBOYwSideColorsEq1.Size = new System.Drawing.Size(202, 13);
            this.labelBOYwSideColorsEq1.TabIndex = 25;
            this.labelBOYwSideColorsEq1.Text = "Sides matching: BOY - BYR - GRY - GYO";
            // 
            // cmdSwitchFrontBottomPieces
            // 
            this.cmdSwitchFrontBottomPieces.Location = new System.Drawing.Point(38, 496);
            this.cmdSwitchFrontBottomPieces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSwitchFrontBottomPieces.Name = "cmdSwitchFrontBottomPieces";
            this.cmdSwitchFrontBottomPieces.Size = new System.Drawing.Size(190, 29);
            this.cmdSwitchFrontBottomPieces.TabIndex = 26;
            this.cmdSwitchFrontBottomPieces.Text = "Switch Bottom 2 Pieces (Front)";
            this.cmdSwitchFrontBottomPieces.UseVisualStyleBackColor = true;
            this.cmdSwitchFrontBottomPieces.Click += new System.EventHandler(this.cmdSwitchFrontBottomPieces_Click);
            // 
            // buttonGetNoSQL
            // 
            this.buttonGetNoSQL.Location = new System.Drawing.Point(16, 179);
            this.buttonGetNoSQL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGetNoSQL.Name = "buttonGetNoSQL";
            this.buttonGetNoSQL.Size = new System.Drawing.Size(115, 29);
            this.buttonGetNoSQL.TabIndex = 27;
            this.buttonGetNoSQL.Text = "Get NoSQL data";
            this.buttonGetNoSQL.UseVisualStyleBackColor = true;
            this.buttonGetNoSQL.Click += new System.EventHandler(this.buttonGetNoSQL_Click);
            // 
            // buttonLoadFromMongo
            // 
            this.buttonLoadFromMongo.Location = new System.Drawing.Point(16, 293);
            this.buttonLoadFromMongo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadFromMongo.Name = "buttonLoadFromMongo";
            this.buttonLoadFromMongo.Size = new System.Drawing.Size(115, 41);
            this.buttonLoadFromMongo.TabIndex = 28;
            this.buttonLoadFromMongo.Text = "Load Cube from Mongo";
            this.buttonLoadFromMongo.UseVisualStyleBackColor = true;
            this.buttonLoadFromMongo.Click += new System.EventHandler(this.buttonLoadFromMongo_Click);
            // 
            // buttonSaveToMongo
            // 
            this.buttonSaveToMongo.Location = new System.Drawing.Point(16, 247);
            this.buttonSaveToMongo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveToMongo.Name = "buttonSaveToMongo";
            this.buttonSaveToMongo.Size = new System.Drawing.Size(115, 41);
            this.buttonSaveToMongo.TabIndex = 29;
            this.buttonSaveToMongo.Text = "Save Cube to Mongo";
            this.buttonSaveToMongo.UseVisualStyleBackColor = true;
            this.buttonSaveToMongo.Click += new System.EventHandler(this.buttonSaveToMongo_Click);
            // 
            // labelBOYwSideColorsEq2
            // 
            this.labelBOYwSideColorsEq2.AutoSize = true;
            this.labelBOYwSideColorsEq2.Location = new System.Drawing.Point(638, 332);
            this.labelBOYwSideColorsEq2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBOYwSideColorsEq2.Name = "labelBOYwSideColorsEq2";
            this.labelBOYwSideColorsEq2.Size = new System.Drawing.Size(202, 13);
            this.labelBOYwSideColorsEq2.TabIndex = 30;
            this.labelBOYwSideColorsEq2.Text = "                     or BOY -  GYO - GRY - BYR";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(790, 496);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(242, 22);
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
            this.comboBox1.Location = new System.Drawing.Point(38, 363);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 28);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "Player Rotates One Front Piece";
            // 
            // linkEditManeuvers
            // 
            this.linkEditManeuvers.AutoSize = true;
            this.linkEditManeuvers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEditManeuvers.Location = new System.Drawing.Point(328, 362);
            this.linkEditManeuvers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkEditManeuvers.Name = "linkEditManeuvers";
            this.linkEditManeuvers.Size = new System.Drawing.Size(134, 22);
            this.linkEditManeuvers.TabIndex = 33;
            this.linkEditManeuvers.TabStop = true;
            this.linkEditManeuvers.Text = "Edit Maneuvers";
            this.linkEditManeuvers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditManeuvers_LinkClicked);
            // 
            // linkShowSideSideView
            // 
            this.linkShowSideSideView.AutoSize = true;
            this.linkShowSideSideView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowSideSideView.Location = new System.Drawing.Point(9, 154);
            this.linkShowSideSideView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkShowSideSideView.Name = "linkShowSideSideView";
            this.linkShowSideSideView.Size = new System.Drawing.Size(276, 18);
            this.linkShowSideSideView.TabIndex = 34;
            this.linkShowSideSideView.TabStop = true;
            this.linkShowSideSideView.Text = "_obselete_ Give Side-Side View of Cube.";
            this.linkShowSideSideView.Visible = false;
            this.linkShowSideSideView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowSideSideView_Click);
            // 
            // panelFront
            // 
            this.panelFront.BackColor = System.Drawing.Color.Gray;
            this.panelFront.Controls.Add(this.labelOriginalBackF);
            this.panelFront.Controls.Add(this.labelOriginalFrontF);
            this.panelFront.Controls.Add(this.labelCaptionFront);
            this.panelFront.Location = new System.Drawing.Point(146, 64);
            this.panelFront.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFront.Name = "panelFront";
            this.panelFront.Size = new System.Drawing.Size(244, 238);
            this.panelFront.TabIndex = 35;
            this.panelFront.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFront_Paint);
            this.panelFront.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            this.panelFront.MouseEnter += new System.EventHandler(this.Panel_Enter);
            this.panelFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // labelOriginalBackF
            // 
            this.labelOriginalBackF.AutoSize = true;
            this.labelOriginalBackF.BackColor = System.Drawing.Color.Transparent;
            this.labelOriginalBackF.ForeColor = System.Drawing.Color.White;
            this.labelOriginalBackF.Location = new System.Drawing.Point(171, 224);
            this.labelOriginalBackF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOriginalBackF.Name = "labelOriginalBackF";
            this.labelOriginalBackF.Size = new System.Drawing.Size(70, 13);
            this.labelOriginalBackF.TabIndex = 2;
            this.labelOriginalBackF.Text = "Original Back";
            this.labelOriginalBackF.Visible = false;
            // 
            // labelOriginalFrontF
            // 
            this.labelOriginalFrontF.AutoSize = true;
            this.labelOriginalFrontF.BackColor = System.Drawing.Color.Transparent;
            this.labelOriginalFrontF.ForeColor = System.Drawing.Color.White;
            this.labelOriginalFrontF.Location = new System.Drawing.Point(2, 224);
            this.labelOriginalFrontF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOriginalFrontF.Name = "labelOriginalFrontF";
            this.labelOriginalFrontF.Size = new System.Drawing.Size(69, 13);
            this.labelOriginalFrontF.TabIndex = 1;
            this.labelOriginalFrontF.Text = "Original Front";
            // 
            // labelCaptionFront
            // 
            this.labelCaptionFront.AutoSize = true;
            this.labelCaptionFront.BackColor = System.Drawing.Color.Transparent;
            this.labelCaptionFront.ForeColor = System.Drawing.Color.White;
            this.labelCaptionFront.Location = new System.Drawing.Point(7, 6);
            this.labelCaptionFront.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCaptionFront.Name = "labelCaptionFront";
            this.labelCaptionFront.Size = new System.Drawing.Size(57, 13);
            this.labelCaptionFront.TabIndex = 0;
            this.labelCaptionFront.Text = "Front View";
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Silver;
            this.panelBack.Controls.Add(this.labelOriginalBackB);
            this.panelBack.Controls.Add(this.labelOriginalFrontB);
            this.panelBack.Controls.Add(this.labelCaptionBack);
            this.panelBack.Location = new System.Drawing.Point(651, 64);
            this.panelBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(238, 238);
            this.panelBack.TabIndex = 36;
            this.panelBack.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBack_Paint);
            this.panelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            this.panelBack.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.panelBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // labelOriginalBackB
            // 
            this.labelOriginalBackB.AutoSize = true;
            this.labelOriginalBackB.BackColor = System.Drawing.Color.Transparent;
            this.labelOriginalBackB.ForeColor = System.Drawing.Color.Black;
            this.labelOriginalBackB.Location = new System.Drawing.Point(167, 224);
            this.labelOriginalBackB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOriginalBackB.Name = "labelOriginalBackB";
            this.labelOriginalBackB.Size = new System.Drawing.Size(70, 13);
            this.labelOriginalBackB.TabIndex = 4;
            this.labelOriginalBackB.Text = "Original Back";
            // 
            // labelOriginalFrontB
            // 
            this.labelOriginalFrontB.AutoSize = true;
            this.labelOriginalFrontB.Location = new System.Drawing.Point(5, 224);
            this.labelOriginalFrontB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOriginalFrontB.Name = "labelOriginalFrontB";
            this.labelOriginalFrontB.Size = new System.Drawing.Size(69, 13);
            this.labelOriginalFrontB.TabIndex = 3;
            this.labelOriginalFrontB.Text = "Original Front";
            this.labelOriginalFrontB.Visible = false;
            // 
            // labelCaptionBack
            // 
            this.labelCaptionBack.AutoSize = true;
            this.labelCaptionBack.Location = new System.Drawing.Point(5, 6);
            this.labelCaptionBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCaptionBack.Name = "labelCaptionBack";
            this.labelCaptionBack.Size = new System.Drawing.Size(58, 13);
            this.labelCaptionBack.TabIndex = 1;
            this.labelCaptionBack.Text = "Back View";
            // 
            // panelSideRight
            // 
            this.panelSideRight.BackColor = System.Drawing.Color.Silver;
            this.panelSideRight.Controls.Add(this.labelOriginalBackR);
            this.panelSideRight.Controls.Add(this.labelOriginalFrontR);
            this.panelSideRight.Controls.Add(this.labelCaptionRightSide);
            this.panelSideRight.Location = new System.Drawing.Point(408, 64);
            this.panelSideRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(238, 238);
            this.panelSideRight.TabIndex = 37;
            this.panelSideRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideRight_Paint);
            // 
            // labelOriginalBackR
            // 
            this.labelOriginalBackR.AutoSize = true;
            this.labelOriginalBackR.BackColor = System.Drawing.Color.Transparent;
            this.labelOriginalBackR.ForeColor = System.Drawing.Color.Black;
            this.labelOriginalBackR.Location = new System.Drawing.Point(166, 224);
            this.labelOriginalBackR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOriginalBackR.Name = "labelOriginalBackR";
            this.labelOriginalBackR.Size = new System.Drawing.Size(70, 13);
            this.labelOriginalBackR.TabIndex = 3;
            this.labelOriginalBackR.Text = "Original Back";
            this.labelOriginalBackR.Visible = false;
            // 
            // labelOriginalFrontR
            // 
            this.labelOriginalFrontR.AutoSize = true;
            this.labelOriginalFrontR.Location = new System.Drawing.Point(2, 224);
            this.labelOriginalFrontR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOriginalFrontR.Name = "labelOriginalFrontR";
            this.labelOriginalFrontR.Size = new System.Drawing.Size(69, 13);
            this.labelOriginalFrontR.TabIndex = 2;
            this.labelOriginalFrontR.Text = "Original Front";
            this.labelOriginalFrontR.Visible = false;
            // 
            // labelCaptionRightSide
            // 
            this.labelCaptionRightSide.AutoSize = true;
            this.labelCaptionRightSide.Location = new System.Drawing.Point(2, 6);
            this.labelCaptionRightSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCaptionRightSide.Name = "labelCaptionRightSide";
            this.labelCaptionRightSide.Size = new System.Drawing.Size(82, 13);
            this.labelCaptionRightSide.TabIndex = 1;
            this.labelCaptionRightSide.Text = "Right-Side View";
            // 
            // panelSideLeft
            // 
            this.panelSideLeft.BackColor = System.Drawing.Color.Silver;
            this.panelSideLeft.Controls.Add(this.labelOriginalBackL);
            this.panelSideLeft.Controls.Add(this.labelOriginalFrontL);
            this.panelSideLeft.Controls.Add(this.labelCaptionLeftSide);
            this.panelSideLeft.Location = new System.Drawing.Point(894, 64);
            this.panelSideLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSideLeft.Name = "panelSideLeft";
            this.panelSideLeft.Size = new System.Drawing.Size(238, 238);
            this.panelSideLeft.TabIndex = 38;
            this.panelSideLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideLeft_Paint);
            // 
            // labelOriginalBackL
            // 
            this.labelOriginalBackL.AutoSize = true;
            this.labelOriginalBackL.BackColor = System.Drawing.Color.Transparent;
            this.labelOriginalBackL.ForeColor = System.Drawing.Color.Black;
            this.labelOriginalBackL.Location = new System.Drawing.Point(167, 224);
            this.labelOriginalBackL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOriginalBackL.Name = "labelOriginalBackL";
            this.labelOriginalBackL.Size = new System.Drawing.Size(70, 13);
            this.labelOriginalBackL.TabIndex = 5;
            this.labelOriginalBackL.Text = "Original Back";
            this.labelOriginalBackL.Visible = false;
            // 
            // labelOriginalFrontL
            // 
            this.labelOriginalFrontL.AutoSize = true;
            this.labelOriginalFrontL.Location = new System.Drawing.Point(2, 224);
            this.labelOriginalFrontL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOriginalFrontL.Name = "labelOriginalFrontL";
            this.labelOriginalFrontL.Size = new System.Drawing.Size(69, 13);
            this.labelOriginalFrontL.TabIndex = 3;
            this.labelOriginalFrontL.Text = "Original Front";
            // 
            // labelCaptionLeftSide
            // 
            this.labelCaptionLeftSide.AutoSize = true;
            this.labelCaptionLeftSide.Location = new System.Drawing.Point(2, 6);
            this.labelCaptionLeftSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCaptionLeftSide.Name = "labelCaptionLeftSide";
            this.labelCaptionLeftSide.Size = new System.Drawing.Size(114, 13);
            this.labelCaptionLeftSide.TabIndex = 1;
            this.labelCaptionLeftSide.Text = "Left-of-Front Side View";
            // 
            // labelMajorRotateCubeLeft
            // 
            this.labelMajorRotateCubeLeft.AutoSize = true;
            this.labelMajorRotateCubeLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMajorRotateCubeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMajorRotateCubeLeft.Location = new System.Drawing.Point(62, 62);
            this.labelMajorRotateCubeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMajorRotateCubeLeft.Name = "labelMajorRotateCubeLeft";
            this.labelMajorRotateCubeLeft.Size = new System.Drawing.Size(86, 91);
            this.labelMajorRotateCubeLeft.TabIndex = 39;
            this.labelMajorRotateCubeLeft.Text = "<";
            this.toolTip1.SetToolTip(this.labelMajorRotateCubeLeft, "Pivot Perspective so left-hand side view becomes Front View.");
            this.labelMajorRotateCubeLeft.Click += new System.EventHandler(this.labelMajorRotateCubeLeft_Click);
            // 
            // labelMajorRotateCubeRight
            // 
            this.labelMajorRotateCubeRight.AutoSize = true;
            this.labelMajorRotateCubeRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMajorRotateCubeRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMajorRotateCubeRight.Location = new System.Drawing.Point(1137, 64);
            this.labelMajorRotateCubeRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMajorRotateCubeRight.Name = "labelMajorRotateCubeRight";
            this.labelMajorRotateCubeRight.Size = new System.Drawing.Size(86, 91);
            this.labelMajorRotateCubeRight.TabIndex = 40;
            this.labelMajorRotateCubeRight.Text = ">";
            this.toolTip1.SetToolTip(this.labelMajorRotateCubeRight, "Pivot Perspective so right-hand side view becomes Front View.");
            this.labelMajorRotateCubeRight.Click += new System.EventHandler(this.labelMajorRotateRight_Click);
            // 
            // checkUseAllAbstractObjects
            // 
            this.checkUseAllAbstractObjects.AutoSize = true;
            this.checkUseAllAbstractObjects.Location = new System.Drawing.Point(505, 4);
            this.checkUseAllAbstractObjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkUseAllAbstractObjects.Name = "checkUseAllAbstractObjects";
            this.checkUseAllAbstractObjects.Size = new System.Drawing.Size(246, 17);
            this.checkUseAllAbstractObjects.TabIndex = 41;
            this.checkUseAllAbstractObjects.Text = "Use an abstract object for Front && Back Views.";
            this.checkUseAllAbstractObjects.UseVisualStyleBackColor = true;
            this.checkUseAllAbstractObjects.CheckedChanged += new System.EventHandler(this.checkUseAllAbstractObjects_CheckedChanged);
            this.checkUseAllAbstractObjects.Click += new System.EventHandler(this.checkUseAllAbstractObjects_Click);
            // 
            // FormSolvingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 561);
            this.Controls.Add(this.checkUseAllAbstractObjects);
            this.Controls.Add(this.labelMajorRotateCubeRight);
            this.Controls.Add(this.labelMajorRotateCubeLeft);
            this.Controls.Add(this.panelSideLeft);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panelSideLeft.ResumeLayout(false);
            this.panelSideLeft.PerformLayout();
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
        private System.Windows.Forms.Label labelCaptionRightSide;
        private System.Windows.Forms.Panel panelSideLeft;
        private System.Windows.Forms.Label labelCaptionLeftSide;
        private System.Windows.Forms.Label labelMajorRotateCubeLeft;
        private System.Windows.Forms.Label labelMajorRotateCubeRight;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkUseAllAbstractObjects;
        private System.Windows.Forms.Label labelOriginalFrontF;
        private System.Windows.Forms.Label labelOriginalFrontB;
        private System.Windows.Forms.Label labelOriginalFrontR;
        private System.Windows.Forms.Label labelOriginalFrontL;
        private System.Windows.Forms.Label labelOriginalBackF;
        private System.Windows.Forms.Label labelOriginalBackB;
        private System.Windows.Forms.Label labelOriginalBackR;
        private System.Windows.Forms.Label labelOriginalBackL;
    }
}

