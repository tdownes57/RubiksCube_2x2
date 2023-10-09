using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/17/2020 thomas downes
using RubiksCube_2x2.Maneuvers;  // Added 1/16/2021 thomas

namespace RubiksCube_2x2
{
    //abstract class RubiksCubeOneSide
    abstract class RubiksCubeOneSide
    {
        // Renamed to "RubiksCubeOneSide" from "BackOrFront" on 12/89/2020 td
        // 
        // Added 11/12/2020 Thomas Downes 
        //
        public abstract void Simple_Clockwise90();
        public abstract void Simple_Counterwise90();

        // Added 1/11/2021 thomas downes
        public RubiksPieceCorner Piece1;
        public RubiksPieceCorner Piece2;
        public RubiksPieceCorner Piece3;
        public RubiksPieceCorner Piece4;

        // Added 4/2/2021 thomas downes 
        public bool OriginalFront;
        public bool OriginalBack;   // Added 4/3/2021 Thomas Downes

        //Added 11/13/2020 thomas downes
        public abstract bool SideIsASolidColor();
        public abstract void ComplexRevolution();   //Renamed from "ComplexRotation". 


        //Added 11/14/2020 thomas downes
        public abstract void LoadInitialPositions();

        //
        //Added 11/17/2020 thomas downes
        //
        public abstract RubiksPieceCorner WhichPieceIsClicked(Point par_point);
        public abstract RubiksPieceCorner WhichPieceHasMouseHover(Point par_point);

        //
        //Added 12/08/2020 thomas downes
        //
        public abstract bool PiecesAreAdjacent(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2);
        public abstract bool PiecesAre_BottomSWSE(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2);
        public abstract bool PiecesAreAdjacent_Clockwise(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2);
        public abstract bool PiecesBelongToThisSide(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2);

        //Added 12/9/2020 thomas downes 
        public abstract void GodlikeSwitch_Piece(RubiksPieceCorner par_dragged, RubiksPieceCorner par_replaced);

        // Added 5/8/2021 Thomas Downes  
        public abstract void GodlikeSwitch_Tile(RubiksFaceTile_Struct par_dragged, RubiksFaceTile_Struct par_replaced);

        // Aug9 2023 public abstract RubiksPieceCorner GetPiece(FrontClockFace par_enum);
        public abstract RubiksPieceCorner GetPiece(FrontClockFace_Enum par_enum);

        //Added 10/09/2023 thomas downes
        public abstract RubiksFace_4Tiles Get4tiles_FrontFace();


        // Added 5/6/2021 td 
        internal int Output_PanelWidth;
        internal int Output_PanelHeight;
        internal int Output_CenterX;
        internal int Output_CenterY;

        //Added 6/14/2021 td
        //---private Color mod_colorEmphasisFace = Color.LightCyan;
        private Color mod_colorEmphasisFace = Color.White;


        public RubiksPieceCorner GetPieceAtPosition(FrontClockFace_Enum par_enum) // (FrontClockFace)
        {
            //
            // Added 1/16/2020 thomas downes   
            //
            //Aug9 2023  if (this.Piece1.FrontClockFacePosition == par_enum) return this.Piece1;
            //Aug9 2023  else if (this.Piece2.FrontClockFacePosition == par_enum) return this.Piece2;
            //Aug9 2023  else if (this.Piece3.FrontClockFacePosition == par_enum) return this.Piece3;
            //Aug9 2023  else if (this.Piece4.FrontClockFacePosition == par_enum) return this.Piece4;

            if (this.Piece1.FrontClockFacePosition.EnumValue() == par_enum) return this.Piece1;
            else if (this.Piece2.FrontClockFacePosition.EnumValue() == par_enum) return this.Piece2;
            else if (this.Piece3.FrontClockFacePosition.EnumValue() == par_enum) return this.Piece3;
            else if (this.Piece4.FrontClockFacePosition.EnumValue() == par_enum) return this.Piece4;

            else return null;

        }


