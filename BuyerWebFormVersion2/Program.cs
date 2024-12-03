using BuyerWebFormVersion2.Configuration;
using BuyerWebFormVersion2.Data;
using BuyerWebFormVersion2.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var mongoDBSettings = builder.Configuration.GetSection("MongoDbSettings").Get<MongoDbSettings>();
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseMongoDB(mongoDBSettings.AtlasURI ?? "", mongoDBSettings.DatabaseName ?? ""));

builder.Services.AddScoped<GetDatabaseInfoService>();
builder.Services.AddScoped<InsertBuyerInfoIntoDatabaseService>();
builder.Services.AddScoped<IGetDatabaseInfoService, GetDatabaseInfoService>();
builder.Services.AddScoped<IInsertBuyerInfoIntoDatabaseService, InsertBuyerInfoIntoDatabaseService>();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Create}/{id?}");

app.Run();