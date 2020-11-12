using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas 

namespace RubiksCube_2x2
{
    class BlueYellowRed : RubikPieceCorner
    {
        public BlueYellowRed()
        {
            base.FaceColor1of3 = Color.Blue; // Green. 
            base.FaceColor2of3 = Color.Yellow;
            base.FaceColor3of3 = Color.Red;

            //
            // Clock position:
            //
            //           [.N.]   [.N.]
            //   [.W.]  [10:30] [1:30]  [.E.]
            //   [.W.]  [ 7:30] [3:30]  [.E.]
            //           [.S.]   [.S.]
            //
            // (The [. .] faces are _side_ faces.) 
            //
            // Clock position 10:30 pm 
            base.FrontFacePosition = FrontClockFace.ten_thirty;

            base.FaceColor1Position = FacePositionNSWE.N_side_of_front;
            base.FaceColor2Position = FacePositionNSWE.FrontFacing;
            base.FaceColor3Position = FacePositionNSWE.W_side_of_front;

            //
            //
            // More description, which may or may not be needed. 
            //
            //
            base.WhichFaceIsN_of_front = EnumFaceNum.Face1;
            base.WhichFaceIsS_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            base.WhichFaceIsW_of_front = EnumFaceNum.Face3;
            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;





        }
    }
}