        public bool PiecesAre_BottomSWSE_Base(RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2)
        {
            //throw new NotImplementedException();
            //bool bPiecesAreRecognized = PiecesBelongToThisSide(par_piece1, par_piece2);
            //if (!bPiecesAreRecognized) throw new ArgumentOutOfRangeException();

            FrontClockFace position1 = par_piece1.FrontClockFacePosition;
            FrontClockFace position2 = par_piece2.FrontClockFacePosition;

            bool bPosition1_SW = (position1.EnumValue() == FrontClockFace_Enum.seven_thirty);
            bool bPosition1_SE = (position1.EnumValue() == FrontClockFace.four_thirty);
            bool bPosition2_SW = (position2.EnumValue() == FrontClockFace_Enum.seven_thirty);
            bool bPosition2_SE = (position2.EnumValue() == FrontClockFace.four_thirty);

            bool b_1SW_2SE = (bPosition1_SW && bPosition2_SE);
            bool b_1SE_2SW = (bPosition1_SE && bPosition2_SW);

            bool bOutputValue = (b_1SE_2SW || b_1SW_2SE);
            return bOutputValue;

        }


        public void GodlikeSwitch_Base(RubiksPieceCorner par_dragged, RubiksPieceCorner par_replaced)
        {
            //
            // Added 11/17/2020 thomas downes
            //
            FrontClockFace clock_dragged = par_dragged.FrontClockFacePosition;
            FrontClockFace clock_replaced = par_replaced.FrontClockFacePosition;
            FrontClockFace tempClock = FrontClockFace.unassigned;
            FrontClockFace targetClock = FrontClockFace.unassigned;

            //
            // Position the dragged piece. 
            //
            targetClock = clock_replaced; // We will place the selected/dragged piece at the Replaced position.
            do
            {
                par_dragged.Revolve_Clockwise90();
                tempClock = par_dragged.FrontClockFacePosition;
            } while (tempClock != targetClock);

            //
            // Position the replaced piece. 
            //
            targetClock = clock_dragged; // We will place the selected/dragged piece at the Replaced position.
            do
            {
                par_replaced.Revolve_Clockwise90();
                tempClock = par_replaced.FrontClockFacePosition;
            } while (tempClock != targetClock);

        }


        public void GodlikeSwitch_Base(RubiksFaceTile_Struct par_dragged, RubiksFaceTile_Struct par_replaced)
        {
            //
            // Added 5/9/2021 thomas downes
            //
            //base.GodlikeSwitch_Base(par_dragged, par_replaced);

            throw new NotImplementedException(".....");



        }



