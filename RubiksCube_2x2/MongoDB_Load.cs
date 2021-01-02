using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerNoSQL;  // Added 12/20/2020 thomas downes

namespace RubiksCube_2x2
{
    //
    // Added 12/20/2020 thomas downes
    //
    class MongoDB_Load
    {
        //
        // Added 12/20/2020 thomas downes
        //
        public static string GetReturnData_FirstDocument()
        {
            //
            // Added 12/20/2020 thomas downes
            //
            string strNoSQL = "";
            var objTest = new DataLayerNoSQL.MongoAtlas();
            objTest.SetUp_DataClient();
            strNoSQL = objTest.ReturnData;

            //MessageBox.Show("NoSQL:_________  " + strNoSQL);
            return strNoSQL;
        }

        public static void GetRubiksSides(out Front.ClassFrontside out_frontSide,
                                           out Back.ClassBackside out_backSide)
        {
            //
            // Added 12/20/2020 thomas downes
            //
            //var objConfig = new DataLayerNoSQL.RubiksSideConfiguration();
            var objConfig = DataLayerNoSQL.MongoAtlas.GetRubiksSideConfiguration();

            //out_frontSide = new Front.ClassFrontside(objConfig.Front_Brief_BRW, objConfig.Front_Brief_BWO,
            //                                      objConfig.Front_Brief_GOW, objConfig.Front_Brief_GWR);
            out_frontSide = new Front.ClassFrontside(objConfig.Front_Brief_BRW, objConfig.Front_Brief_BWO,
                                                  objConfig.Front_Brief_GOW, objConfig.Front_Brief_GWR);

            out_backSide = new Back.ClassBackside(objConfig.Back_Brief_BOY, objConfig.Back_Brief_BYR,
                                                  objConfig.Back_Brief_GRY, objConfig.Back_Brief_GYO);

        }

    }
}
