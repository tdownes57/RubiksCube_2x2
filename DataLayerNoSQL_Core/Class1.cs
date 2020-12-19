using System;
using MongoDB.Driver.Core;  // Added 12/18/2020 thomas downes
using MongoDB.Bson.IO;  
using MongoDB.Driver.Core.Connections;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataLayerNoSQL_Core
{
    //
    //   https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
    //
    public class Class1
    {
        //
        //   https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
        //
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        private MongoDB.Driver.Core.Connections.BuildInfoResult mod_conn = new BuildInfoResult(); 








    }
}
