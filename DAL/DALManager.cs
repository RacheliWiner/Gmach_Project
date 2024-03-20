using DAL.DALApi;
using DAL.DALImplementation;
using DAL.DALObjects;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALManager
    {
        public ClassificationsRepo classifications { get; }
        public GmachRepo gmach { get; }
        public LocationsRepo locations { get; }
        public OwnerPasswordRepo ownerPassword { get; }
        public ProductsRepo products { get; }

        public DALManager()
        {
            ServiceCollection services = new();
            services.AddDbContext<GmachContext>();

            services.AddScoped<IRepository<Classification>, ClassificationsRepo>();
            services.AddScoped<IRepository<Gmach>, GmachRepo>();
            services.AddScoped<IRepository<Location>, LocationsRepo>();
            services.AddScoped<IRepository<OwnerPassword>, OwnerPasswordRepo>();
            services.AddScoped<IRepository<Product>, ProductsRepo>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            
            classifications = (ClassificationsRepo)serviceProvider.GetRequiredService<ClassificationsRepo>();
            gmach = (GmachRepo)serviceProvider.GetRequiredService<GmachRepo>();
            locations = (LocationsRepo)serviceProvider.GetRequiredService<LocationsRepo>();
            ownerPassword = (OwnerPasswordRepo)serviceProvider.GetRequiredService<OwnerPasswordRepo>();
            products = (ProductsRepo)serviceProvider.GetRequiredService<ProductsRepo>();
        }
    }
}
