using DAL;
using DAL.DALApi;
using DAL.DALObjects;
using DAL.DALImplementation;
using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IRepository<Location>, LocationsRepo>();

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("GmachDB");
builder.Services.AddDbContext<GmachContext>(options => options.UseSqlServer(connString));

var app = builder.Build();

app.MapControllers();
app.Run();