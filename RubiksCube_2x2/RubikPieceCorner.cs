using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 11/11/2020 thomas downes

namespace RubiksCube_2x2
{
    class RubikPieceCorner {
        //public System.Drawing.Color Color1of3;

        //
        // Colors must be expressed in partial-alphabetical order,
        //    i.e. as follows.
        //    
        //  Color #1 must be the lowest (closest to A)
        //    alphabetically: 
        //         blue, green, orange, red, yellow  
        //  (Face #1 is the face of the Rubik's piece which 
        //     corresponds to Color #1.)
        //
        //  Color #2 must be the color of the face which is 
        //     the first face from Face #1, when moving in a 
        //     clockwise direction. 
        //  (Face #2 is the face of the Rubik's piece which 
        //     corresponds to Color #2.)
        //     
        //  Color #3 must be the color of the face which is 
        //     the first face after Face #2, when moving in a 
        //     clockwise direction. 
        //  (Face #3 is the face of the Rubik's piece which 
        //     corresponds to Color #3.)
        //     
        //
        public System.Drawing.Color FaceColor1of3;
        public System.Drawing.Color FaceColor2of3;
        public System.Drawing.Color FaceColor3of3;

        //
        //          [.N.]   [.N.]
        //   [.W.] [10:30] [1:30]  [.E.]
        //   [.W.]  [ 7:30] [3:30]  [.E.]
        //           [.S.]   [.S.]
        //
        // (The [. .] faces are _side_ faces.) 
        //
        public FrontClockFace FrontFacePosition;

        public FacePositionNSWE FaceColor1Position;
        public FacePositionNSWE FaceColor2Position;
        public FacePositionNSWE FaceColor3Position;

        public EnumFaceNum WhichFaceIsN_offront;
        public EnumFaceNum WhichFaceIsW_offront;
        public EnumFaceNum WhichFaceIsE_offront;
        public EnumFaceNum WhichFaceIsS_offront;

    }
}
