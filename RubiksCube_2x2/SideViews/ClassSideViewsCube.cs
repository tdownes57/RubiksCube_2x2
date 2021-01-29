using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2.SideViews
{
    class ClassSideViewsCube : RubiksCubeBothSides
    {
        //
        // Added 1/23/2021 thomas downes
        //
        ClassSideViewSide mod_front;
        ClassSideViewSide mod_back;  

        public ClassSideViewsCube(RubiksCubeBothSides par_cube, EnumLeftOrRight par_enum)
        {
            //
            // Added 1/23/2021 Thomas Downes
            //
            mod_front = new ClassSideViewSide(par_cube, par_enum);

            if (par_enum == EnumLeftOrRight.Left) mod_back = new ClassSideViewSide(par_cube, EnumLeftOrRight.Right);
            if (par_enum == EnumLeftOrRight.Right) mod_back = new ClassSideViewSide(par_cube, EnumLeftOrRight.Left);

            //base.FrontSide = mod_front;
            //base.BackSide = mod_back;  

        }




    }
}
