using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
        void Update(int id, T item);
        void Add(T item);
    }
}
