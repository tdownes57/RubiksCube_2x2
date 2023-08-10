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
        public static FrontClockFace one_thirty_obj => new FrontClockFace(FrontClockFace_Enum.one_thirty);
        public static FrontClockFace four_thirty_obj => new FrontClockFace(FrontClockFace_Enum.four_thirty);
        public static FrontClockFace seven_thirty_obj => new FrontClockFace(FrontClockFace_Enum.seven_thirty);
        public static FrontClockFace ten_thirty_obj => new FrontClockFace(FrontClockFace_Enum.ten_thirty);

        public static FrontClockFace_Enum one_thirty => FrontClockFace_Enum.one_thirty;
        public static FrontClockFace_Enum four_thirty => FrontClockFace_Enum.four_thirty;
        public static FrontClockFace_Enum seven_thirty => FrontClockFace_Enum.seven_thirty;
        public static FrontClockFace_Enum ten_thirty => FrontClockFace_Enum.ten_thirty;

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

        public void SetFrontClockPosition(FrontClockFace_Enum par_enum)
        {
            // Set the Enum value.----8/09/2023
            mod_enumClockPosition = par_enum;
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


        //
        //  https://dotnettutorials.net/lesson/why-we-should-override-equals-method/
        //
        public override bool Equals(object par_object)
        {
            //
            //  https://dotnettutorials.net/lesson/why-we-should-override-equals-method/
            //
            // If the passed object is null
            if (par_object == null)
            {
                return false;
            }

            //---if (!(obj is Customer))
            //---++if (!(par_object is FrontClockFace))
            //---++{
            //---++    return false;
            //---++}

            if (par_object is FrontClockFace)
            {
                // Added 10/29/2021 thomas d. 
                bool bEqualValue = (mod_enumClockPosition == ((FrontClockFace)par_object).EnumValue());
                return bEqualValue;
            }
            else if (par_object is FrontClockFace_Enum)
            {
                // Added 10/29/2021 thomas d. 
                return (mod_enumClockPosition == (FrontClockFace_Enum)par_object);
            }
            else return false;

            //return (this.FirstName == ((Customer)obj).FirstName)
            //    && (this.LastName == ((Customer)obj).LastName);

                //---++bool bEqualValue = (mod_enumClockPosition == ((FrontClockFace)par_object).EnumValue());
                //---++return bEqualValue;

        }

        public override int GetHashCode()
        {
            //
            //  https://dotnettutorials.net/lesson/why-we-should-override-equals-method/
            //
            //----return FirstName.GetHashCode() ^ LastName.GetHashCode();
            return mod_enumClockPosition.GetHashCode();

        }


        public EnumLeftOrRight LeftOrRight()
        {
            // Added 10/29/2021 thomas downes
            if (mod_enumClockPosition.Equals(FrontClockFace.one_thirty)) return EnumLeftOrRight.Right;
            if (mod_enumClockPosition.Equals(FrontClockFace.four_thirty)) return EnumLeftOrRight.Right;
            if (mod_enumClockPosition.Equals(FrontClockFace.seven_thirty)) return EnumLeftOrRight.Left;
            if (mod_enumClockPosition.Equals(FrontClockFace.ten_thirty)) return EnumLeftOrRight.Left;
            return EnumLeftOrRight.Unassigned;

        }

    }




}
