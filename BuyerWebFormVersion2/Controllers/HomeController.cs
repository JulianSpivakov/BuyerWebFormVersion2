using BuyerWebFormVersion2.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using BuyerWebFormVersion2.Services;
using BuyerWebFormVersion2.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BuyerWebFormVersion2.Controllers
{
    public class HomeController : Controller
    {        
        private readonly IGetDatabaseInfoService _databaseInfo;
        private readonly IInsertBuyerInfoIntoDatabaseService _insertBuyerInfoIntoDatabase;

        public HomeController(IGetDatabaseInfoService databaseInfo, IInsertBuyerInfoIntoDatabaseService insertBuyerInfoIntoDatabase)
        {
            _databaseInfo = databaseInfo;
            _insertBuyerInfoIntoDatabase = insertBuyerInfoIntoDatabase;
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ShowDatabase()
        {
            return View(_databaseInfo.GetDatabase());
        }

        [HttpPost]
        public async Task<IActionResult> Create(BuyerWebForm collection)
        {
            await _insertBuyerInfoIntoDatabase.InsertBuyerInfo(collection);
            return View();
        }
    }
}
