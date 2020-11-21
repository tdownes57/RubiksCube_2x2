using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2
{
    static class Uniqueness
    {
        //
        // Added 11/20/2020 Thomas Downes  
        //
        private static List<string> ListDescriptions = new List<string>();

        // Added 11/20/2020 Thomas Downes  
        private static List<string> ListDescriptions_Rotate90 = new List<string>();
        private static List<string> ListDescriptions_Rotate180 = new List<string>();
        private static List<string> ListDescriptions_Rotate270 = new List<string>();

        public static string AddDescription(in string par_strBriefDescription)
        {
            //
            // Added 11/20/2020 thomas downes 
            //
            int indexFound;   
            if (DescriptionIsRepeated(in par_strBriefDescription, out indexFound))
            {
                return "Repeated, Index " + indexFound.ToString();
            }
            ListDescriptions.Add(par_strBriefDescription);
            return ("New, Index " + (ListDescriptions.Count - 1).ToString());

        }


        public static string AddDescription(in Back.ClassBackside par_backside, bool par_checkRotations)
        {
            //
            // Added 11/20/2020 thomas downes 
            //
            int indexFound;

            string strBriefDescription = par_backside.ToString();

            //
            //Prior to any rotation. 
            //
            if (DescriptionIsRepeated(in strBriefDescription, out indexFound))
            {
                return "Repeated, Index " + indexFound.ToString();
            }

            //
            //Rotation #1 -  90 degrees
            //
            par_backside.Simple_Clockwise90();
            string strBriefDescription_90 = par_backside.ToString();
            if (DescriptionIsRepeated(in strBriefDescription_90, ListDescriptions_Rotate90, out indexFound))
            {
                par_backside.Simple_Clockwise90();  // Restoration work.  Now at 180 degrees.
                par_backside.Simple_Clockwise90();  // Restoration work.  Now at 270 degrees. 
                par_backside.Simple_Clockwise90();  // Restoration work.  Now back at 0 degrees. 
                return "Repeated, Index " + indexFound.ToString() + " - Rotation 90 degrees";
            }

            //
            //Rotation #2 -  180 degrees (prior 90 degrees + new 90 degrees)
            //
            par_backside.Simple_Clockwise90();
            string strBriefDescription_180 = par_backside.ToString();
            if (DescriptionIsRepeated(in strBriefDescription_180, ListDescriptions_Rotate180, out indexFound))
            {
                par_backside.Simple_Clockwise90();  // Restoration work.  Now at 270 degrees. 
                par_backside.Simple_Clockwise90();  // Restoration work.  Now back at 0 degrees. 
                return "Repeated, Index " + indexFound.ToString() + " - Rotation 180 degrees";
            }

            //
            //Rotation #3 -  270 degrees (prior 180 degrees + new 90 degrees)
            //
            par_backside.Simple_Clockwise90();
            string strBriefDescription_270 = par_backside.ToString();
            if (DescriptionIsRepeated(in strBriefDescription_270, ListDescriptions_Rotate270, out indexFound))
            {
                par_backside.Simple_Clockwise90();  // Restoration work.  Now back at 0 degrees. 
                return "Repeated, Index " + indexFound.ToString() + " - Rotation 270 degrees";
            }

            //
            // Restoration work.  Return to Net-0 degrees. 
            //
            par_backside.Simple_Clockwise90();  // Restoration work.  Now back at 0 degrees. 

            ListDescriptions.Add(strBriefDescription);
            ListDescriptions_Rotate90.Add(strBriefDescription_90);
            ListDescriptions_Rotate180.Add(strBriefDescription_180);
            ListDescriptions_Rotate270.Add(strBriefDescription_270);

            return ("New, Index " + (ListDescriptions.Count - 1).ToString());

        }


        private static bool DescriptionIsRepeated(in string par_strBriefDescription, out int pout_indexRepeated)
        {
            //
            // Added 11/20/2020 thomas downes 
            //
            //foreach (string strItem in ListDescriptions)
            //{
            //    if (strItem == par_strBriefDescription)
            //}

            for (int indexLD = 0; indexLD < ListDescriptions.Count; indexLD++)
            {
                if (ListDescriptions[indexLD] == par_strBriefDescription)
                {
                    pout_indexRepeated = indexLD;
                    return true;
                }
            }
            pout_indexRepeated = -1;
            return false;  
        }


        private static bool DescriptionIsRepeated(in string par_strBriefDescription, 
                                                   in List<string> par_ListDescriptions,
                                                   out int pout_indexRepeated)
        {
            //
            // Added 11/20/2020 thomas downes 
            //
            //foreach (string strItem in ListDescriptions)
            //{
            //    if (strItem == par_strBriefDescription)
            //}

            for (int indexLD = 0; indexLD < par_ListDescriptions.Count; indexLD++)
            {
                if (par_ListDescriptions[indexLD] == par_strBriefDescription)
                {
                    pout_indexRepeated = indexLD;
                    return true;
                }
            }
            pout_indexRepeated = -1;
            return false;
        }


    }
}
