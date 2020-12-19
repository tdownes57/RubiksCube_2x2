using System;
using System.Collections.Generic;
using System.Text;
//
//    https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
//
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataLayerNoSQL_Core
{
    //
    //    https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
    //
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

    }

}
