using BuyerWebFormVersion2.Data;
using BuyerWebFormVersion2.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BuyerWebFormVersion2.Services
{
    public class GetDatabaseInfoService : IGetDatabaseInfoService
    {
        public MongoClient _buyer = new("mongodb://127.0.0.1:27017/");

        //пробував використати ApplicationDbContext тут, але мабуть його тут не можна використати в моїй ситуації

        public List<BuyerWebForm> GetDatabase()
        {
            var database = _buyer.GetDatabase("EveryMatrixTest");
            var collection = database.GetCollection<BuyerWebForm>("Test");
            var collectionData = collection.Find<BuyerWebForm>(x => true).ToList();
            return collectionData;
        }
    }
}