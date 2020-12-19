using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayerNoSQL;   // Added 12/19/2020 thomas d. 
//using MongoDB.Driver;   // Added 12/19/2020 thomas d. 

namespace RubiksCube_2x2
{
    class TestMongoDB
    {
        public static string GetTestData()
        {
            //
            // Added 12/19/2020 td
            //
            var objTest = new DataLayerNoSQL.MongoAtlas();

            objTest.SetUp_DataClient();

            //var objCollection = objTest.ThisCollection; 

            return objTest.ReturnData; 

        }



    }
}
