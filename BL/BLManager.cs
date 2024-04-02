using BL.BLImplementation;
using BL.BLApi;
using BL.BLObject;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLManager
    {
        public IGmachDetailsForClient gmachDetailsForClient { get; }
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
