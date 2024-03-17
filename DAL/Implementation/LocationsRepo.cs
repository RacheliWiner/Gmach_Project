using DAL.Api;
using DAL.DalObject;


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

                        if (l.GmachCode == g.GmachCode)
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
