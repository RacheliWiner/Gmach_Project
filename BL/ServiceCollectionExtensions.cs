using BL.BLApi;
using BL.BLImplementation;
using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace BL
{


    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection collection, string config)
        {


            collection.AddScoped<IGmachDetailsForClient, GmachDetailsForClientRepo>();
            collection.AddRepositories(config);
            /* collection.AddAutoMapper(typeof(PassengerProfile), typeof(FlightProfile),
                 typeof(PersonalDetailsProfile), typeof(PassengerWithFlightProfile));*/

            //collection.AddRepositories(config);

            return collection;
        }
    }



}
