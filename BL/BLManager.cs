using BL.BLApi;
using BL.BLImplementation;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BL
{
    public class BLManager
    {
        IGmachDetailsForClient gmachDetailsForClient;
        //.....

        public BLManager()
        {
            ServiceCollection services = new();
            services.AddScoped<DALManager>();

            services.AddScoped<IGmachDetailsForClient, GmachDetailsForClientRepo>();
            //.....
            ServiceProvider servicesProvider = services.BuildServiceProvider();

            gmachDetailsForClient = servicesProvider.GetService<IGmachDetailsForClient>();
        }
    }
}
