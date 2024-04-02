using BL.BLApi;
using BL.BLImplementation;
using DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{


    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection collection,string config)
        { 
            collection.AddRepositories(config);

            collection.AddScoped<IGmachDetailsForClient, GmachDetailsForClientRepo>();
           
           /* collection.AddAutoMapper(typeof(PassengerProfile), typeof(FlightProfile),
                typeof(PersonalDetailsProfile), typeof(PassengerWithFlightProfile));*/

            //collection.AddRepositories(config);
           
            return collection;
        }
    }



}
