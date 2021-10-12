using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;  // Added 5/8/2021 thomas d.

namespace RubiksCube_2x2
{
    class RubiksFaceTile_Struct
    {
        //
        // Added 5/8/2021 Thomas Downes  
        //
        public RubiksPieceCorner Corner;
        public EnumAll12Faces Enum_All12Faces;
        public EnumFaceNum Enum_FaceNum;
        public Color Enum_Color;

        // Added 6/18/2021 thomas downes
        public EnumFacePositionNSWE Enum_FacePositionNSWE;
        public EnumCubeRotation_NorthPole Enum_CubeRotation;

        // Added 6/18/2021 thomas downes
        public RubiksFaceTile_Struct()
        {
            // Added 6/18/2021 thomas downes
            //ThisCorner = par_corner;
        }

        // Added 6/18/2021 thomas downes
        public RubiksFaceTile_Struct(RubiksPieceCorner par_corner)
        {
            // Added 6/18/2021 thomas downes
            Corner = par_corner;
        }


    }
}
