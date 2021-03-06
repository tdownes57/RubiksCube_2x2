﻿using System;
using MongoDB.Driver;   // Added 11/21/2020 thomas downes
using MongoDB.Driver.Core.Connections;  // Added 11/21/2020 thomas downes 

namespace DataLayerNoSQL
{
    public class Connection
    {
        public void ConnectToDb()
        {
            //
            // Added 11/21/2020 thomas downes  
            //
            //MongoDB.Driver objDriver = new MongoDB.Driver.ConnectionMode 
            //ConnectionMode enumConnMode = ConnectionMode.Direct;
            //DirectConnection objDirectConnection = new DirectConnection();

            //IsMasterResult objectIMR = new IsMasterResult();
            //var objDoc = new BsonDocumentCommand<int>();

            //var objConnect = new MongoDB.Driver.Core.Connections
            //    .ConnectionDescription(new ConnectionID(),);

            var byteArrayAddress = new byte[] { 0, 0, 0, 0 };
            var objIPAddress = new System.Net.IPAddress(byteArrayAddress);

            //
            //   https://cloud.mongodb.com/v2/5fbb31ecbaf9ad01b2a30783#clusters
            //
            var objClusterId = new MongoDB.Driver.Core.Clusters.ClusterId();  // Cluster0, cluster0-shard-00-01.zcz3l
            //objClusterId = MongoDB.Driver.Core.Clusters.ClusterConnectionMode

            var objEndPoint1 = new System.Net.IPEndPoint(objIPAddress, 80);
            var objEndPoint2 = new System.Net.IPEndPoint(System.Net.IPAddress.Parse("10.1.1.100"), 80);

            var objServerID = new MongoDB.Driver.Core.Servers.ServerId(objClusterId, objEndPoint1);
            var objConnectionID = new ConnectionId(objServerID);

            string strConnectionString = "  ";
            var objConnectionString = new MongoDB.Driver.Core.Configuration.ConnectionString(strConnectionString);


            var currMongoClient = new MongoDB.Driver.MongoClient();





        }



    }
}
