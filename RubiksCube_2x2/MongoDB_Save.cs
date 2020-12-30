using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube_2x2
{
    //
    // Added 12/20/2020 thomas downes
    //

    class MongoDB_Save
    {
        //
        // Added 12/20/2020 thomas downes
        //
        public static void SaveRubiksSides(in Front.ClassFrontside in_frontSide,
                                           in Back.ClassBackside in_backSide)
        {
            //
            // Added 12/20/2020 thomas downes
            //
            //var objConfig = new DataLayerNoSQL.RubiksSideConfiguration();
            //var objConfig = DataLayerNoSQL.MongoAtlas.GetRubiksSideConfiguration();

            //out_frontSide = new Front.ClassFrontside(objConfig.Front_Brief_BRW, objConfig.Front_Brief_BWO,
            //                                      objConfig.Front_Brief_GOW, objConfig.Front_Brief_GWR);

            //out_backSide = new Back.ClassBackside(objConfig.Back_Brief_BOY, objConfig.Back_Brief_BYR,
            //                                      objConfig.Back_Brief_GRY, objConfig.Back_Brief_GYO);

            var objConfig = new DataLayerNoSQL.RubiksSideConfiguration();

            objConfig.Back_Brief_BOY = in_backSide.Brief_BOY();
            objConfig.Back_Brief_BYR = in_backSide.Brief_BYR();
            objConfig.Back_Brief_GRY = in_backSide.Brief_GRY();
            objConfig.Back_Brief_GYO = in_backSide.Brief_GYO();

            objConfig.Front_Brief_BRW = in_frontSide.Brief_BRW();
            objConfig.Front_Brief_BWO = in_frontSide.Brief_BWO();
            objConfig.Front_Brief_GOW = in_frontSide.Brief_GOW();
            objConfig.Front_Brief_GWR = in_frontSide.Brief_GWR();

            DataLayerNoSQL.MongoAtlas.SaveRubiksSideConfiguration(objConfig);

            return; 

        }

    }
}
