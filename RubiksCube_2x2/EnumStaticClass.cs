using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public enum FrontClockFace { one_thirty, four_thirty, seven_thirty, ten_thirty};

    public class EnumStaticClass
    {
    }
}
