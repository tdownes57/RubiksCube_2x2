using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2
{
    class ComplexRotation
    {
        RubikPieceCorner _cornerNE; 
        RubikPieceCorner _cornerSE;
        RubikPieceCorner _cornerSW; 
        RubikPieceCorner _cornerNW;

        public ComplexRotation(RubikPieceCorner cornerNE, RubikPieceCorner cornerSE, 
                               RubikPieceCorner cornerSW, RubikPieceCorner cornerNW)
        {
            //
            // Added 11/11/2020 
            //
            _cornerNE = cornerNE;
            _cornerNW = cornerNW;
            _cornerSE = cornerSE;
            _cornerSW = cornerSW;


        }

        public void RotateOnce_Simple()
        {
            //
            // Added 11/11/2020 
            //

        }

        public void RotateOnce_Complex()
        {
            //
            // Added 11/11/2020 
            //


        }


        public void ReturnToStartingPosition()
        {
            //
            // Added 11/11/2020 
            //


        }




    }
}
