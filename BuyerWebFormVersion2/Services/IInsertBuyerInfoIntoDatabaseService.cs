using BuyerWebFormVersion2.Models;

namespace BuyerWebFormVersion2.Services
{
    public interface IInsertBuyerInfoIntoDatabaseService
    {
        Task<BuyerWebForm?> InsertBuyerInfo(BuyerWebForm collection);
    }
}
