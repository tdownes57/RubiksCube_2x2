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

    }
}
