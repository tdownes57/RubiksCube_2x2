using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RubiksCube_2x2.Back
{
    class ClassBacksideBrief
    {
        public string PositionsBrief { get; set; }

        // 
        // Added 11/19/2020 thomas downes  
        //
        public ClassBacksideBrief(Back.ClassBackside par_backsideFull)
        {
            //
            // Added 11/19/2020 thomas downes  
            //
            // Example #1:
            //
            //     BOY/NE==F1:N_F2:E_F3:F  BYR/SE==F1:S_F2:E_F3:F  GRY/SW==F1:F_F2:W_F3:S  GYO/NW==F1:N_F2:F_F3:W
            //
            // Example #2:
            //
            //     BOY/SW==F1:S_F2:W_F3:F  BYR/NE==F1:N_F2:E_F3:F  GRY/SE==F1:F_F2:E_F3:S  GYO/NW==F1:N_F2:F_F3:W
            //
            //     (F = Front Face) 
            //

            string brief_BOY = par_backsideFull.Brief_BOY();
            string brief_BYR = par_backsideFull.Brief_BYR();
            string brief_GRY = par_backsideFull.Brief_GRY();
            string brief_GYO = par_backsideFull.Brief_GYO();

            //this.PositionsBrief = String.Concat(brief_BOY, brief_BYR, brief_GRY, brief_GYO);
            this.PositionsBrief = (brief_BOY + "  " + brief_BYR + "  " + brief_GRY + "  " + brief_GYO);

        }

        public static ClassBackside Deserialize(string par_stringToBeParsed)
        {
            //
            // Added 11/20/2020 thomas downes  
            //
            // Example #1:
            //
            //     BOY/NE==F1:N_F2:E_F3:F  BYR/SE==F1:S_F2:E_F3:F  GRY/SW==F1:F_F2:W_F3:S  GYO/NW==F1:N_F2:F_F3:W
            //
            // Example #2:
            //
            //     BOY/SW==F1:S_F2:W_F3:F  BYR/NE==F1:N_F2:E_F3:F  GRY/SE==F1:F_F2:E_F3:S  GYO/NW==F1:N_F2:F_F3:W
            //
            //     (F = Front Face) 
            //
            char[] separators = new char[] { ' ' };
            string[] parsedByFour = par_stringToBeParsed.Split(separators, 4);

            BlueOrangeYellow outputBOY = new BlueOrangeYellow(parsedByFour[0]);
            BlueYellowRed outputBYR = new BlueYellowRed(parsedByFour[1]);
            GreenRedYellow outputGRY = new GreenRedYellow(parsedByFour[2]);
            GreenYellowOrange outputGYO = new GreenYellowOrange(parsedByFour[3]);

            ClassBackside outputBackside = new ClassBackside(outputBOY, outputBYR, outputGRY, outputGYO);

            return outputBackside; 

        }


        public static ClassBackside Deserialize(string par_stringBriefBOY, string par_stringBriefBYR,
                                                string par_stringBriefGRY, string par_stringBriefGYO)
        {
            //
            // Added 12/20/2020 thomas downes  
            //
            // Example #1:
            //
            //     BOY/NE==F1:N_F2:E_F3:F  BYR/SE==F1:S_F2:E_F3:F  GRY/SW==F1:F_F2:W_F3:S  GYO/NW==F1:N_F2:F_F3:W
            //
            // Example #2:
            //
            //     BOY/SW==F1:S_F2:W_F3:F  BYR/NE==F1:N_F2:E_F3:F  GRY/SE==F1:F_F2:E_F3:S  GYO/NW==F1:N_F2:F_F3:W
            //
            //     (F = Front Face) 
            //
            //--char[] separators = new char[] { ' ' };
            //---string[] parsedByFour = par_stringToBeParsed.Split(separators, 4);

            //--BlueOrangeYellow outputBOY = new BlueOrangeYellow(parsedByFour[0]);
            //--BlueYellowRed outputBYR = new BlueYellowRed(parsedByFour[1]);
            //--GreenRedYellow outputGRY = new GreenRedYellow(parsedByFour[2]);
            //--GreenYellowOrange outputGYO = new GreenYellowOrange(parsedByFour[3]);

            BlueOrangeYellow outputBOY = new BlueOrangeYellow(par_stringBriefBOY);
            BlueYellowRed outputBYR = new BlueYellowRed(par_stringBriefBYR);
            GreenRedYellow outputGRY = new GreenRedYellow(par_stringBriefGRY);
            GreenYellowOrange outputGYO = new GreenYellowOrange(par_stringBriefGYO);

            ClassBackside outputBackside = new ClassBackside(outputBOY, outputBYR, outputGRY, outputGYO);

            return outputBackside;

        }



    }
}
