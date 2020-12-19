using System;
using System.Collections.Generic;
using System.Linq;
//using MongoDB.Driver.Core;  // Added 12/18/2020 thomas downes
//using MongoDB.Bson.IO;  
//using MongoDB.Driver.Core.Connections;
using MongoDB.Bson; //   https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
using MongoDB.Bson.Serialization.Attributes;    //   https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
//using MongoDB.Driver.Core;
using MongoDB.Driver;    //   https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
//using MongoDBWebAPI.Models;

//using MongoDB.Driver;
//using MongoDBWebAPI.Models;

namespace DataLayerNoSQL_Core
{
    //
    //   https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
    //
    public class EmployeeService
    {
        //
        //   https://www.c-sharpcorner.com/article/using-mongodb-with-asp-net-core-web-api/
        //
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        //private MongoDB.Driver.Core.Connections.BuildInfoResult mod_conn = new BuildInfoResult(); 

        private readonly IMongoCollection<Employee> _employees;
        public EmployeeService(IEmployeeDatabaseSettings settings)
        {
            var client = new MongoDB.Driver.MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _employees = database.GetCollection<Employee>(settings.EmployeesCollectionName);

        }

        public List<Employee> Get()
        {
            List<Employee> employees;
            employees = _employees.Find(emp => true).ToList();
            return employees;
        }

        public Employee Get(string id) =>
            _employees.Find<Employee>(emp => emp.Id == id).FirstOrDefault();







    }
}
