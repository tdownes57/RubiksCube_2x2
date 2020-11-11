using System;
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
            base.Color1of3 = Color.Blue; // Green. 
            base.Color2of3 = Color.Orange;
            base.Color3of3 = Color.Yellow;

            base.FrontFace = FrontClockFace.seven_thirty;

        }
    }
}
