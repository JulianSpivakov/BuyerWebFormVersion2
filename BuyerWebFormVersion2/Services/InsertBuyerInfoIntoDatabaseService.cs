using BuyerWebFormVersion2.Data;
using BuyerWebFormVersion2.Models;
using MongoDB.Driver;
using BuyerWebFormVersion2.Services;


namespace BuyerWebFormVersion2.Services
{
    public class InsertBuyerInfoIntoDatabaseService : IInsertBuyerInfoIntoDatabaseService
    {
        public MongoClient _buyer = new("mongodb://127.0.0.1:27017/");

        //пробував використати ApplicationDbContext тут, але мабуть його тут не можна використати в моїй ситуації

        public async Task<BuyerWebForm?> InsertBuyerInfo(BuyerWebForm collection)
        {
            var database = _buyer.GetDatabase("EveryMatrixTest");
            var _collection = database.GetCollection<BuyerWebForm>("Test");
            await _collection.InsertOneAsync(collection);
            return null;
        }
    }
}
