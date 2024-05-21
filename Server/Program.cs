using BL;
using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


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
