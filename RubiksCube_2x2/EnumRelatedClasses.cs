//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//
// Added 10/29/2021 thomas downes
//
namespace RubiksCube_2x2
{
    //Added 10/29/2021 thomas downes
    public class FrontClockFace
    {
        //Added 10/29/2021 thomas downes
        private FrontClockFace_Enum mod_enumClockPosition = FrontClockFace_Enum.unassigned;
        //Added 10/29/2021 thomas downes
        public FrontClockFace()
        {
            // Default constructor. 
        }
        public FrontClockFace_Enum EnumValue()
        {
            // Convert to Enum value.----10/29/2021
            return mod_enumClockPosition;
        }
        //Added 10/29/2021 thomas downes
        public FrontClockFace(FrontClockFace_Enum par_enumClockPosition)
        {
            // Simple & substantive constructor. 
            mod_enumClockPosition = par_enumClockPosition;
        }
        public FrontClockFace_Enum NextCW_Enum()
        {
            //Added 10/29/2021 thomas downes
            if (mod_enumClockPosition == FrontClockFace_Enum.one_thirty) return FrontClockFace_Enum.four_thirty;
            if (mod_enumClockPosition == FrontClockFace_Enum.four_thirty) return FrontClockFace_Enum.seven_thirty;
            if (mod_enumClockPosition == FrontClockFace_Enum.seven_thirty) return FrontClockFace_Enum.ten_thirty;
            if (mod_enumClockPosition == FrontClockFace_Enum.ten_thirty) return FrontClockFace_Enum.one_thirty;
            else return FrontClockFace_Enum.unassigned;
        }
        public FrontClockFace NextPositionCW(bool par_pleaseDontThrowExceptions = false)
        {
            //Added 10/29/2021 thomas downes
            if (mod_enumClockPosition == FrontClockFace_Enum.one_thirty) return new FrontClockFace(FrontClockFace_Enum.four_thirty);
            if (mod_enumClockPosition == FrontClockFace_Enum.four_thirty) return new FrontClockFace(FrontClockFace_Enum.seven_thirty);
            if (mod_enumClockPosition == FrontClockFace_Enum.seven_thirty) return new FrontClockFace(FrontClockFace_Enum.ten_thirty);
            if (mod_enumClockPosition == FrontClockFace_Enum.ten_thirty) return new FrontClockFace(FrontClockFace_Enum.one_thirty);
            
            //else return new FrontClockFace(FrontClockFace_Enum.unassigned);
            if (par_pleaseDontThrowExceptions) return new FrontClockFace(FrontClockFace_Enum.unassigned);
            throw new System.Exception("The NextPositionCW() is not determinable.");

        }
    }




}
