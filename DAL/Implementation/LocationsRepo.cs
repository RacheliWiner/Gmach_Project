using DAL.Api;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public class LocationsRepo: IRepository<Location>
    {
        LibraryContext context;
        public LocationsRepo(LibraryContext context)
        {
            this.context = context;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetAll()
        {
            throw new NotImplementedException();
        }

        public Location GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Location item)
        {
            foreach(Gmach g in context.Gmaches)
            {
                if(g.GmachCode == id)
                {
                    foreach(Location l in context.Locations)
                    {
                        if(l.Zip == g.Zip)
                        {
                            l.City = item.City;
                            l.Neighborhood = item.Neighborhood;
                            l.Street = item.Street;
                            l.HouseNumber = item.HouseNumber;
                            context.SaveChanges();
                            break;
                        }
                    }
                }
            }
        }


        public void Add(Location item)
        {
            throw new NotImplementedException();
        }
    }
}
