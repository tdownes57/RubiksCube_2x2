using System;
using System.Collections.Generic;
using System.Text;
// MongoDB C#/.NET Driver
// https://docs.mongodb.com/drivers/csharp
using MongoDB.Bson;
using MongoDB.Driver;
//
//    https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
//
//using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataLayerNoSQL
{
    public class RubiksSideConfiguration
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        //public string ABC_EgBOY { get; set; }

        public string Back_Brief_BOY  { get; set; }
        public string Back_Brief_BYR  { get; set; }
        public string Back_Brief_GRY  { get; set; }
        public string Back_Brief_GYO  { get; set; }

    }
}
