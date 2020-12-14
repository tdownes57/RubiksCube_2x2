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

            string brief_BOY = par_frontsideFull.Brief_BOY();
            string brief_BYR = par_frontsideFull.Brief_BYR();
            string brief_GRY = par_frontsideFull.Brief_GRY();
            string brief_GYO = par_frontsideFull.Brief_GYO();

            //this.PositionsBrief = String.Concat(brief_BOY, brief_BYR, brief_GRY, brief_GYO);
            this.PositionsBrief = (brief_BOY + "  " + brief_BYR + "  " + brief_GRY + "  " + brief_GYO);

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

            ClassFrontside outputFrontside = new ClassFrontside(outputBRW, outputBWO, outputGOW, outputGWR);

            return outputFrontside; 

        }




    }
}
