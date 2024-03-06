using DAL.Api;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation
{
    public class ClassificationsRepo : IRepository<Classification>
    {
        LibraryContext context;
        public ClassificationsRepo(LibraryContext context)
        {
            this.context = context;
        }
        public void Add(Classification item)
        {
            context.Classifications.Add(item);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Classification> GetAll()
        {
            throw null;
        }

        public Classification GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Classification item)
        {
            throw new NotImplementedException();
        }
    }
}
