using DataAccess.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AccountDao
{
    public class AccountDaoMongoDB : IAccountDao
    {
        public IEnumerable<BusinessAccount> FindAccounts()
        {
            MongoClient mongoClient = new MongoClient("mongodb://172.17.0.2");
            //MongoClient mongoClient = new MongoClient("172.17.0.2:27017");

            IMongoDatabase mongoDatabase = mongoClient.GetDatabase("RecursosAjenos");
            var collection = mongoDatabase.GetCollection<BsonDocument>("Accounts");

            var account = new BsonDocument
            {
                { "AccountNumber", "ES9420805801101234567891" },
                { "Type", "Cuenta clara" },
                { "Balance", "200" }
            };

            collection.InsertOne(account);

            return new List<BusinessAccount>();
        }
    }
}
