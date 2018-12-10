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
        public string AccountId { get; private set; }
        [BsonElement("AccountNumber")]
        public string AccountNumber { get; private set; }
        [BsonElement("Type")]
        public string Type { get; private set; }
        [BsonElement("Balance")]
        public decimal Balance { get; set; }

        public BusinessAccount(string accountId, string accountNumber, string type, decimal balance)
        {
            AccountId = accountId;
            AccountNumber = accountNumber;
            Type = type;
            Balance = balance;
        }
    }
}
