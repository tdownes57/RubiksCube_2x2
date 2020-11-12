using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // added 11/11/2020  

namespace RubiksCube_2x2
{
    public static class FaceSize
    {
        public const int Front_Half_wdth = 30;
        public const int Front_Half_hght = 30;

        public const int Side_Half_wdth_HORI = 20; // 30;
        public const int Side_Half_wdth_VERT = 20;

        public const int Side_Half_hght_VERT = 20;
        public const int Side_Half_hght_HORI = 20;  // 30;

    }

    //
    //          [.N.]   [.N.]
    //   [.W.] [10:30] [1:30]  [.E.]
    //   [.W.]  [ 7:30] [3:30]  [.E.]
    //           [.S.]   [.S.]
    // (The [. .] faces are _side_ faces.) 
    //
    public enum FrontClockFace { one_thirty, four_thirty, seven_thirty, ten_thirty};

    //
    // A 2x2 Rubik's Cube:   (The [. .] faces are _side_ faces.)  
    //
    //            [.N.]   [.N.]
    //     [.W.] [front] [front]  [.E.]
    //     [.W.] [front] [front]  [.E.]
    //            [.S.]   [.S.]
    //
    //
    //          [.N.]   [.N.]
    //   [.W.] [10:30] [1:30]  [.E.]
    //   [.W.]  [ 7:30] [3:30]  [.E.]
    //           [.S.]   [.S.]
    //
    public enum FacePositionNSWE { NotSpecified, FrontFacing, N_side_of_front, S_side_of_front, E_side_of_front, W_side_of_front };

    public enum EnumFaceNum { NotSpecified, NotApplicable_DifferentPiece, Face1, Face2, Face3 };

    public class EnumStaticClass
    {

        public static Rectangle GetRectangle_Front(Point p_centerOfForm, FrontClockFace p_face_position)
        {
            //
            // Added 11/11/2020 Thomas Downes  
            //
            //
            // Define the rectange which will represent one of four(4) front single-color rectangles. 
            //
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);
            Point center_point_form = p_centerOfForm;

            //const int mod_face_half_wdth = 30;
            //const int mod_face_half_hght = 30;

            switch (p_face_position) // (par_FrontFace)
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


        private static Rectangle GetRectangle_byCenter(Point par_center, int half_width, int half_hght)
        {
            //Point center_point_form = new Point(this.Width / 2, this.Height / 2);
            //Point center_point_rect; //= new Point(this.Width / 2, this.Height / 2);

            return new Rectangle(par_center.X - half_width, par_center.Y - half_hght,
                2 * half_width, 2 * half_hght);

        }



    }
}
