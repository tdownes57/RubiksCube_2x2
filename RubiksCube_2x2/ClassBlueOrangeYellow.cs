﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas 

namespace RubiksCube_2x2
{
    class BlueOrangeYellow : RubikPieceCorner
    {
        public BlueOrangeYellow()
        {
            base.FaceColor1of3 = Color.Blue; // Green. 
            base.FaceColor2of3 = Color.Orange;
            base.FaceColor3of3 = Color.Yellow;

            //
            // Clock position:
            //
            //          [.N.]   [.N.]
            //   [.W.] [10:30] [1:30]  [.E.]
            //   [.W.] [ 7:30] [3:30]  [.E.]
            //           [.S.]   [.S.]
            //
            // (The [. .] faces are _side_ faces.) 
            //
            base.FrontFacePosition = FrontClockFace.seven_thirty;  // [ 7:30]  in   [.W.] [ 7:30] [3:30]  [.E.] 

            base.FaceColor1Position = FacePositionNSWE.W_side_of_front;
            base.FaceColor2Position = FacePositionNSWE.FrontFacing;
            base.FaceColor3Position = FacePositionNSWE.S_side_of_front;

            //
            //
            // More description, which may or may not be needed (helpful). 
            //
            //
            base.WhichFaceIsN_of_front = EnumFaceNum.NotApplicable_DifferentPiece;
            base.WhichFaceIsS_of_front = EnumFaceNum.Face3;
            base.WhichFaceIsW_of_front = EnumFaceNum.Face2;
            base.WhichFaceIsE_of_front = EnumFaceNum.NotApplicable_DifferentPiece;

        }
    }
}