using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;  // Added 12/19/2020 td 
// MongoDB C#/.NET Driver
// https://docs.mongodb.com/drivers/csharp
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataLayerNoSQL
{
    public class MongoAtlas
    {
        //   Quick Start: C# and MongoDB - Starting and Setup
        // https://www.mongodb.com/blog/post/quick-start-c-sharp-and-mongodb-starting-and-setup  
        //
        public IMongoCollection<RubiksSideConfiguration> ThisCollection;

        public string ReturnData;  

        public void SetUp_DataClient()
        {
            // ...
            //var client = new MongoClient(
            //    "mongodb+srv://<username>:<password>@<cluster-address>/test?w=majority"
            //);
            var client_TD = new MongoClient(
                "mongodb+srv://tomdownes1:art666@cluster0.zcz3l.mongodb.net/test"
            );


            var objDatabase = client_TD.GetDatabase("RubiksOperations");

            //var objCollection = objDatabase.GetCollection<RubiksSideConfiguration>("CurrentPosition_Brief");

            this.ThisCollection = objDatabase.GetCollection<RubiksSideConfiguration>("CurrentPosition_Brief");

            //return this.ThisCollection < 0 > ();

            Func<RubiksSideConfiguration, bool> test_func1 = s => s.Back_Brief_BOY.StartsWith("B") ;
            //var test_expression = System.Linq.Expressions.Expression<Func<RubiksSideConfiguration, bool>>. 

            //var obj_expression = System.Linq.Expressions.Expression.IsTrue()

            Expression<Func<RubiksSideConfiguration, bool>> my_linq_func = s => s.Back_Brief_BOY.StartsWith("B");


            var obj_filter = new ExpressionFilterDefinition<RubiksSideConfiguration>(my_linq_func);

            var obj_findOptions = new FindOptions();

            var obj_findResult = ThisCollection.Find<RubiksSideConfiguration>(my_linq_func, obj_findOptions);

            long intCountDocuments = obj_findResult.CountDocuments();  // Added 12/19/2020 thomas downes

            //ReturnData = obj_findResult.ToString();

            ReturnData = "Back_Brief_BOY: "  + obj_findResult.First<RubiksSideConfiguration>().Back_Brief_BOY;

        }

    }
}
