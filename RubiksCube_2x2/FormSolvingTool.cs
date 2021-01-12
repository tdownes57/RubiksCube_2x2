using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubiksCube_2x2
{
    public partial class FormSolvingTool : Form
    {
        private Point center_point_form_FRONT; // = new Point(this.Width / 2, this.Height / 2);
        private Point center_point_form_BACK; // Added 11/12/2020 td

        //Added 12/8/2020 thomas downes
        private RubiksCubeBothSides mod_cubeWholeBothSides;

        private Back.ClassBackside mod_cubeBackside; //Added 11/12/2020 thomas downes
        private Back.BlueOrangeYellow mod_BackPieceBOY = new Back.BlueOrangeYellow();
        private Back.BlueYellowRed mod_BackPieceBYR = new Back.BlueYellowRed();
        private Back.GreenRedYellow mod_BackPieceGRY = new Back.GreenRedYellow();
        private Back.GreenYellowOrange mod_BackPieceGYO = new Back.GreenYellowOrange();

        //private Front.ClassRotateRules mod_RotateFrontside; //Added 11/13/2020 thomas downes
        private Front.ClassFrontside mod_cubeFrontside; //Added 11/13/2020 thomas downes
        private Front.BlueWhiteOrange mod_FrontPieceBWO = new Front.BlueWhiteOrange();
        private Front.BlueRedWhite mod_FrontPieceBRW = new Front.BlueRedWhite();
        private Front.GreenWhiteRed mod_FrontPieceGWR = new Front.GreenWhiteRed();
        private Front.GreenOrangeWhite mod_FrontPieceGOW = new Front.GreenOrangeWhite();

        //Added 11/17/2020 thomas downes
        private Cursor _customCursorRing = null;
        private Cursor _customCursorPlus = null;
        private RubikPieceCorner _rubiksPiece_Dragged = null;
        private RubikPieceCorner _rubiksPiece_Replaced = null;
        private bool _godlike_behavior_OK;

        //Added 11/20/2020 thomas downes
        // 1/4/2021 //private int mod_countOfComplexMotions = 0;
        private int mod_frontCountOfRotateBtmRight = 0;  // Renamed 1/4/2021 thomas
        private int mod_backCountOfRevolveClockwise = 0;  // Added 1/4/2021 thomas
        private int mod_backCountOfRevolveCounterClock = 0;  // Added 1/4/2021 thomas

        //Added 11/20/2020 thomas downes
        private bool mod_bGiveCompletionMessage = true;

        //Added 12/6/2020 thomas downes
        private bool _bClickedFrontside = false;  // _bClickedFrontside; //  false;
        private bool _bClickedBackside = false;  // _bClickedBackside;  // false;


        public FormSolvingTool()
        {
            InitializeComponent();

            //
            // Added 11/12/2020 thomas downes
            //
            mod_cubeBackside = new Back.ClassBackside(mod_BackPieceBOY, mod_BackPieceBYR,
                                                           mod_BackPieceGRY, mod_BackPieceGYO);
            mod_cubeBackside.LoadInitialPositions();

            //
            // Added 11/13/2020 thomas downes
            //
            //---mod_RotateFrontside = new Front.ClassRotateRules_Front(mod_FrontPieceBWO, mod_FrontPieceBRW,
            //---                                               mod_FrontPieceGWR, mod_FrontPieceGOW);
            mod_cubeFrontside = new Front.ClassFrontside(mod_FrontPieceBWO, mod_FrontPieceBRW,
                                                           mod_FrontPieceGWR, mod_FrontPieceGOW);

            //Added 11/15/2020 thomas downes
            mod_cubeFrontside.LoadInitialPositions();

            //Added 12/8/2020 thomas downes
            mod_cubeWholeBothSides = new RubiksCubeBothSides(mod_cubeFrontside, mod_cubeBackside);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush a_brush = new SolidBrush(Color.Red);

            //center_point_form = new Point(this.Width / 2, this.Height / 2);
            //center_point_form = new Point(this.Width / 2, this.Height / 4);
            //center_point_form = new Point(this.Width / 2, 2 * this.Height / 5);
            //center_point_form = new Point(this.Width / 2, 1 * this.Height / 4);
            //center_point_form = new Point(this.Width / 2, 1 * this.Height / 3);

            center_point_form_FRONT = new Point(this.Width / 3, 1 * this.Height / 3);
            center_point_form_BACK = new Point(this.Width * 2 / 3, 1 * this.Height / 3);

            //
            // Added 11/17/2020 td 
            //
            bool boolRefreshSideObject = false;
            const bool c_boolLoadLastSerializedPositions = true;  // false;  // true;  //  false;  // true; 

            if (c_boolLoadLastSerializedPositions)
            {
                var pieceBOY = JsonStaticClass_Load.LoadPiece_BOY();
                var pieceBYR = JsonStaticClass_Load.LoadPiece_BYR();
                var pieceGRY = JsonStaticClass_Load.LoadPiece_GRY();
                var pieceGYO = JsonStaticClass_Load.LoadPiece_GYO();

                if (pieceBOY != null)
                {
                    mod_BackPieceBOY = pieceBOY;
                    boolRefreshSideObject = true;
                }
                if (pieceBYR != null)
                {
                    mod_BackPieceBYR = pieceBYR;
                    boolRefreshSideObject = true;
                }
                if (pieceGRY != null)
                {
                    mod_BackPieceGRY = pieceGRY;
                    boolRefreshSideObject = true;
                }
                if (pieceGYO != null)
                {
                    mod_BackPieceGYO = pieceGYO;
                    boolRefreshSideObject = true;
                }
            }

            //Refresh the Backside object.  
            if (boolRefreshSideObject)
            {
                mod_cubeBackside = new Back.ClassBackside(mod_BackPieceBOY, mod_BackPieceBYR,
                                                               mod_BackPieceGRY, mod_BackPieceGYO);
                //this.Refresh();

                //Added 12/13/2020 thomas downes
                mod_cubeWholeBothSides = new RubiksCubeBothSides(mod_cubeFrontside, mod_cubeBackside);
            }

            //Added 11/20/2020 thomas downes
            const bool c_bCheckRotations = true;
            string strUniqueIndex;
            string strBriefDescription;
            strBriefDescription = (new Back.ClassBacksideBrief(mod_cubeBackside)).PositionsBrief;
            labelBriefSerialization.Text = strBriefDescription;

            if (c_bCheckRotations)
            {
                //string strUniqueIndex = Uniqueness.AddDescription(strBriefDescription);
                strUniqueIndex = Uniqueness.AddDescription(in mod_cubeBackside, true);
            }
            else
            {
                strUniqueIndex = Uniqueness.AddDescription(strBriefDescription);
            }
            labelUniquenessIndex.Text = strUniqueIndex;

            // Added 12/4/2020 td
            labelUVW_VWX_WXY_XYZ.Text = mod_cubeBackside.BOY_etc_Clockwise();

            //Added 12/06/2020 td
            comboGodlikePowers.SelectedIndex = 0;  

        }

        private void Form1_Draw_NotInUse(object sender, EventArgs e)
        {
            //System.Drawing.SolidBrush a_brush = new SolidBrush(Color.Red);



        }

        #region Obselete Code

        private Rectangle GetRectangle_FrontFace(int whichRect, Point par_center_point_form)
        {
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);

            //const int half_wdth = 30;
            //const int half_hght = 30;  

            switch (whichRect)
            {
               case 0:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(par_center_point_form.X + FaceSize.Front_Half_wdth, par_center_point_form.Y - FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);
                case 1:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(par_center_point_form.X + FaceSize.Front_Half_wdth, par_center_point_form.Y + FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);
                case 2:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(par_center_point_form.X - FaceSize.Front_Half_wdth, par_center_point_form.Y + FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);
                case 3:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(par_center_point_form.X - FaceSize.Front_Half_wdth, par_center_point_form.Y - FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                default: return new Rectangle(0, 0, 100, 100);
            }
        }


        private Rectangle GetRectangle_FrontFace(FrontClockFace par_FrontFace, Point par_center_point_form)
        {
            //
            // Define the rectange which will represent one of four(4) front single-color rectangles. 
            //
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);

            //const int mod_face_half_wdth = 30;
            //const int mod_face_half_hght = 30;

            switch (par_FrontFace)
            {
                case FrontClockFace.one_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(par_center_point_form.X + FaceSize.Front_Half_wdth,
                                                  par_center_point_form.Y - FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                case FrontClockFace.four_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(par_center_point_form.X + FaceSize.Front_Half_wdth,
                                                  par_center_point_form.Y + FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                case FrontClockFace.seven_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(par_center_point_form.X - FaceSize.Front_Half_wdth,
                                                  par_center_point_form.Y + FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                case FrontClockFace.ten_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(par_center_point_form.X - FaceSize.Front_Half_wdth,
                                                  par_center_point_form.Y - FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                    //
                    // Not likely to be used: 
                    //
                default: return new Rectangle(0, 0, 100, 100);
            }
        }


        private Rectangle GetRectangle_SideFace(FrontClockFace par_FrontFace, Point par_center_of_form, 
                                                   bool p_clockwise, bool p_counterwise)
        {
            //
            // Define the rectange which will represent one of eight(8) side single-color rectangles. 
            //
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            Point center_point_frontface; //= new Point(this.Width / 2, this.Height / 2);
            Point center_point_sideface; //= new Point(this.Width / 2, this.Height / 2);

            Point center_point_13h30 = new Point(par_center_of_form.X + FaceSize.Front_Half_wdth,
                                                 par_center_of_form.Y - FaceSize.Front_Half_hght);
            Point center_point_16h30 = new Point(par_center_of_form.X + FaceSize.Front_Half_wdth,
                                                 par_center_of_form.Y + FaceSize.Front_Half_hght);
            Point center_point_19h30 = new Point(par_center_of_form.X - FaceSize.Front_Half_wdth,
                                                 par_center_of_form.Y + FaceSize.Front_Half_hght);
            Point center_point_22h30 = new Point(par_center_of_form.X - FaceSize.Front_Half_wdth,
                                                 par_center_of_form.Y - FaceSize.Front_Half_hght);

            //const int half_wdth_HORI = 30;
            //const int half_wdth_VERT = 20;

            //const int half_hght_VERT = 20;
            //const int half_hght_HORI = 30;

            switch (par_FrontFace)
            {
                case FrontClockFace.one_thirty:
                    //
                    // Clockwise & Counter-Clockwise from the front face. 
                    //
                    //return new Rectangle(0, 0, 100, 100);

                    //center_point_frontface = new Point();
                    //center_point_frontface = new Point(center_point_form.X + FaceSize.Front_Half_wdth, 
                    //                                   center_point_form.Y - FaceSize.Front_Half_hght);
                    center_point_frontface = center_point_13h30;

                    if (p_clockwise)
                    {
                        center_point_sideface = new Point(center_point_frontface.X,
                                                          center_point_frontface.Y - FaceSize.Side_Half_hght_VERT - 10 - 25);
                        return GetRectangle_byCenter(center_point_sideface, 
                            FaceSize.Side_Half_hght_VERT, 
                            FaceSize.Side_Half_wdth_VERT);
                    }
                    else if (true || p_counterwise)
                    {
                        //center_point_frontface = new Point(center_point_form.X + half_wdth, center_point_form.Y - half_hght);
                        //return GetRectangle_byCenter(center_point_frontface, 25, 25);
                        center_point_sideface = new Point(center_point_frontface.X + FaceSize.Side_Half_hght_HORI + 10 + 25,
                                                          center_point_frontface.Y);
                        return GetRectangle_byCenter(center_point_sideface,
                            FaceSize.Side_Half_wdth_HORI,
                            FaceSize.Side_Half_hght_HORI);
                    }
                    return new Rectangle(2, 2, 10, 10);  // Doesn't execute. 
                    //
                    // End of case. 
                    //

                case FrontClockFace.four_thirty:
                    //
                    // Clockwise & Counter-Clockwise from the front face. 
                    //
                    center_point_frontface = center_point_16h30;   // 3:30

                    if (p_clockwise)
                    {
                        center_point_sideface = new Point(center_point_frontface.X + FaceSize.Side_Half_wdth_HORI + 10 + 25,
                                                          center_point_frontface.Y);  // - FaceSize.Side_Half_hght_HORI - 10);
                        return GetRectangle_byCenter(center_point_sideface,
                            FaceSize.Side_Half_wdth_HORI,
                            FaceSize.Side_Half_hght_HORI);
                    }
                    else if (true || p_counterwise)
                    {
                        //center_point_frontface = new Point(center_point_form.X + half_wdth, center_point_form.Y - half_hght);
                        //return GetRectangle_byCenter(center_point_frontface, 25, 25);
                        center_point_sideface = new Point(center_point_frontface.X,
                                                          center_point_frontface.Y + FaceSize.Side_Half_hght_VERT + 10 + 25);
                        return GetRectangle_byCenter(center_point_sideface,
                            FaceSize.Side_Half_wdth_VERT,
                            FaceSize.Side_Half_hght_VERT);
                    }
                    return new Rectangle(2, 2, 10, 10);  // Doesn't execute. 
                    //
                    // End of case.  
                    //

                case FrontClockFace.seven_thirty:
                    //
                    // Clockwise & Counter-Clockwise from the front face. 
                    //
                    center_point_frontface = center_point_19h30;   // 3:30

                    if (p_clockwise)
                    {
                        center_point_sideface = new Point(center_point_frontface.X,
                                                          center_point_frontface.Y + FaceSize.Side_Half_hght_VERT + 10 + 25);  // - FaceSize.Side_Half_hght_HORI - 10);
                        return GetRectangle_byCenter(center_point_sideface,
                            FaceSize.Side_Half_wdth_VERT,
                            FaceSize.Side_Half_hght_VERT);
                    }
                    else if (true || p_counterwise)
                    {
                        //center_point_frontface = new Point(center_point_form.X + half_wdth, center_point_form.Y - half_hght);
                        //return GetRectangle_byCenter(center_point_frontface, 25, 25);
                        center_point_sideface = new Point(center_point_frontface.X - FaceSize.Side_Half_hght_HORI - 10 - 25,
                                                          center_point_frontface.Y);
                        return GetRectangle_byCenter(center_point_sideface,
                            FaceSize.Side_Half_wdth_HORI,
                            FaceSize.Side_Half_hght_HORI);
                    }
                    return new Rectangle(2, 2, 10, 10);  // Doesn't execute. 
                    //
                    // End of case.  
                    //

                case FrontClockFace.ten_thirty:
                    //
                    // Clockwise & Counter-Clockwise from the front face. 
                    //
                    center_point_frontface = center_point_22h30;   // 3:30

                    if (p_clockwise)
                    {
                        center_point_sideface = new Point(center_point_frontface.X - FaceSize.Side_Half_wdth_HORI - 10 - 25,
                                                          center_point_frontface.Y);
                        return GetRectangle_byCenter(center_point_sideface,
                            FaceSize.Side_Half_wdth_HORI,
                            FaceSize.Side_Half_hght_HORI);
                    }
                    else if (true || p_counterwise)
                    {
                        //center_point_frontface = new Point(center_point_form.X + half_wdth, center_point_form.Y - half_hght);
                        //return GetRectangle_byCenter(center_point_frontface, 25, 25);
                        center_point_sideface = new Point(center_point_frontface.X,
                                                          center_point_frontface.Y - FaceSize.Side_Half_hght_VERT - 10 - 25);  // - FaceSize.Side_Half_hght_HORI - 10);
                        return GetRectangle_byCenter(center_point_sideface,
                            FaceSize.Side_Half_wdth_VERT,
                            FaceSize.Side_Half_hght_VERT);
                    }
                    return new Rectangle(2, 2, 10, 10);  // Doesn't execute. 
                    //
                    // End of case.  
                    //

                //
                // Not likely to be used: 
                //
                default: return new Rectangle(0, 0, 100, 100);
            }
        }


        private Rectangle GetRectangle_byCenter(Point par_center, int half_width, int half_hght)
        {
            //
            // Copied from Form1.cs on 11/12/2020 thomas downes
            //
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            //Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);

            return new Rectangle(par_center.X - half_width, 
                par_center.Y - half_hght, 
                (2 * half_width), 
                (2 * half_hght));

        }

        #endregion

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            //---private void Form1_Paint(object sender, PaintEventArgs e)
            //
            //Encapsulated 11/12/2020 td
            //
            const bool c_boolUseObjects = true;

            if (c_boolUseObjects)
            {
                mod_cubeWholeBothSides.PaintThisCube(e.Graphics, 
                        center_point_form_FRONT,
                        center_point_form_BACK);
            }
            else
            {
                Form1_Paint_BACK(e);
                Form1_Paint_FRONT(e);
            }

        }

        private void Form1_Paint_BACK(PaintEventArgs e)  //object sender, PaintEventArgs e)
        {
            //
            // Called by the following:
            //    private void Form1_Paint(object sender, PaintEventArgs e)
            //
            System.Drawing.SolidBrush a_brush_blu = new SolidBrush(Color.Blue);
            System.Drawing.SolidBrush a_brush_green = new SolidBrush(Color.Lime);
            System.Drawing.SolidBrush a_brush_orange = new SolidBrush(Color.Orange);

            System.Drawing.SolidBrush a_brush_red = new SolidBrush(Color.Red);
            System.Drawing.SolidBrush a_brush_yel = new SolidBrush(Color.Yellow);
            //System.Drawing.SolidBrush a_brush_green = new SolidBrush(Color.Green);

            Graphics a_graphics = e.Graphics;

            //a_graphics.FillRectangle(a_brush, GetRectangle_FrontFace(0));
            //a_graphics.FillRectangle(a_brush, GetRectangle_FrontFace(1));
            //a_graphics.FillRectangle(a_brush, GetRectangle_FrontFace(2));
            //a_graphics.FillRectangle(a_brush, GetRectangle_FrontFace(3));

            const bool c_boolUseObjects1 = true;  // Added 1/11/2021  
            const bool c_boolUseObjects2 = false; // true;  Suffixed with "2" on 1/11/2021.

            if (c_boolUseObjects1)
            {
                //
                // Added 1/11/2021 Thomas Downes        
                //
                mod_cubeWholeBothSides.PaintThisCube(a_graphics, center_point_form_BACK);

            }
            else if (c_boolUseObjects2)
            {
                //
                // Added 11/11/2020 Thomas Downes        
                //
                //mod_BackPieceBOY.PaintByGraphics(a_graphics, center_point_form_BACK);
                //mod_BackPieceBYR.PaintByGraphics(a_graphics, center_point_form_BACK);
                //mod_BackPieceGRY.PaintByGraphics(a_graphics, center_point_form_BACK);
                //mod_BackPieceGYO.PaintByGraphics(a_graphics, center_point_form_BACK);

                ////
                //// Step 1 of 2.  Paint the front faces.  (vs. sides) 
                ////
                //mod_BackPieceBOY.PaintByGraphics(a_graphics, center_point_form_BACK, EnumWhatToPaint.JustFront);
                //mod_BackPieceBYR.PaintByGraphics(a_graphics, center_point_form_BACK, EnumWhatToPaint.JustFront);
                //mod_BackPieceGRY.PaintByGraphics(a_graphics, center_point_form_BACK, EnumWhatToPaint.JustFront);
                //mod_BackPieceGYO.PaintByGraphics(a_graphics, center_point_form_BACK, EnumWhatToPaint.JustFront);

                ////
                //// Step 2 of 2.  Paint the side faces.  
                ////
                //mod_BackPieceBOY.PaintByGraphics(a_graphics, center_point_form_BACK, EnumWhatToPaint.JustSides);
                //mod_BackPieceBYR.PaintByGraphics(a_graphics, center_point_form_BACK, EnumWhatToPaint.JustSides);
                //mod_BackPieceGRY.PaintByGraphics(a_graphics, center_point_form_BACK, EnumWhatToPaint.JustSides);
                //mod_BackPieceGYO.PaintByGraphics(a_graphics, center_point_form_BACK, EnumWhatToPaint.JustSides);

                //
                // Step 1 of 2.  Paint the front faces.  (vs. sides) 
                //
                mod_BackPieceBOY.PaintByGraphics_FrontFace(a_graphics, center_point_form_BACK); //, EnumWhatToPaint.JustFront);
                mod_BackPieceBYR.PaintByGraphics_FrontFace(a_graphics, center_point_form_BACK); //, EnumWhatToPaint.JustFront);
                mod_BackPieceGRY.PaintByGraphics_FrontFace(a_graphics, center_point_form_BACK); //, EnumWhatToPaint.JustFront);
                mod_BackPieceGYO.PaintByGraphics_FrontFace(a_graphics, center_point_form_BACK); //, EnumWhatToPaint.JustFront);

                //
                // Step 2 of 2.  Paint the side faces.  
                //
                mod_BackPieceBOY.PaintByGraphics_SideFaces(a_graphics, center_point_form_BACK); //, EnumWhatToPaint.JustSides);
                mod_BackPieceBYR.PaintByGraphics_SideFaces(a_graphics, center_point_form_BACK); //, EnumWhatToPaint.JustSides);
                mod_BackPieceGRY.PaintByGraphics_SideFaces(a_graphics, center_point_form_BACK); //, EnumWhatToPaint.JustSides);
                mod_BackPieceGYO.PaintByGraphics_SideFaces(a_graphics, center_point_form_BACK); //, EnumWhatToPaint.JustSides);

            }
            else
            {
                //
                // Fill the front faces. 
                //
                a_graphics.FillRectangle(a_brush_yel, GetRectangle_FrontFace(FrontClockFace.one_thirty, center_point_form_BACK));  // 1:30 pm, or 13h30  (top right)
                a_graphics.FillRectangle(a_brush_orange, GetRectangle_FrontFace(FrontClockFace.four_thirty, center_point_form_BACK)); // 3:30 pm, or 15h30   (bottom right) 
                a_graphics.FillRectangle(a_brush_orange, GetRectangle_FrontFace(FrontClockFace.seven_thirty, center_point_form_BACK)); // 7:30 pm, or 19h30  (bottom left) 
                a_graphics.FillRectangle(a_brush_yel, GetRectangle_FrontFace(FrontClockFace.ten_thirty, center_point_form_BACK));   // 10:30 pm, or 22h30  (top left)  

                //
                // Fill the side faces. 
                //
                a_graphics.FillRectangle(a_brush_green, GetRectangle_SideFace(FrontClockFace.one_thirty, center_point_form_BACK, true, false)); // 1:30 pm, or 13h30  (top right)
                a_graphics.FillRectangle(a_brush_red, GetRectangle_SideFace(FrontClockFace.one_thirty, center_point_form_BACK, false, true));

                a_graphics.FillRectangle(a_brush_green, GetRectangle_SideFace(FrontClockFace.four_thirty, center_point_form_BACK, true, false)); // 3:30 pm, or 15h30   (bottom right) 
                a_graphics.FillRectangle(a_brush_yel, GetRectangle_SideFace(FrontClockFace.four_thirty, center_point_form_BACK, false, true));

                a_graphics.FillRectangle(a_brush_yel, GetRectangle_SideFace(FrontClockFace.seven_thirty, center_point_form_BACK, true, false)); // 7:30 pm, or 19h30  (bottom left) 
                a_graphics.FillRectangle(a_brush_blu, GetRectangle_SideFace(FrontClockFace.seven_thirty, center_point_form_BACK, false, true));

                a_graphics.FillRectangle(a_brush_red, GetRectangle_SideFace(FrontClockFace.ten_thirty, center_point_form_BACK, true, false));  // 10:30 pm, or 22h30  (top left)  
                a_graphics.FillRectangle(a_brush_blu, GetRectangle_SideFace(FrontClockFace.ten_thirty, center_point_form_BACK, false, true));
            }
        }


        private void Form1_Paint_FRONT(PaintEventArgs e)  //object sender, PaintEventArgs e)
        {
            //
            // Called by the following:
            //    private void Form1_Paint(object sender, PaintEventArgs e)
            //
            System.Drawing.SolidBrush a_brush_blu = new SolidBrush(Color.Blue);
            System.Drawing.SolidBrush a_brush_green = new SolidBrush(Color.Lime);
            System.Drawing.SolidBrush a_brush_orange = new SolidBrush(Color.Orange);

            System.Drawing.SolidBrush a_brush_red = new SolidBrush(Color.Red);
            System.Drawing.SolidBrush a_brush_whi = new SolidBrush(Color.White);
            //System.Drawing.SolidBrush a_brush_green = new SolidBrush(Color.Green);

            Graphics a_graphics = e.Graphics;

            //a_graphics.FillRectangle(a_brush, GetRectangle_FrontFace(0));
            //a_graphics.FillRectangle(a_brush, GetRectangle_FrontFace(1));
            //a_graphics.FillRectangle(a_brush, GetRectangle_FrontFace(2));
            //a_graphics.FillRectangle(a_brush, GetRectangle_FrontFace(3));

            // Jan. 11 //const bool c_boolUseObjects = true;
            const bool c_boolUseObjects1 = true;  // Added 1/11/2021  
            const bool c_boolUseObjects2 = false; // true;  Suffixed with "2" on 1/11/2021.

            if (c_boolUseObjects1)
            {
                //
                // Added 1/11/2021 Thomas Downes        
                //
                //mod_cubeWholeBothSides.PaintThisCube(a_graphics, center_point_form_FRONT);
                mod_cubeFrontside.PaintThisSide(a_graphics, center_point_form_BACK);

            }

            else if (c_boolUseObjects2)  //if (c_boolUseObjects)
            {
                //
                // Added 11/11/2020 Thomas Downes        
                //
                //mod_FrontPieceBWO.PaintByGraphics(a_graphics, center_point_form_FRONT);
                //mod_FrontPieceBRW.PaintByGraphics(a_graphics, center_point_form_FRONT);
                //mod_FrontPieceGWR.PaintByGraphics(a_graphics, center_point_form_FRONT);
                //mod_FrontPieceGOW.PaintByGraphics(a_graphics, center_point_form_FRONT);

                mod_FrontPieceBWO.PaintByGraphics(a_graphics, center_point_form_FRONT, EnumWhatToPaint.FrontAndSides);
                mod_FrontPieceBRW.PaintByGraphics(a_graphics, center_point_form_FRONT, EnumWhatToPaint.FrontAndSides);
                mod_FrontPieceGWR.PaintByGraphics(a_graphics, center_point_form_FRONT, EnumWhatToPaint.FrontAndSides);
                mod_FrontPieceGOW.PaintByGraphics(a_graphics, center_point_form_FRONT, EnumWhatToPaint.FrontAndSides);

            }
            else
            {
                //
                // Fill the front faces. 
                //
                a_graphics.FillRectangle(a_brush_whi, GetRectangle_FrontFace(FrontClockFace.one_thirty, center_point_form_FRONT));  // 1:30 pm, or 13h30  (top right)
                a_graphics.FillRectangle(a_brush_orange, GetRectangle_FrontFace(FrontClockFace.four_thirty, center_point_form_FRONT)); // 3:30 pm, or 15h30   (bottom right) 
                a_graphics.FillRectangle(a_brush_orange, GetRectangle_FrontFace(FrontClockFace.seven_thirty, center_point_form_FRONT)); // 7:30 pm, or 19h30  (bottom left) 
                a_graphics.FillRectangle(a_brush_whi, GetRectangle_FrontFace(FrontClockFace.ten_thirty, center_point_form_FRONT));   // 10:30 pm, or 22h30  (top left)  

                //
                // Fill the side faces. 
                //
                a_graphics.FillRectangle(a_brush_green, GetRectangle_SideFace(FrontClockFace.one_thirty, center_point_form_FRONT, true, false)); // 1:30 pm, or 13h30  (top right)
                a_graphics.FillRectangle(a_brush_red, GetRectangle_SideFace(FrontClockFace.one_thirty, center_point_form_FRONT, false, true));

                a_graphics.FillRectangle(a_brush_green, GetRectangle_SideFace(FrontClockFace.four_thirty, center_point_form_FRONT, true, false)); // 3:30 pm, or 15h30   (bottom right) 
                a_graphics.FillRectangle(a_brush_whi, GetRectangle_SideFace(FrontClockFace.four_thirty, center_point_form_FRONT, false, true));

                a_graphics.FillRectangle(a_brush_whi, GetRectangle_SideFace(FrontClockFace.seven_thirty, center_point_form_FRONT, true, false)); // 7:30 pm, or 19h30  (bottom left) 
                a_graphics.FillRectangle(a_brush_blu, GetRectangle_SideFace(FrontClockFace.seven_thirty, center_point_form_FRONT, false, true));

                a_graphics.FillRectangle(a_brush_red, GetRectangle_SideFace(FrontClockFace.ten_thirty, center_point_form_FRONT, true, false));  // 10:30 pm, or 22h30  (top left)  
                a_graphics.FillRectangle(a_brush_blu, GetRectangle_SideFace(FrontClockFace.ten_thirty, center_point_form_FRONT, false, true));
            }
        }

        private void buttonRotateClockwise_Click(object sender, EventArgs e)
        {
            //
            // Added 11/12/2020 thomas downes
            //
            mod_cubeBackside.Simple_Clockwise90();
            this.Refresh();

            //Added 1/04/2021 thomas downes
            mod_backCountOfRevolveClockwise += 1;
            lblCntBacksideSimpleCW.Text = "Count: " + mod_backCountOfRevolveClockwise.ToString();

        }

        private void buttonRotateComplex_Click(object sender, EventArgs e)
        {
            //
            // Added 11/13/2020 thomas downes  
            //
            //static intCountOfClicks = 0; 

            //if (mod_RotateBackside.SideIsASolidColor())
            if (mod_cubeBackside.SideIsASolidColor() && mod_bGiveCompletionMessage)
            {
                //    // Added 11/13/2020 thomas downes
                //    MessageBox.Show("The backside of the Cube is completed, i.e. a solid color.", "Completed", 
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    mod_bGiveCompletionMessage = false;  //Don't show a second time in a row. 
                //    return; 
            }
            if (mod_cubeBackside.SideIsASolidColor_AndSidesMatch() && mod_bGiveCompletionMessage)
            {
                // Added 1/07/2021 thomas downes
                MessageBox.Show("The backside of the Cube is completed, i.e. a solid color, and the side-colors are arranged correctly.", "Completed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                mod_bGiveCompletionMessage = false;  //Don't show a second time in a row. 
                return;
            }
            else
            {
                mod_bGiveCompletionMessage = true;  //Reinitialize.  ---11/20/2020 thomas downes
            }

            mod_cubeFrontside.ComplexRevolution();
            mod_cubeBackside.ComplexRevolution();
            this.Refresh();

            //Added 11/20/2020 thomas downes
            mod_frontCountOfRotateBtmRight += 1;
            lblCntFrontsideRotateBtmRight.Text = "Count: " + mod_frontCountOfRotateBtmRight.ToString();

            //Added 11/20/2020 thomas downes
            //string strBriefDescription = mod_RotateBackside.ToString();
            string strBriefDescription = (new Back.ClassBacksideBrief(mod_cubeBackside)).PositionsBrief;  
            string strUniqueIndex = Uniqueness.AddDescription(strBriefDescription);
            labelUniquenessIndex.Text = strUniqueIndex;
            labelBriefSerialization.Text = strBriefDescription;

            //Added 12/1/2020 thomas
            bool bPriorValue = false; //Added 12/1/2020 thomas
            if (mod_cubeBackside.PiecesAreCorrectlyOrdered(out bPriorValue))
            {
                // Added 12/01/2020 thomas downes
                if (bPriorValue == false) // Only show the message if the value has changed. 
                {
                    MessageBox.Show("All the pieces of the backside are correctly placed " + 
                        "in relation with each other-- BOY, BYR, GRY, GOY  (or BOY, GOY, GRY, BYR).",
                        "Pieces in correct order",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Added 12/4/2020 td
            labelUVW_VWX_WXY_XYZ.Text = mod_cubeBackside.BOY_etc_Clockwise();


        }

        private void labelComplexRotate2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes
            //
            //this.Cursor
            //
            //  C# Winforms - change cursor icon of mouse
            //  https://stackoverflow.com/questions/2902327/c-sharp-winforms-change-cursor-icon-of-mouse
            //  https://stackoverflow.com/questions/432379/set-custom-cursor-from-resource-file
            //  https://www.youtube.com/watch?v=mTuVpfsPX1k
            //  https://convertico.com/
            //
            //
            //I have the answer for a picturebox
            //
            //    Picturebox1.cursor = new cursor(Properties.Resources.CURSOR NAME.GetHicon());
            //
            //this.Cursor = new Cursor(Properties.Resources.custom_cursor_tcd2);

            var ms = new System.IO.MemoryStream(Properties.Resources.custom_cursor_tcd2);  // (My.Resources.Cursor1)
            this.Cursor = new Cursor(ms);

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes
            //
            //this.Cursor
            //
            //  C# Winforms - change cursor icon of mouse
            //  https://stackoverflow.com/questions/2902327/c-sharp-winforms-change-cursor-icon-of-mouse
            //  https://stackoverflow.com/questions/432379/set-custom-cursor-from-resource-file
            //  https://www.youtube.com/watch?v=mTuVpfsPX1k
            //  https://convertico.com/
            //
            //
            //I have the answer for a picturebox
            //
            //    Picturebox1.cursor = new cursor(Properties.Resources.CURSOR NAME.GetHicon());
            //
            //this.Cursor = new Cursor(Properties.Resources.custom_cursor_tcd2);

            const bool c_boolEntireFormHasCustomCursor = false;

            if (c_boolEntireFormHasCustomCursor)
            {
                //var ms = new System.IO.MemoryStream(Properties.Resources.custom_cursor_tcd2);  // (My.Resources.Cursor1)
                //var ms = new System.IO.MemoryStream(Properties.Resources.custom_cursor_transparent2);  // (My.Resources.Cursor1)
                //this.Cursor = new Cursor(ms);
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes 
            //
            Point currentLocation = new Point(e.X, e.Y);

            RubikPieceCorner whichPiece = null;

            //
            // Back Side 
            //
            if (whichPiece == null)
            {
                whichPiece = mod_cubeBackside.WhichPieceHasMouseHover(currentLocation);
            }

            //
            // Front Side
            //
            //Added 12/6/2020 thomas downes
            if (whichPiece == null)
            {
                //Added 12/6/2020 thomas downes
                whichPiece = mod_cubeFrontside.WhichPieceHasMouseHover(currentLocation);

                //Added 12/6/2020 thomas downes
                if (false && whichPiece != null)
                MessageBox.Show("You have placed the mouse over the front side of the Rubik's Cube.");
            }

            //
            // Take a look at whether or not we have identified a clicked piece. 
            //
            if (whichPiece == null)
            {
                if (_rubiksPiece_Dragged == null)
                {
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                if (_rubiksPiece_Dragged != null)
                {
                    //
                    // We are dragging a piece. Don't modify the cursor. 
                    //
                }
                else 
                {
                    //
                    // Let's apply the Ring cursor, "ring_cursor" (formerly "transparent2").  
                    //
                    if (_customCursorRing == null)
                    {
                        //var ms = new System.IO.MemoryStream(Properties.Resources.custom_cursor_tcd2);  // (My.Resources.Cursor1)
                        //var ms = new System.IO.MemoryStream(Properties.Resources.transparent2);  // (My.Resources.Cursor1)
                        var ms = new System.IO.MemoryStream(Properties.Resources.ring_cursor);  // (My.Resources.Cursor1)
                        _customCursorRing = new Cursor(ms);
                    }
                    //this.Cursor = new Cursor(ms);
                    this.Cursor = _customCursorRing;
                }
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes  
            //
            bool bClickedFrontside = false;  // _bClickedFrontside; //  false;
            bool bClickedBackside = false;  // _bClickedBackside;  // false;
            bool bAllowGodlikeOperations = (1 == comboGodlikePowers.SelectedIndex);

            RubikPieceCorner piece_clicked = null;

            //Front Side
            //  Check the Front Side for a clicked piece. 
            //
            if (piece_clicked == null)
            {
                piece_clicked = mod_cubeFrontside.WhichPieceIsClicked(e.X, e.Y);
                if (piece_clicked != null) bClickedFrontside = true;
            }

            // Sloan says, look here, there's a bug!!!
            // AccessibleDefaultActionDescription ----- 

            //Back Side
            //  Check the Back Side for a clicked piece.
            //
            if (piece_clicked == null)
            {
                piece_clicked = mod_cubeBackside.WhichPieceIsClicked(e.X, e.Y);
                if (piece_clicked != null) bClickedBackside = true;
            }

            if (piece_clicked == null)
            {
                //
                // Clean up time!!   Then exit Sub.
                //
                _rubiksPiece_Dragged = null;
                _rubiksPiece_Replaced = null;
                this.Cursor = Cursors.Default;
                labelHowToMoveAPiece.Visible = false;

                //Added 11/17/2020 thomas d.
                CheckIfSideFaceWasClicked(e.X, e.Y);

                //Added 12/6/2020 thomas downes
                _bClickedFrontside = bClickedFrontside;
                _bClickedBackside = bClickedBackside;

                return;
            }

            else if (piece_clicked != null)
            {
                if (_rubiksPiece_Dragged != null)
                {
                    //
                    //   Step 2 of 2 -- Replace.
                    //
                    //   We are pretty much done with the drag-and-replace process. 
                    //
                    this.Cursor = Cursors.Default;
                    _rubiksPiece_Replaced = piece_clicked;

                    // Added 11/17/2020 thomas downes
                    if (bAllowGodlikeOperations) // Conditioned 12/7/2020 td
                    {
                        //
                        // Allow the pieces to be moved without any consequence to the 
                        //    arrangement of pieces on the opposide side of the cube. 
                        //
                        // Condition added 12/06/2020 thomas downes
                        RubiksCubeOneSide cubeSide = null;

                        if (bClickedFrontside) cubeSide = mod_cubeFrontside;
                        if (bClickedBackside) cubeSide = mod_cubeBackside;
                        cubeSide.GodlikeSwitch(_rubiksPiece_Dragged, _rubiksPiece_Replaced);

                        // Condition (& function call) added 12/06/2020 thomas downes
                        //if (bClickedFrontside) mod_cubeFrontside
                        //    .GodlikeSwitch(_rubiksPiece_Dragged, _rubiksPiece_Replaced);
                    }
                    else
                    {
                        //
                        // Allow only adjacent pieces to be swapped. 
                        //
                        bool bPiecesAreAdjacent_Front = (bClickedFrontside 
                            && mod_cubeFrontside.AdjacentPieces(_rubiksPiece_Dragged, _rubiksPiece_Replaced));
                        bool bPiecesAreAdjacent_Back = (bClickedBackside
                            && mod_cubeBackside.AdjacentPieces(_rubiksPiece_Dragged, _rubiksPiece_Replaced));

                        bool bAdjacentPieces = (bPiecesAreAdjacent_Front || bPiecesAreAdjacent_Back);

                        if (bAdjacentPieces)
                        {
                            // Added 12/7/2020 td
                            MessageBox.Show("Great, the pieces are adjacent.  Okay to effect the consequences to the other side?");

                            //Added 12/9/2020 thomas downes  
                            if (bClickedFrontside)
                                mod_cubeWholeBothSides.OrientCube_Step1Rotate(_rubiksPiece_Dragged,
                                 _rubiksPiece_Replaced, true,
                                 mod_cubeFrontside, mod_cubeBackside);
                            if (bClickedBackside) 
                                  mod_cubeWholeBothSides.OrientCube_Step1Rotate(_rubiksPiece_Dragged, 
                                   _rubiksPiece_Replaced, true, 
                                   mod_cubeBackside, mod_cubeFrontside);
                            mod_cubeWholeBothSides.SwitchBottomPieces_Front();
                            mod_cubeWholeBothSides.OrientCube_Step2Restore();

                        }
                        else
                        {
                            // Added 12/7/2020 td
                            MessageBox.Show("The pieces are not adjacent, and Godlike operartions are turned off.  Please reconsider.");

                        }


                    }


                    //
                    // Clean up time!!
                    //
                    _rubiksPiece_Dragged = null;
                    _rubiksPiece_Replaced = null;
                    labelHowToMoveAPiece.Visible = false;
                    this.Cursor = Cursors.Default;
                    this.Refresh();
                    // Added 12/4/2020 td
                    labelUVW_VWX_WXY_XYZ.Text = mod_cubeBackside.BOY_etc_Clockwise();
                    //Added 12/6/2020 td
                    _bClickedBackside = false;
                    _bClickedFrontside = false; 

                    //Added 12/1/2020 thomas
                    bool bPriorValue = false;
                    if (mod_cubeBackside.PiecesAreCorrectlyOrdered(out bPriorValue))
                    {
                        // Added 12/01/2020 thomas downes
                        if (bPriorValue == false) //Let's not keep hitting the user over the head with this message. 
                        {
                            MessageBox.Show("All the pieces of the backside are correctly placed in relation with each other-- BOY, BYR, GRY, GOY.",
                                "Pieces in correct order",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    if (CheckForGodlikeBehavior_MovePiece())
                    {
                        _rubiksPiece_Dragged = piece_clicked;
                        if (_customCursorPlus == null)
                        {
                            //var ms = new System.IO.MemoryStream(Properties.Resources.transparent2);  // (My.Resources.Cursor1)
                            var ms = new System.IO.MemoryStream(Properties.Resources.plussign_cursor);  // (My.Resources.Cursor1)
                            _customCursorPlus = new Cursor(ms);
                        }
                        this.Cursor = _customCursorPlus;
                        labelHowToMoveAPiece.Visible = true;
                    }
                }

                // Added 12/4/2020 td
                //Moved up, to a condition.//labelUVW_VWX_WXY_XYZ.Text = mod_RotateBackside.BOY_etc_Clockwise();

            }

        }

        private void CheckIfSideFaceWasClicked(int e_X, int e_Y)  // (object sender, MouseEventArgs e)
        {
            //---private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
            //
            // Added 11/17/2020 thomas downes
            //
            RubikPieceCorner piece_clicked = null; // = mod_RotateBackside.WhichPiece_SideFaceClicked(e_X, e_Y);

            //Added 12/05/2020 thomas downes 
            if (null == piece_clicked)
                piece_clicked = mod_cubeFrontside.WhichPiece_SideFaceClicked(e_X, e_Y);

            //Conditioned 12/05/2020 thomas downes 
            if (null == piece_clicked) 
                piece_clicked = mod_cubeBackside.WhichPiece_SideFaceClicked(e_X, e_Y);

            //if (piece_clicked != null && _rubiksPiece_Dragged != null)
            if (_rubiksPiece_Dragged != null)
            {
                //
                // The user has double-clicked, but seems to be in the 
                //    middle of a select-then-drop process.  
                //
                // This is confusing behavior by the user. 
                //
                // Let's "punish" the user by reverting to an earlier state of things. 
                //
                // Clean up time!!   Then exit Sub.
                //
                _rubiksPiece_Dragged = null;
                _rubiksPiece_Replaced = null;
                this.Cursor = Cursors.Default;
                labelHowToMoveAPiece.Visible = false;
                _bClickedFrontside = false;  //Added 12/6/2020 thomas downes
                _bClickedBackside = false;  //Added 12/6/2020 thomas downes
                return;
            }

            if (piece_clicked != null)
            {
                //
                // Rotate the piece clockwise.  
                //
                // First, check with the user if he or she wants to 
                //   perform a godlike behavior. 
                //
                if (CheckForGodlikeBehavior_RotateInPlace())
                {
                    //piece_clicked.RotateInPlace_Clockwise120();
                    piece_clicked.RotateInPlace_PivotPiece120degrees();
                    this.Refresh();
                }

            }


        }


        private bool CheckForGodlikeBehavior_RotateInPlace()
        {
            //
            // Added 11/17/2020 thoms downes
            //
            if (_godlike_behavior_OK == false)
            {
                DialogResult user_response;
                user_response = MessageBox.Show("Do you want to perform a godlike behavior?"
                                   + "\n \n  (Rotating a piece in place, i.e. not affecting other pieces.) ", 
                                   "Godlike Behavior",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                _godlike_behavior_OK = (user_response == DialogResult.Yes);
                //return true;
            }
            return _godlike_behavior_OK;
        }

        private bool CheckForGodlikeBehavior_MovePiece()
        {
            //
            // Added 11/17/2020 thoms downes
            //
            if (_godlike_behavior_OK == false)
            {
                DialogResult user_response;
                user_response = MessageBox.Show("Do you want to perform a godlike behavior?"
                                   + "\n \n  (Selecting a piece to move elsewhere, without impacting surrounding pieces.) ",
                                   "Godlike Behavior",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                _godlike_behavior_OK = (user_response == DialogResult.Yes);
            }
            return _godlike_behavior_OK;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes
            //
            //JsonStaticClass_Save.SaveToDiskPiece_BOY(mod_BackPieceBOY);
            //JsonStaticClass_Save.SaveToDiskPiece_BYR(mod_BackPieceBYR);
            //JsonStaticClass_Save.SaveToDiskPiece_GRY(mod_BackPieceGRY);
            //JsonStaticClass_Save.SavePiece_GYO(mod_BackPieceGYO);

            const bool c_boolBriefVersion1 = false;   // true;  //Added 12/14/2020 thomas downes

            if (c_boolBriefVersion1)
            {
                var objectSide = new Back.ClassBacksideBrief(mod_cubeBackside);
                string strSerialization = objectSide.PositionsBrief;
            }
            else 
            {
                const bool c_boolBriefVersion2 = false;   // true;  //Added 12/14/2020 thomas downes
                JsonStaticClass_Save.SaveToDiskPiece_BOY(mod_BackPieceBOY, c_boolBriefVersion2);
                JsonStaticClass_Save.SaveToDiskPiece_BYR(mod_BackPieceBYR, c_boolBriefVersion2);
                JsonStaticClass_Save.SaveToDiskPiece_GRY(mod_BackPieceGRY, c_boolBriefVersion2);
                JsonStaticClass_Save.SavePiece_GYO(mod_BackPieceGYO, c_boolBriefVersion2);   //, c_boolBriefVersion);
            }

            //
            // Save to Mongo Database!
            //
            //  Added 12/30/2020 td
            //
            MongoDB_Save.SaveRubiksSides(in mod_cubeFrontside, in mod_cubeBackside);

        }

        private void linkRevertToStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //
            // Added 11/17/2020 thomas downes
            //
            if (CheckForGodlikeBehavior_MovePiece())
            {
                mod_cubeBackside.LoadInitialPositions();
                this.Refresh(); 
            }

        }

        private void cmdSwitchFrontBottomPieces_Click(object sender, EventArgs e)
        {
            //
            //  Added 12/9/2020 thomas d.
            //
            RubikPieceCorner beforePiece430;  // For testing only. 
            RubikPieceCorner beforePiece1030;   // For testing only. 
            FrontClockFace test_position430_Before;
            FrontClockFace test_position430_After;
            FrontClockFace test_position1030_Before;
            FrontClockFace test_position1030_After;

            //
            // Testing, before. 
            //
            beforePiece430 = mod_cubeBackside.GetPiece(FrontClockFace.four_thirty);
            beforePiece1030 = mod_cubeBackside.GetPiece(FrontClockFace.ten_thirty);

            test_position430_Before = beforePiece430.FrontClockFacePosition;
            test_position1030_Before = beforePiece1030.FrontClockFacePosition;

            //MessageBox.Show("Before..... \n  Blue-Orange-Yellow piece: " + mod_BackPieceBOY.ToString() +
            //                "\n\n Green-Red-Yellow piece: " + mod_BackPieceGRY.ToString());

            //
            // Major call !!   Do the work!
            //
            mod_cubeWholeBothSides.SwitchBottomPieces_Front();
            this.Refresh();

            //
            // Testing, after. 
            //
            test_position430_After = beforePiece430.FrontClockFacePosition;
            test_position1030_After = beforePiece1030.FrontClockFacePosition;

            bool boolNoChange430 = (test_position430_Before == test_position430_After);
            bool boolNoChange1030 = (test_position1030_Before == test_position1030_After);

            if (boolNoChange430) MessageBox.Show("The backside piece at 4:30 has not moved.");
            if (boolNoChange1030) MessageBox.Show("The backside piece at 10:30 has not moved.");

            //MessageBox.Show("After..... \n  Blue-Orange-Yellow piece: " + mod_BackPieceBOY.ToString() +
            //    "\n\n Green-Red-Yellow piece: " + mod_BackPieceGRY.ToString());

            //
            // Check object-references. 
            //
            //bool boolObjectOkayBOY_1 = (mod_BackPieceBOY == mod_cubeBackside._pieceBOY);
            //bool boolObjectOkayGRY_1 = (mod_BackPieceGRY == mod_cubeBackside._pieceGRY);

            //if (!boolObjectOkayBOY_1) MessageBox.Show("Object-reference #1 for BOY is broken.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //if (!boolObjectOkayGRY_1) MessageBox.Show("Object-reference #1 for GRY is broken.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // 1-2-2021//bool boolObjectOkayBOY_2 = (mod_BackPieceBOY == mod_cubeWholeBothSides.BackSide()._pieceBOY );
            // 1-2-2021//bool boolObjectOkayGRY_2 = (mod_BackPieceGRY == mod_cubeWholeBothSides.BackSide()._pieceGRY );

            bool boolObjectOkayBOY_2 = (mod_BackPieceBOY == mod_cubeWholeBothSides.BackSide._pieceBOY);
            bool boolObjectOkayGRY_2 = (mod_BackPieceGRY == mod_cubeWholeBothSides.BackSide._pieceGRY);

            if (!boolObjectOkayBOY_2) MessageBox.Show("Object-reference #2 for BOY is broken.....!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (!boolObjectOkayGRY_2) MessageBox.Show("Object-reference #2 for GRY is broken.....!!.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //
            // Give supplementary feedback to the user. 
            //
            //Added 12/1/2020 thomas
            bool bPriorValue = false; //Added 12/1/2020 thomas
            if (mod_cubeBackside.PiecesAreCorrectlyOrdered(out bPriorValue))
            {
                // Added 12/01/2020 thomas downes
                if (bPriorValue == false) // Only show the message if the value has changed. 
                {
                    MessageBox.Show("All the pieces of the backside are correctly placed in relation with each other-- BOY, BYR, GRY, GOY.",
                        "Pieces in correct order",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Added 12/4/2020 td
            labelUVW_VWX_WXY_XYZ.Text = mod_cubeBackside.BOY_etc_Clockwise();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetNoSQL_Click(object sender, EventArgs e)
        {
            //
            //  Added 12/19/2020 td
            //
            string strNoSQL = "";

            var objTest = new DataLayerNoSQL.MongoAtlas();

            objTest.SetUp_DataClient();

            strNoSQL = objTest.ReturnData;

            MessageBox.Show("NoSQL:_________  " + strNoSQL);

        }

        private void buttonSaveToMongo_Click(object sender, EventArgs e)
        {
            //
            // Save to Mongo Database!
            //
            //  Added 12/30/2020 td
            //
            MongoDB_Save.SaveRubiksSides(in mod_cubeFrontside, in mod_cubeBackside);

        }

        private void buttonLoadFromMongo_Click(object sender, EventArgs e)
        {
            //
            // Save to Mongo Database!
            //
            //  Added 12/30/2020 td
            //
            MongoDB_Load.GetRubiksSides(out mod_cubeFrontside, out mod_cubeBackside);

            //Added 1/2/2021 Thomas DOWNES
            //mod_cubeWholeBothSides = new RubiksCubeBothSides(mod_cubeFrontside, mod_cubeBackside);
            mod_cubeWholeBothSides.BackSide = mod_cubeBackside;
            mod_cubeWholeBothSides.FrontSide = mod_cubeFrontside;

            this.Refresh();

        }

        private void buttonRotateCounter_Click(object sender, EventArgs e)
        {
            //
            // Added 11/12/2020 thomas downes
            //
            //Three clockwise 90-degrees = 270 degrees = 360 - 90 degrees
            mod_cubeBackside.Simple_Clockwise90();  // Step 1 of 3. 3 x 90 = 270 degrees = 360 - 90 degrees
            mod_cubeBackside.Simple_Clockwise90();  // Step 2 of 3. 3 x 90-degrees = 270 degrees = 360 - 90 degrees
            mod_cubeBackside.Simple_Clockwise90();  // Step 3 of 3. 3 x 90-degrees = 270 degrees = 360 - 90 degrees
            this.Refresh();

            //Added 1/04/2021 thomas downes
            mod_backCountOfRevolveCounterClock += 1;
            lblCntBacksideSimpleCCW.Text = "Count: " + mod_backCountOfRevolveCounterClock.ToString();

        }
    }
}
