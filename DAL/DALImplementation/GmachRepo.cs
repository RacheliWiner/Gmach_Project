using DAL.DALApi;
using DAL.DALObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation
{
    public class GmachRepo : IRepository<Gmach>
    {
        GmachContext context;
        public GmachRepo(GmachContext context)
        {
            this.context = context;
        }
        public void Add(Gmach item)
        {
            context.Gmaches.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = context.Gmaches.Find(id);
            context.Gmaches.Remove(entity);
            context.SaveChanges();
        }

        public List<Gmach> GetAll()
        {
            return context.Gmaches.ToList();
        }

        public Gmach GetById(int id)
        {
            return context.Gmaches.Find(id);
        }

        public void Update(int id, Gmach item)
        {
            var entity = context.Gmaches.Find(id);
            context.Gmaches.Remove(entity);
            context.Gmaches.Add(item);
            context.SaveChanges();
        }
    }
}
