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
    public partial class Form1 : Form
    {
        private Point center_point_form; // = new Point(this.Width / 2, this.Height / 2);

        private BlueOrangeYellow mod_PieceBOY = new BlueOrangeYellow();
        private BlueYellowRed mod_PieceBYR = new BlueYellowRed();
        private GreenRedYellow mod_PieceGBRY = new GreenRedYellow();
        private GreenYellowOrange mod_PieceGYO = new GreenYellowOrange();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush a_brush = new SolidBrush(Color.Red);

            //center_point_form = new Point(this.Width / 2, this.Height / 2);
            center_point_form = new Point(this.Width / 2, this.Height / 4);


    }

    private void Form1_Draw_NotInUse(object sender, EventArgs e)
        {
            //System.Drawing.SolidBrush a_brush = new SolidBrush(Color.Red);



        }

        private Rectangle GetRectangle_FrontFace(int whichRect)
        {
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);

            //const int half_wdth = 30;
            //const int half_hght = 30;  

            switch (whichRect)
            {
               case 0:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X + FaceSize.Front_Half_wdth, center_point_form.Y - FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);
                case 1:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X + FaceSize.Front_Half_wdth, center_point_form.Y + FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);
                case 2:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X - FaceSize.Front_Half_wdth, center_point_form.Y + FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);
                case 3:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X - FaceSize.Front_Half_wdth, center_point_form.Y - FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                default: return new Rectangle(0, 0, 100, 100);
            }
        }


        private Rectangle GetRectangle_FrontFace(FrontClockFace par_FrontFace)
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
                    center_point_rect = new Point(center_point_form.X + FaceSize.Front_Half_wdth, 
                                                  center_point_form.Y - FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                case FrontClockFace.four_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X + FaceSize.Front_Half_wdth, 
                                                  center_point_form.Y + FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                case FrontClockFace.seven_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X - FaceSize.Front_Half_wdth, 
                                                  center_point_form.Y + FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                case FrontClockFace.ten_thirty:
                    //return new Rectangle(0, 0, 100, 100);
                    center_point_rect = new Point(center_point_form.X - FaceSize.Front_Half_wdth, 
                                                  center_point_form.Y - FaceSize.Front_Half_hght);
                    return GetRectangle_byCenter(center_point_rect, 25, 25);

                    //
                    // Not likely to be used: 
                    //
                default: return new Rectangle(0, 0, 100, 100);
            }
        }


        private Rectangle GetRectangle_SideFace(FrontClockFace par_FrontFace, bool p_clockwise, bool p_counterwise)
        {
            //
            // Define the rectange which will represent one of eight(8) side single-color rectangles. 
            //
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            Point center_point_frontface; //= new Point(this.Width / 2, this.Height / 2);
            Point center_point_sideface; //= new Point(this.Width / 2, this.Height / 2);

            Point center_point_13h30 = new Point(center_point_form.X + FaceSize.Front_Half_wdth,
                                                 center_point_form.Y - FaceSize.Front_Half_hght);
            Point center_point_16h30 = new Point(center_point_form.X + FaceSize.Front_Half_wdth,
                                                 center_point_form.Y + FaceSize.Front_Half_hght);
            Point center_point_19h30 = new Point(center_point_form.X - FaceSize.Front_Half_wdth,
                                                 center_point_form.Y + FaceSize.Front_Half_hght);
            Point center_point_22h30 = new Point(center_point_form.X - FaceSize.Front_Half_wdth,
                                                 center_point_form.Y - FaceSize.Front_Half_hght);

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
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            //Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);

            return new Rectangle(par_center.X - half_width, par_center.Y - half_hght, 
                2 * half_width, 2 * half_hght);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
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

            //
            // Fill the front faces. 
            //
            a_graphics.FillRectangle(a_brush_yel, GetRectangle_FrontFace(FrontClockFace.one_thirty));  // 1:30 pm, or 13h30  (top right)
            a_graphics.FillRectangle(a_brush_orange, GetRectangle_FrontFace(FrontClockFace.four_thirty)); // 3:30 pm, or 15h30   (bottom right) 
            a_graphics.FillRectangle(a_brush_orange, GetRectangle_FrontFace(FrontClockFace.seven_thirty)); // 7:30 pm, or 19h30  (bottom left) 
            a_graphics.FillRectangle(a_brush_yel, GetRectangle_FrontFace(FrontClockFace.ten_thirty));   // 10:30 pm, or 22h30  (top left)  

            //
            // Fill the side faces. 
            //
            a_graphics.FillRectangle(a_brush_green, GetRectangle_SideFace(FrontClockFace.one_thirty, true, false)); // 1:30 pm, or 13h30  (top right)
            a_graphics.FillRectangle(a_brush_red, GetRectangle_SideFace(FrontClockFace.one_thirty, false, true));
            
            a_graphics.FillRectangle(a_brush_green, GetRectangle_SideFace(FrontClockFace.four_thirty, true, false)); // 3:30 pm, or 15h30   (bottom right) 
            a_graphics.FillRectangle(a_brush_yel, GetRectangle_SideFace(FrontClockFace.four_thirty, false, true));
            
            a_graphics.FillRectangle(a_brush_yel, GetRectangle_SideFace(FrontClockFace.seven_thirty, true, false)); // 7:30 pm, or 19h30  (bottom left) 
            a_graphics.FillRectangle(a_brush_blu, GetRectangle_SideFace(FrontClockFace.seven_thirty, false, true));
            
            a_graphics.FillRectangle(a_brush_red, GetRectangle_SideFace(FrontClockFace.ten_thirty, true, false));  // 10:30 pm, or 22h30  (top left)  
            a_graphics.FillRectangle(a_brush_blu, GetRectangle_SideFace(FrontClockFace.ten_thirty, false, true));

        }





    }
}