        public void ComplexRules_Perform(ComplexPieceMoves_OneSide par_rules)  //----(ComplexPieceMoves_Five par_rules)
        {
            //
            // Added 12/9/2020 thomas downes 
            //
            //
            //
            // Implementing the movements described above, as follows: 
            //
            RubiksPieceCorner piece_starting_at_130 = GetPiece(FrontClockFace.one_thirty);
            RubiksPieceCorner piece_starting_at_430 = GetPiece(FrontClockFace.four_thirty);
            RubiksPieceCorner piece_starting_at_730 = GetPiece(FrontClockFace_Enum.seven_thirty);
            RubiksPieceCorner piece_starting_at_1030 = GetPiece(FrontClockFace.ten_thirty);

            //First, set the clock position of the piece.   
            //    ----11/18/2020 thomas downes
            //
            const bool c_boolOnlySetClockPosition = true;
            piece_starting_at_130.ReorientPiece_Complex(par_rules.move1_from130.StartingPoint, par_rules.move1_from130.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_430.ReorientPiece_Complex(par_rules.move2_from430.StartingPoint, par_rules.move2_from430.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_730.ReorientPiece_Complex(par_rules.move3_from730.StartingPoint, par_rules.move3_from730.EndingPoint, c_boolOnlySetClockPosition);
            piece_starting_at_1030.ReorientPiece_Complex(par_rules.move4_from1030.StartingPoint, par_rules.move4_from1030.EndingPoint, c_boolOnlySetClockPosition);

            //
            // Use the static class, ComplexRulesEngine.  
            //
            // Move #1 of 5. 
            //
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            ComplexRulesEngine0130.this_piece_startsAt_130 = piece_starting_at_130;
            ComplexRulesEngine0130.this_complex_move = par_rules.move1_from130;
            ComplexRulesEngine0130.FrontFace_130_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #2 of 5. 
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            ComplexRulesEngine0430.this_piece_startsAt_430 = piece_starting_at_430;
            ComplexRulesEngine0430.this_complex_move = par_rules.move2_from430;
            ComplexRulesEngine0430.FrontFace_430_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #3 of 5. 
            //ComplexRulesEngine.ReorientPiece_Complex(move1_from130.StartingPoint, move1_from130.EndingPoint);
            ComplexRulesEngine0730.this_piece_startsAt_730 = piece_starting_at_730;
            ComplexRulesEngine0730.this_complex_move = par_rules.move3_from730;
            ComplexRulesEngine0730.FrontFace_730_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #4 of 5. 
            //ComplexRulesEngine.FrontFace_1030_ReorientTo(move1_from130.StartingPoint, move1_from130.EndingPoint);
            ComplexRulesEngine1030.this_piece_startsAt_1030 = piece_starting_at_1030;
            ComplexRulesEngine1030.this_complex_move = par_rules.move4_from1030;
            ComplexRulesEngine1030.FrontFace_1030_ReorientTo(); // (move1_from130.StartingPoint, move1_from130.EndingPoint);

            // Move #5 of 5. ----11/18/2020 thomas d. 
            if (par_rules.move5_Clockwise90)  //.ClockwiseRevolution90)
            {
                // Added 11/18/2020 td 
                piece_starting_at_130.Revolve_Clockwise90();
                piece_starting_at_430.Revolve_Clockwise90();
                piece_starting_at_730.Revolve_Clockwise90();
                piece_starting_at_1030.Revolve_Clockwise90();

            }

        }


        public void PaintThisSide_Base(System.Drawing.Graphics par_graphics, Point par_pointCenter,
                          RubiksPieceCorner par_piece1, RubiksPieceCorner par_piece2,
                          RubiksPieceCorner par_piece3, RubiksPieceCorner par_piece4,
                          EnumPrimaryView par_enumView)
        {
            //
            // Added 1/11//2020 thomas downes
            //
            // Step 1 of 2.  Paint the front faces.  (vs. sides) 
            //
            //   (Code copied from FormSolvingTool.Form1_Paint_BACK(PaintEventArgs e), 1/11/2021.)
            //
            if (par_enumView == EnumPrimaryView.Front || par_enumView == EnumPrimaryView.Back)
            {
                // Step 1 of 2.  Paint the front faces.  (vs. sides) 
                //
                //   (Code copied from FormSolvingTool.Form1_Paint_BACK(PaintEventArgs e), 1/11/2021.)
                //
                par_piece1.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                par_piece2.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                par_piece3.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
                par_piece4.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);

                //
                // Step 2 of 2.  Paint the side faces.  
                //
                //   (Code copied from FormSolvingTool.Form1_Paint_BACK(PaintEventArgs e), 1/11/2021.)
                //
                par_piece1.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                par_piece2.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                par_piece3.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
                par_piece4.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);

            }
            else if (par_enumView == EnumPrimaryView.Right)
            {
                //
                // Added 1/31/2021 thomas downes
                //
                Exception a_exception;

                par_piece1.PaintByGraphics(par_graphics, par_pointCenter, par_enumView, out a_exception);
                par_piece2.PaintByGraphics(par_graphics, par_pointCenter, par_enumView, out a_exception);
                par_piece3.PaintByGraphics(par_graphics, par_pointCenter, par_enumView, out a_exception);
                par_piece4.PaintByGraphics(par_graphics, par_pointCenter, par_enumView, out a_exception);


            }
            else if (par_enumView == EnumPrimaryView.Unassigned)
            {
                //Added 1/31/2021 thomas downes
                throw new NotImplementedException();

            }


        }


