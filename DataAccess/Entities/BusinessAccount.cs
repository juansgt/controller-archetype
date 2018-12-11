using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class BusinessAccount
    {
        [BsonId]
        public ObjectId AccountId { get; private set; }
        [BsonElement("accountNumber")]
        public string AccountNumber { get; private set; }
        [BsonElement("type")]
        public string Type { get; private set; }
        [BsonElement("balance")]
        public decimal Balance { get; set; }

        public BusinessAccount(ObjectId accountId, string accountNumber, string type, decimal balance)
        {
            AccountId = accountId;
            AccountNumber = accountNumber;
            Type = type;
            Balance = balance;
        }
    }
}
