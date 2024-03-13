using DAL.Api;
using DAL.DalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public class LocationsRepo : IRepository<Location>
    {
        GmachContext context;
        public LocationsRepo(GmachContext context)
        {
            this.context = context;
        }


        public List<Location> GetAll()
        {
            throw new NotImplementedException();
        }



        public void Update(int id, Location item)
        {
            foreach (Gmach g in context.Gmaches)
            {
                if (g.GmachCode == id)
                {
                    foreach (Location l in context.Locations)
                    {
                        //if (l.Zip == g.Zip)
                        //{
                        //    l.City = item.City;
                        //    l.Neighborhood = item.Neighborhood;
                        //    l.Street = item.Street;
                        //    l.HouseNumber = item.HouseNumber;
                        //    context.SaveChanges();
                        //    break;
                        //}
                    }
                }
            }
        }


        public void Add(Location item)
        {
            throw new NotImplementedException();
        }

        public Location GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
