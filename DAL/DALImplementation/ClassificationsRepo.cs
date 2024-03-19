using DAL.DALApi;
using DAL.DALObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation
{
    public class ClassificationsRepo : IRepository<Classification>
    {
        GmachContext context;
        public ClassificationsRepo(GmachContext context)
        {
            this.context = context;
        }
        public void Add(Classification item)
        {
            context.Classifications.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            context.Classifications.Remove(entity);
            context.SaveChanges();
        }

        public List<Classification> GetAll()
        {
            return context.Classifications.ToList();
        }

        public Classification GetById(int id)
        {
            return context.Classifications.Find(id);
        }

        public void Update(int id, Classification item)
        {
            var entity = GetById(id);
            context.Classifications.Remove(entity);
            context.Classifications.Add(item);
            //context.Classifications.Update(item);
            context.SaveChanges();
        }
    }
}
