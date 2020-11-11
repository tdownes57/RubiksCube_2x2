using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas 

namespace RubiksCube_2x2
{
    class GreenRedYellow : RubikPieceCorner
    {
        public GreenRedYellow()
        {
            base.FaceColor1of3 = Color.Lime; // Green. 
            base.FaceColor2of3 = Color.Red;
            base.FaceColor3of3 = Color.Yellow;

            //
            //Clock position: 
            //
            base.FrontFacePosition = FrontClockFace.one_thirty;

            base.FaceColor1Position = FacePositionNSWE.W_side_of_front;
            base.FaceColor2Position = FacePositionNSWE.FrontFacing;
            base.FaceColor3Position = FacePositionNSWE.S_side_of_front;

        }



    }
}
