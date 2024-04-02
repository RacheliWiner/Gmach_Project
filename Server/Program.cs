using DAL.DALObjects;
using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BL.BLApi;
using BL.BLImplementation;
using BL;
using Microsoft.Extensions.Configuration;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL;


var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddScoped<BLManager>();
builder.Services.AddControllers();




DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("GmachDB");
builder.Services.AddServices(connString);
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();



//DBActions actions = new DBActions(builder.Configuration);
//var connString = actions.GetConnectionString("GmachDB");
//builder.Services.AddDbContext<GmachContext>(options => options.UseSqlServer(connString));

var app = builder.Build();

app.MapControllers();
app.Run();
