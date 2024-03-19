using DAL.DALApi;
using DAL.DALObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation
{
    public class OwnerPasswordRepo : IRepository<OwnerPassword>
    {
        GmachContext context;
        public OwnerPasswordRepo(GmachContext context)
        {
            this.context = context;
        }
        public void Add(OwnerPassword item)
        {
            context.OwnerPasswords.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = context.OwnerPasswords.Find(id);
            context.OwnerPasswords.Remove(entity);
            context.SaveChanges();
        }

        public List<OwnerPassword> GetAll()
        {
            return context.OwnerPasswords.ToList();
        }

        public OwnerPassword GetById(int id)
        {
            return context.OwnerPasswords.Find(id);
        }

        public void Update(int id, OwnerPassword item)
        {
            var entity = context.OwnerPasswords.Find(id);
            context.OwnerPasswords.Remove(entity);
            context.OwnerPasswords.Add(item);
            context.SaveChanges();
        }
    }
}
