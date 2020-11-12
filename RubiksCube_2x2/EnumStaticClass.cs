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
    }
}
