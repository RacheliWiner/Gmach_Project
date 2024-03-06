using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Api
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(string id);
        void Delete(string id);
        void Update(int id, T item);
        void Add(T item);
    }
}
