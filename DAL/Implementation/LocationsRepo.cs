using DAL.Api;
using DAL.DalObject;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> 6b2a5c8a5c2bb381fc040ebe83a6ebe9a6eb057e

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
            return context.Locations.ToList();


        }



        public void Update(int id, Location item)
        {
            foreach (Gmach g in context.Gmaches)
            {
                if (g.GmachCode == id)
                {
                    foreach (Location l in context.Locations)
                    {
<<<<<<< HEAD
                        //if (l.Zip == g.Zip)
                        //{
                        //    l.City = item.City;
                        //    l.Neighborhood = item.Neighborhood;
                        //    l.Street = item.Street;
                        //    l.HouseNumber = item.HouseNumber;
                        //    context.SaveChanges();
                        //    break;
                        //}
=======
                        if (l.GmachCode == g.GmachCode)
                        {
                            l.City = item.City;
                            l.Neighborhood = item.Neighborhood;
                            l.Street = item.Street;
                            l.HouseNumber = item.HouseNumber;
                            context.SaveChanges();
                            break;
                        }
>>>>>>> 6b2a5c8a5c2bb381fc040ebe83a6ebe9a6eb057e
                    }
                }
            }
        }


        public void Add(Location item)
        {
            context.Locations.Add(item);
            context.SaveChanges();
            return;

        }

        public Location GetById(int id)
        {
            return context.Locations.Find(id);
        }

        public void Delete(int id)
        {
            var entity = GetById(id);   
            context.Locations.Remove(entity);
            context.SaveChanges();


        }
    }
}
