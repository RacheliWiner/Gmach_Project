using DAL.Models;
using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("GmachDB");
builder.Services.AddDbContext<LibraryContext>(options => options.UseSqlServer(connString));

var app = builder.Build();

//app.MapControllers();
app.Run();