        public void PaintThisSide_Base(System.Drawing.Graphics par_graphics, Point par_pointCenter)
        {
            //
            // Added 1/11//2020 thomas downes
            //
            // Step 1 of 2.  Paint the front faces.  (vs. sides) 
            //
            //   (Code copied from FormSolvingTool.Form1_Paint_BACK(PaintEventArgs e), 1/11/2021.)
            //
            Piece1.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
            Piece2.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
            Piece3.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);
            Piece4.PaintByGraphics_FrontFace(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustFront);

            //
            // Step 2 of 2.  Paint the side faces.  
            //
            //   (Code copied from FormSolvingTool.Form1_Paint_BACK(PaintEventArgs e), 1/11/2021.)
            //
            Piece1.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
            Piece2.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
            Piece3.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);
            Piece4.PaintByGraphics_SideFaces(par_graphics, par_pointCenter); //, EnumWhatToPaint.JustSides);

        }


        public void PaintThisSide_Base(System.Drawing.Graphics par_graphics, Point par_pointCenter, EnumPrimaryView par_view)
        {
            // 
            // Added 2/1/2021 thomas downes  
            //
            Exception an_error;

            //Piece1.PaintByGraphics(par_graphics, par_pointCenter, par_view, out an_error);
            //Piece2.PaintByGraphics(par_graphics, par_pointCenter, par_view, out an_error);
            //Piece3.PaintByGraphics(par_graphics, par_pointCenter, par_view, out an_error);
            //Piece4.PaintByGraphics(par_graphics, par_pointCenter, par_view, out an_error);

            Piece1.PaintByGraphics_IfVisible(par_graphics, par_pointCenter, par_view, out an_error);
            Piece2.PaintByGraphics_IfVisible(par_graphics, par_pointCenter, par_view, out an_error);
            Piece3.PaintByGraphics_IfVisible(par_graphics, par_pointCenter, par_view, out an_error);
            Piece4.PaintByGraphics_IfVisible(par_graphics, par_pointCenter, par_view, out an_error);

        }

        public void SetTemporaryTextMarkers_ClockPositions()
        {
            //
            // Added 1/11/2021 thomas downes
            //
            // Place "1:30", "4:30", "7:30", and "10:30" on the front faces, 
            //   depending on position.  
            //
            this.Piece1.SetTemporaryTextMarker_ClockPosition();
            this.Piece2.SetTemporaryTextMarker_ClockPosition();
            this.Piece3.SetTemporaryTextMarker_ClockPosition();
            this.Piece4.SetTemporaryTextMarker_ClockPosition();

        }


        public void ClearTemporaryTextMarkers_ClockPositions()
        {
            //
            // Added 2/05/2021 thomas downes
            // 
            // Place "1:30", "4:30", "7:30", and "10:30" on the front faces, 
            //   depending on position.  
            //
            this.Piece1.ClearTemporaryTextMarker_ClockPosition();
            this.Piece2.ClearTemporaryTextMarker_ClockPosition();
            this.Piece3.ClearTemporaryTextMarker_ClockPosition();
            this.Piece4.ClearTemporaryTextMarker_ClockPosition();

        }


        public void Repaint(System.Windows.Forms.Panel par_panel, bool par_bIsASideView,
                            EnumPrimaryView par_enumView_Optional = EnumPrimaryView.Unassigned)
        {
            //
            // Added 1/28/2021 thomas downes
            //
            //var graphicsFront = par_panelFront.CreateGraphics();
            //var graphicsBack = par_panelBackside.CreateGraphics();

            // 1 of 2. Paint the front side. 
            //    Point pointCenter_Front = new Point(par_panelFront.Width / 2, par_panelFront.Height / 2);
            //    mod_frontside.PaintThisSide_Base(graphicsFront, pointCenter_Front);
            //

            // 2 of 2. Paint the back side. 
            //    Point pointCenter_Back = new Point(par_panelBackside.Width / 2, par_panelBackside.Height / 2);
            //    mod_backside.PaintThisSide_Base(graphicsBack, pointCenter_Back);
            //

            var a_graphics = par_panel.CreateGraphics();

            int intCenterX = par_panel.Width / 2;
            int intCenterY = par_panel.Height / 2;

            // Let's try to fix a baffling bug which is pushing our graphic
            //   down ( w/ greater Y than expected) and causing the graphic 
            //   to be off-center (too far in the six 0'clock direction).
            //   ----5/6/2021 td
            if (intCenterY > intCenterX) intCenterY = intCenterX;

            //Point pointCenter = new Point(par_panel.Width / 2, par_panel.Height / 2);
            Point pointCenter = new Point(intCenterX, intCenterY);

            //----Jan. 31, 2021--this.PaintThisSide_Base(a_graphics, pointCenter);

            //Bifurcated 2/1/2021 thomas 
            if (par_bIsASideView) this.PaintThisSide_Base(a_graphics, pointCenter, par_enumView_Optional);
            else this.PaintThisSide_Base(a_graphics, pointCenter);

            // Added 5/6/2021  thomas downes
            this.Output_PanelHeight = par_panel.Height;
            this.Output_PanelWidth = par_panel.Width;
            this.Output_CenterX = pointCenter.X;
            this.Output_CenterY = pointCenter.Y;

        }


        public bool IsSolved()
        {
            //
            // Added 6/10 and 6/3/2021 thomas downes  
            //
            //Added 12/1/2020 thomas
            //bool bPriorValue = false; //Added 12/1/2020 thomas
            //bool bCorrectlyOrdered = (this.PiecesAreCorrectlyOrdered(out bPriorValue));

            //
            // Added 6/10/2021 Thomas Downes
            //
            Color color_Piece1 = this.Piece1.GetColorOfFrontFace();
            Color color_Piece2 = this.Piece2.GetColorOfFrontFace();
            Color color_Piece3 = this.Piece3.GetColorOfFrontFace();
            Color color_Piece4 = this.Piece4.GetColorOfFrontFace();

            bool boolColorsMatch_FrontFace =
                (color_Piece1 == color_Piece2) &&
                (color_Piece2 == color_Piece3) &&
                (color_Piece3 == color_Piece4);

            if (boolColorsMatch_FrontFace)
            {

                RubiksPieceCorner piece_NE_one_thirty = this.GetPieceAtPosition(FrontClockFace.one_thirty);
                RubiksPieceCorner piece_SE_four_thirty = this.GetPieceAtPosition(FrontClockFace.four_thirty);
                RubiksPieceCorner piece_SW_seven_thirty = this.GetPieceAtPosition(FrontClockFace_Enum.seven_thirty);
                RubiksPieceCorner piece_NW_ten_thirty = this.GetPieceAtPosition(FrontClockFace.ten_thirty);

                bool boolColorsMatch_North = false;
                bool boolColorsMatch__East = false;
                bool boolColorsMatch_South = false;
                bool boolColorsMatch__West = false;

                // North side NW = North-West;  NE = North-East      
                Color colorNorth_NW = piece_NW_ten_thirty.GetColorOfSideFace_CounterClockwise();
                Color colorNorth_NE = piece_NE_one_thirty.GetColorOfSideFace_ClockwiseFromFront();
                boolColorsMatch_North = (colorNorth_NE == colorNorth_NW);
                if (!boolColorsMatch_North) return false;

                // East side EN = East-North; ES = East-South. 
                Color colorEast__EN = piece_NE_one_thirty.GetColorOfSideFace_CounterClockwise();
                Color colorEast__ES = piece_SE_four_thirty.GetColorOfSideFace_ClockwiseFromFront();
                boolColorsMatch__East = (colorEast__EN == colorEast__ES);
                if (!boolColorsMatch__East) return false;

                // South side  
                Color colorSouth_SE = piece_SE_four_thirty.GetColorOfSideFace_CounterClockwise();
                Color colorSouth_SW = piece_SW_seven_thirty.GetColorOfSideFace_ClockwiseFromFront();
                boolColorsMatch_South = (colorSouth_SE == colorSouth_SW);
                if (!boolColorsMatch_South) return false;

                // West side WS = West-South;  WN = West-North  
                Color colorWest__WS = piece_SW_seven_thirty.GetColorOfSideFace_CounterClockwise();
                Color colorWest__WN = piece_NW_ten_thirty.GetColorOfSideFace_ClockwiseFromFront();
                boolColorsMatch__West = (colorWest__WN == colorWest__WS);
                if (!boolColorsMatch__West) return false;

                //
                // Summarize.
                //
                bool boolColorsMatch_AllSides =
                     (boolColorsMatch_North &&
                      boolColorsMatch_South &&
                      boolColorsMatch__East &&
                      boolColorsMatch__West);

                return boolColorsMatch_AllSides;

            }
            else return false;

        }


        public Color Color_DrawWithEmphasis_Next()
        {
            //
            // Added 6/13/2021 thomas downes 
            //
            if (mod_colorEmphasisFace == Color.White)
            {
                // This should be the starting code. 
                mod_colorEmphasisFace = Color.LightCyan;
                return mod_colorEmphasisFace;
            }
            else if (mod_colorEmphasisFace == Color.LightCyan)
            {
                mod_colorEmphasisFace = Color.LightYellow;
                return mod_colorEmphasisFace;
            }
            else if (mod_colorEmphasisFace == Color.LightYellow)
            {
                mod_colorEmphasisFace = Color.LightCyan;
                return mod_colorEmphasisFace;
            }
            else 
            {
                //
                // Should not be used.  If you see Red, it's a logic error. 
                //
                mod_colorEmphasisFace = Color.Red;
                return mod_colorEmphasisFace;
            }

        }


        public Color Color_DrawWithEmphasis_Current()
        {
            //
            // Added 6/13/2021 thomas downes 
            //
            return mod_colorEmphasisFace;

        }



        public void Remove_DrawWithEmphasis()
        {
            //
            // Added 6/13/2021 thomas downes 
            //
            this.Piece1.GodControl_DrawWithEmphasis_JustMoved = false;
            this.Piece2.GodControl_DrawWithEmphasis_JustMoved = false;
            this.Piece3.GodControl_DrawWithEmphasis_JustMoved = false;
            this.Piece4.GodControl_DrawWithEmphasis_JustMoved = false;

            // Added 6/13/2021 thomas downes 
            this.Piece1.GodControl_DrawWithEmphasis_JustClicked = false;
            this.Piece2.GodControl_DrawWithEmphasis_JustClicked = false;
            this.Piece3.GodControl_DrawWithEmphasis_JustClicked = false;
            this.Piece4.GodControl_DrawWithEmphasis_JustClicked = false;


        }


        public void Load_GodControlColors()
        {
            //
            // Added 6/18/2021 thomas downes 
            //
            //  This will serve to emphasis/highlight the front faces of the
            //    pieces which are recently selected or moved. 
            //
            //this.Piece1.DrawWithEmphasis_JustMoved = false;
            //this.Piece2.DrawWithEmphasis_JustMoved = false;
            //this.Piece3.DrawWithEmphasis_JustMoved = false;
            //this.Piece4.DrawWithEmphasis_JustMoved = false;

            this.Piece1.Color_GodControlEmphasis = Color.LightCyan;
            this.Piece2.Color_GodControlEmphasis = Color.LightYellow;
            this.Piece3.Color_GodControlEmphasis = Color.LightPink;
            this.Piece4.Color_GodControlEmphasis = Color.LightGray;

        }

        public void SpecifyParentSideToAllPieces()
        {
            //
            // Added 6/14/2021 thomas downes 
            //
            //--mod_mainside_back.SpecifyParentSideToAllPieces();
            //--mod_mainside_front.SpecifyParentSideToAllPieces();

            this.Piece1.ParentSide = this;
            this.Piece2.ParentSide = this;
            this.Piece3.ParentSide = this;
            this.Piece4.ParentSide = this;

        }




    }
}