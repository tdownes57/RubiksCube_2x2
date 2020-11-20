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
            //     BOY/NE=F1:N_F2:E_F3:F BYR/SE=F1:S_F2:E_F3:F GRY/SW=F1:F_F2:W_F3:S GYO/NW=F1:N_F2:F_F3:W
            //
            // Example #1:
            //
            //     BOY/SW=F1:S_F2:W_F3:F BYR/NE=F1:N_F2:E_F3:F GRY/SE=F1:F_F2:E_F3:S GYO/NW=F1:N_F2:F_F3:W
            //
            //     (F = Front Face) 
            //

            string brief_BOY = par_backsideFull.Brief_BOY();
            string brief_BYR = par_backsideFull.Brief_BYR();
            string brief_GRY = par_backsideFull.Brief_GRY();
            string brief_GYO = par_backsideFull.Brief_GYO();

            this.PositionsBrief = String.Concat(brief_BOY, brief_BYR, brief_GRY, brief_GYO);


        }


    }
}
