using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
// 
// Added 12/13/2020 thomas downes  
//

namespace RubiksCube_2x2.Front
{
    class ClassFrontsideBrief
    {
        public string PositionsBrief { get; set; }

        // 
        // Added 12/13/2020 thomas downes  
        //
        public ClassFrontsideBrief(Front.ClassFrontside par_frontsideFull)
        {
            //
            // Added 12/13/2020 thomas downes  
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

            string brief_BRW = par_frontsideFull.Brief_BRW();
            string brief_BWO = par_frontsideFull.Brief_BWO();
            string brief_GOW = par_frontsideFull.Brief_GOW();
            string brief_GWR = par_frontsideFull.Brief_GWR();

            //this.PositionsBrief = String.Concat(brief_BOY, brief_BYR, brief_GRY, brief_GYO);
            this.PositionsBrief = (brief_BRW + "  " + brief_BWO + "  " + brief_GOW + "  " + brief_GWR);

        }


        public static ClassFrontside Deserialize(string par_stringToBeParsed)
        {
            //
            // Added 12/13/2020 thomas downes  
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

            BlueRedWhite outputBRW = new BlueRedWhite(parsedByFour[0]);
            BlueWhiteOrange outputBWO = new BlueWhiteOrange(parsedByFour[1]);
            GreenOrangeWhite outputGOW = new GreenOrangeWhite(parsedByFour[2]);
            GreenWhiteRed outputGWR = new GreenWhiteRed(parsedByFour[3]);

            ClassFrontside outputFrontside = new ClassFrontside(outputBWO, outputBRW, outputGWR, outputGOW);

            return outputFrontside; 

        }


        public static ClassFrontside Deserialize(string par_stringBriefBRW, string par_stringBriefBWO,
                                                string par_stringBriefGOW, string par_stringBriefGWR)
        {
            //
            // Added 12/13/2020 thomas downes  
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
            BlueRedWhite outputBRW = new BlueRedWhite(par_stringBriefBRW);
            BlueWhiteOrange outputBWO = new BlueWhiteOrange(par_stringBriefBWO);
            GreenOrangeWhite outputGOW = new GreenOrangeWhite(par_stringBriefGOW);
            GreenWhiteRed outputGWR = new GreenWhiteRed(par_stringBriefGWR);

            ClassFrontside outputFrontside = new ClassFrontside(outputBWO, outputBRW, outputGWR, outputGOW);

            return outputFrontside;

        }


    }
}
