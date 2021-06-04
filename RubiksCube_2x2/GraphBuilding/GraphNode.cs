using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RubiksCube_2x2;  // Added 6/3/2021 Thomas Downes
//
// Added 6/3/2021 Thomas Downes
//

namespace RubiksCube_2x2.GraphBuilding
{
    //
    // Added 6/3/2021 Thomas Downes
    //
    class GraphNode
    {
        //
        // Added 6/3/2021 Thomas Downes
        //
        public string CurrentState_FrontSide;
        public string CurrentState_BackSide;

        //
        // Here are the object references which allow 
        //   this multi-colored graph to operate.
        //
        // "Multi-colored" = each edge of graph is associated with a number
        //    (i.e. a color, but instead of colors we use numbered maneuvers:
        //          Maneuver1
        //          Maneuver2
        //          Maneuver3
        //          Maneuver4
        //
        public GraphNode NodeNext_ViaManeuver1;
        public GraphNode NodeNext_ViaManeuver2;
        public GraphNode NodeNext_ViaManeuver3;
        public GraphNode NodeNext_ViaManeuver4;

        public GraphNode NodePrior_ViaManeuver1;
        public GraphNode NodePrior_ViaManeuver2;
        public GraphNode NodePrior_ViaManeuver3;
        public GraphNode NodePrior_ViaManeuver4;

        public bool Solved()
        {
            //
            // Added 6/3/2021 Thomas Downes  
            //
            var objCube = new RubiksCubeBothSides(this.CurrentState_FrontSide,
                                                  this.CurrentState_BackSide);

            bool bSolved_Front = objCube.FrontSide.IsSolved();
            bool bSolved_Back = objCube.BackSide.IsSolved();

            bool bSolved_Fully = (bSolved_Front && bSolved_Back);

            //return false;  
            return bSolved_Fully;

        }


    }
}
